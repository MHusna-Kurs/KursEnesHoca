select cinsiyet, AVG( year(getdate()) - year(dogumTarihi)) as yas from Kullanicilar group by cinsiyet

select cinsiyet, AVG(datediff(year,(dogumTarihi), getdate())) as yas from Kullanicilar group by cinsiyet

select cinsiyet [Cinsiyet], COUNT(*) as [Kişi Sayısı] from Kullanicilar group by cinsiyet

--YANLIŞ KULLANIM
--select cinsiyet [Cinsiyet], COUNT(*) as [Kişi Sayısı] from Kullanicilar group by cinsiyet having (dogumTarihi > 2000-01-01)

select cinsiyet [Cinsiyet], Count(*) as [Kişi Sayısı] from Kullanicilar where dogumTarihi > '2000-01-01' group by cinsiyet

select cinsiyet, Count(*) [Yaş Ortalamaları] from Kullanicilar group by cinsiyet having AVG(DATEDIFF(YEAR, dogumTarihi, GETDATE())) > 20

--Cinsiyetlerine göre koltuk numaralarının ortalaması 20'den büyük olan kullanıcıların sayıları

select yolcuCinsiyet, Count(*) [Kullanıcı Sayısı] from GuzergahOtobusKullanicilar group by yolcuCinsiyet having AVG(koltukNo) >= 20

--3. ayın 11'inden sonra bilet almış yolcuların cinsiyetlerine göre koltuk numaralarının ortalaması 20'den büyük olanları getir

select yolcuCinsiyet, Count(*) [Kullanıcı Sayısı] from GuzergahOtobusKullanicilar
where biletKesimTarihi > '2022-11-03' group by yolcuCinsiyet having AVG(koltukNo) >= 20

--3. ayın 11'inden itibaren bilet almış yolcuların kalkış saatini gösteren bilgi.

select guzoto.kalkisSaat [Kalkış Saati], guzotokul.biletKesimTarihi [Tarih]
from GuzergahOtobusler guzoto inner join GuzergahOtobusKullanicilar guzotokul
on guzotokul.seferId = guzoto.seferId where guzotokul.biletKesimTarihi >= '2022-11-03'

--Kullanıcı adı enes soyadı tepehan olan kişinin biletlerini listeleyin

select * from Kullanicilar k inner join  GuzergahOtobusKullanicilar gok on gok.kullaniciId = k.kullaniciId
where k.ad = 'Mehmet Hüsna' and k.soyad = 'Kışla'

select * from GuzergahOtobusKullanicilar 
where kullaniciId = (select kullaniciId from Kullanicilar
					 where ad = 'Enes' and soyad = 'Tepehan')