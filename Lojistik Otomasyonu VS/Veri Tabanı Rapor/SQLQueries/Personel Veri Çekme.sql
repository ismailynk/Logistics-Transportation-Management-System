select per.*,maas.personel_yili,maas.yil_oraný,sýnýf.maaþ_pozisyon,sýnýf.pozisyon_sýnýf,(maas.yil_oraný*sýnýf.maaþ_pozisyon )as Toplam_maaþ from personell as per
inner join personel_bilgi as pb on per.personel_bilgi=pb.id_personel_bilgi  
inner join maas_katsayý as maas on pb.id_Katsayý = maas.id_maas_katsayý 
inner join sýnýf_personel as sýnýf on pb.id_Sýnýf = sýnýf.id_sýnýf