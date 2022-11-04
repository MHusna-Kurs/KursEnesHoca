select * from Kullanicilar

select ad, soyad from Kullanicilar

select distinct kalkisYeri from Guzergahlar

select * from Kullanicilar where cinsiyet = 'true' and ad='Enes'

select * from Kullanicilar where cinsiyet = 'true' and (ad='Rüstem' or soyad='Tepehan')

select tc from Kullanicilar order by tc desc

insert into Kullanicilar (ad, soyad, tc, tel, mail, cinsiyet, dogumTarihi, kullaniciAd, kullaniciSifre)
values ('Mehmet Hüsna', 'Kışla', '38967823455', '5486789245', 'mehmethusnak@gmail.com', 'true', '26.05.1999', 'mhusna', '1818')

select * from Kullanicilar where ad='Mehmet Hüsna'