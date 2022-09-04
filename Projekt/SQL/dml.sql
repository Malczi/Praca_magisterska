USE master
GO
USE MGR
GO

INSERT INTO Dzial (Nazwa)
	VALUES
	('Budowa'),
	('Ogr�d i wypoczynek'),
	('Technika'),
	('Mieszkanie'),
	('Kuchnia'),
	('�azienka');

INSERT INTO Kategoria (Nazwa, ID_dzial)
	VALUES
	('Materia�y budowlane',1),
	('Drewno budowlane',1),
	('Drzwi',1),
	('Okna',1),
	('Schody i balustrady',1),
	('Ro�liny',2),
	('Maszyny ogrodowe',2),
	('Grille',2),
	('Lampy zewn�trzne',2),
	('Meble ogrodowe',2),
	('Elektronarz�dzia',3),
	('Narz�dzia r�czne',3),
	('Du�e maszyny',3),
	('Od�nie�arki i zamiatarki',3),
	('Maszyny czyszcz�ce',3),
	('O�wietlenie',4),
	('Meble',4),
	('Pod�ogi',4),
	('Farby i lakiery',4),
	('Tapety',4),
	('Aneksy kuchenne',5),
	('AGD',5),
	('Baterie kuchenne',5),
	('Meble kuchenne',5),
	('Okapy kuchenne',5),
	('Meble �azienkowe',6),
	('Lustra �azienkowe',6),
	('Wanny',6),
	('Prysznice i akcesoria',6),
	('Toalety',6);

INSERT INTO Podkategoria (Nazwa, ID_kategoria)
	VALUES
	('Tynki, zaprawy i cement',1),
	('Materia�y izolacyjne',1),
	('Drewno nieheblowane',2),
	('Drewno heblowane',2),
	('Drzwi zewn�trzne',3),
	('Klamki do drzwi',3),
	('Okna PCV',4),
	('Parapety',4),
	('Schody wewn�trzne',5),
	('Por�cze i balustrady',5),
	('Kwiaty doniczkowe',6),
	('Krzewy',6),
	('Kosiarki',7),
	('Pi�y �a�cuchowe',7),
	('Grille w�glowe',8),
	('Grille gazowe',8),
	('Kinkiety zewn�trzne',9),
	('O�wietlenie dekoracyjne zewn�trzne',9),
	('Zestawy wypoczynkowe',10),
	('�awki ogrodowe',10),
	('Wiertarki i wkr�tarki',11),
	('Opalarki',11),
	('Pi�y i pilniki',12),
	('Klucze i zestawy kluczy',12),
	('Agregaty pr�dotw�rcze',13),
	('Wyci�garki',13),
	('Spalinowe od�nie�arki',14),
	('Zamiatarki',14),
	('Myjki wysoko�i�nieniowe i akcesoria',15),
	('Odkurzacze',15),
	('Lampy do wn�trz',16),
	('O�wietelenie LED',16),
	('Rega�y',17),
	('��ka',17),
	('Sto�y',17),
	('Krzes�a',17),
	('Panele pod�ogowe i pod�ogi drewniane',18),
	('Dywany',18),
	('Farby do wn�trz',19),
	('Lakiery specjalistyczne',19),
	('Tapety dekoracyjne',20),
	('Tapety do malowania',20),
	('Zestawy mebli kuchennych',21),
	('Kuchenki',22),
	('Lod�wki',22),
	('Zmywarki',22),
	('Jednouchwytowe baterie z mieszaczem',23),
	('Armatura dwuchwytowa',23),
	('Szafki kuchenne',24),
	('Blaty kuchenne',24),
	('Okapy nad wysp�',25),
	('Okapy �cienne',25),
	('Umywalki',26),
	('Szafki �azienkowe',26),
	('Szafki z lustrem',27),
	('Lustra',27),
	('Wanny',28),
	('Wanny wolnostoj�ce',28),
	('Brodziki prysnicowe',29),
	('Kabiny prysznicowe',29),
	('WC',30),
	('Bidety',30);

INSERT INTO Typ_produkt (Nazwa, ID_podkategoria)
	VALUES
	('Cement',1),								--1
	('Tynk',1),									--2	
	('Zaprawa',1),								--3
	('We�na izolacyjna',2),						--4
	('Styropian',2),							--5
	('Kant�wka',3),								--6
	('�ata monta�owe',3),						--7
	('Kant�wka',4),								--8
	('Drewno konstrukcyjne',4),					--9
	('Prawe',5),								--10			
	('Lewe',5),									--11
	('Otwarte',6),								--12
	('Zamkni�te',6),							--13
	('Okna',7),									--14
	('Nawiewniki',7),							--15
	('Wewn�trzne',8),							--16
	('Zewn�trzne',8),							--17
	('Schody na pi�tro',9),						--18
	('Schody strychowe',9),						--19
	('Drewniane',10),							--20
	('Metalowe',10),							--21
	('Ro�liny zielone',11),						--22
	('Ro�liny kwiatowe',11),					--23
	('Iglaste',12),								--24
	('Li�ciaste',12),							--25
	('Kosiarki spalinowe',13),					--26
	('Ko�iarki elektryczne',13),				--27
	('Pi�y spalinowe',14),						--28
	('Pi�y elektryczne',14),					--29
	('Stal chromowana',15),						--30
	('�eliwne',15),								--31
	('Stalowe',16),								--32
	('�eliwne',16),								--33
	('Z czujnikiem ruchu',17),					--34
	('Bez czujnika ruchu',17),					--35
	('Z zewn�trznym modu�em s�onecznym',18),	--36
	('Bez zewn�trznego modu�u s�onecznego',18), --37
	('Zestawy',19),								--38
	('Kanapy',19),								--39
	('Fotele',19),								--40
	('Drewniane',20),							--41
	('Tworzywo sztuczne',20),					--42
	('Wiertarki',21),							--43
	('Wkr�tarki',21),							--44
	('Moc: 1000W',22),							--45
	('Moc: 2000W',22),							--46
	('Pi�y',23),								--47
	('Pilniki',23),								--48
	('Zestawy',24),								--49
	('Pojedyncze',24),							--50
	('Gniazdo 230V',25),						--51
	('Gniazdo 2 x 230V',25),					--52
	('Ud�wig powy�ej 500kg',26),				--53
	('Ud�wig do 500kg',26),						--54
	('Z nap�dem',27),							--55
	('Bez nap�du',27),							--56
	('Mokre',28),								--57
	('Suche',28),								--58
	('Moc do 2000W',29),						--59
	('Moc powy�ej 2000W',29),					--60
	('Praca na mokro',30),						--61
	('Praca na sucho',30),						--62
	('Lampy stoj�ce',31),						--63
	('Lampy wisz�ce',31),						--64
	('�ar�wki LED',32),							--65
	('Ta�my LED',32),							--66
	('Metalowe',33),							--67
	('Tworzywo sztuczne',33),					--68
	('Stela�e',34),								--69
	('Materace',34),							--70
	('Biurka',35),								--71
	('Salonowe',35),							--72
	('Biurowe',36),								--73
	('Salonowe',36),							--74
	('Panele pod�ogowe',37),					--75
	('Pod�ogi drewniane',37),					--76
	('Chodniki',38),							--77
	('Wyk�adziny dywanowe',38),					--78
	('Bia�e',39),								--79
	('Kolorowe',39),							--80
	('Lakiery do drzwi',40),					--81
	('Lakiery do okien',40),					--82
	('Flizelinowa',41),							--83
	('Papierowa',41),							--84
	('Winylowa',41),							--85
	('Papierowa',42),							--86
	('Flizelinowa',42),							--87
	('Seria Nika',43),							--88
	('Seria Napoli',43),						--89
	('Seria Galia',43),							--90
	('P�yty',44),								--91
	('Z piekarnikiem',44),						--92
	('Lod�wki do zabudowy',45),					--93
	('Ch�odziarko zamra�arki',45),				--94
	('Zmywarki do zabudowy',46),				--95
	('Z natryskiem',47),						--96
	('Bez natrysku',47),						--97
	('Chromowane',48),							--98
	('Matowe',48),								--99
	('Szafki do zabudowy',49),					--100
	('Szafki do przechowywania',49),			--101
	('Jasne',50),								--102
	('Ciemne',50),								--103
	('Chromowane',51),							--104
	('Matowe',51),								--105
	('Chromowane',52),							--106
	('Matowe',52),								--107
	('Jasne',53),								--108
	('Ciemne',53),								--109
	('1-drzwiowe',54),							--110
	('3-drzwiowe',54),							--111
	('1-drzwiowe',55),							--112
	('3-drzwiowe',55),							--113
	('Z o�wietleniem',56),						--114
	('Bez o�wietlenia',56),						--115
	('Prostok�tne',57),							--116
	('Naro�ne',57),								--117
	('Owalne',58),								--118
	('Asymetryczne',58),						--119	
	('P�okr�g�e',59),							--120
	('Prostok�tne',59),							--121
	('Prostok�tne',60),							--122
	('P�okr�g�e',60),							--123
	('Wisz�ce',61),								--124
	('Stoj�ce',61),								--125
	('Wisz�ce',62),								--126
	('Stoj�ce',62);								--127

INSERT INTO Jednostka (Nazwa)
	VALUES
	('szt.'),                                   --1
	('m2'),										--2
	('m3'),										--3
	('stopni Celcjusza'),						--4
	('kg'),										--5
	('m');										--6

INSERT INTO Producent (Nazwa, Adres_URL)
	VALUES 
	('GardenCompany','www.gardencompany.pl'),
	('FlorMaster','www.flormaster.pl'),
	('Herman','www.herman.pl'),
	('Cersanit','www.cersanit.pl'),
	('Oknoplasy','www.oknoplast.pl');

INSERT INTO Gwarancja (Opis_gwarancja, Okres_gwarancja)
	VALUES 
	('GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 2 LAT',2),
	('GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 1 ROKU',1),
	('GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 3 LAT',3),
	('GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 4 LAT',4),
	('GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 5 LAT',5);

INSERT INTO Produkt (Nazwa, ID_producent, ID_typ_produkt, Nr_produkt, Cena_sugerowana_netto, Termin_magazynowania_miesiace, Termin_przydatnosci_miesiace, Objetosc_magazynowa_m3,
ID_gwarancja)
	VALUES
	('Palma Livistona Roundifolia',1,22,6740831,119.00,6,NULL,0.1,1),
	('Swiss Krono Panel pod�ogowy D�b Mateo 8 mm AC 4',2,75,6396980,95.85,NULL,NULL,0.1,5),
	('Pantor Drzwi zewn�trzne Rodan antracyt 80P',3,11,6340756,1299.00,12,NULL,1.2,5),
	('INKER Kompakt WC poziomy Modena',4,125,3113263,349.00,24,NULL,1.6,5),
	('ACO Okno gospodarcze ACO Kipp bia�e 100 cm x 60 cm',5,14,6224950,259.00,24,NULL,0.6,5);

INSERT INTO Typ_magazynowania (Nazwa)
	VALUES
	('Magazyn zewn�trzny'),
	('Magazyn wewn�trzny'),
	('Magazyn suchy'),
	('Magazyn mokry'),
	('Magazyn klimatyzowany');

INSERT INTO Parametr_typ_magazynowania (ID_typ_magazynowania, Parametr, Wartosc_dolna, Wartosc_gorna, ID_jednostka)
	VALUES
	(1,'Pojemno�� w m3',500,500000,3),
	(2,'Pojemno�� w m3',500,500000,3),
	(2,'Temperatura',15,20,4),
	(3,'Pojemno�� w m3',500,500000,3),
	(3,'Temperatura',15,20,4),
	(4,'Pojemno�� w m3',500,500000,3),
	(5,'Pojemno�� w m3',500,500000,3),
	(5,'Temperatura',16,18,4);

INSERT INTO Poziom_magazynowanie (Poziom)
	VALUES
	('Poziom 1'),
	('Poziom 2'),
	('Poziom 3'),
	('Poziom 4'),
	('Poziom 5'),
	('Poziom 6'),
	('Poziom 7');

INSERT INTO Parametr_poziom_magazynowanie (ID_poziom_magazynowanie, Parametr, Wartosc_dolna, Wartosc_gorna, ID_jednostka)
	VALUES
	(1,'Ud�wig w kg',0,6000,5),
	(2,'Ud�wig w kg',0,5000,5),
	(3,'Ud�wig w kg',0,4000,5),
	(4,'Ud�wig w kg',0,3000,5),
	(5,'Ud�wig w kg',0,2000,5),
	(6,'Ud�wig w kg',0,1000,5),
	(7,'Ud�wig w kg',0,500,5);

INSERT INTO Magazyn	
	VALUES
	('Magazyn 1',50000,1,2),
	('Magazyn 2',50000,2,3),
	('Magazyn 3',50000,3,5),
	('Magazyn 4',50000,4,2),
	('Magazyn 5',50000,5,5),
	('Magazyn 6',50000,6,3);

INSERT INTO Miejsce_magazynowania (ID_produkt, ID_magazyn, ID_typ_magazynowania, ID_poziom_magazynowanie, Nr_miejsca)
	VALUES
	(1,1,2,7,12),
	(2,2,2,6,10),
	(3,3,2,3,25),
	(4,4,2,2,72),
	(5,5,2,1,12);

INSERT INTO Slownik_atrybut (Nazwa, ID_jednostka)
	VALUES
	('Szeroko��',6),
	('D�ugo��',6),
	('Wysko��',6),
	('Masa',5),
	('Ud�wig',5);

INSERT INTO Atrybut (ID_produkt, ID_slownik_atrybut, Wartosc)
	VALUES 
	(1,1,0.1),
	(1,2,0.2),
	(1,3,0.4),
	(1,4,0.3),
	(2,1,0.1),
	(2,2,0.2),
	(2,3,0.4),
	(2,4,0.3),
	(3,1,0.1),
	(3,2,0.2),
	(3,3,0.4),
	(3,4,0.3),
	(4,1,0.1),
	(4,2,0.2),
	(4,3,0.4),
	(4,4,0.3),
	(5,1,0.1),
	(5,2,0.2),
	(5,3,0.4),
	(5,4,0.3);

INSERT INTO Usluga (Nazwa, Cena)
	VALUES
	('Wysy�ka',19.99),
	('Monta�', 150.00);

INSERT INTO Wyksztalcenie (Nazwa)
	VALUES
	('Podstawowe'),
	('�rednie bran�owe'),
	('�rednie'),
	('In�ynier'), 
	('Wy�sze');

INSERT INTO Pracownik (Nazwisko, Imie, Nr_dowodu, PESEL, ID_wyksztalcenie)
	VALUES
	('St�pie�','Cyprian','WKD280139','79011740953',5),
	('Kaczmarczyk','Alan','HAX969224','93091338824',5),
	('Chmielewski','Patryk','IOO219297','63041501141',5),
	('Sadowski','Aleks','QHK228993','60071024949',5),
	('Szyma�ski','Julian','VZB053425','52010239293',4),
	('Mazurek','Andrzej','XAQ952177','84102022764',4),
	('B�k','Marian','ZWF458058','77090820874',4),
	('Witkowski','Albert','INP326487','85101668014',2),
	('Adamski','Marian','IEG911588','93110702564',2),
	('Sawicki','Martin','RXD734838','59011957201',2),
	('Wasilewska','Wiktoria','NBV262900','60080638650',3),
	('Tomaszewska','Zofia','AZS447082','92121215667',3),
	('Ka�mierczak','Karolina','SUP379301','66031085212',5),
	('Wr�blewska','Anna','RKX574945','65123109441',5),
	('Makowska','Gabriela','SIU515159','85040388301',4),
	('Borkowska','Diana','VJX004993','89092653132',4),
	('W�odarczyk','Weronika','FOU333301','93080402772',1);

INSERT INTO Email_pracownik (ID_pracownik, Email, Data_od, Data_do)
	VALUES
	(1,'stepien.cuprian@mail.com','2022-01-01', NULL),
	(2,'kaczmarczyk.alan@mail.com','2022-01-01', NULL),
	(3,'chmielewski.patryk@mail.com','2022-01-01', NULL),
	(4,'sadowski.aleks@mail.com','2022-01-01', NULL),
	(5,'szymanski.julian@mail.com','2022-01-01', NULL),
	(6,'mazurek.andrzej@mail.com','2022-01-01', NULL),
	(7,'bak.marian@mail.com','2022-01-01', NULL),
	(8,'witkowski.albert@mail.com','2022-01-01', NULL),
	(9,'adamski.marian@mail.com','2022-01-01', NULL),
	(10,'sawicki.martin@mail.com','2022-01-01', NULL),
	(11,'wasilewska.wiktoria@mail.com','2022-01-01', NULL),
	(12,'tomaszewska.zofia@mail.com','2022-01-01', NULL),
	(13,'kazimierczak.karolina@mail.com','2022-01-01', NULL),
	(14,'wroblewska.anna@mail.com','2022-01-01', NULL),
	(15,'makowska.gabriela@mail.com','2022-01-01', NULL),
	(16,'borkowska.diana@mail.com','2022-01-01', NULL),
	(17,'wlodarczyk.weronika@mail.com','2022-01-01', NULL);

INSERT INTO Dane_adresowe_pracownik (ID_pracownik, Miejscowosc, Ulica, Nr_budynku, Nr_lokalu, Kod_pocztowy, Data_od, Data_do)
	VALUES
	(1, 'Warszawa', 'Jana Paw�a II', '21', '37', '02-137', '2021-04-14',NULL),
	(2, 'Marki', 'Markowa', '23', '11', '12-000', '2019-08-14',NULL),
	(3, 'Warszawa', 'Kombatant�w', '6', '26', '11-500', '2020-02-13',NULL),
	(4, 'Warszawa', 'Kr�lowej Jadwigi', '11', '20', '02-347', '2020-04-19',NULL),
	(5, 'Warszawa', 'Ko�ciuszki', '51', '32', '02-952', '2018-10-02',NULL),
	(6, 'Marki', 'D�uga', '1', '1', '12-301', '2019-03-09',NULL),
	(7, 'Warszawa', 'Kr�tka', '2','2','02-022', '2021-06-11',NULL),
	(8, 'Warszawa', '�rednia', '3','3','01-437', '2021-06-11',NULL),
	(9, 'Warszawa', 'Kaliskiego', '2', '11', '01-534', '2020-02-11',NULL),
	(10, 'Warszawa', 'G�rczewska', '11', '20', '03-321', '2020-01-13',NULL),
	(11, 'Marki', 'Naturalna', '21', '36', '08-808', '2018-07-13',NULL), 
	(12, 'Pruszk�w', 'Wiejska', '13', '32', '11-111', '2017-05-13',NULL),
	(13, 'Warszawa',' Po�czy�ska', '2','33', '01-910', '2018-01-01',NULL),
	(14, 'Warszawa', 'Al. Jerozolimskie', '5','10', '02-147', '2017-01-01',NULL),
	(15, 'Pruszk�w', 'Marsza�kowska', '1', '1', '03-332', '2019-01-01',NULL),
	(16, 'Pruszk�w', 'Prosta', '27', '22', '01-712', '2020-01-01',NULL),
	(17, 'Pruszk�w', 'Karolkowa' ,'3', '34', '04-543', '2022-01-01',NULL);

INSERT INTO Nr_telefon_pracownik (ID_pracownik, Numer, Data_od, Data_do)
	VALUES
	(1,'123123123','2022-01-01', NULL),
	(2,'321321321','2022-02-01', NULL),
	(3,'456456456','2021-12-10', NULL),
	(4,'321321321','2020-05-01', NULL),
	(5,'321321321','2021-06-01', NULL),
	(6,'852963711','2021-06-01', NULL),
	(7,'741852963','2021-06-01', NULL),
	(8,'147258369','2021-06-01', NULL),
	(9,'753951456','2021-06-01', NULL),
	(10,'951753852','2021-06-01', NULL),
	(11,'357951852','2021-06-01', NULL),
	(12,'998774112','2021-06-01', NULL),
	(13,'525858747','2021-06-01', NULL),
	(14,'564825915','2021-06-01', NULL),
	(15,'987321645','2021-06-01', NULL),
	(16,'826487520','2021-06-01', NULL),
	(17,'650380478','2021-06-01', NULL);

INSERT INTO Dzial_pracownik (Nazwa_dzial_pracownik)
	VALUES
	('Zarz�d'),
	('Dzia� kadr'),
	('Dzia� sprzeda�y'),
	('Dzia� logistyki i magazynu'),
	('Dzia� utrzymania czysto�ci');

INSERT INTO Stanowisko (Nazwa_stanowiska, ID_dzial_pracownik)
	VALUES
	('Prezes',1),
	('Kierownik zarz�du',1),
	('Wiceprezes',1),
	('Kadrowa',2),
	('Handlowiec',3),
	('Sprzedawca',3),
	('Magazynier',4),
	('Operator w�zka wid�owego',4),
	('Sprz�taczka',5);

INSERT INTO Etat (ID_stanowisko, Liczba_miejsc)
	VALUES
	(1,1),
	(2,3),
	(3,2),
	(4,2),
	(5,10),
	(6,50),
	(7,50),
	(8,15),
	(9,30);

INSERT INTO Posada_pracownika (ID_etat, Data_od, Data_do)
	VALUES
	(1,'2022-04-10', NULL),
	(2,'2022-04-10', NULL),
	(3,'2022-04-10', NULL),
	(4,'2022-04-10', NULL),
	(5,'2022-04-10', NULL),
	(6,'2022-04-10', NULL),
	(7,'2022-04-10', NULL),
	(8,'2022-04-10', NULL),
	(9,'2022-04-10', NULL);

INSERT INTO Rodzaj_umowy (Nazwa, Urlop)
	VALUES
	('Umowa o prac�',26),
	('Umowa zlecenie',0),
	('Umowa o dzie�o',0);

INSERT INTO Rodzaj_nieobecnosci (Symbol, Wspolczynnik_wynagrodzenia)
VALUES
	('UW',0),
	('CH',-0.2),
	('NB',-1.0);

INSERT INTO Nieobecnosc (ID_pracownik, ID_rodzaj_nieobecnosci, Data_od, Data_do)
VALUES
	(1,1,'2022-04-11','2022-04-24'),
	(2,2,'2022-04-12','2022-04-16'),
	(3,2,'2022-04-18','2022-04-19'),
	(4,2,'2022-04-13','2022-04-14'),
	(5,3,'2022-04-13','2022-04-19'),
	(6,2,'2022-04-13','2022-04-15'),
	(7,1,'2022-04-13','2022-04-15'),
	(8,1,'2022-04-13','2022-04-15'),
	(9,1,'2022-04-13','2022-04-15'),
	(10,1,'2022-04-13','2022-04-15');

INSERT INTO Wymiar_pracy (Nazwa, Wspolczynnik_wynagrodzenia)
	VALUES
	('Pe�ny etat',1.0),
	('P� etatu',0.5);

INSERT INTO Umowa (ID_wymiar_pracy, ID_rodzaj_umowy, ID_pracownik, ID_posada_pracownika, Wynagrodzenie)
	VALUES
	(1,1,1,1,5000),
	(1,1,2,4,4000),
	(1,1,3,5,3600),
	(2,2,4,3,5500),
	(2,1,5,2,5500),
	(2,2,06,3,4500),
	(1,1,07,4,4500),
	(1,2,8,4,3500),
	(1,2,9,8,5500),
	(1,1,10,9,6000),
	(2,1,11,1,7000),
	(2,1,12,2,5000),
	(1,1,13,8,3600),
	(1,1,14,8,3600),
	(1,1,15,9,2500),
	(1,1,16,7,6000),
	(1,1,17,5,5000);

INSERT INTO Rodzaj_nadgodziny (Nazwa)
	VALUES 
	('Nadrabianie zaleg�o�ci'),
	('Iwentaryzacja'),
	('Praca dodatkowa');

INSERT INTO Nadgodziny (ID_pracownik, Data_nadgodziny, ID_rodzaj_nadgodziny, Czas)
	VALUES
	(5,'2022-05-06',2,8),
	(7,'2022-05-06',2,8),
	(8,'2022-05-06',2,8);

INSERT INTO Czas_pracy (ID_pracownik, Data_pracy, Liczba_godzin)
	VALUES
	(1,'2022-06-01',8),
	(2,'2022-06-01',8),
	(3,'2022-06-01',8),
	(4,'2022-06-01',8),
	(5,'2022-06-01',8),
	(6,'2022-06-01',8),
	(7,'2022-06-01',8),
	(8,'2022-06-01',8),
	(9,'2022-06-01',8),
	(10,'2022-06-01',8),
	(11,'2022-06-01',8),
	(12,'2022-06-01',8),
	(13,'2022-06-01',8),
	(14,'2022-06-01',8),
	(15,'2022-06-01',8),
	(16,'2022-06-01',8),
	(17,'2022-06-01',8);

INSERT INTO Wyplata (ID_Pracownik, Data_wyplaty)
	VALUES
	(1,'2022-06-28'),
	(2,'2022-06-28'),
	(3,'2022-06-28'),
	(4,'2022-06-28'),
	(5,'2022-06-28'),
	(6,'2022-06-28'),
	(7,'2022-06-28'),
	(8,'2022-06-28'),
	(9,'2022-06-28'),
	(10,'2022-06-28'),
	(11,'2022-06-28'),
	(12,'2022-06-28'),
	(13,'2022-06-28'),
	(14,'2022-06-28'),
	(15,'2022-06-28'),
	(16,'2022-06-28'),
	(17,'2022-06-28');

INSERT INTO Typ_szkolenie (Nazwa)
	VALUES
	('Szkolenie wst�pne'),
	('Szkolenie BHP'),
	('Szkolenie zawodowe'),
	('Szkolenie bran�owe');

INSERT INTO Szkolenie_pracownik (ID_typ_szkolenie, ID_pracownik, Data_od, Data_do)
	VALUES
	(2,1,'2022-05-25','2022-05-26'),
	(2,2,'2022-05-25','2022-05-26'),
	(2,3,'2022-05-25','2022-05-26'),
	(2,4,'2022-05-25','2022-05-26'),
	(2,5,'2022-05-25','2022-05-26'),
	(2,6,'2022-05-25','2022-05-26'),
	(2,7,'2022-05-25','2022-05-26'),
	(2,8,'2022-05-25','2022-05-26'),
	(2,9,'2022-05-25','2022-05-26'),
	(2,10,'2022-05-25','2022-05-26'),
	(2,11,'2022-05-25','2022-05-26'),
	(2,12,'2022-05-25','2022-05-26'),
	(2,13,'2022-05-25','2022-05-26'),
	(2,14,'2022-05-25','2022-05-26'),
	(2,15,'2022-05-25','2022-05-26'),
	(2,16,'2022-05-25','2022-05-26'),
	(2,17,'2022-05-25','2022-05-26');

INSERT INTO Dostawca (Nazwa, Nr_telefon, Adres_email, Kod_pocztowy, Miasto, Ulica, Nr_budynku, Nr_lokalu, NIP)
	VALUES
	('Budex', 852123654, 'budex@mail.com', '58-512', 'Warszawa', 'Budowlana', 12, NULL, '5647892139'),
	('Ogrodex', 585214554, 'ogrodex@mail.com', '58-502', 'Warszawa', 'Ogrodowa', 32, 12, '5600092139'),
	('Techmax', 852543654, 'techmax@mail.com', '12-512', 'Warszawa', 'Techniczna', 69, NULL, '1247892139'),
	('Flatix', 222123654, 'flatix@mail.com', '00-123', 'Warszawa', 'Mieszkalna', 112, 2, '6847892139'),
	('Kuchmax', 562123654, 'kuchmax@mail.com', '03-512', 'Warszawa', 'Kulinarna', 3, NULL, '0347892139'),
	('�a�mix', 852123654, 'lazmix@mail.com', '05-521', 'Warszawa', 'Prysznicowa', 5, NULL, '5687892139');

INSERT INTO Dostawa (ID_dostawca, ID_pracownik, Data_dostawa)
	VALUES
	(1,16,'2022-06-05'),
	(2,16,'2022-06-05'),
	(3,16,'2022-06-05'),
	(4,16,'2022-06-05'),
	(5,16,'2022-06-05');

INSERT INTO Dostawa_szczegol (ID_dostawa, ID_produkt, Ilosc, Cena_szt)
	VALUES 
	(1,1,200,15.99),
	(2,2,150,150.99),
	(3,3,100,1585.99),
	(4,4,100,113.99),
	(5,5,150,9.99),
	(5,1,50,15.99);

INSERT INTO Status_dostawa (Nazwa_status)
	VALUES 
	('W trakcie realizacji'),
	('Do roz�adunku'),
	('Zrealizowana');

INSERT INTO Stan_realizacji_dostawa (ID_dostawa, ID_status_dostawa, Data_st, ID_pracownik)
	VALUES
	(1,2,'2022-04-16 09:10:00',16),
	(2,2,'2022-04-16 09:20:00',16),
	(3,2,'2022-04-16 09:30:00',16),
	(4,1,'2022-04-16 09:40:00',16),
	(5,1,'2022-04-16 09:50:00',16);

INSERT INTO Typ_pojazd_transport (Nazwa)
	VALUES
	('Transport wewn�trzny'),
	('Transport zewn�trzny');

INSERT INTO Rodzaj_pojazd_transport (Nazwa)
	VALUES
	('TIR'),
	('Pojazd dostawczy'),
	('W�zek wid�owy');

INSERT INTO Stan_techniczny_pojazd_transport (Nazwa)
	VALUES
	('Sprawny'),
	('Niesprawny'),
	('W trakcie obs�ugi');

INSERT INTO Typ_paliwa (Nazwa)
	VALUES
	('PB95'),
	('ON');

INSERT INTO Pojazd_transport (Marka, Model, Nr_rejestracyjny, ID_typ_pojad_transport, ID_rodzaj_pojazd_transport, ID_stan_techniczny_pojazd_transport,
Sr_spalanie_wg_producenta, ID_typ_paliwa)
	VALUES
	('MAN', 'TGX', 'WI1235',1,1,1,25.3,2),
	('MAN', 'TGX', 'WI1236',1,1,1,25.3,2),
	('MAN', 'TGX', 'WI1237',1,1,1,25.3,2),
	('MAN', 'TGE', 'WI1238',2,2,1,15.3,2),
	('MAN', 'TGE', 'WI1239',2,2,1,15.3,2),
	('MAN', 'TGE', 'WI1210',2,2,1,15.3,2),
	('Toyota', 'Seria 8', NULL, 1,3,1,3.0,2),
	('Toyota', 'Seria 8', NULL, 1,3,1,3.0,2),
	('Toyota', 'Seria 8', NULL, 1,3,1,3.0,2);

INSERT INTO Typ_parametr_pojazd_transport (Nazwa, ID_jednostka)
	VALUES
	('Ud�wig', 5),
	('�adowno��', 5),
	('Pojemno��', 3);

INSERT INTO Parametr_rodzaj_transport (ID_pojazd_transport, ID_typ_parametr_pojazd_transport, Wartosc)
	VALUES
	(1,2,25000.0),
	(2,2,25000.0),
	(3,2,25000.0),
	(4,2,3500.0),
	(5,2,3500.0),
	(6,2,3500.0),
	(7,1,1500.0),
	(8,1,1500.0),
	(9,1,1500.0);

INSERT INTO Rozladunek (ID_dostawa, ID_pojazd_transport, ID_pracownik, Data_rozladunek)
	VALUES
	(1,8,16,'2022-06-10'),
	(2,8,16,'2022-06-10'),
	(3,9,16,'2022-06-10');

INSERT INTO Rabat (Nazwa, Rabat)
	VALUES 
	('Rabat 5%', 0.05),
	('Rabat 10%', 0.10),
	('Rabat 15%', 0.15),
	('Rabat 20%', 0.20),
	('Rabat 25%', 0.25),
	('Rabat 30%', 0.30),
	('Rabat 35%', 0.35),
	('Rabat 40%', 0.40),
	('Rabat 45%', 0.45),
	('Rabat 50%', 0.50);

INSERT INTO Status_klient (Nazwa, ID_rabat)
	VALUES
	('Diamond member', 10),
	('Gold member', 8),
	('Silver member', 6),
	('Blue member', 4),
	('Member', 2);

INSERT INTO Klient (Nazwisko, Imie, Nazwa_firmy, NIP, Nr_telefonu_1, Nr_telefonu_2, Email, Miasto, Kod_pocztowy, Ulica, Nr_domu, Nr_lokalu, ID_status_klient)
	VALUES 
	('B�aszczyk','Julia','Buildingbay','3925771972','+48508553515',NULL,'blaszyk.julia@mail.com','Warszawa','01-965','Warszawska',5,2,5),
	('Witkowska','Asia','Evash','3385364050','+48508553511',NULL,'witkowska.asia@mail.com','Warszawa','01-965','Lubelska',5,2,4),
	('Kwiatkowska','Olimpia','Bw Rocs','7986369864','+48508553512',NULL,'kwiatkowska.olimia@mail.com','Warszawa','01-965','Podkarpacka',5,2,3),
	('Walczak','Paula','Interiors','3947707007','+48508553513',NULL,'walczak.paula@mail.com','Warszawa','01-965','Bia�ostocka',5,2,2),
	('G�owacka','Wanda','Interiors','1196266517','+48508553514',NULL,'glowacka.wanda@mail.com','Warszawa','01-965','Rzeszowska',5,2,1),
	('Szyma�ski','Kamil','Aero','3939314836','+48508553517',NULL,'szymanski.kamil@mail.com','Warszawa','01-965','Gda�ska',5,2,5),
	('Ko�odziej','Miron','Sierra De Hartford','1111924156','+48508553518',NULL,'kolodziej.miron@mail.com','Warszawa','01-965','Sopcka',5,2,4),
	('Michalak','Eugeniusz','Ariq Enclosures','9529657698','+48508553519',NULL,'michalak.eugeniusz@mail.com','Warszawa','01-965','Wroc�awska',5,2,3),
	('Mr�z','Joachim','Lokaan Plaza','9311755001','+48508553510',NULL,'mroz.joachim@mail.com','Warszawa','01-965','Pozna�ska',5,2,2),
	('Zalewski','Konrad','Obsee Du Monde Homes','7594880792','+48508553520',NULL,'zalewski.konrad@mail.com','Warszawa','01-965','Szczeci�ska',5,2,1);

INSERT INTO Podatek (Procent)
	VALUES
	(0),
	(8),
	(23),
	(11),
	(28);

INSERT INTO Forma_platnosc (Nazwa)
	VALUES
	('Przelew'),
	('Karta p�atnicza'),
	('Got�wka'),
	('BLIK'),
	('Przelew pocztowy');

INSERT INTO Typ_odbioru (Nazwa)
	VALUES
	('Wysy�ka'),
	('Odbi�r osobisty');

INSERT INTO Stan_realizacji (Nazwa_stan_realizaji)
	VALUES
	('W trakcie realizacji'),
	('Gotowe do odbioru'),
	('Zrealizowane'),
	('Wys�ano');

INSERT INTO Status_oferta (Nazwa_status_oferta)
	VALUES
	('Zaakceptowana'),
	('Odrzucona'),
	('Do rozpatrzenia'),
	('W trakcie realizacji');

INSERT INTO Oferta_handlowa (ID_pracownik, Termin_realizacja, ID_status_oferta)
	VALUES
	(3,'2022-06-01',1),
	(3,'2022-06-01',1),
	(3,'2022-06-01',2),
	(3,'2022-06-01',3),
	(3,'2022-06-01',4);

INSERT INTO Oferta_handlowa_szczegol (ID_oferta_handlowa, ID_produkt, Ilosc, Cena_netto_za_jednostke, ID_podatek)
	VALUES
	(1,1,20,119.00,3),
	(1,2,20,95.85,3),
	(1,5,15,259.00,3),
	(2,1,20,119.00,3),
	(2,5,15,259.00,3),
	(3,1,20,119.00,3),
	(4,2,20,95.85,3),
	(4,5,15,259.00,3),
	(4,1,20,119.00,3),
	(5,5,15,259.00,3);

INSERT INTO Umowa_sprzedaz_hurt (ID_oferta_handlowa, ID_klient)
	VALUES
	(1,2),
	(2,3);

INSERT INTO Zamowienie (ID_umowa_sprzedaz_hurt, ID_klient, ID_pracownik, ID_stan_realizaji, ID_oferta_handlowa, Data_zamowienie)
	VALUES
	(1,1,3,3,1,'2022-06-03'),
	(2,1,3,3,2,'2022-06-03');

INSERT INTO Zamowienie_szczegol (ID_zamowienie, ID_produkt, Ilosc)
	VALUES
	(1,1,20),
	(1,2,20),
	(1,5,15),
	(2,1,20),
	(2,5,15);

INSERT INTO Sprzedaz_hurt (ID_zamowienie, Data_sprzedazy, Termin_zaplata, ID_forma_platnosc, ID_Typ_odbioru)
	VALUES
	(1,'2022-06-05','2022-06-19',1,2),
	(2,'2022-06-05','2022-06-19',1,1);

INSERT INTO Sprzedaz_szczegol_hurt (ID_sprzedaz_hurt, ID_produkt, ID_jednostka, Ilosc)
	VALUES
	(1,1,1,20),
	(1,2,1,20),
	(1,5,1,15),
	(2,1,1,20),
	(2,5,1,15),
	(2,3,1,15),
	(2,4,1,10);

INSERT INTO Sprzedaz_detal (Data_sprzedazy, Termin_zaplata, ID_forma_platnosc, ID_Typ_odbioru)
	VALUES
	('2022-06-05','2022-06-19',1,2),
	('2022-06-05','2022-06-19',1,2),
	('2022-06-05','2022-06-19',1,1),
	('2022-06-05','2022-06-19',1,1);

INSERT INTO Sprzedaz_szczegol_detal (ID_sprzedaz_detal, ID_produkt, ID_jednostka, Cena_netto_za_jednostke, ID_podatek, Ilosc)
	VALUES 
	(1,1,1,119.00,3,10),
	(1,2,1,95.85,3,3),
	(2,1,1,119.00,3,3),
	(2,3,1,1299.00,3,12),
	(3,5,1,259.99,3,1),
	(4,4,1,159.99,3,15);

INSERT INTO Sprzedaz_usluga_hurt (ID_sprzedaz_hurt, ID_pracownik, Termin_zaplata, ID_forma_platnosc)
	VALUES
	(2,7,'2022-06-19',1)

INSERT INTO Szczegol_sprzedaz_usluga_hurt (ID_sprzedaz_usuluga_hurt, ID_usluga, Data_sprzedaz_usluga)
	VALUES 
	(1,1,'2022-06-05');

INSERT INTO Sprzedaz_usluga_detal(ID_sprzedaz_detal, ID_pracownik, Termin_zaplata, ID_forma_platnosc)
	VALUES
	(3,7,'2022-06-19',1)

INSERT INTO Szczegol_sprzedaz_usluga_detal (ID_sprzedaz_usuluga_detal, ID_usluga, Data_sprzedaz_usluga)
	VALUES 
	(1,1,'2022-06-05');

INSERT INTO Wysylka_hurt (ID_sprzedaz_usluga_hurt, ID_pojazd_transport, ID_pracownik, Data_wysylka)
	VALUES
	(1,4,5,'2022-06-06');

INSERT INTO Wysylka_detal (ID_sprzedaz_usluga_detal, ID_pojazd_transport, ID_pracownik, Data_wysylka)
	VALUES
	(1,5,6,'2022-06-06');

INSERT INTO Typ_reklamacja (Nazwa)
	VALUES
	('Zwrot'),
	('Reklamacja');

INSERT INTO Reklamacja_hurt (ID_pracownik, ID_sprzedaz_hurt, Data_reklamacja, Opis_reklamacja)
	VALUES
	(3,2,'2022-06-15','Produkt nie nadaje si� do monta�u');

INSERT INTO Szczegol_reklamacja_hurt (ID_reklamacja_hurt, ID_typ_reklamacja, ID_produkt, Ilosc, Utylizacja, Uwagi)
	VALUES
	(1,2,5,1,1,'Brak uwag'),
	(1,2,2,2,1,'Brak uwag');


INSERT INTO Reklamacja_detal (ID_pracownik, ID_sprzedaz_detal, Data_reklamacja, Opis_reklamacja)
	VALUES
	(3,2,'2022-06-15','Produkt zniszczony');

INSERT INTO Szczegol_reklamacja_detal (ID_reklamacja_detal, ID_typ_reklamacja, ID_produkt, Ilosc, Utylizacja, Uwagi)
	VALUES
	(1,2,1,1,1,'Brak uwag'),
	(1,2,3,2,1,'Brak uwag');

INSERT INTO Typ_utylizacja
	VALUES
	('Zewn�trzna'),
	('Wewn�trzna');

INSERT INTO Utylizacja
	VALUES 
	(5,1,1),
	(2,1,2),
	(1,1,1),
	(3,1,2);



