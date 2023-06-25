
Create table TKGiamDoc(
	maGD char(50) references NhanVien(MaNV),
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL,
)
INSERT Into TKGiamDoc Values('NV000', 'mtan', '123')
Select * from TkGiamDoc
CREATE TABLE TKNhanVien(
	maNVTK char(50) references NhanVien(MaNV),
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL,
)

Select * from TKNhanVien
INSERT INTO TkNhanVien Values('NV001', 'dlong', '123')
INSERT INTO TkNhanVien Values('NV002', 'dloc', '123')
INSERT INTO TkNhanVien Values('NV003', 'cminh', '123')
INSERT INTO TkNhanVien Values('NV004',  'vanb', '123')

INSERT INTO TkNhanVien Values('NV005', 'ttam', '123')
INSERT INTO TkNhanVien Values('NV006', 'hlinh', '123')
INSERT INTO TkNhanVien Values('NV007', 'ttuan', '123')
INSERT INTO TkNhanVien Values('NV008',  'tbac', '123')
INSERT INTO TkNhanVien Values('NV009',  'tthanh', '123')
INSERT INTO TkNhanVien Values('NV010',  'thoa', '123')
INSERT INTO TkNhanVien Values('NV011', 'tchinh', '123')
INSERT INTO TkNhanVien Values('NV012', 'dphi', '123')

INSERT INTO TkNhanVien Values('NV013', 'mtan1', '123')
INSERT INTO TkNhanVien Values('NV014', 'mtan2', '123')
INSERT INTO TkNhanVien Values('NV015', 'mtan3', '123')
INSERT INTO TkNhanVien Values('NV016', 'hson1', '123')
INSERT INTO TkNhanVien Values('NV017', 'xmai', '123')
INSERT INTO TkNhanVien Values('NV018', 'dtrung', '123')
INSERT INTO TkNhanVien Values('NV019', 'dmanh', '123')
select * from TKNhanVien order by maTP
SELECT Username FROM TkNhanVien WHERE Username = 'mtan1' AND Pass_word = '123'

/*
CREATE TABLE TKNhanVien(
	MaNV char(50) references NhanVien(MaNV),
	hoVaTen nchar(50) NOT NULL,
	viTri nchar(50) NOT NULL,
	MaPB char(50) references PhongBan(MaPB),
	SDT nchar(20) NOT NULL,
	Email nchar(50) NOT NULL,
	MaNguoiTao char(50) references NhanVien(MaNV),
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL,
)
select * from TKNhanVien order by maNV

Insert into TKNhanVien values('NV001', N'Bùi Đức Long', 'CV005', 'PB002', '0777981051', 'buiduclong@gmail.com', 'NV006', 'dlong', 123)
Insert into TKNhanVien values('NV002', N'Vũ Đức Lộc', 'CV007', 'PB002', '0949484333', 'vuducloc@gmail.com', 'NV006', 'dloc', 123)
Insert into TKNhanVien values('NV003', N'Trần Công Minh', 'CV015', 'PB004', '0923532224', 'trancongminh@gmail.com', 'NV008', 'cminh', 123)
Insert into TKNhanVien values('NV004', N'Hoàng Văn B', 'CV019', 'PB006', '0843434445', 'hoangvanb@gmail.com', 'NV010', 'vanb', 123)
*/
CREATE TABLE PHONGBAN(
	MAPB char(50) PRIMARY KEY,
	TENPB nchar(50) NOT NULL,
	DIACHI nchar(50) NOT NULL,
	SODIENTHOAI char(50) NOT NULL,
	TruongPhong char(50) references NhanVien(MaNV),

)


INSERT INTO PHONGBAN VALUES('PB001', N'Kế Toán', N'TPHCM', N'0777981051')
INSERT INTO PHONGBAN VALUES('PB002', N'Công Nghệ Thông Tin', N'TPHCM', N'0984035555')
INSERT INTO PHONGBAN VALUES('PB003', N'Nhân Sự', N'TPHCM', N'0394443325')
INSERT INTO PHONGBAN VALUES('PB004', N'Chăm sóc khách hàng', N'TPHCM', N'0932741143')
INSERT INTO PHONGBAN VALUES('PB005', N'Hành Chính', N'TPHCM', N'074388555')
INSERT INTO PHONGBAN VALUES('PB006', N'Kinh Doanh', N'TPHCM', N'0394443325')
INSERT INTO PHONGBAN VALUES('PB007', N'Kiểm toán', N'TPHCM', N'0327485858')
INSERT INTO PHONGBAN VALUES('PB008', N'Cố vấn', N'TPHCM', N'0948933556')
INSERT INTo PHONGBAN VALUES('PB000', N'Giám Đốc', N'TPHCM', N'0912345678', null)
INSERT Into PhongBan values('PB009', N'Quản Lý Dự Án', N'TPHCM', N'0983947878', NULL)

update PhongBan set TruongPhong='NV005' where MaPB='PB001'
update PhongBan set TruongPhong='NV006' where MaPB='PB002'
update PhongBan set TruongPhong='NV007' where MaPB='PB003'
update PhongBan set TruongPhong='NV008' where MaPB='PB004'
update PhongBan set TruongPhong='NV009' where MaPB='PB005'
update PhongBan set TruongPhong='NV010' where MaPB='PB006'
update PhongBan set TruongPhong='NV011' where MaPB='PB007'
update PhongBan set TruongPhong='NV012' where MaPB='PB008'
Select * from PhongBan

CREATE TABLE CHUCVU(
	MaChucVu char(50) Primary key,
	TenChucVu nchar(50) NOT NULL,
	MaPhongBan char(50) references PHONGBAN(MaPB),
	LuongChucVu int NOT NULL,
)
select * from ChucVu
INSERT INTO CHUCVU values('CV000', N'Giám Đốc', 'PB000', 100000000)

INSERT INTO CHUCVU values('CV001', N'Kế toán trưởng', 'PB001', 30000000)
INSERT INTO CHUCVU values('CV002', N'Kế toán tổng hợp', 'PB001', 13000000)
INSERT INTO CHUCVU values('CV003', N'Kế toán thuế', 'PB001', 10000000)
INSERT INTO CHUCVU values('CV004', N'Kế toán tiền lương', 'PB001', 12000000)

INSERT INTO CHUCVU values('CV005', N'Quản trị hệ thống', 'PB002', 20000000)
INSERT INTO CHUCVU values('CV006', N'Lập trình viên', 'PB002', 20000000)
INSERT INTO CHUCVU values('CV007', N'Chuyên viên hỗ trợ kỹ thuật', 'PB002', 22000000)
INSERT INTO CHUCVU values('CV008', N'Nhân viên phát triển Web', 'PB002', 15000000)
INSERT INTO CHUCVU values('CV024', N'Trưởng phòng IT', 'PB002', 35000000)


INSERT INTO CHUCVU values('CV009', N'Giám đốc nhân sự', 'PB003', 30000000)
INSERT INTO CHUCVU values('CV010', N'Trưởng phòng nhân sự', 'PB003', 21000000)
INSERT INTO CHUCVU values('CV011', N'Chuyên viên tuyển dụng', 'PB003', 10000000)
INSERT INTO CHUCVU values('CV012', N'Chuyên viên đào tạo và phát triển', 'PB003', 17000000)

INSERT INTO CHUCVU values('CV013', N'Nhân viên hỗ trợ khách hàng', 'PB004', 12000000)
INSERT INTO CHUCVU values('CV014', N'Chuyên viên chăm sóc khách hàng', 'PB004', 13000000)
INSERT INTO CHUCVU values('CV015', N'Trưởng phòng CSKH', 'PB004', 25000000)

INSERT INTO CHUCVU values('CV016', N'Nhân viên hành chính', 'PB005', 12000000)
INSERT INTO CHUCVU values('CV017', N'Trưởng phòng hành chính', 'PB005', 12000000)

INSERT INTO CHUCVU values('CV018', N'Nhân viên kinh doanh', 'PB006', 13000000)
INSERT INTO CHUCVU values('CV019', N'Trưởng phòng kinh doanh', 'PB006', 20000000)
INSERT INTO CHUCVU values('CV020', N'Nhân viên Telesales', 'PB006', 13000000)

INSERT INTO CHUCVU values('CV021', N'Nhân viên kiểm toán', 'PB007', 14000000)
INSERT INTO CHUCVU values('CV022', N'Trưởng phòng kiểm toán', 'PB007', 22000000)

INSERT INTO CHUCVU values('CV023', N'Cố vấn cấp cao', 'PB008', 21000000)

INSERT INTO CHUCVU values('CV025', N'Project Manager', 'PB009', 30000000)




/*update CHUCVU set LuongChucVu=10000000 where MaChucVu='CV003'*/

select * from CHUCVU



CREATE TABLE NHANVIEN(
	MANV char(50) PRIMARY KEY,
	HOTEN nchar(50) NOT NULL,
	VITRI nchar(50) REFERENCES Chucvu(MaChucVu),
	QUEQUAN nchar(50) NOT NULL,
	DANTOC nchar(50) NOT NULL,
	GIOITINH nchar(50) NOT NULL,
	NGAYSINH date NULL,
	SODIENTHOAI char(50) NOT NULL,
	MAPB char(50) references PHONGBAN(MAPB),
	TinhTrang nchar(50) NULL,
	Email char(100) NULL,
	HonNhan nchar(50) NULL,
	SoCMND nchar(50) NULL,
	NgayCap nchar(50) NULL,
	NoiCap nchar(50) NULL,
	TonGiao nchar(50) NULL,
	NgayVao date NULL,
	DiaChi nchar(50) NULL,
	Facebook nchar(50) NULL,
	GhiChu nchar(1000) NULL,
	Anh image NULL,
)
/*alter table NhanVien
add Anh image NULL*/

INSERT INTO NHANVIEN VALUES('NV000', N'Lê Minh Tân', 'CV000', N'Kiên Giang', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB000', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12','Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
INSERT INTO NHANVIEN VALUES('NV001', N'Bùi Đức Long', 'CV005', N'Thái Bình', N'Kinh', N'Nam', '2003-09-04', '0777981051', 'PB002', N'Đang làm', 'buiduclong@gmail.com',N'Độc Thân', '0834978378', '2020-04-13', '../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV002', N'Vũ Đức Lộc', 'CV007', N'Lâm Đồng', N'Kinh', N'Nam', '2003-02-14', '0949484333', 'PB002', N'Đang làm', 'vuducloc@gmail.com',N'Đã Kết Hôn','08345485755', '2020-04-13', '../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV003', N'Trần Công Minh', 'CV015', N'Hà Tĩnh', N'Kinh', N'Nam', '2003-06-15', '0923532224', 'PB004', N'Đang làm', 'trancongminh@gmail.com',N'Độc Thân', '224325835355', '2020-04-13','../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV004', N'Hoàng Văn B', 'CV019', N'Hà Tĩnh', N'Kinh', N'Nam', '2003-04-13', '0843434445', 'PB006', N'Đang làm', 'hoangvanb@gmail.com',N'Đã Kết Hôn','1893783748365', '2020-04-13', '../../.././Images/nv1.png');

INSERT INTO NHANVIEN VALUES('NV005', N'Vũ Thị Thanh Tâm', 'CV001', N'Sơn La', N'Kinh', N'Nữ', '1998-12-11', '0495454656', 'PB001', N'Đang làm', 'vuthithanhtam@gmail.com',N'Độc Thân','989437483774', '2020-04-13','../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV006', N'Nguyễn Hồng Linh', 'CV024', N'Kiên Giang', N'Kinh', N'Nam', '1995-01-05', '0495454958', 'PB002', N'Đang làm', 'nguyenhonglinh@gmail.com',N'Đã Kết Hôn','846567858356', '2020-04-13', '../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV007', N'Nguyễn Thanh Tuấn', 'CV010', N'TPHCM', N'Kinh', N'Nam', '1995-09-05', '0978345123', 'PB003', N'Đang làm', 'nguyenthanhtuan@gmail.com',N'Độc Thân','846567835355', '2020-04-13','../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV008', N'Nguyễn Thị Bắc', 'CV015', N'Đồng Nai', N'Kinh', N'Nữ', '1999-09-20', '0495534666', 'PB004', N'Đang làm', 'nguyenthibac@gmail.com',N'Đã Kết Hôn', '14355835355', '2020-04-13','../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV009', N'Nguyễn Tiến Thành', 'CV017', N'TPHCM', N'Kinh', N'Nam', '1993-01-11', '0854123434', 'PB005', N'Đang làm', 'nguyentienthanh@gmail.com',N'Độc Thân','224325835355', '2020-04-13','../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV010', N'Trương Thị Hoa', 'CV019', N'Bình Thuận', N'Kinh', N'Nữ', '1998-01-05', '0495454958', 'PB006', N'Đang làm', 'truongthihoa@gmail.com',N'Đã Kết Hôn', '756475837583', '2020-04-13', '../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV011', N'Nguyễn Thị Chinh', 'CV022', N'TPHCM', N'Kinh', N'Nữ', '2000-03-17', '0899549833', 'PB007', N'Đang làm', 'nguyenthichinh@gmail.com',N'Độc Thân','83748765545', '2020-04-13', '../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV012', N'Hoàng Đức Phi', 'CV023', N'TPHCM', N'Kinh', N'Nam', '1999-11-12', '0963245144', 'PB008', N'Đang làm', 'hoangducphi@gmail.com',N'Đã Kết Hôn', '847384626327', '2020-04-13', '../../.././Images/nv1.png');

INSERT INTO NHANVIEN VALUES('NV013', N'Lê Minh Tân', 'CV001', N'Kiên Giang', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB001', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12',N'Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
INSERT INTO NHANVIEN VALUES('NV014', N'Lê Minh Tân', 'CV001', N'Kiên Giang', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB001', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12',N'Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
INSERT INTO NHANVIEN VALUES('NV015', N'Lê Minh Tân', 'CV001', N'Kiên Giang', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB001', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12',N'Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);

INSERT INTO NHANVIEN VALUES('NV016', N'Trần Hoàng Sơn', 'CV025', N'TPHCM', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB009', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12','Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
INSERT INTO NHANVIEN VALUES('NV017', N'Tô Thị Xuân Mai', 'CV025', N'TPHCM', N'Kinh', N'Nữ', '1992-09-03', '0966234567', 'PB009', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12','Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
INSERT INTO NHANVIEN VALUES('NV018', N'Bùi Đức Trung', 'CV011', N'Kiên Giang', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB003', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12','Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
INSERT INTO NHANVIEN VALUES('NV019', N'Bùi Đức Mạnh', 'CV012', N'Kiên Giang', N'Kinh', N'Nam', '1990-09-04', '0966234567', 'PB003', N'Đang làm', 'leminhtan@gmail.com',N'Độc Thân', '938958486854', '2020-04-13', N'Hà Nội', N'Không Có','2019-11-12','Phan Văn Trị, Gò Vấp, TPHCM', 'https://www.facebook.com/abc.948','Hello' ,null);
select * from NhanVien where not maPB = 'PB009' and not maPB = 'PB003' and not maPB = 'PB001'

CREATE TABLE LUONG(
	MaNV char(50) references NHANVIEN(MANV),
	LuongCoBan int NULL,
	Thuong int NULL,
	LuongNhan int NULL
)
INSERT INTO LUONG VALUES('NV001', 3000000, 500000, 0)
INSERT INTO LUONG VALUES('NV002', 4000000, 200000, 0)
INSERT INTO LUONG VALUES('NV003', 5000000, 300000, 0)
INSERT INTO LUONG VALUES('NV004', 3000000, 400000, 0)
INSERT INTO LUONG VALUES('NV005', 2000000, 500000, 0)
INSERT INTO LUONG VALUES('NV006', 3000000, 500000, 0)
INSERT INTO LUONG VALUES('NV007', 4000000, 400000, 0)
INSERT INTO LUONG VALUES('NV008', 5000000, 300000, 0)
INSERT INTO LUONG VALUES('NV009', 5000000, 400000, 0)
INSERT INTO LUONG VALUES('NV010', 3000000, 200000, 0)
INSERT INTO LUONG VALUES('NV011', 3000000, 300000, 0)
INSERT INTO LUONG VALUES('NV012', 4000000, 400000, 0)

Select * from Luong

Create table DuAn(
	MaDA int Primary Key,
    TenDuAn nchar(50) NULL,
    MieuTa nchar(200) NULL,
	TinhTrang nchar(200) NULL,
    MaNguoiSoHuu char(50) references NhanVien(MaNV),
	TaiLieu varbinary(Max) NULL,
    NgayBatDau date NULL,
    NgayKetThuc date NULL,
    NgayDuocThem date NULL,
	TiLeHT int Default(0)
)
alter table DuAn
alter column NgayDuocThem datetime NULL
alter table DuAn 
Update DuAn set TiLeHT = 0
add TiLeHT int Default(0)
Insert into DuAn values(1, 'Web bán hàng', 'C#', 'In Progress','NV005', null, '2022-1-1', '2022-2-24', '2023-01-03');
Insert into DuAn values(2, 'Web bán hàng', 'Javascript','Completed', 'NV006', null, '2022-1-1', '2022-2-24', '2023-01-03');
Insert into DuAn values(3, 'Web bán hàng', 'Python','On Hold', 'NV007', null,'2022-1-1','2022-2-24', '2023-01-03');
Insert into DuAn values(11, 'Web bán hàng', 'HTML','Completed', 'NV008', null,'2022-1-1','2022-2-24', '2023-01-03');
select * from DUAN
select * from NhanVienThamGiaDA
Create table NhanVienThamGiaDA(
	MaDA int references DUAN(MaDA),
	MaNV char(50) references NhanVien(MaNV)
)
select * from NhanVienThamGiaDA
Create table NhiemVu(
	MaNhiemVu int Primary Key,
	MaDA int references DUAN(MaDA),
	TenNhiemVu nchar(100) NULL,
	MieuTa nchar(100) NULL,
	MaNguoiSoHuu char(50) references NhanVien(MaNV),
	TinhTrang nchar(200) NULL,
	NgayBatDau date NULL,
    NgayKetThuc date NULL,
    NgayDuocThem date NULL,
	TaiLieu varbinary(Max) NULL,
	TiLeHT int Default(0)
)
alter table NhiemVu
alter column NgayDuocThem datetime NULL
INSERT INTO NhiemVu Values(1, 1, 'Web bán hàng', 'Code', 'NV001', 'In Progress', '2022-1-1', '2022-2-24', '2023-01-03');
INSERT INTO NhiemVu Values(2, 2, 'Web bán hàng', 'Tester', 'NV002', 'Completed', '2022-1-1', '2022-2-24', '2023-01-03');
INSERT INTO NhiemVu Values(3, 3, 'Web bán hàng', 'Idea', 'NV002', 'On Hold', '2022-1-1', '2022-2-24', '2023-01-03');
Create table NhiemVuNho(
	MaNhiemVuNho int Primary Key,
	MaNhiemVu int references NhiemVu(MaNhiemVu),
	TinhTrang nchar(200) NULL,
	Ten nchar(20) NULL,
	TiLeHT int default(0)
)
select * from NhiemVu
select distinct * from NhanVienThamGiaDA where MaDA = 33
Select distinct NhanVien.MaNV as MaNV, MaPB from NhanVienThamGiaDA inner join NhanVien on NhanVienThamGiaDA.MaNV=NhanVien.MaNV where MaDA = 33
select * from NhiemVuNho
update NhiemVuNho set TinhTrang = 'In Progress' where TinhTrang = N'Chờ Đánh Giá'
delete from NhiemVuNho
select * from DUAN
delete from NhiemVuNho where MaNhiemVuNho = 1 or MaNhiemVuNho = 2
Create table FileNop(
	MaNhiemVuNho int references NhiemVuNho(MaNhiemVuNho),
	MaNguoiSoHuu char(50) references NhanVien(MaNV),
	TaiLieu varbinary(Max) NULL,
	Filter char(10) NULL,
	TenFile char(100) NULL,
	MaFileNop int Primary key
)
select * from FileNop
delete from FileNop

Create table DanhGia(
	MaDanhGia int Primary key,
	MaNhiemVu int references NhiemVu(MaNhiemVu),
	LoiDanhGia nvarchar(Max) NULL,
	NgayDanhGia datetime NULL,
	MaNguoiDG char(50) references NhanVien(MaNV)
)
alter table DanhGia
add SoSao int NULL
select * from DanhGia
delete from DanhGia