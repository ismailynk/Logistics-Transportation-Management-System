declare @sef int 
declare @arac int=2
declare @sofor int=8
declare @sorumlu int=9
declare @ürün int=2
declare @güzergah varchar(50) ='Adana-Ýstanbul'
declare @bastar varchar(50) ='16.04.2022'
declare @bittar varchar (50)='18.04.2022'
insert into sefer (guzergah_sefer,bas_tarih_sefer,id_arac,id_personel_sofor,id_sipariþ,bit_tarih_sefer,sorumlu_personel) values (@güzergah,@bastar,@arac,@sofor,@ürün,@bittar,@sorumlu)

set @sef = (select max(id_sefer)  from sefer)
insert into arac_atama (id_arac,id_sefer)values(@arac,@sef)
insert into atama_personel_sofor(id_sofor,id_sefer)values(@sofor,@sef)
insert into sipariþ(id_ürün,id_sefer)values(@ürün,@sef)
insert into atama_personel_sorumlu(id_sorumlu,id_sefer)values(@sorumlu,@sef)