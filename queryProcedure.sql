alter proc proc_GetRegisDetailsByID
@mapdk char(5)
as
select  t.LoTrinh,t.HanhTrinh, c.MaTour,MaPDK,t.GiaTour,COUNT(c.SoluongDangky) as N'Sô lượng đăng ký'
from Chitiet_PhieuDangKy c ,Tour t
where c.MaPDK= @mapdk and c.MaTour=t.MaTour
Group By c.MaTour ,t.LoTrinh ,MaPDK,t.HanhTrinh,t.GiaTour

exec proc_GetRegisDetailsByID @mapdk
go

create proc proc_InsertRegisFormDetails
@mapdk char(5), @matour char(5) ,@quantity int
as
begin
		declare @isExistsForm int
		declare @regisQuantity int =1 
		select @isExistsForm= ID , @regisQuantity = SoluongDangky from Chitiet_PhieuDangKy  where MaPDK = @mapdk and MaTour = @matour
		
		if(@isExistsForm >0)
		begin
		declare @newRegisQuantity int = @regisQuantity + @quantity -- soluongdangky + soluongdadangky
			if(@newRegisQuantity >0)
			Update dbo.Chitiet_PhieuDangKy set SoluongDangky = @regisQuantity + @quantity
			else 
			delete dbo.Chitiet_PhieuDangKy where MaTour=@matour and MaPDK=@mapdk
		end
		else
		begin
		insert into dbo.Chitiet_PhieuDangKy(MaTour,MaPDK,SoluongDangky) values ( @matour , @mapdk , @quantity)
		end
end
go 
create proc proc_UpdateQuantityInTour
@matour char(5),@detailsquantity smallint
as
declare @oldquantity smallint = 
update Tour set SoluongHientai=@detailsquantity where MaTour = @matour

exec proc_UpdateQuantityInTour @matour , @detailsquantity
go 
alter proc proc_UpdateQuantityInTour
@matour char(5) ,@quantity int
as
begin
		declare @isExistsForm int
		declare @oldquantity int =1 
		select  @oldquantity = SoluongHientai from Tour u where MaTour = @matour
		begin
		declare @newRegisQuantity int = @oldquantity + @quantity 
			if(@newRegisQuantity >0)
			Update dbo.Tour set SoluongHientai = @oldquantity + @quantity where MaTour = @matour
			else 
			update dbo.Tour set SoluongHientai=0 where MaTour = @matour
		end
end
go
ALTER proc pro_GetExistsTourBackDate
@mapdk char(5)
as
select Top 1 t.NgayVe from Chitiet_PhieuDangKy c, Tour t where MaPDK = @mapdk and c.MaTour=t.MaTour order by t.NgayVe desc

exec pro_GetExistsTourBeginDate 'PDK01'
go
alter proc pro_GetTourBackDay
@matour char(5)
as
select Top 1 t.NgayDi from Tour t where  MaTour= @matour 
go
exec pro_GetTourBackDay 'T002'