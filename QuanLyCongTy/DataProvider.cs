using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    internal class DataProvider
    {
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if(parameter != null)
                {
                    string[] words = query.Split(' ');
                    List<string> listpara = new List<string>();
                    foreach(string word in words) 
                    {
                        if (word.Length > 0 && word[0] == '@')
                            listpara.Add(word);
                    }
                    for (int i = 0; i < listpara.Count; i++)
                        cmd.Parameters.AddWithValue(listpara[i], parameter[i]);
                }
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception){}
                conn.Close();
            }
            return dt;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int accpectedRows = 0;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] words = query.Split(' ');
                    List<string> listpara = new List<string>();
                    foreach (string word in words)
                    {
                        if (word.Length > 0 && word[0] == '@')
                            listpara.Add(word);
                    }
                    for (int i = 0; i < listpara.Count; i++)
                        cmd.Parameters.AddWithValue(listpara[i], parameter[i]);
                }
                try
                {
                    accpectedRows = cmd.ExecuteNonQuery();
                }
                catch (Exception){}
                conn.Close();
            }
            return accpectedRows;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object first = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] words = query.Split(' ');
                    List<string> listpara = new List<string>();
                    foreach (string word in words)
                    {
                        if (word.Length > 0 && word[0] == '@')
                            listpara.Add(word);
                    }
                    for (int i = 0; i < listpara.Count; i++)
                        cmd.Parameters.AddWithValue(listpara[i], parameter[i]);
                }
                try
                {
                    first = cmd.ExecuteScalar();
                }
                catch (Exception){}
                conn.Close();
            }
            return first;
        }


    }
}
