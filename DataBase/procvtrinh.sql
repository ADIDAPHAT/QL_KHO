alter proc xoa_PN(@maPN char(10))
as
begin
delete Chitietnhap
where maPN=@maPN
delete PhieuNhap
where maPN = @maPN
end
go
create proc xuat_CTN2(@maPN char(10))
as
begin

select maCTN as [Mã CTN],maHH as [Mã Hàng Hóa],soLuong as [Số Lượng],donGia as [Đơn giá] from Chitietnhap
where maPN=@maPN
end
go
create trigger tt on Chitietnhap for update,insert,delete
as
begin
declare @MAPNCU char(10),@MAPNMOI char(10)
select @MAPNCU=maPN from deleted
select @MAPNMOI=maPN from inserted
update PhieuNhap
set tongTien=(select sum(donGia*soLuong) from Chitietnhap  where maPN=@MAPNMOI)
where maPN=@MAPNMOI
update PhieuNhap
set tongTien=(select sum(donGia*soLuong) from Chitietnhap  where maPN=@MAPNCU)
where maPN=@MAPNCU
end
go
