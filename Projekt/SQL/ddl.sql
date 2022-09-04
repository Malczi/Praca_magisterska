USE master
GO
--DROP DATABASE MGR
--GO
CREATE DATABASE MGR
GO
USE MGR
GO

--OPIS PRODUKTU


CREATE TABLE Dzial
	(
	ID_dzial INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Kategoria
	(
	ID_kategoria INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	ID_dzial INT FOREIGN KEY REFERENCES Dzial(ID_dzial) NOT NULL,
	)

CREATE TABLE Podkategoria
	(
	ID_podkategoria INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	ID_Kategoria INT FOREIGN KEY REFERENCES Kategoria(ID_kategoria) NOT NULL,
	)

CREATE TABLE Typ_produkt
	(
	ID_typ_produkt INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nazwa NVARCHAR(50),
	ID_podkategoria INT FOREIGN KEY REFERENCES Podkategoria(ID_podkategoria) NOT NULL,
	)

CREATE TABLE Alert
	(
	ID_alert INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dzial INT FOREIGN KEY REFERENCES Dzial(ID_dzial) NOT NULL,
	Tresc NVARCHAR(250) NOT NULL,
	Czy_odczytano BIT NOT NULL,
	)

CREATE TABLE Jednostka
	(
	ID_jednostka INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50),
	)

CREATE TABLE Producent
	(
	ID_producent INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Adres_URL NVARCHAR(250) NOT NULL,
	)

CREATE TABLE Gwarancja
	(
	ID_gwarancja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Opis_gwarancja NVARCHAR(250) NOT NULL,
	Okres_gwarancja INT NOT NULL,
	)

CREATE TABLE Produkt 
	(
	ID_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	ID_producent INT FOREIGN KEY REFERENCES Producent(ID_producent) NOT NULL,
	ID_typ_produkt INT FOREIGN KEY REFERENCES Typ_produkt(ID_typ_produkt) NOT NULL,
	Nr_produkt INT NOT NULL,
	Cena_sugerowana_netto DECIMAL(15,2) NOT NULL,
	Termin_magazynowania_miesiace INT,
	Termin_przydatnosci_miesiace INT,
	Objetosc_magazynowa_m3 DECIMAL(15,2) NOT NULL,
	ID_gwarancja INT FOREIGN KEY REFERENCES Gwarancja(ID_gwarancja) NOT NULL,
	)

CREATE TABLE Typ_magazynowania
	(
	ID_typ_magazynowania INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Parametr_typ_magazynowania
	(
	ID_parametr_typ_magazynowania INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_typ_magazynowania INT FOREIGN KEY REFERENCES Typ_magazynowania(ID_typ_magazynowania) NOT NULL,
	Parametr NVARCHAR(50) NOT NULL,
	Wartosc_dolna INT NOT NULL,
	Wartosc_gorna INT NOT NULL,
	ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL,
	)

CREATE TABLE Poziom_magazynowanie
	(
	ID_poziom_magazynowanie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Poziom NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Parametr_poziom_magazynowanie
	(
	ID_parametr_poziom_magazynowanie INT PRIMARY KEY IDENTITY NOT NULL,
	ID_poziom_magazynowanie INT FOREIGN KEY REFERENCES Poziom_magazynowanie(ID_poziom_magazynowanie) NOT NULL,
	Parametr NVARCHAR(50) NOT NULL,
	Wartosc_dolna INT NOT NULL,
	Wartosc_gorna INT NOT NULL,
	ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL,
	)

CREATE TABLE Magazyn
	(
	ID_magazyn INT PRIMARY KEY IDENTITY(1,1),
	Nazwa NVARCHAR(50),
	Pojemnosc_w_m3 INT,
	ID_dzial INT FOREIGN KEY REFERENCES Dzial(ID_dzial),
	ID_typ_magazynowania INT FOREIGN KEY REFERENCES Typ_magazynowania(ID_typ_magazynowania)
	)

CREATE TABLE Miejsce_magazynowania
	(
	ID_miejsce_magazynowania INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_magazyn INT FOREIGN KEY REFERENCES Magazyn(ID_magazyn),
	ID_typ_magazynowania INT FOREIGN KEY REFERENCES Typ_magazynowania(ID_typ_magazynowania) NOT NULL,
	ID_poziom_magazynowanie INT FOREIGN KEY REFERENCES Poziom_magazynowanie(ID_poziom_magazynowanie) NOT NULL,
	Nr_miejsca INT NOT NULL,
	)

CREATE TABLE Slownik_atrybut
	(
	ID_slownik_atrybut INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL,
	)

CREATE TABLE Atrybut
	(
	ID_atrybut INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_slownik_atrybut INT FOREIGN KEY REFERENCES Slownik_atrybut(ID_slownik_atrybut) NOT NULL,
	Wartosc DECIMAL(15,2) NOT NULL,
	)

CREATE TABLE Usluga
	(
	ID_usluga INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Cena DECIMAL(15,2) NOT NULL,
	)

--HR

CREATE TABLE Wyksztalcenie
	(
	ID_wyksztalcenie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa VARCHAR(35) NOT NULL,
	)

CREATE TABLE Pracownik
	(
	ID_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Imie NVARCHAR(50) NOT NULL,
	Nr_dowodu NVARCHAR(9) NOT NULL,
	PESEL NVARCHAR(11) NOT NULL,
	ID_wyksztalcenie INT FOREIGN KEY REFERENCES Wyksztalcenie(ID_wyksztalcenie) NOT NULL,
	)

CREATE TABLE Dane_adresowe_pracownik
	(
	ID_dane_adresowe_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50),
	Nr_budynku INT NOT NULL,
	Nr_lokalu INT,
	Kod_pocztowy NVARCHAR(6) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Nr_telefon_pracownik
	(
	ID_Nr_telefon_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Numer NVARCHAR(9) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Email_pracownik
	(
	ID_email_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Dzial_pracownik
	(
	ID_dzial_pracownik INT PriMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_dzial_pracownik NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Stanowisko
	(
	ID_stanowisko INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_stanowiska NVARCHAR(50) NOT NULL,
	ID_dzial_pracownik INT FOREIGN KEY REFERENCES Dzial_pracownik(ID_dzial_pracownik) NOT NULL,
	)

CREATE TABLE Etat	
	(
	ID_etat INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko INT FOREIGN KEY REFERENCES Stanowisko(ID_stanowisko) NOT NULL,
	Liczba_miejsc INT NOT NULL,
	)

CREATE TABLE Posada_pracownika
	(
	ID_posada_pracownika INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_etat INT FOREIGN KEY REFERENCES Etat(ID_etat),
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Rodzaj_umowy
	(
	ID_rodzaj_umowy INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Urlop INT NOT NULL,
	)

CREATE TABLE Rodzaj_nieobecnosci
	(
	ID_rodzaj_nieobecnosci INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Symbol NVARCHAR(10) NOT NULL,
	Wspolczynnik_wynagrodzenia DECIMAL (15,2),
	)

CREATE TABLE Nieobecnosc
	(
	ID_nieobecnosc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik),
	ID_rodzaj_nieobecnosci  INT FOREIGN KEY REFERENCES Rodzaj_nieobecnosci(ID_rodzaj_nieobecnosci),
	Data_od DATE NOT NULL,
	Data_do DATE NOT NULL,
	)

CREATE TABLE Wymiar_pracy
	(
	ID_wymiar_pracy INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Wspolczynnik_wynagrodzenia DECIMAL (15,2),
	)

CREATE TABLE Umowa
	(
	ID_umowa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wymiar_pracy INT FOREIGN KEY REFERENCES Wymiar_pracy(ID_wymiar_pracy),
	ID_rodzaj_umowy INT FOREIGN KEY REFERENCES Rodzaj_umowy(ID_rodzaj_umowy),
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik),
	ID_posada_pracownika INT FOREIGN KEY REFERENCES Posada_pracownika(ID_posada_pracownika),
	Wynagrodzenie INT NOT NULL,
	)

CREATE TABLE Rodzaj_nadgodziny
	(
	ID_rodzaj_nadgodziny INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50),
	)

CREATE TABLE Nadgodziny 
	(
	ID_nadgodziny INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_nadgodziny DATE NOT NULL,
	ID_rodzaj_nadgodziny INT FOREIGN KEY REFERENCES Rodzaj_nadgodziny(ID_rodzaj_nadgodziny) NOT NULL,
	Czas INT NOT NULL,
	)	

CREATE TABLE Czas_pracy
	(
	ID_czas_pracy  INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_pracy DATE NOT NULL,
	Liczba_godzin INT NOT NULL,
	)

CREATE TABLE Wyplata
	(
	ID_wyplata INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_Pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_wyplaty DATE NOT NULL,
	)

CREATE TABLE Typ_szkolenie
	(
	ID_typ_szkolenie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Szkolenie_pracownik
	(
	ID_szkolenie_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_typ_szkolenie INT FOREIGN KEY REFERENCES Typ_szkolenie(ID_typ_szkolenie) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE NOT NULL,
	)

-- LOGITYKA I MAGAZYN

CREATE TABLE Dostawca
	(
	ID_dostawca INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Nr_telefon NVARCHAR(9) NOT NULL,
	Adres_email NVARCHAR(100) NOT NULL,
	Kod_pocztowy NVARCHAR(6) NOT NULL,
	Miasto NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50), 
	Nr_budynku INT NOT NULL,
	Nr_lokalu INT,
	NIP NVARCHAR(10) NOT NULL,
	)

CREATE TABLE Dostawa
	(
	ID_dostawa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dostawca INT FOREIGN KEY REFERENCES Dostawca(ID_dostawca) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_dostawa DATE NOT NULL,
	)

CREATE TABLE Dostawa_szczegol
	(
	ID_dostawa_szczegol INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dostawa INT FOREIGN KEY REFERENCES Dostawa(ID_dostawa) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Cena_szt DECIMAL(15,2) NOT NULL
	)

CREATE TABLE Status_dostawa 
	(
	ID_status_dostawa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_status NVARCHAR(20) NOT NULL
	)

CREATE TABLE Stan_realizacji_dostawa 
	(
	ID_stan_realizacji_dostawa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dostawa INT FOREIGN KEY REFERENCES Dostawa(ID_dostawa) NOT NULL,
	ID_status_dostawa INT FOREIGN KEY REFERENCES Status_dostawa(ID_status_dostawa) NOT NULL,
	Data_st SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	)

CREATE TABLE Typ_pojazd_transport
	(
	ID_typ_pojazd_transport INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)	

CREATE TABLE Rodzaj_pojazd_transport
	(
	ID_rodzaj_pojazd_transport INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Stan_techniczny_pojazd_transport
	(
	ID_stan_techniczny_pojazd_transport INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Typ_paliwa
	(
	ID_typ_paliwa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL
	)

CREATE TABLE Pojazd_transport
	(
	ID_pojazd_transport INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Marka NVARCHAR(50) NOT NULL,
	Model NVARCHAR(50) NOT NULL,
	Nr_rejestracyjny NVARCHAR(6),
	ID_typ_pojad_transport INT FOREIGN KEY REFERENCES Typ_pojazd_transport(ID_typ_pojazd_transport) NOT NULL,
	ID_rodzaj_pojazd_transport INT FOREIGN KEY REFERENCES Rodzaj_pojazd_transport(ID_rodzaj_pojazd_transport) NOT NULL,
	ID_stan_techniczny_pojazd_transport INT FOREIGN KEY REFERENCES Stan_techniczny_pojazd_transport(ID_stan_techniczny_pojazd_transport) NOT NULL,
	Sr_spalanie_wg_producenta DECIMAL(15,2) NOT NULL,
	ID_typ_paliwa INT FOREIGN KEY REFERENCES Typ_paliwa(ID_typ_paliwa) NOT NULL,
	)

CREATE TABLE Typ_parametr_pojazd_transport
	(
	ID_typ_parametr_pojazd_transport INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL,
	)

CREATE TABLE Parametr_rodzaj_transport
	(
	ID_parametr_pojazd_transport INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pojazd_transport INT FOREIGN KEY REFERENCES Pojazd_transport(ID_pojazd_transport) NOT NULL,
	ID_typ_parametr_pojazd_transport INT FOREIGN KEY REFERENCES Typ_parametr_pojazd_transport(ID_typ_parametr_pojazd_transport) NOT NULL,
	Wartosc INT NOT NULL
	)

CREATE TABLE Rozladunek
	(
	ID_rozladunek INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dostawa INT FOREIGN KEY REFERENCES Dostawa(ID_dostawa) NOT NULL,
	ID_pojazd_transport INT FOREIGN KEY REFERENCES Pojazd_transport(ID_pojazd_transport) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_rozladunek DATE NOT NULL,
	)

--SPRZEDA¯

CREATE TABLE Rabat
	(
	ID_rabat INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Rabat DECIMAL(15,2) NOT NULL,
	)

CREATE TABLE Status_klient
	(
	ID_status_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	ID_rabat INT FOREIGN KEY REFERENCES Rabat(ID_rabat),
	)

CREATE TABLE Klient
	(
	ID_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Imie NVARCHAR(50) NOT NULL,
	Nazwa_firmy NVARCHAR (100),
	NIP NVARCHAR (10),
	Nr_telefonu_1 NVARCHAR(12) NOT NULL,
	Nr_telefonu_2 NVARCHAR(12),
	Email NVARCHAR(100),
	Miasto NVARCHAR(50) NOT NULL,
	Kod_pocztowy NVARCHAR(6) NOT NULL,
	Ulica NVARCHAR(50),
	Nr_domu INT,
	Nr_lokalu INT,
	ID_status_klient INT FOREIGN KEY REFERENCES Status_klient(ID_status_klient) NOT NULL
	)

CREATE TABLE Podatek
	(
	ID_podatek INT PRIMARY KEY IDENTITY(1,1),
	Procent INT NOT NULL,
	)

CREATE TABLE Forma_platnosc
	(
	ID_forma_platnosc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Typ_odbioru
	(
	ID_typ_odbioru INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Stan_realizacji
	(
	ID_stan_realizacji INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_stan_realizaji NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Status_oferta
	(
	ID_status_oferta INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_status_oferta NVARCHAR(30) NOT NULL,
	)

CREATE TABLE Oferta_handlowa
	(
	ID_oferta_handlowa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Termin_realizacja DATE NOT NULL,
	ID_status_oferta INT FOREIGN KEY REFERENCES Status_oferta(ID_status_oferta) NOT NULL,
	)

CREATE TABLE Oferta_handlowa_szczegol
	(
	ID_oferta_handlowa_szczegol INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_oferta_handlowa INT FOREIGN KEY REFERENCES Oferta_handlowa(ID_oferta_handlowa) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Cena_netto_za_jednostke DECIMAL(15,2) NOT NULL,
	ID_podatek INT FOREIGN KEY REFERENCES Podatek(ID_podatek) NOT NULL,
	)

CREATE TABLE Umowa_sprzedaz_hurt
	(
	ID_umowa_sprzedaz_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_oferta_handlowa INT FOREIGN KEY REFERENCES Oferta_handlowa(ID_oferta_handlowa) NOT NULL,
	ID_klient INT FOREIGN KEY REFERENCES Klient(ID_klient) NOT NULL
	)

CREATE TABLE Zamowienie
	(
	ID_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_umowa_sprzedaz_hurt INT FOREIGN KEY REFERENCES Umowa_sprzedaz_hurt(ID_umowa_sprzedaz_hurt) NOT NULL,
	ID_klient INT FOREIGN KEY REFERENCES Klient(ID_klient) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_stan_realizaji INT FOREIGN KEY REFERENCES Stan_realizacji(ID_stan_realizacji),
	ID_oferta_handlowa INT FOREIGN KEY REFERENCES Oferta_handlowa(ID_oferta_handlowa),
	Data_zamowienie DATE NOT NULL,
	)

CREATE TABLE Zamowienie_szczegol
	(
	ID_zamowienie_szczegol INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL
	)

CREATE TABLE Sprzedaz_hurt
	(
	ID_sprzedaz_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	Data_sprzedazy DATE NOT NULL,
	Termin_zaplata DATE NOT NULL,
	ID_forma_platnosc INT FOREIGN KEY REFERENCES Forma_platnosc(ID_forma_platnosc) NOT NULL,
	ID_Typ_odbioru INT FOREIGN KEY REFERENCES Typ_odbioru(ID_typ_odbioru) NOT NULL,
	)

CREATE TABLE Sprzedaz_szczegol_hurt
	(
	ID_sprzedaz_szczegol_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_hurt INT FOREIGN KEY REFERENCES Sprzedaz_hurt(ID_sprzedaz_hurt) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL,
	Ilosc INT NOT NULL,
	)

CREATE TABLE Sprzedaz_detal
	(
	ID_sprzedaz_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Data_sprzedazy DATE NOT NULL,
	Termin_zaplata DATE NOT NULL,
	ID_forma_platnosc INT FOREIGN KEY REFERENCES Forma_platnosc(ID_forma_platnosc) NOT NULL,
	ID_Typ_odbioru INT FOREIGN KEY REFERENCES Typ_odbioru(ID_typ_odbioru) NOT NULL,
	)

CREATE TABLE Sprzedaz_szczegol_detal
	(
	ID_sprzedaz_szczegol_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_detal INT FOREIGN KEY REFERENCES Sprzedaz_detal(ID_sprzedaz_detal) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_jednostka INT FOREIGN KEY REFERENCES Jednostka(ID_jednostka) NOT NULL,
	Cena_netto_za_jednostke DECIMAL(15,2) NOT NULL,
	ID_podatek INT FOREIGN KEY REFERENCES Podatek(ID_podatek) NOT NULL,
	Ilosc INT NOT NULL,
	)

CREATE TABLE Sprzedaz_usluga_hurt
	(
	ID_sprzedaz_usluga_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_hurt INT FOREIGN KEY REFERENCES Sprzedaz_hurt(ID_sprzedaz_hurt) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Termin_zaplata DATE NOT NULL,
	ID_forma_platnosc INT FOREIGN KEY REFERENCES Forma_platnosc(ID_forma_platnosc) NOT NULL,
	)

CREATE TABLE Szczegol_sprzedaz_usluga_hurt
	(
	ID_szczegol_sprzedaz_usluga_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_usuluga_hurt INT FOREIGN KEY REFERENCES Sprzedaz_usluga_hurt(ID_sprzedaz_usluga_hurt) NOT NULL,
	ID_usluga INT FOREIGN KEY REFERENCES Usluga(ID_usluga) NOT NULL,
	Data_sprzedaz_usluga DATE NOT NULL,
	)

CREATE TABLE Sprzedaz_usluga_detal
	(
	ID_sprzedaz_usluga_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_detal INT FOREIGN KEY REFERENCES Sprzedaz_detal(ID_sprzedaz_detal) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Termin_zaplata DATE NOT NULL,
	ID_forma_platnosc INT FOREIGN KEY REFERENCES Forma_platnosc(ID_forma_platnosc) NOT NULL,
	)

CREATE TABLE Szczegol_sprzedaz_usluga_detal
	(
	ID_szczegol_sprzedaz_usluga_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_usuluga_detal INT FOREIGN KEY REFERENCES Sprzedaz_usluga_detal(ID_sprzedaz_usluga_detal) NOT NULL,
	ID_usluga INT FOREIGN KEY REFERENCES Usluga(ID_usluga) NOT NULL,
	Data_sprzedaz_usluga DATE NOT NULL,
	)

CREATE TABLE Wysylka_hurt
	(
	ID_wysylka_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_usluga_hurt INT FOREIGN KEY REFERENCES Sprzedaz_usluga_hurt(ID_sprzedaz_usluga_hurt) NOT NULL,
	ID_pojazd_transport INT FOREIGN KEY REFERENCES Pojazd_transport(ID_pojazd_transport) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_wysylka DATE NOT NULL,
	)

CREATE TABLE Wysylka_detal
	(
	ID_wysylka_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_sprzedaz_usluga_detal INT FOREIGN KEY REFERENCES Sprzedaz_usluga_detal(ID_sprzedaz_usluga_detal) NOT NULL,
	ID_pojazd_transport INT FOREIGN KEY REFERENCES Pojazd_transport(ID_pojazd_transport) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_wysylka DATE NOT NULL,
	)

CREATE TABLE Typ_reklamacja
	(
	ID_typ_reklamacja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Reklamacja_hurt
	(
	ID_reklamacja_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_sprzedaz_hurt INT FOREIGN KEY REFERENCES Sprzedaz_hurt(ID_sprzedaz_hurt) NOT NULL,
	Data_reklamacja DATE NOT NULL,
	Opis_reklamacja NVARCHAR(250) NOT NULL,
	)

CREATE TABLE Szczegol_reklamacja_hurt
	(
	ID_szczegol_reklamacja_hurt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja_hurt INT FOREIGN KEY REFERENCES Reklamacja_hurt(ID_reklamacja_hurt) NOT NULL,
	ID_typ_reklamacja INT FOREIGN KEY REFERENCES Typ_reklamacja(ID_typ_reklamacja) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Utylizacja BIT NOT NULL,
	Uwagi NVARCHAR(250) NOT NULL,
	)

CREATE TABLE Reklamacja_detal
	(
	ID_reklamacja_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_sprzedaz_detal INT FOREIGN KEY REFERENCES Sprzedaz_detal(ID_sprzedaz_detal) NOT NULL,
	Data_reklamacja DATE NOT NULL,
	Opis_reklamacja NVARCHAR(250) NOT NULL,
	)

CREATE TABLE Szczegol_reklamacja_detal
	(
	ID_szczegol_reklamacja_detal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja_detal INT FOREIGN KEY REFERENCES Reklamacja_detal(ID_reklamacja_detal) NOT NULL,
	ID_typ_reklamacja INT FOREIGN KEY REFERENCES Typ_reklamacja(ID_typ_reklamacja) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Utylizacja BIT NOT NULL,
	Uwagi NVARCHAR(250) NOT NULL,
	)

CREATE TABLE Typ_utylizacja
	(
	ID_typ_utylizacja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	)

CREATE TABLE Utylizacja
	(
	ID_utylizacja_magazyn INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_typ_utylizacja INT FOREIGN KEY REFERENCES Typ_utylizacja(ID_typ_utylizacja),
	Ilosc INT NOT NULL,
	)

