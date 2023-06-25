create table ChamCong(
	MaNV char(50) references NhanVien(MaNV),
	CheckIn datetime NULL,
	CheckOut datetime NULL,
	LyDo nchar(255) NULL,
	ChuThich nchar(255) NULL,
	Ngay date,
	primary key(MaNV,Ngay)
)
insert into ChamCong values('NV001', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV001', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV002', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV002', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV003', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV003', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV004', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV004', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV005', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV005', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV006', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV006', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV007', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV008', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV008', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV009', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV009', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV010', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV010', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV011', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV011', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV012', '2023-05-04 07:03', '2023-05-04 07:05', null, null, '2023-05-04')
insert into ChamCong values('NV012', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV007', null, null, N'Bị ốm', null, '2023-05-05')
insert into ChamCong values('NV004', '2023-05-06 07:03', '2023-05-06 07:05', null, null, '2023-05-06')
insert into ChamCong values('NV008', '2023-05-06 07:03', '2023-05-06 07:05', null, null, '2023-05-06')

select * from ChamCong
drop table ChamCong