select müþ.*,ü.* from ürün as ü 
inner join müsteri_ürün as müþürün on ü.id_ürün=müþürün.id_ürün 
inner join müþteri as müþ on müþürün.id_müsteri=müþ.id_müþteri