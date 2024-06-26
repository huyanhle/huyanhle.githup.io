--tạo DB
Create database PhongGym
go
use PhongGym

--tạo các table

Create table HoiVien(
	id_hv varchar(10),
	hoten nvarchar(50),
	gioitinh nvarchar(3),
	sdt varchar(12),
	ngayhethan date,
	goitap nvarchar(50),
	hinhanh varbinary(max),
	Primary key(id_hv)
)
go

Create table SanPham(
	id_sp varchar(10),
	ten nvarchar(50),
	loai nvarchar(30),
	ngaynhap date,
	soluong int,
	dongia varchar(12),
	trongluong varchar(10),
	hangsx nvarchar(50),
	tinhtrang nvarchar(20),
	hinhanh varbinary(max)
	primary key(id_sp)
)
go

Create table ThietBi(
	id_tb varchar(10),
	ten nvarchar(50),
	loai nvarchar(10),
	soluong int,
	hangsx nvarchar(50),
	tinhtrang nvarchar(20),
	soluonghu int,
	ghichu nvarchar(200),
	hinhanh varbinary(max)
	primary key(id_tb)
)
go

--Them HoiVien
Insert into HoiVien
Select 'KH001',N'Ngô Nhật Trường',N'Nam','0988480691','11/12/2017','VIP',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\nnt.jpg', Single_Blob) as imgHV 
go
Insert into HoiVien
Select 'KH002',N'Trần Tuấn Đạt',N'Nam','0123456789','3/8/2017',N'Thường',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\ttd.jpg', Single_Blob) as imgHV 
go
Insert into HoiVien
Select 'KH003',N'Bà Tưng',N'Nữ','01255556669','3/11/2017',N'VIP',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\batung.jpg', Single_Blob) as imgHV 
go
Insert into HoiVien
Select 'KH004',N'Tú Linh',N'Nữ','0966656669','3/8/2017',N'3 tháng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\tulinh.jpg', Single_Blob) as imgHV 
go

--Them SanPham
Insert into SanPham
Select 'SP001',N'ISO 93 Sensation (Socola)',N'Whey Protein','12/1/2016',35,'1.400.000','2.4Kg',N'Ultimate Nutrition',N'Còn hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\iso93.jpg', Single_Blob) as imgHV 
go
Insert into SanPham
Select 'SP002',N'Best BCAA 30 lần dùng',N'BCAA','2/13/2017',30,'550.000','300g',N'BPI Sports',N'Còn hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\bestbcaa.jpg', Single_Blob) as imgHV 
go
Insert into SanPham
Select 'SP003',N'Bao tay tập Gym',N'Phụ kiện','12/12/2016',20,'30.000','',N'THOL',N'Hết hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\baotay.jpg', Single_Blob) as imgHV 
go
Insert into SanPham
Select 'SP004',N'Serious Mass 12LBS',N'Mass','4/13/2017',35,'1.450.000','5Kg',N'ON Optimum Nutrition',N'Còn hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\seriousmass.jpg', Single_Blob) as imgHV 
go
Insert into SanPham
Select 'SP005',N'Rule 1 Protein (Dâu)',N'Whey Protein','12/1/2016',15,'1.500.000','2.4Kg',N'Rule 1',N'Hết hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\rule1.jpg', Single_Blob) as imgHV 
go
Insert into SanPham
Select 'SP006',N'Đai lưng',N'Phụ kiện','4/18/2017',35,'400.000','',N'THOL',N'Còn hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\dailung.jpg', Single_Blob) as imgHV 
go
Insert into SanPham
Select 'SP007',N'Bình lắc 840ml',N'Phụ kiện','12/1/2016',35,'200.000','',N'EvlutionNutrition',N'Còn hàng',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\binhlac.jpg', Single_Blob) as imgHV 
go


--Them ThietBi
Insert into ThietBi
Select 'TA001',N'Giàn tạ tay 40Kg',N'Tạ',1,N'LBL',N'Mới',0,N'Dàn tạ tay từ 2Kg đến 40Kg',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\giantatay.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'MA001',N'Máy chạy bộ',N'Máy',4,N'LBH Fitness',N'Tốt',0,N'Máy chạy bộ thông minh',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\maychaybo.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'TA002',N'Cặp tạ tay 5Kg',N'Tạ',2,N'THOL',N'Mới',0,N'Tạ tay',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\tatay2kg.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'TA003',N'Cặp tạ tay 2Kg',N'Tạ',4,N'THOL',N'Tốt',0,N'Tạ tay',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\tatay5kg.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'MA002',N'Máy đạp xe',N'Máy',4,N'DHZ',N'Hư',2,N'Máy hỗ trợ Cardio',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\maydapxe.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'TA004',N'Giàn tập đa năng',N'Tạ',1,N'LBH Fitness',N'Mới',0,N'Khung kết hợp xà đơn, kéo lưng, kéo cáp',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\giantadanang.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'TA005',N'Tạ đòn 20Kg',N'Tạ',8,N'THOL',N'Mới',0,N'Tạ đòn',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\tadon.jpg', Single_Blob) as imgHV 
go
Insert into ThietBi
Select 'MA003',N'Máy mát-xa eo hông đùi',N'Máy',2,N'THOL',N'Hư',1,N'Máy mát-xa',BulkColumn from Openrowset(Bulk 'C:\Users\Dat\Desktop\QLPG-IMG\maymatxa.jpg', Single_Blob) as imgHV 
go