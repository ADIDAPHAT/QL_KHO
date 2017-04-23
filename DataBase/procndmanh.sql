alter proc xoa_PX(@maPX char(10))
as
begin
delete Chitietxuat
where maPX=@maPX
delete PhieuXuat
where maPX = @maPX
end
go
create proc xuat_CTX2(@maPX char(10))
as
begin

select maCTX as [Mã CTX],maHH as [Mã Hàng Hóa],soLuong as [Số Lượng],donGia as [Đơn giá] from Chitietxuat
where maPX=@maPX
end
go
create trigger tt on Chitietxuat for update,insert,delete
as
begin
declare @MAPXCU char(10),@MAPXMOI char(10)
select @MAPXCU=maPX from deleted
select @MAPXMOI=maPX from inserted
update PhieuXuat
set tongTien=(select sum(donGia*soLuong) from Chitietxuat  where maPX=@MAPXMOI)
where maPX=@MAPXMOI
update PhieuXuat
set tongTien=(select sum(donGia*soLuong) from Chitietxuat  where maPX=@MAPXCU)
where maPX=@MAPXCU
end
go




