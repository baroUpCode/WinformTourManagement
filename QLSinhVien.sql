USE master
GO
IF EXISTS (SELECT NAME FROM SYS.DATABASES WHERE NAME='QLSINHVIEN')
	DROP DATABASE QLSINHVIEN
GO	

CREATE DATABASE qlSinhvien
go
USE [qlSinhvien]
GO
CREATE TABLE Monhoc
(	
	Mamh char(20) NOT NULL,
	Tenmh nvarchar(100) NOT NULL,
	Sotc tinyint,
PRIMARY KEY (Mamh)
)
GO
INSERT Monhoc VALUES (N'CSDL', N'Cơ sở dữ liệu',4)
INSERT Monhoc VALUES (N'GDQP', N'Giáo dục quốc phòng',4)
INSERT Monhoc VALUES (N'LTRC', N'Lập trình C',5)
INSERT Monhoc VALUES (N'TDTC', N'Thể dục thể chất',3)
INSERT Monhoc VALUES (N'THCB', N'Tin học căn bản',3)
INSERT Monhoc VALUES (N'TRIE', N'Triết học', 5)
GO
CREATE TABLE Khoa
(
	Makhoa char(10) NOT NULL,
	Tenkhoa nvarchar(50) NOT NULL,
PRIMARY KEY (Makhoa)
)
GO
INSERT Khoa VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT Khoa VALUES (N'KSDL', N'Khách sạn du lịch')
INSERT Khoa VALUES (N'QTKD', N'Quản trị kinh doanh')
INSERT Khoa VALUES (N'TCNH', N'Tài chính ngân hàng')
GO
CREATE TABLE Sinhvien
(
	Masv char(10) NOT NULL,
	Hoten nvarchar(100) NOT NULL,
	Gioitinh Bit NOT NULL,
	Ngaysinh datetime  NULL,
	Noisinh nvarchar(50) NOT NULL,
	Makhoa char(10) NOT NULL,
	Hinh varchar(100) NULL,
PRIMARY KEY (Masv)
)
GO
set dateformat dmy
go
INSERT Sinhvien VALUES ('10001',N'Nguyễn Hồng Ân',N'False','15/01/1996',N'HCM', N'KSDL','10001img.jpg')
INSERT Sinhvien VALUES ('10002',N'Ngô Văn Tuấn',N'True','08/05/1997', N'Cà Mau', N'CNTT','10002img.jpg')
INSERT Sinhvien VALUES ('11001',N'Trần Thị Xuân Yến', N'False','27/02/1996',N'Cần Thơ', N'KSDL','11001img.jpg')
INSERT Sinhvien VALUES ('11002',N'Cao Văn Toàn', N'True', '27/02/1996',N'Đồng Nai', N'CNTT','11002img.jpg' )
INSERT Sinhvien VALUES ('11003',N'Dương Tuấn Kiệt', N'True','12/12/1996', N'Vũng Tàu', N'TCNH', '11003img.jpg')
INSERT Sinhvien VALUES ('12001',N'Nguyễn Thị Diễm', N'False','10/08/1996', N'HCM', N'TCNH','12001img.jpg')
INSERT Sinhvien VALUES ('12002',N'Nguyễn Bá Khải', N'True','25/09/1996', N'Vĩnh Long', N'QTKD','12002img.jpg')
INSERT Sinhvien VALUES ('12003',N'Trần Bích Thủy', N'False','27/02/1996',N'HCM', N'QTKD','12003img.jpg')
INSERT Sinhvien VALUES ('12004',N'Đào Thế Hùng', N'True','01/01/1995', N'Cần Thơ', N'CNTT','12004img.jpg')
GO
CREATE TABLE Ketqua
(
	Masv char(10) NOT NULL,
	Mamh char(10) NOT NULL,
	Diemthi [float] NOT NULL,
PRIMARY KEY (Masv,Mamh)
)
GO
INSERT Ketqua VALUES ('10001',N'TDTC', 7)
INSERT Ketqua VALUES ('10001',N'THCB', 8.5)
INSERT Ketqua VALUES ('11001',N'GDQP',6.5)
INSERT Ketqua VALUES ('11001',N'TRIE',4)
INSERT Ketqua VALUES ('11002',N'CSDL',5.5)
INSERT Ketqua VALUES ('11002',N'LTRC',3)
INSERT Ketqua VALUES ('12001',N'GDQP',7.5)
INSERT Ketqua VALUES ('12001',N'TDTC',2.5)
INSERT Ketqua VALUES ('12002',N'GDQP',9)
INSERT Ketqua VALUES ('12002',N'TRIE',3.5)
INSERT Ketqua VALUES ('12003',N'TDTC',10)
INSERT Ketqua VALUES ('12003',N'TRIE',6)
INSERT Ketqua VALUES ('12004',N'CSDL',9.5)
INSERT Ketqua VALUES ('12004',N'LTRC',7.5)
INSERT Ketqua VALUES ('12004',N'TRIE',4.5)
