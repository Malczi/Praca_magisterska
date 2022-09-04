USE master
GO
USE MGR
GO

CREATE VIEW v_Products
AS 
SELECT 
Produkt.ID_produkt AS [ID_produktu],
Produkt.Nazwa AS [Nazwa produktu], 
Typ_produkt.Nazwa AS [Typ produktu], 
Produkt.Nr_produkt AS [Numer produktu],
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzial],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
GO

--Departments

CREATE VIEW v_Dzial_budowa
AS 
SELECT 
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Dzial.ID_dzial = 1
GO

CREATE VIEW v_Dzial_ogrod_wypoczynek
AS 
SELECT 
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Dzial.ID_dzial = 2
GO

CREATE VIEW v_Dzial_technika
AS 
SELECT 
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Dzial.ID_dzial = 3
GO

CREATE VIEW v_Dzial_mieszkanie
AS 
SELECT 
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Dzial.ID_dzial = 4
GO

CREATE VIEW v_Dzial_kuchnia
AS 
SELECT 
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Dzial.ID_dzial = 5
GO

CREATE VIEW v_Dzial_lazienka
AS 
SELECT 
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria], 
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Dzial.ID_dzial = 6
GO

--VIEW Kategorie

CREATE VIEW v_Kategoria_mat_bud
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 1
GO

CREATE VIEW v_Kategoria_drew_bud
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 2
GO

CREATE VIEW v_Kategoria_drzwi
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 3
GO

CREATE VIEW v_Kategoria_okna
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 4
GO

CREATE VIEW v_Kategoria_schody_balustrady
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 5
GO

CREATE VIEW v_Kategoria_rosliny
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 6
GO

CREATE VIEW v_Kategoria_masz_ogrod
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 7
GO

CREATE VIEW v_Kategoria_grill
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 8
GO

CREATE VIEW v_Kategoria_lamp_zew
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 9
GO

CREATE VIEW v_Kategoria_meb_ogrod
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 10
GO

CREATE VIEW v_Kategoria_elektr_narz
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 11
GO

CREATE VIEW v_Kategoria_recz_narz
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 12
GO

CREATE VIEW v_Kategoria_duze_maszyny
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 13
GO

CREATE VIEW v_Kategoria_odsniez_zamiat
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 14
GO

CREATE VIEW v_Kategoria_masz_czysz
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 15
GO

CREATE VIEW v_Kategoria_oswietlenie
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 16
GO

CREATE VIEW v_Kategoria_meble
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 17
GO

CREATE VIEW v_Kategoria_podlogi
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 18
GO

CREATE VIEW v_Kategoria_farby_lakiery
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 19
GO

CREATE VIEW v_Kategoria_tapety
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 20
GO

CREATE VIEW v_Kategoria_aneksy_kuchenne
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 21
GO

CREATE VIEW v_Kategoria_AGD
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 22
GO

CREATE VIEW v_Kategoria_baterie_kuchenne
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 23
GO

CREATE VIEW v_Kategoria_meble_kuchenne
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 24
GO

CREATE VIEW v_Kategoria_okapy_kuchenne
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 25
GO

CREATE VIEW v_Kategoria_meble_lazienkowe
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 26
GO

CREATE VIEW v_Kategoria_lustra_lazienkowe
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 27
GO

CREATE VIEW v_Kategoria_wanny
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 28
GO

CREATE VIEW v_Kategoria_prysznice_akcesoria
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 29
GO

CREATE VIEW v_Kategoria_toalety
AS
SELECT
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto], 
Typ_produkt.Nazwa AS [Typ produktu], 
Podkategoria.Nazwa AS [Podkategoria], 
Kategoria.Nazwa AS [Kategoria],
Dzial.Nazwa AS [Dzia³],
Gwarancja.Okres_gwarancja AS [Gwarancja (lata)]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
INNER JOIN Gwarancja ON Produkt.ID_gwarancja = Gwarancja.ID_gwarancja
WHERE Kategoria.ID_kategoria = 30
GO

--Klienci

CREATE VIEW v_All_clients
AS
SELECT
Klient.Nazwisko AS [Nazwisko],
Klient.Imie AS [Imiê],
Klient.Nr_telefonu_1 AS [Numer telefonu],
Status_klient.Nazwa AS [Status klienta],
Klient.Email AS [Adres e-mail],
Klient.Nazwa_firmy AS [Firma],
Klient.ID_klient AS [ID]
FROM Klient
INNER JOIN Status_klient ON Klient.ID_status_klient = Status_klient.ID_status_klient
GO

CREATE VIEW v_Sprzedaz_hurt_klient
AS
SELECT
Sprzedaz_hurt.Data_sprzedazy AS [Data sprzedazy],
Klient.Nazwisko AS [Nazwisko klienta],
Klient.Imie AS [Imiê klienta],
Status_klient.Nazwa AS [Status klienta],
Sprzedaz_hurt.ID_sprzedaz_hurt AS [ID]
FROM Sprzedaz_hurt
INNER JOIN Zamowienie ON Sprzedaz_hurt.ID_zamowienie = Zamowienie.ID_zamowienie
INNER JOIN Klient ON Zamowienie.ID_klient = Klient.ID_klient
INNER JOIN Status_klient ON Klient.ID_status_klient = Status_klient.ID_status_klient
GO

CREATE VIEW v_Sprzedaz_hurt_klient_detalis
AS
SELECT
Sprzedaz_szczegol_hurt.ID_sprzedaz_szczegol_hurt AS [ID],
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Numer produktu],
Sprzedaz_szczegol_hurt.Ilosc AS [Iloœc],
Sprzedaz_hurt.ID_sprzedaz_hurt AS [Nr sprzedazy],
Produkt.Cena_sugerowana_netto AS [Cena za szt.],
[Cena sprzedazy] = Sprzedaz_szczegol_hurt.Ilosc * Produkt.Cena_sugerowana_netto
FROM Sprzedaz_szczegol_hurt
INNER JOIN Sprzedaz_hurt ON Sprzedaz_szczegol_hurt.ID_sprzedaz_hurt = Sprzedaz_hurt.ID_sprzedaz_hurt
INNER JOIN Produkt ON Sprzedaz_szczegol_hurt.ID_produkt = Produkt.ID_produkt
GO

CREATE VIEW v_Edit_client
AS
SELECT
Klient.ID_klient AS [ID],
Klient.Nazwisko AS [Nazwisko],
Klient.Imie AS [Imiê],
Klient.Nazwa_firmy AS [Nazwa firmy],
Klient.NIP AS [NIP],
Klient.Nr_telefonu_1 AS [Nr telefon 1],
Klient.Nr_telefonu_2 AS [Nr telefon 2],
Klient.Email AS [Email],
Klient.Miasto AS [Miasto],
Klient.Kod_pocztowy AS [Kod pocztowy],
Klient.Ulica AS [Ulica],
Klient.Nr_domu AS [Nr domu],
Klient.Nr_lokalu AS [Nr lokali],
Status_klient.Nazwa AS [Status klienta]
FROM Klient
INNER JOIN Status_klient ON Status_klient.ID_status_klient = Klient.ID_status_klient
GO

--SALES

CREATE VIEW v_All_hurt_sold_products
AS
SELECT
Produkt.ID_produkt AS [ID],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
SUM (Sprzedaz_szczegol_hurt.Ilosc) AS [Ilosc],
SUM (Produkt.Cena_sugerowana_netto * Sprzedaz_szczegol_hurt.Ilosc) AS [Przychód]
FROM Produkt
INNER JOIN Sprzedaz_szczegol_hurt ON Sprzedaz_szczegol_hurt.ID_produkt = Produkt.ID_produkt
INNER JOIN Sprzedaz_hurt ON Sprzedaz_szczegol_hurt.ID_sprzedaz_hurt = Sprzedaz_hurt.ID_sprzedaz_hurt
INNER JOIN Zamowienie ON Sprzedaz_hurt.ID_zamowienie = Zamowienie.ID_zamowienie
INNER JOIN Umowa_sprzedaz_hurt ON Zamowienie.ID_umowa_sprzedaz_hurt = Umowa_sprzedaz_hurt.ID_umowa_sprzedaz_hurt
INNER JOIN Oferta_handlowa ON Umowa_sprzedaz_hurt.ID_oferta_handlowa = Oferta_handlowa.ID_oferta_handlowa
WHERE Oferta_handlowa.ID_status_oferta = 1
GROUP BY Produkt.Nazwa, Produkt.ID_produkt, Produkt.Nr_produkt
ORDER BY Ilosc DESC OFFSET 0 ROWS
GO

CREATE VIEW v_All_detal_sold_products
AS
SELECT
Produkt.ID_produkt AS [ID],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
SUM (Sprzedaz_szczegol_detal.Ilosc) AS [Ilosc],
SUM (Sprzedaz_szczegol_detal.Cena_netto_za_jednostke * Sprzedaz_szczegol_detal.Ilosc) AS [Przychód]
FROM Produkt
INNER JOIN Sprzedaz_szczegol_detal ON Sprzedaz_szczegol_detal.ID_produkt = Produkt.ID_produkt
GROUP BY Produkt.Nazwa, Produkt.ID_produkt, Produkt.Nr_produkt
ORDER BY Ilosc DESC OFFSET 0 ROWS
GO

CREATE VIEW v_New_detal_sales
AS
SELECT
Sprzedaz_detal.Data_sprzedazy AS [Data_sprzedazy],
Forma_platnosc.Nazwa AS [Forma_platnosci],
Sprzedaz_detal.Termin_zaplata AS [Termin_zaplaty],
Typ_odbioru.Nazwa AS [Forma_odbioru],
Sprzedaz_detal.ID_sprzedaz_detal AS [ID]
FROM Sprzedaz_detal
INNER JOIN Forma_platnosc ON Forma_platnosc.ID_forma_platnosc = Sprzedaz_detal.ID_forma_platnosc
INNER JOIN Typ_odbioru ON Typ_odbioru.ID_typ_odbioru = Sprzedaz_detal.ID_Typ_odbioru
GO

CREATE VIEW v_New_detal_sales_details
AS
SELECT
Sprzedaz_szczegol_detal.ID_sprzedaz_szczegol_detal AS [ID],
Produkt.Nazwa AS [Produkt],
Produkt.Cena_sugerowana_netto AS [Cena_sugerowana_netto],
Jednostka.Nazwa AS [Jednostka],
Podatek.Procent AS [Podatek_VAT],
Sprzedaz_szczegol_detal.Ilosc AS [Ilosc],
Sprzedaz_szczegol_detal.ID_sprzedaz_detal AS [Nr_sprzedazy]
FROM Sprzedaz_szczegol_detal
INNER JOIN Produkt ON Produkt.ID_produkt = Sprzedaz_szczegol_detal.ID_produkt
INNER JOIN Jednostka ON Jednostka.ID_jednostka = Sprzedaz_szczegol_detal.ID_jednostka
INNER JOIN Podatek ON Podatek.ID_podatek = Sprzedaz_szczegol_detal.ID_podatek
GO

CREATE VIEW v_Ceny_sugerowane_produk
AS
SELECT
Produkt.Nazwa AS [Produkt],
Produkt.Cena_sugerowana_netto AS [Cena proponowana netto]
FROM Produkt
GO

CREATE VIEW v_Oferta_handlowa
AS
SELECT
Oferta_handlowa.ID_oferta_handlowa AS [Numer oferty],
Pracownik.Imie AS [Imiê], Pracownik.Nazwisko AS [Nazwisko],
Oferta_handlowa.Termin_realizacja AS [Termin realizaji],
Status_oferta.Nazwa_status_oferta AS [Status oferty]
FROM Status_oferta
INNER JOIN Oferta_handlowa ON Oferta_handlowa.ID_status_oferta = Status_oferta.ID_status_oferta
INNER JOIN Pracownik ON Oferta_handlowa.ID_pracownik = Pracownik.ID_pracownik
GO

CREATE VIEW v_Oferta_handlowa_zaakceptowane
AS
SELECT
Oferta_handlowa.ID_oferta_handlowa AS [Numer oferty],
Pracownik.Imie AS [Imiê], Pracownik.Nazwisko AS [Nazwisko],
Oferta_handlowa.Termin_realizacja AS [Termin realizaji],
Status_oferta.Nazwa_status_oferta AS [Status oferty]
FROM Status_oferta
INNER JOIN Oferta_handlowa ON Oferta_handlowa.ID_status_oferta = Status_oferta.ID_status_oferta
INNER JOIN Pracownik ON Oferta_handlowa.ID_pracownik = Pracownik.ID_pracownik
WHERE Oferta_handlowa.ID_status_oferta = 1
GO

CREATE VIEW v_Oferta_handlowa_szczegol_zaakceptowane
AS
SELECT
Oferta_handlowa.ID_oferta_handlowa AS [Numer oferty],
Produkt.Nazwa AS [Produkt],
Oferta_handlowa_szczegol.Ilosc AS [Ilosc],
Oferta_handlowa_szczegol.Cena_netto_za_jednostke AS [Cena netto za jednostkê],
Podatek.Procent AS [Podatek VAT %]
FROM Oferta_handlowa_szczegol
FULL JOIN Oferta_handlowa ON Oferta_handlowa.ID_oferta_handlowa = Oferta_handlowa_szczegol.ID_oferta_handlowa
INNER JOIN Podatek ON Podatek.ID_podatek = Oferta_handlowa_szczegol.ID_podatek
INNER JOIN Produkt ON Produkt.ID_produkt = Oferta_handlowa_szczegol.ID_produkt
WHERE Oferta_handlowa.ID_status_oferta = 1
GO

CREATE VIEW v_Oferta_handlowa_szczegol
AS
SELECT
Oferta_handlowa.ID_oferta_handlowa AS [Numer oferty],
Produkt.Nazwa AS [Produkt],
Oferta_handlowa_szczegol.Ilosc AS [Ilosc],
Oferta_handlowa_szczegol.Cena_netto_za_jednostke AS [Cena netto za jednostkê],
Podatek.Procent AS [Podatek VAT %]
FROM Oferta_handlowa_szczegol
FULL JOIN Oferta_handlowa ON Oferta_handlowa.ID_oferta_handlowa = Oferta_handlowa_szczegol.ID_oferta_handlowa
INNER JOIN Podatek ON Podatek.ID_podatek = Oferta_handlowa_szczegol.ID_podatek
INNER JOIN Produkt ON Produkt.ID_produkt = Oferta_handlowa_szczegol.ID_produkt
GO

CREATE VIEW v_Umowa_sprzedazy_hurt
AS
SELECT
Umowa_sprzedaz_hurt.ID_umowa_sprzedaz_hurt AS [Numer umowy sprzedazy],
Oferta_handlowa.ID_oferta_handlowa AS [Numer oferty handlowej],
Klient.Imie AS [Imiê klienta], Klient.Nazwisko AS [Nazwisko klienta],
Pracownik.Imie AS [Imiê pracownika], Pracownik.Nazwisko AS [Nazwisko pracownika]
FROM Umowa_sprzedaz_hurt
INNER JOIN Oferta_handlowa ON Oferta_handlowa.ID_oferta_handlowa = Umowa_sprzedaz_hurt.ID_oferta_handlowa
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Oferta_handlowa.ID_pracownik
INNER JOIN Klient ON Klient.ID_klient = Umowa_sprzedaz_hurt.ID_klient
GO

CREATE VIEW v_Zamowienie
AS 
SELECT
Zamowienie.ID_zamowienie AS [Numer zamowienia],
Zamowienie.ID_umowa_sprzedaz_hurt AS [Numer umowy],
Pracownik.Imie AS [Imie pracownika], Pracownik.Nazwisko AS [Nazwisko pracownika],
Klient.Imie AS [Imiê klienta], Klient.Nazwisko AS [Naziwsko klienta],
Stan_realizacji.Nazwa_stan_realizaji AS [Stan realizacji],
Zamowienie.Data_zamowienie AS [Dara zamówienia],
Oferta_handlowa.ID_oferta_handlowa AS [Numer oferty]
FROM Zamowienie
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Zamowienie.ID_pracownik
INNER JOIN Klient ON Klient.ID_klient = Zamowienie.ID_klient
INNER JOIN Stan_realizacji ON Stan_realizacji.ID_stan_realizacji = Zamowienie.ID_stan_realizaji
INNER JOIN Umowa_sprzedaz_hurt ON Umowa_sprzedaz_hurt.ID_umowa_sprzedaz_hurt = Zamowienie.ID_umowa_sprzedaz_hurt
INNER JOIN Oferta_handlowa ON Oferta_handlowa.ID_oferta_handlowa = Umowa_sprzedaz_hurt.ID_oferta_handlowa
GO

CREATE VIEW v_Zamowienie_szczegol 
AS
SELECT
Zamowienie_szczegol.ID_zamowienie [Numer zamówienia],
Zamowienie_szczegol.ID_zamowienie_szczegol AS [Nr szczegó³u],
Produkt.Nazwa AS [Nazwa produktu],
Zamowienie_szczegol.Ilosc AS [Iloœæ]
FROM Zamowienie_szczegol
INNER JOIN Produkt ON Produkt.ID_produkt = Zamowienie_szczegol.ID_produkt
GO

CREATE VIEW v_Sprzedaz_hurt 
AS
SELECT
Sprzedaz_hurt.ID_sprzedaz_hurt AS [Numer sprzeda¿y],
Sprzedaz_hurt.ID_zamowienie AS [Numer zamowienia],
Sprzedaz_hurt.Data_sprzedazy AS [Data sprzeda¿y],
Typ_odbioru.Nazwa AS [Forma odbioru],
Forma_platnosc.Nazwa AS [Forma p³atnoœci],
Sprzedaz_hurt.Termin_zaplata AS [Termin p³atnoœci]
FROM Sprzedaz_hurt
INNER JOIN Typ_odbioru ON Typ_odbioru.ID_typ_odbioru = Sprzedaz_hurt.ID_Typ_odbioru
INNER JOIN Forma_platnosc ON Forma_platnosc.ID_forma_platnosc = Sprzedaz_hurt.ID_forma_platnosc
GO

CREATE VIEW v_Sprzedaz_szczegol_hurt
AS
SELECT
Sprzedaz_szczegol_hurt.ID_sprzedaz_hurt AS [Numer sprzeda¿y],
Sprzedaz_szczegol_hurt.ID_sprzedaz_szczegol_hurt AS [Numer szczegó³u],
Produkt.Nazwa AS [Nazwa produktu],
Jednostka.Nazwa AS [Jednostka],
Sprzedaz_szczegol_hurt.Ilosc AS [Iloœæ],
Produkt.Cena_sugerowana_netto AS [Sugerowana_cena_netto]
FROM Sprzedaz_szczegol_hurt
INNER JOIN Produkt ON Produkt.ID_produkt = Sprzedaz_szczegol_hurt.ID_produkt
INNER JOIN Jednostka ON Jednostka.ID_jednostka = Sprzedaz_szczegol_hurt.ID_jednostka 
GO

CREATE VIEW v_Reklamacja_hurt
AS
SELECT
Reklamacja_hurt.ID_reklamacja_hurt AS [Numer reklamacji],
Reklamacja_hurt.Data_reklamacja AS [Data reklamacji],
Reklamacja_hurt.ID_sprzedaz_hurt AS [Numer sprzeda¿y],
Pracownik.Imie AS [Imiê pracownika], Pracownik.Nazwisko AS [Nazwisko pracownika],
Reklamacja_hurt.Opis_reklamacja AS [Opis]
FROM Reklamacja_hurt
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Reklamacja_hurt.ID_pracownik
GO

CREATE VIEW v_Reklamacja_hurt_szczegol
AS
SELECT
Szczegol_reklamacja_hurt.ID_reklamacja_hurt AS [Numer reklamacji],
Szczegol_reklamacja_hurt.ID_szczegol_reklamacja_hurt AS [No produktu],
Typ_reklamacja.Nazwa AS [Rodzaj reklamacji],
Produkt.Nazwa AS [Produkt],
Produkt.ID_produkt AS [ID],
Szczegol_reklamacja_hurt.Ilosc AS [Iloœæ],
Szczegol_reklamacja_hurt.Utylizacja AS [Utylizacja],
Szczegol_reklamacja_hurt.Uwagi AS [Uwagi]
FROM Szczegol_reklamacja_hurt
INNER JOIN Typ_reklamacja ON Typ_reklamacja.ID_typ_reklamacja = Szczegol_reklamacja_hurt.ID_typ_reklamacja
INNER JOIN Produkt ON Produkt.ID_produkt = Szczegol_reklamacja_hurt.ID_produkt
GO

CREATE VIEW v_Reklamacja_detal
AS
SELECT
Reklamacja_detal.ID_reklamacja_detal AS [Numer reklamacji],
Reklamacja_detal.Data_reklamacja AS [Data reklamacji],
Reklamacja_detal.ID_sprzedaz_detal AS [Numer sprzeda¿y],
Pracownik.Imie AS [Imiê pracownika], Pracownik.Nazwisko AS [Nazwisko pracownika],
Reklamacja_detal.Opis_reklamacja AS [Opis]
FROM Reklamacja_detal
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Reklamacja_detal.ID_pracownik
GO

CREATE VIEW v_Reklamacja_detal_szczegol
AS
SELECT
Szczegol_reklamacja_detal.ID_reklamacja_detal AS [Numer reklamacji],
Szczegol_reklamacja_detal.ID_szczegol_reklamacja_detal AS [No produktu],
Typ_reklamacja.Nazwa AS [Rodzaj reklamacji],
Produkt.Nazwa AS [Produkt],
Produkt.ID_produkt AS [ID],
Szczegol_reklamacja_detal.Ilosc AS [Iloœæ],
Szczegol_reklamacja_detal.Utylizacja AS [Utylizacja],
Szczegol_reklamacja_detal.Uwagi AS [Uwagi]
FROM Szczegol_reklamacja_detal
INNER JOIN Typ_reklamacja ON Typ_reklamacja.ID_typ_reklamacja = Szczegol_reklamacja_detal.ID_typ_reklamacja
INNER JOIN Produkt ON Produkt.ID_produkt = Szczegol_reklamacja_detal.ID_produkt
GO

--KADRY 

CREATE VIEW v_Pracownik_stanowisko
AS
SELECT
Pracownik.ID_pracownik AS [ID_pracownik],
Pracownik.Imie AS [Imiê],
Pracownik.Nazwisko AS [Nazwisko],
Stanowisko.Nazwa_stanowiska AS [Stanowisko],
Dzial_pracownik.Nazwa_dzial_pracownik AS [Nazwa dzia³u],
Wyksztalcenie.Nazwa AS [Wykszta³cenie],
Nr_telefon_pracownik.Numer AS [Numer telefonu],
Email_pracownik.Email AS [E-mail],
Dane_adresowe_pracownik.Miejscowosc AS [Miasto],
Dane_adresowe_pracownik.Kod_pocztowy AS [Kod pocztowy],
Dane_adresowe_pracownik.Ulica AS [Ulica],
Dane_adresowe_pracownik.Nr_budynku AS [Numer budynku],
Dane_adresowe_pracownik.Nr_lokalu AS [Numer lokalu],
Pracownik.Nr_dowodu AS [Numer dowodu],
Pracownik.PESEL AS [PESEL]
FROM Stanowisko
INNER JOIN Etat ON Stanowisko.ID_stanowisko = Etat.ID_stanowisko
INNER JOIN Posada_pracownika ON Posada_pracownika.ID_etat = Etat.ID_etat
INNER JOIN Umowa ON Umowa.ID_posada_pracownika = Posada_pracownika.ID_posada_pracownika
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Umowa.ID_pracownik
INNER JOIN Dzial_pracownik ON Dzial_pracownik.ID_dzial_pracownik = Stanowisko.ID_dzial_pracownik
INNER JOIN Dane_adresowe_pracownik ON Dane_adresowe_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Nr_telefon_pracownik ON Nr_telefon_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Email_pracownik ON Email_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Wyksztalcenie ON Wyksztalcenie.ID_wyksztalcenie = Pracownik.ID_wyksztalcenie
GO

CREATE VIEW v_Products_oferta_handlowa
AS 
SELECT 
Produkt.ID_produkt AS [ID_produktu],
Produkt.Nazwa AS [Nazwa produktu], 
Produkt.Nr_produkt AS [Numer produktu],
Produkt.Cena_sugerowana_netto AS [Cena netto]
FROM Produkt
INNER JOIN Typ_produkt ON Produkt.ID_typ_produkt = Typ_produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Typ_produkt.ID_podkategoria = Podkategoria.ID_podkategoria 
INNER JOIN Kategoria ON Podkategoria.ID_Kategoria = Kategoria.ID_kategoria
INNER JOIN Dzial ON Kategoria.ID_dzial = Dzial.ID_dzial
GO

--MAGAZYN



CREATE VIEW v_Dostawa
AS
SELECT
Dostawa.ID_dostawa AS [Numer dostawy],
Dostawca.Nazwa AS [Dostawca],
Pracownik.Imie AS [Imiê pracownika], Pracownik.Nazwisko AS [Nazwisko pracownika],
Dostawa.Data_dostawa AS [Data dostawy]
FROM Dostawa
INNER JOIN Dostawca ON Dostawca.ID_dostawca = Dostawa.ID_dostawca
INNER JOIN Pracownik ON Pracownik.ID_pracownik = Dostawa.ID_pracownik
GO

CREATE VIEW v_Dostawa_szczegol
AS
SELECT
Dostawa_szczegol.ID_dostawa_szczegol AS [Nr szczegolu],
Dostawa_szczegol.ID_dostawa AS [Nr dostawy],
Produkt.Nazwa AS [Produkt], Produkt.Nr_produkt AS [Numer produktu],
Dostawa_szczegol.Ilosc AS [Ilosc],
Dostawa_szczegol.Cena_szt AS [Cena za jednostkê]
FROM Dostawa_szczegol
INNER JOIN Produkt ON Produkt.ID_produkt = Dostawa_szczegol.ID_produkt
GROUP BY Dostawa_szczegol.ID_dostawa_szczegol, Dostawa_szczegol.ID_dostawa, Produkt.Nazwa,  Produkt.Nr_produkt, Dostawa_szczegol.Cena_szt, Dostawa_szczegol.Ilosc
GO


--PREDYKCJA DOSTAW



CREATE VIEW v_All_hurt_sold_products_magazyn
AS
SELECT
Produkt.ID_produkt AS [ID],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
SUM (Sprzedaz_szczegol_hurt.Ilosc) AS [Ilosc]
FROM Sprzedaz_szczegol_hurt
INNER JOIN Produkt ON Sprzedaz_szczegol_hurt.ID_produkt = Produkt.ID_produkt
INNER JOIN Sprzedaz_hurt ON Sprzedaz_szczegol_hurt.ID_sprzedaz_hurt = Sprzedaz_hurt.ID_sprzedaz_hurt
INNER JOIN Zamowienie ON Sprzedaz_hurt.ID_zamowienie = Zamowienie.ID_zamowienie
INNER JOIN Umowa_sprzedaz_hurt ON Zamowienie.ID_umowa_sprzedaz_hurt = Umowa_sprzedaz_hurt.ID_umowa_sprzedaz_hurt
INNER JOIN Oferta_handlowa ON Umowa_sprzedaz_hurt.ID_oferta_handlowa = Oferta_handlowa.ID_oferta_handlowa
WHERE Oferta_handlowa.ID_status_oferta = 1
GROUP BY Produkt.Nazwa, Produkt.ID_produkt, Produkt.Nr_produkt, Sprzedaz_szczegol_hurt.Ilosc
ORDER BY ID ASC OFFSET 0 ROWS
GO

CREATE VIEW v_All_hurt_sold_products_magazyn_part2
AS
SELECT
Produkt.ID_produkt AS [ID],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
SUM (v_All_hurt_sold_products_magazyn.Ilosc) AS [Ilosc]
FROM v_All_hurt_sold_products_magazyn
INNER JOIN Produkt ON Produkt.ID_produkt = v_All_hurt_sold_products_magazyn.ID
GROUP BY Produkt.Nazwa, Produkt.ID_produkt, Produkt.Nr_produkt
ORDER BY ID ASC OFFSET 0 ROWS
GO

CREATE VIEW v_All_detal_sold_products_magazyn
AS
SELECT
Produkt.ID_produkt AS [ID],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
SUM (Sprzedaz_szczegol_detal.Ilosc) AS [Ilosc]
FROM Sprzedaz_szczegol_detal
INNER JOIN Produkt ON Sprzedaz_szczegol_detal.ID_produkt = Produkt.ID_produkt
GROUP BY Produkt.Nazwa, Produkt.ID_produkt, Produkt.Nr_produkt
ORDER BY ID ASC OFFSET 0 ROWS
GO

CREATE VIEW v_All_delivered_products_magazyn
AS
SELECT
Produkt.ID_produkt AS [ID],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
SUM (Dostawa_szczegol.Ilosc) AS [Ilosc]
FROM Dostawa_szczegol
INNER JOIN Produkt ON Produkt.ID_produkt = Dostawa_szczegol.ID_produkt
GROUP BY Produkt.Nazwa, Produkt.ID_produkt, Produkt.Nr_produkt
ORDER BY ID ASC OFFSET 0 ROWS
GO


CREATE VIEW v_Last_180_Sales_hurt
AS
SELECT
DISTINCT Produkt.ID_produkt AS [ID_produktu],
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Nr produktu],
CONVERT (INT, ((v_All_hurt_sold_products.Ilosc/3)*1.2)) AS [Planowany popyt miesiêczny],
Sprzedaz_hurt.Data_sprzedazy AS [Data sprzedazy]
FROM Sprzedaz_szczegol_hurt
INNER JOIN Produkt ON Produkt.ID_produkt = Sprzedaz_szczegol_hurt.ID_produkt
INNER JOIN v_All_hurt_sold_products ON v_All_hurt_sold_products.ID = Sprzedaz_szczegol_hurt.ID_produkt
INNER JOIN Sprzedaz_hurt ON Sprzedaz_hurt.ID_sprzedaz_hurt = Sprzedaz_szczegol_hurt.ID_sprzedaz_hurt
WHERE  Data_sprzedazy >= DATEADD(day,-180, getdate()) and    Data_sprzedazy <= getdate()
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt, Sprzedaz_hurt.Data_sprzedazy, v_All_hurt_sold_products.Ilosc
GO

CREATE VIEW v_Last_180_Sales_detal
AS
SELECT
DISTINCT Produkt.ID_produkt AS [ID_produktu],
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Nr produktu],
CONVERT (INT, ((v_All_detal_sold_products.Ilosc/3)*1.2)) AS [Planowany popyt miesiêczny],
Sprzedaz_detal.Data_sprzedazy AS [Data sprzedazy]
FROM Sprzedaz_szczegol_detal
INNER JOIN Produkt ON Produkt.ID_produkt = Sprzedaz_szczegol_detal.ID_produkt
INNER JOIN v_All_detal_sold_products ON v_All_detal_sold_products.ID = Sprzedaz_szczegol_detal.ID_produkt
INNER JOIN Sprzedaz_detal ON Sprzedaz_detal.ID_sprzedaz_detal = Sprzedaz_szczegol_detal.ID_sprzedaz_detal
WHERE  Data_sprzedazy >= DATEADD(day,-180, getdate()) and    Data_sprzedazy <= getdate()
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt, Sprzedaz_detal.Data_sprzedazy, Sprzedaz_szczegol_detal.Ilosc, v_All_detal_sold_products.Ilosc
GO

CREATE VIEW v_All_avalaible_products
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Produkt.ID_produkt),-999) AS [ID_produktu],
Produkt.Nazwa AS [Nazwa produktu],
Produkt.Nr_produkt AS [Numer produktu],
CASE WHEN (v_All_delivered_products_magazyn.Ilosc - (v_All_detal_sold_products_magazyn.Ilosc + v_All_hurt_sold_products_magazyn_part2.Ilosc)) IS NULL 
THEN v_All_delivered_products_magazyn.Ilosc 
ELSE (v_All_delivered_products_magazyn.Ilosc - (v_All_detal_sold_products_magazyn.Ilosc + v_All_hurt_sold_products_magazyn_part2.Ilosc)) END AS [Stan magazynu]
FROM Produkt
FULL OUTER JOIN v_All_delivered_products_magazyn ON v_All_delivered_products_magazyn.ID = Produkt.ID_produkt
FULL OUTER JOIN v_All_detal_sold_products_magazyn ON v_All_detal_sold_products_magazyn.ID = Produkt.ID_produkt
FULL OUTER JOIN v_All_hurt_sold_products_magazyn_part2 ON v_All_hurt_sold_products_magazyn_part2.ID = Produkt.ID_produkt
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt, v_All_delivered_products_magazyn.Ilosc, v_All_detal_sold_products_magazyn.Ilosc,
v_All_hurt_sold_products_magazyn_part2.Ilosc,
CASE WHEN (v_All_delivered_products_magazyn.Ilosc - (v_All_detal_sold_products_magazyn.Ilosc + v_All_hurt_sold_products_magazyn_part2.Ilosc)) IS NULL 
THEN 0
ELSE (v_All_delivered_products_magazyn.Ilosc - (v_All_detal_sold_products_magazyn.Ilosc + v_All_hurt_sold_products_magazyn_part2.Ilosc)) END
ORDER BY [ID_produktu] ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Popyt_prediction
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Produkt.ID_produkt),-999) AS [ID produktu],
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Nr_produktu],
CASE WHEN (v_Last_180_Sales_detal.[Planowany popyt miesiêczny] + v_Last_180_Sales_hurt.[Planowany popyt miesiêczny]) IS NULL THEN 0
ELSE (v_Last_180_Sales_detal.[Planowany popyt miesiêczny] + v_Last_180_Sales_hurt.[Planowany popyt miesiêczny]) END AS [Planowany_popyt],
v_All_avalaible_products.[Stan magazynu] AS [Stan_magazynowy]
FROM Produkt
INNER JOIN v_Last_180_Sales_detal ON v_Last_180_Sales_detal.ID_produktu = Produkt.ID_produkt
INNER JOIN v_Last_180_Sales_hurt ON v_Last_180_Sales_hurt.ID_produktu = Produkt.ID_produkt
FULL OUTER JOIN v_All_avalaible_products ON v_All_avalaible_products.[Nazwa produktu] = Produkt.Nazwa
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt, 
v_Last_180_Sales_detal.[Planowany popyt miesiêczny], v_Last_180_Sales_hurt.[Planowany popyt miesiêczny],
v_All_avalaible_products.[Stan magazynu], 
CASE WHEN (v_Last_180_Sales_detal.[Planowany popyt miesiêczny] + v_Last_180_Sales_hurt.[Planowany popyt miesiêczny]) IS NULL THEN 0 
ELSE (v_Last_180_Sales_detal.[Planowany popyt miesiêczny] + v_Last_180_Sales_hurt.[Planowany popyt miesiêczny]) END
ORDER BY Produkt.ID_produkt ASC OFFSET 0 ROWS
GO


CREATE VIEW v_Pracownik_add
AS
SELECT
Pracownik.ID_pracownik AS [ID_pracownik],
Pracownik.Imie AS [Imiê],
Pracownik.Nazwisko AS [Nazwisko],
Wyksztalcenie.Nazwa AS [Wykszta³cenie],
Nr_telefon_pracownik.Numer AS [Numer telefonu],
Email_pracownik.Email AS [E-mail],
Dane_adresowe_pracownik.Miejscowosc AS [Miasto],
Dane_adresowe_pracownik.Kod_pocztowy AS [Kod pocztowy],
Dane_adresowe_pracownik.Ulica AS [Ulica],
Dane_adresowe_pracownik.Nr_budynku AS [Numer budynku],
Dane_adresowe_pracownik.Nr_lokalu AS [Numer lokalu],
Pracownik.Nr_dowodu AS [Numer dowodu],
Pracownik.PESEL AS [PESEL]
FROM Pracownik
INNER JOIN Dane_adresowe_pracownik ON Dane_adresowe_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Nr_telefon_pracownik ON Nr_telefon_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Email_pracownik ON Email_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Wyksztalcenie ON Wyksztalcenie.ID_wyksztalcenie = Pracownik.ID_wyksztalcenie
GO


CREATE VIEW v_Zajetosc_magazynow
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Magazyn.ID_magazyn),-999) AS ID,
Magazyn.Nazwa AS [Numer magazynu],
Dzial.Nazwa AS [Nazwa dzia³u],
((Sum(DISTINCT Produkt.Objetosc_magazynowa_m3*v_All_avalaible_products.[Stan magazynu])/Magazyn.Pojemnosc_w_m3))*100 AS [Procent zajetosci]
FROM v_All_avalaible_products
INNER JOIN Produkt ON v_All_avalaible_products.[Nazwa produktu] = Produkt.Nazwa
INNER JOIN Typ_produkt ON Typ_produkt.ID_typ_produkt = Produkt.ID_typ_produkt
INNER JOIN Podkategoria ON Podkategoria.ID_podkategoria = Typ_produkt.ID_podkategoria
INNER JOIN Kategoria ON Kategoria.ID_kategoria = Podkategoria.ID_Kategoria
INNER JOIN Dzial ON Dzial.ID_dzial = Kategoria.ID_dzial
INNER JOIN Magazyn ON Dzial.ID_dzial = Magazyn.ID_dzial
GROUP BY Magazyn.ID_magazyn, Magazyn.Nazwa, Dzial.Nazwa, v_All_avalaible_products.[Stan magazynu], Produkt.ID_produkt, Magazyn.Pojemnosc_w_m3
GO

CREATE VIEW v_Procent_magazyn
AS
SELECT
Magazyn.Nazwa AS [Numer_magazynu],
Dzial.Nazwa AS [Dzia³_magazynu],
sum(v_Zajetosc_magazynow.[Procent zajetosci]) AS [Procent]
FROM Magazyn
INNER JOIN v_Zajetosc_magazynow ON v_Zajetosc_magazynow.[Numer magazynu] = Magazyn.Nazwa
INNER JOIN Dzial ON Dzial.ID_dzial = Magazyn.ID_dzial
GROUP BY Magazyn.Nazwa, Dzial.Nazwa, Magazyn.ID_magazyn
ORDER BY Magazyn.ID_magazyn ASC OFFSET 0 ROWS
GO


CREATE VIEW v_Zwroty_detal
AS
SELECT
Produkt.ID_produkt AS [ID_produkt],
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Nr produktu],
Sum(Szczegol_reklamacja_detal.Ilosc) AS [Ilosc]
FROM Szczegol_reklamacja_detal
INNER JOIN Produkt ON Produkt.ID_produkt = Szczegol_reklamacja_detal.ID_produkt
WHERE Szczegol_reklamacja_detal.ID_typ_reklamacja = 0
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt
GO

CREATE VIEW v_Zwroty_hurt
AS
SELECT
Produkt.ID_produkt AS [ID_produkt],
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Nr produktu],
Sum(Szczegol_reklamacja_hurt.Ilosc) AS [Ilosc]
FROM Szczegol_reklamacja_hurt
INNER JOIN Produkt ON Produkt.ID_produkt = Szczegol_reklamacja_hurt.ID_produkt
WHERE Szczegol_reklamacja_hurt.ID_typ_reklamacja = 0
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt
GO

CREATE VIEW v_Zwroty
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Produkt.ID_produkt),-999) AS ID,
Produkt.Nazwa AS [Produkt],
Produkt.Nr_produkt AS [Nr_produktu],
CASE WHEN v_Zwroty_detal.Ilosc + v_Zwroty_hurt.Ilosc IS NULL THEN 0 ELSE v_Zwroty_detal.Ilosc + v_Zwroty_hurt.Ilosc END AS [Ilosc]
FROM Produkt
FULL OUTER JOIN v_Zwroty_detal ON v_Zwroty_detal.ID_produkt = Produkt.ID_produkt
FULL OUTER JOIN v_Zwroty_hurt ON v_Zwroty_hurt.ID_produkt = Produkt.ID_produkt
GROUP BY Produkt.ID_produkt, Produkt.Nazwa, Produkt.Nr_produkt, v_Zwroty_detal.Ilosc, v_Zwroty_hurt.Ilosc,
CASE WHEN v_Zwroty_detal.Ilosc + v_Zwroty_hurt.Ilosc IS NULL THEN 0 ELSE v_Zwroty_detal.Ilosc + v_Zwroty_hurt.Ilosc END
ORDER BY Produkt.ID_produkt ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Producent_alpha
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Producent.ID_producent),-999) AS ID,
Producent.Nazwa AS Nazwa
FROM Producent
ORDER BY Producent.Nazwa ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Dzial_alpha
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Dzial.ID_dzial),-999) AS ID,
Dzial.Nazwa AS Nazwa
FROM Dzial
ORDER BY Dzial.Nazwa ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Kategoria_alpha
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Kategoria.ID_kategoria),-999) AS ID,
Kategoria.Nazwa AS Nazwa
FROM Kategoria
ORDER BY Kategoria.Nazwa ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Podkategoria_alpha
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Podkategoria.ID_podkategoria),-999) AS ID,
Podkategoria.Nazwa AS Nazwa
FROM Podkategoria
ORDER BY Podkategoria.Nazwa ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Typ_alpha_2
AS
SELECT
ISNULL(ROW_NUMBER() OVER(ORDER BY Typ_produkt.ID_typ_produkt),-999) AS ID,
Typ_produkt.Nazwa AS Nazwa
FROM Typ_produkt
ORDER BY Typ_produkt.Nazwa ASC OFFSET 0 ROWS
GO



--SELECT * FROM v_Dzial_budowa
--SELECT * FROM v_Zwroty_detal
--SELECT * FROM v_Zwroty
--SELECT * FROM v_All_avalaible_products
--SELECT * FROM v_All_delivered_products_magazyn
--SELECT * FROM v_All_detal_sold_products_magazyn
--SELECT * FROM v_All_hurt_sold_products_magazyn
--SELECT * FROM v_Oferta_handlowa_szczegol

