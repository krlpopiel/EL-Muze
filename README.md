# EL‑Muze

[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.txt) ![Platforma: Windows](https://img.shields.io/badge/platform-Windows-lightgrey) ![Język: C#](https://img.shields.io/badge/language-C%23-blueviolet) ![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.x-green) ![Wersja](https://img.shields.io/badge/version-1.5-orange)

Spis treści
- [Co robi projekt](#co-robi-projekt)
- [Dlaczego warto](#dlaczego-warto)
- [Najważniejsze funkcje](#najwazniejsze-funkcje)
- [Wymagania](#wymagania)
- [Szybki start](#szybki-start)
- [Konfiguracja bazy danych](#konfiguracja-bazy-danych)
- [Uruchamianie aplikacji](#uruchamianie-aplikacji)
- [Struktura projektu — istotne pliki](#struktura-projektu--istotne-pliki)
- [Gdzie szukać pomocy](#gdzie-szukac-pomocy)
- [Utrzymanie i kontrybucje](#utrzymanie-i-kontrybucje)
- [Licencja](#licencja)

<img width="787" height="389" alt="MVC" src="https://github.com/user-attachments/assets/40d6b6b8-8663-436c-b01a-dcfb9221fbd6" />

## Co robi projekt
EL‑Muze to aplikacja desktopowa napisana w C# (Windows Forms) do zarządzania rejestrem elbląskich zabytków. Interfejs aplikacji jest w języku polskim. Aplikacja pozwala przeglądać, dodawać, modyfikować, wyszukiwać i archiwizować wpisy dotyczące obiektów zabytkowych zapisanych w bazie danych SQL Server.

## Dlaczego warto
- Prosta, stacjonarna aplikacja do zarządzania rejestrem zabytków.
- Wbudowane filtrowanie i wyszukiwanie z wieloma kryteriami.
- Tryb archiwum (widok zmodyfikowanych wpisów).
- Podstawowe statystyki (liczba wpisów, najstarszy/najnowszy wpis, procent archiwum).
- Typowany DataSet ułatwia powiązanie kodu z tabelą bazy danych.

## Najważniejsze funkcje
- CRUD (Create / Read / Update / Delete) dla wpisów zabytków
- Zaawansowane wyszukiwanie z wieloma warunkami
- Widok archiwum (zapisane jako `modyfikowano = true`)
- Raport statystyczny (wiek wpisów, top 5 ulic itp.)

## Wymagania
- System: Windows
- Visual Studio (zalecane) z obsługą projektów .NET Framework
- .NET Framework 4.x (aplikacja wykorzystuje System.Windows.Forms)
- SQL Server lub LocalDB (baza `zabytki`)

## Szybki start
1. Sklonuj repozytorium:
   git clone https://github.com/krlpopiel/EL-Muze.git

2. Otwórz projekt/solucję w Visual Studio:
   - Jeśli w repo jest plik `.sln`, otwórz go, w przeciwnym razie otwórz folder jako projekt.

3. Skonfiguruj połączenie z bazą danych (patrz poniżej).

4. Zbuduj (Debug/Release) i uruchom aplikację (F5 w Visual Studio).

## Konfiguracja bazy danych
Aplikacja korzysta z połączeń zapisanych w ustawieniach (Settings). Edytuj połączenia w:
- EL‑Muze/Properties/Settings.settings lub `EL-Muze/Properties/Settings.Designer.cs`

Klucze połączeń używane w projekcie:
- `centrala_muzeumConnectionString`
- `zabytkiConnectionString`

Przykładowa minimalna tabela kompatybilna z używanymi kolumnami:

```sql
CREATE TABLE dbo.zabytki (
  id INT IDENTITY(1,1) PRIMARY KEY,
  ulica NVARCHAR(255) NULL,
  numer NVARCHAR(50) NULL,
  obiekt NVARCHAR(255) NOT NULL,
  nr_rejestru NVARCHAR(100) NULL,
  data_wpisu DATETIME NULL,
  decyzja NVARCHAR(255) NULL,
  modyfikowano BIT NULL
);
```

Ważne:
- Dokładna struktura kolumn i typy znajdują się w `EL-Muze/zabytkiDataSet.Designer.cs` — jeśli wprowadzisz zmiany w schemacie, zaktualizuj typed DataSet w projekcie.
- Dostosuj connection string do swojej instancji SQL Server (Integrated Security lub login/hasło).

## Uruchamianie aplikacji
- W Visual Studio: Build → Run (F5).
- Z pliku EXE: uruchom plik w `bin/Debug` lub `bin/Release`.
- Aplikacja startuje w formie powitalnej (`Ekran_Powitalny`), następnie otwiera główną przeglądarkę (`Przegladarka`).

Podstawowy przepływ (UI po polsku):
- Dodaj nowy wpis → formularz `Zabytek`
- Edytuj wpis → zaznacz rekord → modyfikuj (stary rekord może zostać oznaczony `modyfikowano = true`)
- Wyszukuj → `WyszukiwanieZabytkow` → wyniki w `WyszukaneZabytki`
- Archiwum → przycisk Archiwum w `Przegladarka`
- Statystyki → przycisk Statystyki pokazuje raport

## Struktura projektu — istotne pliki
- EL-Muze/Program.cs — punkt wejścia aplikacji
- EL-Muze/Forms/
  - Ekran_Powitalny.cs — ekran powitalny
  - Przegladarka.cs — główny interfejs (lista, CRUD, statystyki)
  - Zabytek.cs — formularz dodawania/edycji wpisu
  - WyszukiwanieZabytkow.cs, WyszukaneZabytki.cs — mechanizm wyszukiwania
- EL-Muze/zabytkiDataSet.Designer.cs — typed DataSet (schemat danych)
- EL-Muze/Properties/Settings.Designer.cs — domyślne connection stringi
- LICENSE.txt — licencja projektu

Relative links:
- Licencja: LICENSE.txt
- Ustawienia: EL-Muze/Properties/Settings.Designer.cs
- Typed DataSet: EL-Muze/zabytkiDataSet.Designer.cs
- Główny formularz: EL-Muze/Forms/Przegladarka.cs

## Gdzie szukać pomocy
- Zgłaszaj błędy i pytania poprzez Issues: https://github.com/krlpopiel/EL-Muze/issues
- W przypadku pytań dotyczących schematu bazy danych sprawdź `EL-Muze/zabytkiDataSet.Designer.cs`.
- Do dyskusji nad funkcjami lub większymi zmianami otwieraj Issues opisując proponowane zmiany.

## Utrzymanie i kontrybucje
Opiekun projektu: użytkownik GitHub `krlpopiel` — https://github.com/krlpopiel

## Licencja
Projekt udostępniony na licencji MIT — zobacz `LICENSE.txt`.

---
