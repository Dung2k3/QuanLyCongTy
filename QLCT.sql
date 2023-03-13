﻿CREATE DATABASE QLCT
GO

USE QLCT
GO

CREATE TABLE dbo.MucLuong(
<<<<<<< HEAD
	MaLuong varchar(10) PRIMARY KEY,
=======
	MaLuong nchar(10) PRIMARY KEY,
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
	MucLuong int NOT NULL 
)
GO

INSERT INTO MucLuong VALUES('ML_NV01',10000000)--NhanVienMoi
INSERT INTO MucLuong VALUES('ML_NV02',15000000)--NhanVienVua
INSERT INTO MucLuong VALUES('ML_NV03',20000000)--NhanVienLauNam
INSERT INTO MucLuong VALUES('ML_TP01',50000000)--TruongPhong
INSERT INTO MucLuong VALUES('ML_QL01',40000000)--QuanLy
GO

CREATE TABLE dbo.NhanVien(
<<<<<<< HEAD
	MaNV varchar(10) PRIMARY KEY,
	HoTenNV nvarchar(50),
	DiaChi nvarchar(50) NULL,
	Sdt varchar(12) UNIQUE,	
	NgaySinh date,
	Phai nvarchar(10),
	Cccd varchar(20) UNIQUE,
	Email varchar(25) UNIQUE,
	MaPB varchar(10) NULL,
	MaLuong varchar(10) REFERENCES MucLuong(MaLuong)
=======
	MaNV nchar(10) PRIMARY KEY,
	HoTenNV nchar(50),
	DiaChi nchar(50) NULL,
	Sdt nchar(12) UNIQUE,	
	NgaySinh date,
	Phai nchar(10),
	Cccd nchar(20) UNIQUE,
	Email nchar(25) UNIQUE,
	MaPB nchar(10) NULL,
	MaLuong nchar(10) REFERENCES MucLuong(MaLuong)
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
)
GO

INSERT INTO NhanVien 
VALUES('NV001', N'Trần Minh Dương', 'HCM', '0967675782', '1988-01-01', 'Nam', '092203232432', 'LTD@gmail.com', 'PB_QL', 'ML_TP01')
INSERT INTO NhanVien 
VALUES('NV002', N'Nguyen Thanh Tùng', 'HCM', '0966696084', '1989-02-02', 'Nam', '095121551722', 'NTT@gmail.com', 'PB_QL', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV003', N'Lê Minh Hùng', 'HCM', '0986810782', '1988-03-03', 'Nam', '093501761895', 'LMH@gmail.com', 'PB_QL', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV004', N'Phạm Hoài Sơn', 'HCM', '0923232323', '1989-04-04', 'Nam', '098968366861', 'PHS@gmail.com', 'PB_SX', 'ML_QL01')
INSERT INTO NhanVien 
<<<<<<< HEAD
VALUES('NV005', N'Trần Phương Đài', 'HCM', '0986865482', '1988-05-05', N'Nữ', '098353536799', 'TPD@gmail.com', 'PB_SX', 'ML_QL01')
=======
VALUES('NV005', N'Trần Phương Đài', 'HCM', '0986810782', '1988-05-05', N'Nữ', '098353536799', 'TPD@gmail.com', 'PB_SX', 'ML_QL01')
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
INSERT INTO NhanVien 
VALUES('NV006', N'Đỗ Đăng Khoa', 'HCM', '0929192796', '1989-06-06', 'Nam', '090107287746', 'DDK@gmail.com', 'PB_SX', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV007', N'Đinh Mạnh Ninh', 'HCM', '0917934709', '1988-01-01', 'Nam', '091408184282', 'DMN@gmail.com', 'PB_SX', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV008', N'Hà Minh Khôi', 'HCM', '0989886825', '1980-04-11', 'Nam', '094617396327', 'HMK@gmail.com', 'PB_SX', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV009', N'Chu Tiểu My', 'HCM', '0986539548', '1988-05-22', N'Nữ', '093461146718', 'CTM@gmail.com', 'PB_MK', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV010', N'Phan Diễm My', 'HCM', '0917449142', '1985-12-01', N'Nữ', '092631050324', 'PNM@gmail.com', 'PB_MK', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV011', N'Hồ Hoài Anh', 'HCM', '0913632520', '1982-11-21', 'Nam', '093223966609', 'HHA@gmail.com', 'PB_MK', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV012', N'Đỗ Hồng Đăng', 'HCM', '0929192790', '1989-06-06', 'Nam', '090107287743', 'DHD@gmail.com', 'PB_HC', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV013', N'Đinh Mạnh Quỳnh', 'HCM', '0917934700', '1988-01-01', 'Nam', '091408184283', 'DMQ@gmail.com', 'PB_HC', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV014', N'Nguyễn Quang Huy', 'HCM', '0989886820', '1980-04-11', 'Nam', '094617396323', 'NQH@gmail.com', 'PB_HC', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV015', N'Chu Hà My', 'HCM', '0986539540', '1988-05-22', N'Nữ', '093461146713', 'CHN@gmail.com', 'PB_TK', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV016', N'Phan Diễm Quỳnh', 'HCM', '0917449140', '1985-12-01', N'Nữ', '092631050323', 'PDQ@gmail.com', 'PB_TK', 'ML_QL01')
INSERT INTO NhanVien 
VALUES('NV017', N'Hồ Ngọc Hà', 'HCM', '0913632527', '1982-11-21', 'Nam', '093223966603', 'HNH@gmail.com', 'PB_TK', 'ML_QL01')
GO

CREATE TABLE dbo.PhongBan(
<<<<<<< HEAD
	MaPB varchar(10) PRIMARY KEY,
	TenPB nvarchar(30),
	MaTrPhong varchar(10) REFERENCES NhanVien(MaNV),
	ViTri nvarchar(40) NULL,
=======
	MaPB nchar(10) PRIMARY KEY,
	TenPB nchar(30),
	MaTrPhong nchar(10) REFERENCES NhanVien(MaNV),
	ViTri nchar(40) NULL,
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
)
GO

INSERT INTO PhongBan VALUES('PB_QL', N'Phòng Quản Lý','NV001','A5_201')
INSERT INTO PhongBan VALUES('PB_SX', N'Phòng Sản Xuất','NV004','A5_202')
INSERT INTO PhongBan VALUES('PB_MK', N'Phòng Marketing','NV009','A5_102')
INSERT INTO PhongBan VALUES('PB_HC', N'Phòng Hành Chính','NV012','A5_302')
INSERT INTO PhongBan VALUES('PB_TK', N'Phòng Thiết Kế','NV015','A5_402')
GO

ALTER TABLE NhanVien WITH CHECK ADD FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB)

CREATE TABLE dbo.TaiKhoan(
<<<<<<< HEAD
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	TK varchar(30),
	MK varchar(30),
=======
	MaNV nchar(10) REFERENCES NhanVien(MaNV),
	TK nchar(30),
	MK nchar(30),
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
	PRIMARY KEY(MaNV)
)
GO

INSERT INTO TaiKhoan VALUES('NV001','tmd','tmd123')
INSERT INTO TaiKhoan VALUES('NV002','ntt','ntt123')
INSERT INTO TaiKhoan VALUES('NV003','lmh','ntt123')
INSERT INTO TaiKhoan VALUES('NV004','phs','phs123')
INSERT INTO TaiKhoan VALUES('NV005','tpd','tpd123')
INSERT INTO TaiKhoan VALUES('NV006','ddk','ddk123')
INSERT INTO TaiKhoan VALUES('NV007','dmn','dmn123')
INSERT INTO TaiKhoan VALUES('NV008','hmk','hmk123')
INSERT INTO TaiKhoan VALUES('NV009','ctm','ctm123')
INSERT INTO TaiKhoan VALUES('NV010','pdm','pdm123')
INSERT INTO TaiKhoan VALUES('NV011','hha','hha123')
INSERT INTO TaiKhoan VALUES('NV012','dhd','dhd123')
INSERT INTO TaiKhoan VALUES('NV013','dmq','dmq123')
INSERT INTO TaiKhoan VALUES('NV014','nqh','nqh123')
INSERT INTO TaiKhoan VALUES('NV015','chn','chn123')
INSERT INTO TaiKhoan VALUES('NV016','pdq','pdq123')
INSERT INTO TaiKhoan VALUES('NV017','hnh','hnh123')
GO

CREATE TABLE dbo.Checkin(
<<<<<<< HEAD
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
=======
	MaNV nchar(10) REFERENCES NhanVien(MaNV),
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
	TGCheckin datetime,
	PRIMARY KEY(MaNV,TGCheckin)
)
GO

INSERT INTO Checkin VALUES('NV001','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV002','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV003','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV004','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV005','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV006','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV007','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV008','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV009','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV010','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV011','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV012','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV013','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV014','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV015','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV016','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV017','2023-03-01T07:50:00')
INSERT INTO Checkin VALUES('NV001','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV002','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV003','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV004','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV005','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV006','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV007','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV008','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV009','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV010','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV011','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV012','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV013','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV014','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV015','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV016','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV017','2023-03-02T07:50:00')
INSERT INTO Checkin VALUES('NV001','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV002','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV003','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV004','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV005','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV006','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV007','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV008','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV009','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV010','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV011','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV012','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV013','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV014','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV015','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV016','2023-03-03T07:50:00')
INSERT INTO Checkin VALUES('NV017','2023-03-03T07:50:00')
GO

CREATE TABLE dbo.Checkout(
<<<<<<< HEAD
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	TGCheckout datetime,
	PRIMARY KEY(MaNV,TGCheckout)
=======
	MaNV nchar(10) REFERENCES NhanVien(MaNV),
	TGCheckin datetime,
	PRIMARY KEY(MaNV,TGCheckin)
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
)
GO
INSERT INTO Checkout VALUES('NV001','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV002','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV003','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV004','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV005','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV006','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV007','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV008','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV009','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV010','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV011','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV012','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV013','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV014','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV015','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV016','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV017','2023-03-01T17:10:00')
INSERT INTO Checkout VALUES('NV001','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV002','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV003','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV004','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV005','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV006','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV007','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV008','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV009','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV010','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV011','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV012','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV013','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV014','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV015','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV016','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV017','2023-03-02T17:10:00')
INSERT INTO Checkout VALUES('NV001','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV002','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV003','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV004','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV005','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV006','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV007','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV008','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV009','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV010','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV011','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV012','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV013','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV014','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV015','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV016','2023-03-03T17:10:00')
INSERT INTO Checkout VALUES('NV017','2023-03-03T17:10:00')
GO

CREATE TABLE dbo.XinNghi(
<<<<<<< HEAD
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
=======
	MaNV nchar(10) REFERENCES NhanVien(MaNV),
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
	NgayNghi date,
	NgayDiLam date,
	PRIMARY KEY(MaNV,NgayNghi)
)
GO

CREATE TABLE dbo.DuAn(
<<<<<<< HEAD
	MaDA varchar(10) PRIMARY KEY,
	TenDuAn nvarchar(50),
	MoTa nvarchar(200) NULL,
	MaPB varchar(10) REFERENCES PhongBan(MaPB),
	DiaDiem nvarchar(40) NULL,
	DeadLine date,
	DanhGia nvarchar(200) NULL,
=======
	MaDA nchar(10) PRIMARY KEY,
	TenDuAn nchar(50),
	MoTa nchar(200) NULL,
	MaPB nchar(10) REFERENCES PhongBan(MaPB),
	DiaDiem nchar(40) NULL,
	DeadLine date,
	DanhGia nchar(200) NULL,
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
	Thuong bigint NULL
)
GO

INSERT INTO DuAn
VALUES('DA001',N'Thiết kế nhãn nước trái cây', N'Làm nổi bật vị của nước ngọt'+ CHAR(13)+CHAR(10)+ N'Màu sắc dễ chú ý','PB_TK', N'Công ty', '2000-02-02',N'Hoàn Thành Tốt',10000000)
INSERT INTO DuAn
VALUES('DA002',N'Đăng ký bản quyền nước trái cây', N'Có chữ ký của Ủy bản kiểm định chất lượng sản phẩm ','PB_HC', N'Công ty', '2000-03-02',N'Trễ Hạn 1 tháng ',0)
INSERT INTO DuAn
VALUES('DA003',N'Thiết kết và thi công dây chuyền SX nước trái cây', N'Kinh phí dưới 10 tỷ'+ CHAR(13)+CHAR(10)+ N'Đáp ứng 10000 chai 1 ngày','PB_SX', N'Nhà máy số 1', '2000-08-02',N'Hoàn Thành',100000000)
INSERT INTO DuAn
VALUES('DA004',N'Làm video quảng cáo nước trái cây', N'Video đăng trên titok'+ CHAR(13)+CHAR(10)+ N'Thuê tiktoker','PB_MK', N'Công ty', '2000-08-02',N'Hoàn Thành Tốt',10000000)
INSERT INTO DuAn
VALUES('DA005',N'Chỉnh sửa logo công ty', N'Bo góc logo cũ','PB_TK', N'Công Ty', '2023-02-02',N'Hoàn Thành Tốt',10000000)
INSERT INTO DuAn
VALUES('DA006',N'Quảng bá logo mới', N'Công khai số tiền thiết kế logo là 7 tỷ','PB_MK', N'Công ty', '2023-05-03',N'Đang Thực Hiện',0)
GO


CREATE TABLE dbo.PhanCong(
<<<<<<< HEAD
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	MaDA varchar(10) REFERENCES DuAn(MaDA),
	CongViec nvarchar(200),
	DeadLine date,
	NhanXet nvarchar(50) NULL,
=======
	MaNV nchar(10) REFERENCES NhanVien(MaNV),
	MaDA nchar(10) REFERENCES DuAn(MaDA),
	CongViec nchar(100),
	DeadLine date,
	NhanXet nchar(50) NULL,
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
	ChamCong int NULL,
	PRIMARY KEY(MaNV,MaDA)
)
GO

INSERT INTO PhanCong
VALUES('NV016','DA001',N'Thiết kế nhãn trên lon nước','2000-01-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV017','DA001',N'Thiết kế nhãn thùng đựng lon','2000-01-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV013','DA002',N'Làm đơn Xin Đăng Ký Bản Quyền','2000-02-02', N'Trễ Hạn 2 Ngày', 40)
INSERT INTO PhanCong
VALUES('NV014','DA002',N'Liên hệ và nộp đơn cho cơ quản kiểm định','2000-02-10', N'Trễ Hạn 1 tháng', 0)
INSERT INTO PhanCong
VALUES('NV005','DA003',N'Lập bảng thiết kế','2000-03-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV006','DA003',N'Chuẩn bị vật tư','2000-04-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV007','DA003',N'Liên hệ công ty thi công','2000-04-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV008','DA003',N'Giám sát quá trình thi công','2000-07-02', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV010','DA004',N'Liên hệ tiktoker','2000-05-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV011','DA004',N'Chuẩn bị content','2000-05-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV016','DA005',N'Thiết kế logo','2023-01-20', N'Hoàn Thành Tốt', 100)
INSERT INTO PhanCong
VALUES('NV010','DA006',N'Liên hệ các nhà báo','2000-04-20', N'Đang Thực Hiện', 0)
INSERT INTO PhanCong
VALUES('NV011','DA006',N'Đăng bài về logo','2000-04-20', N'Đang Thực Hiện', 0)
GO
<<<<<<< HEAD
=======

SELECT * FROM MucLuong
SELECT * FROM NhanVien
SELECT * FROM PhongBan
SELECT * FROM P
SELECT * FROM PhanCong
SELECT * FROM PhanCong
>>>>>>> e3b538af5aee5705690946a1ada08ab0db7758a7
