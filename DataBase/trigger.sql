alter trigger update_sln on Chitietnhap for insert as
begin
declare @mactn1 char(10),@sl1 int,@mahh1 char(10)
select @mactn1=mactn from inserted
select @sl1=soluong,@mahh1=MaHH from Chitietnhap where Mactn=@mactn1
update HangHoa
set soluong=soluong+@sl1
where MaHH=@mahh1
  end

  go 
alter trigger update_slx on Chitietxuat for insert as
begin
declare @mactx1 char(10),@sl1 int,@mahh1 char(10)
select @mactx1=mactx from inserted
select @sl1=soluong,@mahh1=MaHH from Chitietnhap where Mactn=@mactx1
update HangHoa
set soluong=soluong-@sl1
where MaHH=@mahh1
  end


go

alter trigger update_sln2 on Chitietnhap for update as
begin
update HangHoa
set soluong= slhh
from (select HH.MaHH, (CTN.soLuong-CTX.soLuong) as slhh from HangHoa HH, Chitietnhap CTN, Chitietxuat CTX where HH.maHH=CTN.maHH and HH.maHH=CTX.maHH group by HH.maHH, CTN.soLuong, CTX.soLuong)
as A
where HangHoa.maHH=A.maHH
  end
  go
alter trigger update_slx2 on Chitietxuat for update as
begin
update HangHoa
set soluong= slhh
from (select HH.MaHH, (CTN.soLuong-CTX.soLuong) as slhh from HangHoa HH, Chitietnhap CTN, Chitietxuat CTX where HH.maHH=CTN.maHH and HH.maHH=CTX.maHH group by HH.maHH, CTN.soLuong, CTX.soLuong)
as A
where HangHoa.maHH=A.maHH
  end