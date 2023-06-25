CREATE TABLE TuyenDung(
	MaTD char(20) Primary key,
	TenTD nchar(100) NULL,
	ViTri nchar(100) NULL,
	PhongBan nchar(100) NULL,
	MucLuongTu int NULL,
	MucLuongDen int NULL,
	HanTuyen date NULL,
	HinhThucLamViec nchar(100) NULL,
	NoiLamViec nchar(100) NULL
)
INSERT INTO TuyenDung VALUES('TD001', N'Tuyển dụng lập trình viên', N'Nhân viên', N'Công nghệ thông tin', '13000000', '16000000', '2022-10-05', N'Bán thời gian', N'TP Hồ Chí Minh')
INSERT INTO TuyenDung VALUES('TD002', N'Tuyển dụng kế toán', N'Nhân viên', N'Kế toán', '10000000', '13000000', '2022-07-15', N'Toàn thời gian', N'TP Hồ Chí Minh')
select * from TuyenDung

CREATE TABLE UngVien(
	MaUV char(20) Primary key,
	TenUV nchar(100) NULL,
	SDT char(20) NULL,
	Email nchar(100) NULL,
	DanhGia nchar(500) NULL,
	MaTD char(20) references TuyenDung(MaTD)
)
INSERT INTO UngVien VALUES('UV001', N'Nguyễn Việt Hoàng', '0964562315', 'hoangnv@gmail.com', '', 'TD001')
INSERT INTO UngVien VALUES('UV002', N'Lê Ngọc Anh', '0975465855', 'anhle@gmail.com', '', 'TD002')
INSERT INTO UngVien VALUES('UV003', N'Nguyễn Sử Khánh Hoàng', '0963562331', 'hoag@gmail.com', '', 'TD002')
INSERT INTO UngVien VALUES('UV004', N'Phan Thị Thảo', '0973452111', 'thaoxd@gmail.com', '', 'TD001')
INSERT INTO UngVien VALUES('UV005', N'Trần Duy Tuấn', '0988654466', 'tuanbeo@gmail.com', '', 'TD002')
INSERT INTO UngVien VALUES('UV006', N'Phạm Công Sơn', '0964475782', 'sonzi@gmail.com', '', 'TD001')
INSERT INTO UngVien VALUES('UV007', N'Nguyễn Thị Trang', '0966123422', 'trag@gmail.com', '', 'TD002')
INSERT INTO UngVien VALUES('UV008', N'Nguyễn Thùy Giang', '0973666234', 'giangg@gmail.com', '', 'TD001')
INSERT INTO UngVien VALUES('UV009', N'Nguyễn Tùng Bách', '0973758687', 'bachip@gmail.com', '', 'TD001')
select * from Ungvien