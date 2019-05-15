create table CUSTOMER(
	idNguoidung int identity(1,1) primary key,
	tenNguoidung nvarchar(100),
	hinhanhNguoidung image,
	gioitinh nvarchar(50),
	diachi nvarchar(100),
	sdt int,
	ghichu nvarchar(100)
)

create table CONTACT(
	idContact int identity(1,1) primary key,
	tenContact nvarchar(100),
	noidungContact nvarchar(max),
	idNguoidung int,
	tenNguoidung nvarchar(100),
	hinhanhNguoidung image,
	gioitinh nvarchar(50),
	diachi nvarchar(100),
	sdt int,
	ghichu nvarchar(100)
)