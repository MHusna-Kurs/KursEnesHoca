select * from Kullanicilar

select ad, soyad from Kullanicilar

select distinct kalkisYeri from Guzergahlar

select * from Kullanicilar where cinsiyet = 'true' and ad='Enes'

select * from Kullanicilar where cinsiyet = 'true' and (ad='Rüstem' or soyad='Tepehan')

select tc from Kullanicilar order by tc desc

insert into Kullanicilar (ad, soyad, tc, tel, mail, cinsiyet, dogumTarihi, kullaniciAd, kullaniciSifre)
values ('Mehmet Hüsna', 'Kışla', '38967823455', '5486789245', 'mehmethusnak@gmail.com', 'true', '26.05.1999', 'mhusna', '1818')

select * from Kullanicilar where ad='Mehmet Hüsna'

delete from Kullanicilar where kullaniciId = 1

select top 5 * from Kullanicilar

select * from Kullanicilar where kullaniciAd like 's%'

select * from Kullanicilar where kullaniciAd like '%s'

select * from Kullanicilar where kullaniciAd like '[abs]%'

select * from Kullanicilar where kullaniciAd not like '[abs]%'

select * from Kullanicilar where ad in ('Enes', 'Furkan')

select * from Kullanicilar where dogumTarihi between '01.01.1000' and '01.01.2000'

select * from Kullanicilar where kullaniciId between 1 and 20

select ad as Adi from Kullanicilar where kullaniciId between 1 and 5

select guz.kalkisYeri, guz.varisYeri, o.plaka, o.marka, o. model, o.wifi, o.tv, g.tarih, g.sure, g.kalkisSaat, g.biletFiyat
from GuzergahOtobusler g inner join Otobusler o on g.otobusId = o.otobusId
					     inner join Guzergahlar guz on g.guzergahId = guz.guzergahId

--Yolcu adı rüstem soyadı karayel olan müşterinin sefer bilgisinin getir

--select gok.yolcuAd, gok.yolcuSoyad, gok.koltukNo, 
--	   guz.kalkisYeri, guz.varisYeri, 
--	   guzoto.tarih, guzoto.sure, guzoto.kalkisSaat, guzoto.biletFiyat
--from GuzergahOtobusKullanicilar gok inner join GuzergahOtobusler guzoto on gok.seferId = guzoto.guzergahId
--									inner join  on guzoto.seferId = gok.seferId
--where k.ad = 'Rüstem' and k.soyad = 'Karayel'

--Cinsiyetlerine göre kullanıcıların yaş ortalaması

--select column_name from table_name where contidion group by column_name order by asc 

declare @tarih nvarchar(10) set @tarih = (select dogumTarihi from Kullanicilar) select right(@tarih,4) as result
declare @bugun int = year(getdate() - result.)