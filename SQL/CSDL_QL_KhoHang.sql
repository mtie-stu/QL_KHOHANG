create database QL_KhoHang
use QL_KhoHang
drop database QL_KhoHang

create table Sanpham (
MaSP nvarchar(100) not null ,
TenSP nvarchar(100),
DVT nvarchar(20),
infoSP nvarchar(500)
)

create table Kehang(
MaKeHang nvarchar(100) not null ,
MaSP nvarchar(100),   --Khóa ngoại-Kệ hàng 1
TenSP nvarchar(100),
DVT nvarchar(20),
SoLuongKH int
)

create table Nhanvien (
id int identity(1,1) not null,
MaNV nvarchar(20) not null ,
Email nvarchar(50) not null,
SDT nvarchar(20),
TenNV nvarchar(50) not null,
DiaChi nvarchar(100) not null,
VaiTro tinyint not null,
CCCD nvarchar(20),
TinhTrang tinyint not null,
AnhNV varchar(500),--Chuỗi địa chỉ của ảnh 
MatKhau nvarchar(50)

)

create table Task (
idTask int identity(1,1) not null,
MaTask nvarchar(100) not null,
Thoigiangiao nvarchar(100),
LoaiTask nvarchar(10), --1:nhap/2: xuat
MaSP nvarchar(100),-- Khóa ngoại-Task 2
MaNV nvarchar(20),--Khóa ngoại-Task 3
Trangthai tinyint not null, -- hoàn thành/ chưa hoàn thành 
SoLuong int,
MaKeHang nvarchar(100),--Khóa ngoại- Task 4
duyet tinyint --0 chưa duyệt, 1 duyệt 
)

create table Phieuxuat (
idPX int identity(1,1) not null,
MaPX nvarchar(100) not null,--Khóa chính-Phiếu xuất 5
Thoigian nvarchar(100),
MaNV  nvarchar(20) not null,--Khóa ngoại-Phiếu xuất 6
Trangthai tinyint not null, -- 0: Chưa hoàn thành, 1: hoàn thành 
)

create table CTPhieuxuat (
MaPX nvarchar(100),--Khóa ngoại-Chi tiết phiếu xuất 7
MaSP nvarchar(100),--Khóa ngoại-Chi tiết phiếu xuất 8
TenSP nvarchar(100),
MaKeHang nvarchar(100),--Khóa ngoại-Chi tiết phiếu xuất-task 9 
Soluong int not null,--Khóa ngoại-Chi tiết phiếu xuất-task 10
MaTask nvarchar(100)--Khóa ngoại-Chi tiết phiếu xuất-task 11
)

Create table Phieunhap (
idPN int identity(1,1) not null,
MaPN nvarchar(100) not null ,--Khóa chính-Phieunhap 12
Thoigian nvarchar(100),--Thời gian user hoàn thành  
MaNV  nvarchar(20) not null,--Khóa ngoại-Phieunhap 13 
Trangthai tinyint not null, -- 0: Chưa hoàn thành, 1: hoàn thành 
)

create table CTPhieunhap (
MaPN nvarchar(100),--Khóa ngoại-Chi tiết phiếu nhập 14
MaKeHang nvarchar(100),--Khóa ngoại-Chi tiết phiếu nhập 15
MaSP nvarchar(100),--Khóa ngoại-Chi tiết phiếu nhập 16
TenSP nvarchar(100),
Soluong int not null,--Khóa ngoại-Chi tiết phiếu nhập 17 
MaTask nvarchar(100)--Khóa ngoại-Chi tiết phiếu nhập 18
)

--Khóa chính
ALTER TABLE Sanpham  
ADD PRIMARY KEY (MaSP);  

ALTER TABLE KeHang
ADD PRIMARY KEY (MaKeHang);

ALTER TABLE NhanVien
ADD PRIMARY KEY (MaNV);

ALTER TABLE Task
ADD PRIMARY KEY (MaTask);

ALTER TABLE Phieuxuat
ADD PRIMARY KEY (MaPX);

ALTER TABLE Phieunhap
ADD PRIMARY KEY (MaPN);


-- Khóa Ngoại 
--Khóa ngoại của kệ hàng
alter table Kehang
add constraint fk_Kehang_MaSP
Foreign key (MaSP) references Sanpham(MaSP) --1

--Khóa ngoại của Task
alter table Task
add constraint fk_Task_MaSP
Foreign key (MaSP) references Sanpham(MaSP) --2 hoàn thành 

alter table Task
add constraint fk_Task_MaNV
Foreign key (MaNV) references NhanVien(MaNV) --3 hoàn thành 

alter table Task
add constraint fk_Kehang_MaKeHang
Foreign key (MaKeHang) references Kehang(MaKeHang) --4 hoàn thành 

--Khóa ngoại của CT phiếu nhập
alter table CTPhieunhap
add constraint fk_CTPN_MaPN
Foreign key (MaPN) references PhieuNhap(MaPN)--5 hoàn thành 

alter table CTPhieunhap
add constraint fk_CTPN_MaTask
Foreign key (MaTask) references Task(MaTask)--6 hoàn thành 

alter table CTPhieunhap
add constraint fk_CTPN_MaKeHang
Foreign key (MaKeHang) references KeHang(MaKeHang)--7 hoàn thành 

--Khóa ngoại của CT phiếu xuất
alter table CTPhieuxuat
add constraint fk_CTPX_MaPX
Foreign key (MaPX) references Phieuxuat(MaPX)--8 hoàn thành 

alter table CTPhieuxuat
add constraint fk_CTPX_MaTask
Foreign key (MaTask) references Task(MaTask)--9 hoàn thành

alter table CTPhieuxuat
add constraint fk_CTPX_MaKeHang
Foreign key (MaKeHang) references KeHang(MaKeHang)--10 hoàn thành 

--KHóa ngoại của Phiếu nhâp
alter table Phieunhap 
add constraint fk_Phieunhap_MaNV
Foreign key (MaNV) references NhanVien(MaNV)--11 hoàn thành 
--Khóa ngoại của Phiếu xuất
alter table Phieuxuat 
add constraint fk_Phieuxuat_MaNV
Foreign key (MaNV) references NhanVien(MaNV)--12 hoàn thành 



--Đăng Nhập
Create procedure DangNhap @email nvarchar(20),
						  @matkhau nvarchar(50)
as 
begin 
	declare @status int
	 if exists(select * from NhanVien where Email =@email and MatKhau = @matkhau)
	    set @status =1
	 else 
	   set @status =0
	   select @status
end

--Quên mật khẩu
create procedure QuenMatKhau @email nvarchar(50)
as
begin 
     declare @status int 
	 if exists(select * from NhanVien where Email =@email )
	    set @status =1
	 else 
	   set @status =0
	   select @status
end

--Tạo mật khẩu mới 
create procedure TaoMatKhauMoi @email nvarchar(20),
                               @matkhau nvarchar(50)
as
  begin
       update NhanVien set MatKhau = @matkhau 
	   where Email = @email
  end

  -- Lấy vai trò nhân viên
  create procedure LayVaiTroNV @email nvarchar(20)
as
  begin 
       declare @status int 
	 if exists(select VaiTro from NhanVien where Email =@email )
	    set @status =1
	 else 
	   set @status =0
	   select @status
 end

 -- Thay đổi mật khẩu 
 create procedure ThayDoimatKhau (@email nvarchar(20),
                                  @opwd nvarchar(50),
								  @npwd nvarchar(50))
as
  declare @op nvarchar(50)
  select @op= MatKhau from NhanVien where Email = @email
  if @op = @opwd
  begin 
       update NhanVien set MatKhau = @npwd where Email = @email
	   return 1
  end
  else 
       return -1

-- Danh sách nhân viên
create procedure DanhSachNV as 
begin
     select Email, TenNV, DiaChi, VaiTro, TinhTrang
	 from NhanVien
end

--Thêm Nhân viên
create procedure InsertNhanVien 
                                @email nvarchar(50),
								@tennv nvarchar(50),
								@diachi nvarchar(100),
								@vaitro tinyint,
								@cccd nvarchar(20),
								@tinhtrang tinyint
as 
  begin 
       declare @Manv nvarchar(20);
	   declare @Id int;

	   select @Id = ISNULL(MAX(ID),0) + 1 from NhanVien
	   select @Manv = 'NV' + Right('0000' + CAST(@Id AS nvarchar(4)),4)
	   insert into NhanVien (MaNV, Email, TenNV, DiaChi, VaiTro, TinhTrang) values 
	   (@Manv, @email, @tennv, @diachi, @vaitro, @tinhtrang) 
 end

 -- Sửa nhân viên
 create procedure UpdateNhanVien 
                                 @email nvarchar(50),
								@tennv nvarchar(50),
								@diachi nvarchar(100),
								@vaitro tinyint,
								@tinhtrang tinyint
as
  begin
       update NhanVien set TenNV = @tennv, DiaChi = @diachi,
	                       VaiTro = @vaitro, TinhTrang= @tinhtrang
		where Email = @email
 end

 -- Xoá nhân viên
 create procedure DeleteNhanVien @email nvarchar(50)
 as 
   begin
        delete from NhanVien where Email = @email
	end
                     
-- Tìm kiếm Nhân Viên  
create procedure SearchNhanVien @tenNV nvarchar(50)
as
  begin 
      set nocount on;
	  select Email, TenNV, DiaChi, VaiTro, TinhTrang
	  from NhanVien where TenNV like + '%' +@tenNV + '%' 
  end
-- Tạo task
create procedure InsertTask
				@thoigiantao nvarchar(100),
				@loaitask nvarchar(10),
				@masp nvarchar(100),
				@trangthai tinyint,
				@soluong int,
				@makehang nvarchar(100)
as 
	begin
		declare @matask nvarchar(20);
		declare @Id int;
		--Tạo mã task
		Select @Id =ISNULL(Max(idTask),0)+1 from Task;
		Select @matask = 'T' +Right('0000' + cast(@Id as nvarchar(4)),4);
		-- Tạo MaPN hoac hoặc MaPX dựa vào loaitask
		Declare @MaPN nvarchar(100);
		Declare @MaPX nvarchar(100);

		If @loaitask = 1 --1 là phiếu nhập
		Begin 
			SELECT @Id = ISNULL(Max(idPN),0)+1 from Phieunhap; 
			SELECT @MaPN = 'PN' + RIGHT('0000' + CAST(@Id AS NVARCHAR(4)), 4);  
		
			INSERT INTO PhieuNhap (MaPN, Thoigian)  
		    VALUES (@MaPN, @thoigiantao); -- 0: chưa hoàn thành /1: hòan thành 
		
			INSERT INTO CTPhieunhap (MaPN,MaTask, MaSP, MaKeHang,Soluong)  
			VALUES (@MaPN, @matask, @masp,@makehang,@soluong);  
		END
		ELSE IF @loaitask =2 --2 là phiếu xuất
		Begin 
			SELECT @Id = ISNULL(Max(idPX),0)+1 from Phieuxuat;
			SELECT @MaPX = 'PX' + RIGHT('0000' + CAST(@Id AS NVARCHAR(4)), 4);
			
			INSERT INTO Phieuxuat(MaPX, Thoigian)  
		    VALUES (@MaPX, @thoigiantao); -- 0: chưa hoàn thành /1: hòan thành 
		
			INSERT INTO CTPhieuxuat(MaPX,MaTask, MaSP, MaKeHang,Soluong)  
			VALUES (@MaPN, @matask, @masp,@makehang,@soluong);  
		END
		--Thêm thông tin vào bảng task
		Insert into Task (MaTask,LoaiTask,MaKeHang,MaSP,SoLuong,Thoigiangiao)
        Values(@matask,@loaitask,@makehang,@masp,@soluong,@thoigiantao);-- 0: chưa hoàn thành /1: hòan thành 
End
--Admin duyệt sản phẩm 
-- Admin duyệt Task
CREATE PROCEDURE AdminDuyetTask
    @matask NVARCHAR(100),
    @manv NVARCHAR(20),
    @duyet TINYINT
AS
BEGIN
    -- Kiểm tra xem Task có tồn tại hay không
    IF EXISTS (SELECT 1 FROM Task WHERE MaTask = @matask)
    BEGIN

        -- Nếu admin đồng ý duyệt (Duyet = 1)
        IF @duyet = 1
        BEGIN
			UPDATE Task
		    SET MaNV = @manv,
            Duyet = @duyet
		    WHERE MaTask = @matask;
            -- Chuyển Task về cho nhân viên
            PRINT 'Admin đồng ý duyệt Task. Task được chuyển về cho nhân viên.';
        END
        ELSE
        BEGIN
            -- Admin không đồng ý duyệt
            PRINT 'Admin không đồng ý duyệt Task.';
			UPDATE Task
		    SET 
            Duyet = @duyet
		    WHERE MaTask = @matask;
        END
    END
    ELSE
    BEGIN
        -- Thông báo nếu Task không tồn tại
        PRINT 'Task không tồn tại.';
    END
END;

--Xem Task (nhân viên + admin)
CREATE PROCEDURE GetTasksByUser  
    @MaNV NVARCHAR(50) = NULL,  -- Tham số có thể là NULL  
    @Duyet BIT,  
    @LoaiTask NVARCHAR(20)  
AS  
BEGIN  
    IF @LoaiTask = 'nhap'  
    BEGIN  
        -- Trường hợp User hoặc Admin xem task nhập hàng  
        SELECT   
            T.idTask,  
            T.MaTask,  
            T.Thoigiangiao,  
            T.LoaiTask,  
            T.MaSP AS MaSP_Task,  
            T.MaNV AS MaNV_Task,  
            T.Trangthai AS Trangthai_Task,  
            T.SoLuong,  
            T.MaKeHang,  
            T.duyet,  
            NULL AS MaPX,  
            NULL AS ThoiGianPX,  
            NULL AS Trangthai_PX,  
            CN.MaSP AS MaSP_CTNH,  
            CN.Soluong AS SoLuong_CTNH,  
            PN.MaPN,  
            PN.Thoigian AS ThoiGianPN,  
            PN.Trangthai AS Trangthai_PN  
        FROM   
            Task AS T  
        LEFT JOIN   
            CTPhieunhap AS CN ON T.MaTask = CN.MaTask  
        LEFT JOIN   
            Phieunhap AS PN ON CN.MaPN = PN.MaPN  
        WHERE   
            T.Trangthai = 1 AND   
            T.duyet = @Duyet AND   
            (@MaNV IS NULL OR T.MaNV = @MaNV); -- Nếu @MaNV là NULL, admin sẽ xem tất cả, ngược lại chỉ xem của nhân viên  
    END  
    ELSE IF @LoaiTask = 'xuat'  
    BEGIN  
        -- Trường hợp User hoặc Admin xem task xuất hàng  
        SELECT   
            T.idTask,  
            T.MaTask,  
            T.Thoigiangiao,  
            T.LoaiTask,  
            T.MaSP AS MaSP_Task,  
            T.MaNV AS MaNV_Task,  
            T.Trangthai AS Trangthai_Task,  
            T.SoLuong,  
            T.MaKeHang,  
            T.duyet,  
            PX.MaPX,  
            PX.Thoigian AS ThoiGianPX,  
            PX.Trangthai AS Trangthai_PX,  
            CT.MaSP AS MaSP_CTPX,  
            CT.Soluong AS SoLuong_CTPX,  
            NULL AS MaPN,  
            NULL AS ThoiGianPN,  
            NULL AS Trangthai_PN  
        FROM   
            Task AS T  
        LEFT JOIN   
            CTPhieuxuat AS CT ON T.MaTask = CT.MaTask  
        LEFT JOIN   
            Phieuxuat AS PX ON CT.MaPX = PX.MaPX  
        WHERE   
            T.Trangthai = 1 AND   
            T.duyet = @Duyet AND   
            (@MaNV IS NULL OR T.MaNV = @MaNV); -- Nếu @MaNV là NULL, admin sẽ xem tất cả, ngược lại chỉ xem của nhân viên  
    END  
    ELSE  
    BEGIN  
        -- Nếu @LoaiTask không phải 'nhap' hoặc 'xuat', bạn có thể xử lý hoặc trả về một thông báo nào đó  
        RAISERROR('LoaiTask không hợp lệ. Vui lòng kiểm tra lại.', 16, 1);  
    END  
END;

-- Nhập Sản Phẩm 
CREATE PROCEDURE NhapSanPhamKeHang
    @masp NVARCHAR(100),
    @tensp NVARCHAR(100),
    @dvt NVARCHAR(20),
    @infoSP NVARCHAR(500),
    @makehang NVARCHAR(100),
    @soluong INT,
    @matask NVARCHAR(100)
AS
BEGIN
    -- Kiểm tra xem Task có tồn tại và đã được duyệt hay chưa
    DECLARE @duyet TINYINT;
    SELECT @duyet = duyet FROM Task WHERE MaTask = @matask AND MaSP = @masp AND MaKeHang = @makehang AND SoLuong = @soluong;

    IF @duyet IS NULL
    BEGIN
        PRINT 'Dữ liệu nhập không đúng với bảng Task. Vui lòng kiểm tra lại.';
        RETURN;
    END

    IF @duyet = 0
    BEGIN
        PRINT 'Task  chưa được admin duyệt. Vui lòng liên hệ admin để hỗ trợ.';
        RETURN;
    END
	If @duyet=1 
	begin
    -- Trường hợp 1: Sản phẩm đã tồn tại trong bảng sản phẩm
    IF EXISTS (SELECT 1 FROM Sanpham WHERE MaSP = @masp)
    BEGIN
        -- Cập nhật số lượng sản phẩm trong kệ hàng
        IF EXISTS (SELECT 1 FROM KeHang WHERE MaSP = @masp AND MaKeHang = @makehang)
        BEGIN
            UPDATE KeHang
            SET SoLuongKH = SoLuongKH + @soluong
            WHERE MaSP = @masp AND MaKeHang = @makehang;
        END
        ELSE
        BEGIN
            INSERT INTO KeHang (MaKeHang, MaSP, TenSP, DVT, SoLuongKH)
            VALUES (@makehang, @masp, @tensp, @dvt, @soluong);
        END
    END
    ELSE
    BEGIN
        -- Trường hợp 2: Sản phẩm không tồn tại trong bảng sản phẩm
        INSERT INTO Sanpham (MaSP, TenSP, DVT, infoSP)
        VALUES (@masp, @tensp, @dvt, @infoSP);

        -- Cập nhật sản phẩm vào kệ hàng
        INSERT INTO KeHang (MaKeHang, MaSP, TenSP, DVT, SoLuongKH)
        VALUES (@makehang, @masp, @tensp, @dvt, @soluong);
    END

    PRINT 'Nhập sản phẩm vào kệ hàng thành công.';
END
end;

CREATE PROCEDURE ExportProductFromKehang  
    @MaKeHang NVARCHAR(50),  
    @MaSP NVARCHAR(50),  
    @SoLuong INT,  
    @MaTask NVARCHAR(50)  
AS  
BEGIN  
    DECLARE @CurrentSoLuong INT;  
    DECLARE @TaskExists INT;  

    -- Kiểm tra tính hợp lệ của mã kệ hàng và mã sản phẩm  
    IF NOT EXISTS (SELECT 1 FROM Kehang WHERE MaKeHang = @MaKeHang AND MaSP = @MaSP)  
    BEGIN  
        PRINT 'Mã kệ hàng hoặc mã sản phẩm không tồn tại.';  
        RETURN;  
    END  

    -- Lấy số lượng hiện tại của sản phẩm trong kệ hàng  
    SELECT @CurrentSoLuong = SoLuongKH  
    FROM Kehang  
    WHERE MaKeHang = @MaKeHang AND MaSP = @MaSP;  

    -- Kiểm tra số lượng xuất  
    IF @SoLuong > @CurrentSoLuong  
    BEGIN  
        PRINT 'Số lượng xuất lớn hơn số lượng hiện tại trong kệ hàng.';  
        RETURN;  
    END  

    -- Kiểm tra xem mã task có tồn tại trong bảng Task  
    SELECT @TaskExists = COUNT(*)  
    FROM Task  
    WHERE MaTask = @MaTask AND MaSP = @MaSP;  

    IF @TaskExists = 0  
    BEGIN  
        PRINT 'Vui lòng kiểm tra lại dữ liệu đầu vào (mã task không hợp lệ).';  
        RETURN;  
    END  

    -- Cập nhật lại số lượng sản phẩm trong kệ hàng  
    UPDATE Kehang  
    SET SoLuongKH = SoLuongKH - @SoLuong  
    WHERE MaKeHang = @MaKeHang AND MaSP = @MaSP;  

    PRINT 'Xuất sản phẩm thành công!';  
END;

-- Thống kê kệ hàng dựa theo mã sản phẩm 
CREATE PROCEDURE spThongKeKehangTheoMaSP
    @MaSP nvarchar(100)
AS
BEGIN
    -- Kiểm tra xem sản phẩm có tồn tại trong kệ hàng không
    IF EXISTS (SELECT 1 FROM Kehang WHERE MaSP = @MaSP)
    BEGIN
        -- Thực hiện truy vấn để thống kê kệ hàng theo mã sản phẩm
        SELECT MaSP, SoLuongKH
        FROM Kehang
        WHERE MaSP = @MaSP
    END
    ELSE
    BEGIN
        RAISERROR('Sản phẩm không tồn tại trong kệ hàng.', 16, 1)
    END
END



--Thống kê sô lượng sản phẩm nhập xuất theo mã nhân viên
CREATE PROCEDURE spThongKeNhapXuatTheoMaNV
    @MaNV nvarchar(100)
AS
BEGIN
    -- Thống kê số lượng sản phẩm nhập và xuất theo mã nhân viên
    SELECT 
        Nhanvien.MaNV,
        Nhanvien.TenNV,
        SUM(CASE WHEN Task.LoaiTask = 'Nhập' THEN Task.SoLuong ELSE 0 END) AS SoLuongNhap,
        SUM(CASE WHEN Task.LoaiTask = 'Xuất' THEN Task.SoLuong ELSE 0 END) AS SoLuongXuat
    FROM Task
    INNER JOIN Nhanvien ON Task.MaNV = Nhanvien.MaNV
    WHERE Task.MaNV = @MaNV
    GROUP BY Nhanvien.MaNV, Nhanvien.TenNV
END

INSERT INTO Nhanvien (MaNV, Email, SDT, TenNV, DiaChi, VaiTro, CCCD, TinhTrang, AnhNV, MatKhau)
VALUES 
    ('NV001', 'nv001@example.com', '0123456789', 'Nguyễn Văn A', '123 Đường ABC, Quận 1, TP. HCM', 1, '123456789', 1, '/images/avatar.jpg', 'password123'),
    ('NV002', 'nv002@example.com', '0987654321', 'Trần Thị B', '456 Đường XYZ, Quận 2, TP. HCM', 2, '987654321', 1, '/images/avatar.jpg', 'abcdef');
    
update Nhanvien set MatKhau = '72441292916521318018810973127250152733056'
where MaNV='NV001'
update Nhanvien set MatKhau = '232118023913780252881702166014020151142'
where MaNV='NV002'