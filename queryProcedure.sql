alter proc proc_GetRegisDetailsByID
@mapdk char(5)
as
select  t.LoTrinh,t.HanhTrinh, c.MaTour,MaPDK,COUNT(c.SoluongDangky) as N'Sô l??ng ??ng ký'
from Chitiet_PhieuDangKy c ,Tour t
where c.MaPDK= @mapdk and c.MaTour=t.MaTour
Group By c.MaTour ,t.LoTrinh ,MaPDK

exec proc_GetRegisDetailsByID @mapdk

create proc proc_InsertRegisFormDetails
@mapdk char(5), @matour smallint ,@quantity int
as
begin
		declare @isExistsForm int
		declare @regisQuantity int =1
		select @isExistsForm= Count(MaTour) , @regisQuantity = SoluongDangKy from dbo.Chitiet_PhieuDangKy where MaPDK = @mapdk and MaTour = @matour
		if(@isExistsForm >0)
		begin
		declare @newRegisQuantity int = @regisQuantity + @quantity
			if(@newRegisQuantity >0)
			Update dbo.Chitiet_PhieuDangKy set SoluongDangky = @regisQuantity + @quantity
			else 
			delete dbo.Chitiet_PhieuDangKy where MaTour=@matour and MaPDK=@mapdk
		end
end