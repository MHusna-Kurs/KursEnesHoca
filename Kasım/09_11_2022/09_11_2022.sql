--Stored Procedure Oluşturma
--create procedure seferleriGetir as
--begin
--select * from GuzergahOtobusler
--end

--exec seferleriGetir

--create procedure kalkisSaatleri @tarih date as
--begin
--select guzoto.kalkisSaat [Kalkış Saati], guzotokul.biletKesimTarihi [Tarih]
--from GuzergahOtobusler guzoto inner join GuzergahOtobusKullanicilar guzotokul
--on guzotokul.seferId = guzoto.seferId where guzotokul.biletKesimTarihi >= @tarih
--end

--exec kalkisSaatleri '2022-11-03'

--create procedure verify @username nvarchar(20), @password nvarchar(20)
--as

--if exists(select * from Kullanicilar where kullaniciAd=@username and kullaniciSifre=@password)
--	print('User Exists')
--else
--	print('User Does not Exist')
--go -->Begin-end yeni versiyon.

--exec verify @username='mhusna', @password='1818'

create procedure toplama @variable1 int, @variable2 int 
as
declare @sonuc int
begin
set @sonuc=@variable1+@variable2
print('Toplam: '+str(sonuc))
end

exec toplama 30, 40

alter procedure seferGuncelle @seferId int, @guzergahId int, @otobusId int, @tarih nvarchar(10), @sure smallint,
							   @kalkisSaat nvarchar(5), @biletFiyat smallmoney, @Message nchar(30) = 'message' output
as
begin

if exists(select * from GuzergahOtobusler where seferId=@seferId)
	begin
	update GuzergahOtobusler set biletFiyat=@biletFiyat where seferId=@seferId
	set @Message='Row Updated'
	end

else
	begin
	insert into GuzergahOtobusler(guzergahId, otobusId, tarih, sure, kalkisSaat, biletFiyat) values
								 (@guzergahId, @otobusId, @tarih, @sure, @kalkisSaat, @biletFiyat)
	set @Message='Row inserted.'
	end
end

declare @mes nchar(30)
exec seferGuncelle 1, 3, 2, '04.11.2022', '200', '11:00', '250', @mes output
print(@mes)

--Tablo döndüren fonksiyon.
create function firmalars()
returns table
as
return(select * from firmalar)

SELECT * from firmalars()

--Scalar tablo
create function kullanicilarSutunBirlestir(@tc nvarchar(50), @ad nvarchar(50), @soyad nvarchar(50))
returns nvarchar(120)
as begin
return(select @tc+' '+@ad+' '+@soyad)
end

select [dbo].[kullanicilarSutunBirlestir] (Kullanicilar.tc, Kullanicilar.ad, Kullanicilar.soyad) as Kullanıcı
from Kullanicilar

---------------------
create function Fun_Addition(@Num1 Decimal(7,2), @Num2 Decimal(7,2))
returns Decimal(7,2)
begin
	declare @Result Decimal(7,2)
	set @Result = @Num1+@Num2
	return @Result
end

print dbo.Fun_Addition(12.7,15.3)