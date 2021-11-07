SET DATEFORMAT DMY
USE MASTER
GO 
IF EXISTS (SELECT*FROM SYSDATABASES WHERE NAME = 'QL_MYPHAM')
BEGIN 
	DROP DATABASE QL_MYPHAM
END 
GO 
CREATE DATABASE QL_MYPHAM
GO 
USE QL_MYPHAM
GO
CREATE TABLE CHU_DE(
	MACD	CHAR(20) NOT NULL,
	TENCD	NVARCHAR(20) NOT NULL,
CONSTRAINT PK_CHUDE PRIMARY KEY (MACD)
)
CREATE TABLE KHACHHANG
(
	MAKH	CHAR(20)		NOT NULL,
	TENKH	NVARCHAR(50)	NOT NULL,
	DIACHI	NVARCHAR(50)	NULL,
	DIENTHOAI VARCHAR(20)	NULL,
	NGAYSINH	varchar(50)	NULL,
	GIOITINH	NVARCHAR(50)		NULL,
	EMAIL		VARCHAR(50) NULL,
	TAIKHOAN	VARCHAR(50)	NOT NULL,
	MATKHAU		varchar(100) not null
CONSTRAINT	PK_KHACHHANG	PRIMARY KEY (MAKH),


)
CREATE TABLE NHASANXUAT(
	MANSX	CHAR(20)		NOT NULL,
	DIACHI	NVARCHAR(500)	NULL,
	DIENTHOAI VARCHAR(20)	NULL,
CONSTRAINT	PK_NHASANXUAT	PRIMARY KEY (MANSX)
)
CREATE TABLE SANPHAM(
	MASP	CHAR(20)			NOT NULL,
	TENSP	NVARCHAR(50)		NOT NULL,
	DONGIA	MONEY					NULL,
	DONVITINH	NVARCHAR(50)		NULL,
	MOTA	NVARCHAR(200)			NULL,
	HINHMINHOA	char(10)			NULL,
	MACD	CHAR(20)				NULL,
	MANSX	CHAR(20)				NULL,
	NGAYCAPNHAT varchar(50)			NULL,
	SOLUONGBAN	CHAR(20)			NULL,
	CONSTRAINT PK_MON PRIMARY KEY(MASP),
	CONSTRAINT FK_MON_CHUDE FOREIGN KEY(MACD) REFERENCES CHU_DE(MACD),
	CONSTRAINT FK_MON_NHASANXUAT FOREIGN KEY (MANSX) REFERENCES NHASANXUAT(MANSX)
)
CREATE TABLE DONDATHANG(
	SDH			CHAR(20)	NOT NULL,
	MAKH		CHAR(20)	NULL,
	NGAYDATHANG	DATETIME	NOT NULL,
	TRIGIA		MONEY		NULL,
	DAGIAOHANG	NVARCHAR(50)		NOT NULL,
	NGAYGIAOHANG	DATETIME	NULL,
	MASP			CHAR(20)	NOT NULL,
CONSTRAINT PK_DONDATHANG PRIMARY KEY (SDH),
CONSTRAINT FK_DONHANG_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
CONSTRAINT FK_DONHANG_SANPHAM FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
)
CREATE TABLE CTDONHANG(
	MACTDH	CHAR(20)	NOT NULL,
	SDH		CHAR(20)	NOT NULL,
	MS		CHAR(20)	NULL,
	SOLUONG	INT			NULL,
	DONGIA	MONEY		NULL,
	THANHTIEN	MONEY	NULL,
CONSTRAINT PK_CTDONHANG PRIMARY KEY (MACTDH, SDH),
CONSTRAINT FK_CTDONHANG_DONDATHANG FOREIGN KEY(SDH) REFERENCES DONDATHANG(SDH)
)



insert into CHU_DE(MACD,TENCD) values ('M01',N'Sữa Rửa Mặt')
insert into CHU_DE(MACD,TENCD) values ('M02',N'Toner Nước Hoa Hồng')
insert into CHU_DE(MACD,TENCD) values ('M03',N'Dưỡng Ẩm')
insert into CHU_DE(MACD,TENCD) values ('M04',N'Serum Tinh Dưỡng')
insert into CHU_DE(MACD,TENCD) values ('M05',N'Dưỡng Trắng')
insert into CHU_DE(MACD,TENCD) values ('M06',N'Chống Lão Hóa')
insert into CHU_DE(MACD,TENCD) values ('M07',N'Chăm Sóc Vùng Da Mắt')
insert into CHU_DE(MACD,TENCD) values ('M08',N'Trị Mụn')
insert into CHU_DE(MACD,TENCD) values ('M09',N'Lotion Dưỡng Ẩm')
insert into CHU_DE(MACD,TENCD) values ('M10',N'Tinh Chất Dưỡng')
insert into CHU_DE(MACD,TENCD) values ('M11',N'Dưỡng Trắng')
insert into CHU_DE(MACD,TENCD) values ('M12',N'Chống Lão Hóa')
insert into CHU_DE(MACD,TENCD) values ('M13',N'Chăm Sóc Da Mặt')
insert into CHU_DE(MACD,TENCD) values ('M14',N'Mặt Nạ Dưỡng Da')
insert into CHU_DE(MACD,TENCD) values ('M15',N'Chống Nắng Bảo Vệ Da')


insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX01',N'35 Quách Văn Tuấn, P.12, Q.Tân Bình.','0939 386068 ')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX02',N'285/26 Cách mạng tháng 8, Phường 12, Q.10, TPHCM – 97C, Lê Quang Định, Phường 14, Q.Bình Thạnh, TPHCM.','090.990.4560')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX03',N'111B Nguyễn Lâm, Phường 3, Q. Bình Thạnh. TP. HCM','19007101')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX04',N'335/1 Điện Biên Phủ, P. 4, Q.3,TP.HCM – 179 Cộng Hòa, P.13, Q.Tân Bình, TP.HCM.','08 7109 9333')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX05',N'208 Nguyễn Hữu Cảnh, Vinhomes Central Park, Phường 22, Quận Bình Thạnh, TP. Hồ Chí Minh.','028 6660 8100')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX06',N'802, Sư Vạn Hạnh , P.12, Q.10, TP.HCM – 24 Đường D2, P25, Quận Bình Thạnh , TPHCM – 45 Truông Tre (TTHC Dĩ An), TX. Dĩ An, Bình Dương.','0989.753.623')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX07',N'385/68 Đường Quang Trung, Phường 10, Gò Vấp','0906 278 197')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX08',N'3Số 39/29 Đường Khương Hạ, Phường Khương Đình – Thanh Xuân – Hà Nội .','098.165.9986')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX09',N'3Shophouse B5-22, Lily 3, KĐT Vinhome Mỹ Đình, Hàm Nghi, Nam Từ Liêm, Hà Nội.',' 0168.7641.999')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX10','35 ,P.12, Q.Tân Bình.','0939 38699 ')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX11','285/26 Q.Bình Thạnh, TPHCM.','0936 3865568 ')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX12','Phường 5, Q. Bình Thạnh. TP. HCM.','0939 25564 ')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX13','Q.10,TP.HCM – 179 Cộng Hòa, P.13, Q.Tân Bình, TP.HCM.','0355148521 ')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX14','63 Quách Văn Tuấn, P.11,TP.HCM.','02241111054 ')
insert into NHASANXUAT(MANSX,DIACHI,DIENTHOAI) values('NSX15','Phường 10, Quận Bình Tân, TP. Hồ Chí Minh.','0925122002')


insert into SANPHAM(MASP,TENSP,DONGIA,DONVITINH,MOTA,HINHMINHOA,MACD,MANSX,NGAYCAPNHAT,SOLUONGBAN) VALUES('MSP01',N'Sữa Rửa Mặt Paulas Choice Skin Balancing','429.000',N'VNĐ',N'Cân Bằng Độ Ẩm Và Giảm Dầu','','M01','NSX01','19-02-19','20')
insert into SANPHAM(MASP,TENSP,DONGIA,DONVITINH,MOTA,HINHMINHOA,MACD,MANSX,NGAYCAPNHAT,SOLUONGBAN) VALUES('MSP02',N'Nước Hoa Hồng Nacific','497.000',N'VNĐ',N'Làm Dịu Da Nhạy Cảm ','','M02','NSX02','16-02-19','20')
insert into SANPHAM(MASP,TENSP,DONGIA,DONVITINH,MOTA,HINHMINHOA,MACD,MANSX,NGAYCAPNHAT,SOLUONGBAN) VALUES('MSP03',N'Gel Dưỡng Ẩm Paulas Choice Skin Balancing ','680.000',N'VNĐ',N'ho Da Mềm Mịn Ban Đêm ','','M03','NSX03','12-02-19','10')
insert into SANPHAM(MASP,TENSP,DONGIA,DONVITINH,MOTA,HINHMINHOA,MACD,MANSX,NGAYCAPNHAT,SOLUONGBAN) VALUES('MSP04',N'Tinh Chất Paulas Choice  ','1432000',N'VNĐ',N'Đặc Trị Se Khít Lỗ Chân Lông Và Làm Sáng Da','','M04','NSX04','10-02-19','8')


insert into KHACHHANG(MAKH,TENKH,DIACHI,DIENTHOAI,NGAYSINH,GIOITINH,EMAIL,TAIKHOAN,MATKHAU) values('MKH01','NguyenLeHai','APD - Vườn Lài - TPHCM','0335351217','2000-02-08','Nam','lehainguyen0802@gmail.com','user','user')

select * from KHACHHANG
select * from CHU_DE
select * from CTDONHANG
select * from SANPHAM
select * from NHASANXUAT

SELECT MASP, TENSP, DONGIA, DONVITINH, MOTA, TENCD FROM SANPHAM INNER JOIN CHU_DE ON SANPHAM.MACD = CHU_DE.MACD 
Delete from SANPHAM where MASP = 'MSP01'

Update SANPHAM set TENSP = N'n', DONGIA = '1', DONVITINH = N'sd', MOTA = N's}', MACD = N'M01' where MASP ='MSP01'

Update SANPHAM set TENSP = N'{0}', DONGIA = '{1}', DONVITINH = N'{2}', MOTA = N'{3}', MACD = N'{4}' where MASP ='{5}' ", tensp, dongia, donvitinh, mota, macd, masp
Insert into SANPHAM values(" + "'" + masp + "'", "N'" + tensp + "'", "N'" + dongia + "'", "N'" + donvitinh + "'", "'" + mota + "'", "N'" + tencd + "'"
