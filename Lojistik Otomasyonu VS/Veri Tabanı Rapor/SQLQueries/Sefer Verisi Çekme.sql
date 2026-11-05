select  k.*,arac.*,ürün.*,personell.ad_personel as soforad,personell.id_personel as soforid,personell.kmlkno_personel as sofortc,p.id_personel as sorumluid,p.kmlkno_personel as sorumlutc
,p.ad_personel as sorumluad from sefer as k 
inner join arac as arac on k.id_arac= arac.id_arac   
inner join ürün as ürün on k.id_sipariþ=ürün.id_ürün 
inner join  personell as personell on k.id_personel_sofor=personell.id_personel   
inner join  personell as p on k.sorumlu_personel=p.id_personel 