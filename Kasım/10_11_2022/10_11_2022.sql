--create trigger kullaniciListele on Kullanicilar
--after insert
--as
--begin
--select * from Kullanicilar
--end

--insert into Kullanicilar (ad, soyad, tc, tel, mail, cinsiyet, dogumTarihi, kullaniciAd, kullaniciSifre)
--values('Mehmet', 'Kışla', '11111111111', '00000000000', 'mhusna@outlook.com', 1, '1999-05-26', 'MHUSNA', '1907')

--------------------------------------------------------------------------------------------------------------------

--create trigger seferList on GuzergahOtobusler
--after insert
--as
--begin
--select * from GuzergahOtobusler
--end

--exec seferGuncelle 11,2,1,'10.11.2022', '240', '10:00', '700','das'

---------------------------------------------------------------------------------------------------------------------

--alter table Firmalar add silindi bit null

--create trigger firmaSil on Firmalar instead of delete as
--begin
--	update Firmalar set silindi = 1 where firmaId in (select firmaId from deleted)
--end

--delete from Firmalar where firmaId = 1


---NORTHWIND DATABASE

CREATE TRIGGER Update_StockQuantity ON dbo.[Order Details] AFTER INSERT AS
BEGIN
	declare @productId int
	declare @quantity smallint
	SELECT @productId=ProductID, @quantity=Quantity FROM inserted

	--Güncellemeden Önce UnitInStock oku
	SELECT ProductID, ProductName, UnitsInStock FROM dbo.Products WHERE ProductID = @productId

	--Trigger UPDATE ifadesi
	UPDATE Products
	SET UnitsInStock = UnitsInStock - @quantity
	WHERE ProductID = @productId

	--Güncellemeden Sonra UnitsInStock oku
	SELECT ProductID, ProductName, UnitsInStock FROM dbo.Products WHERE ProductID = @productId
END

--Yeni Sipariş Ekle (INSERT INTO)
INSERT INTO dbo.[Order Details](OrderID, ProductID, UnitPrice, Quantity, Discount) values (10501, 1, 18, 5, 0)