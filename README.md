# EL‑Muze

Table of Contents

* [What the project does](https://www.google.com/search?q=%23what-the-project-does)
* [Why it's worth it](https://www.google.com/search?q=%23why-its-worth-it)
* [Key features](https://www.google.com/search?q=%23key-features)
* [Requirements](https://www.google.com/search?q=%23requirements)
* [Quick start](https://www.google.com/search?q=%23quick-start)
* [Database configuration](https://www.google.com/search?q=%23database-configuration)
* [Running the application](https://www.google.com/search?q=%23running-the-application)
* [Project structure — relevant files](https://www.google.com/search?q=%23project-structure--relevant-files)
* [Where to get help](https://www.google.com/search?q=%23where-to-get-help)
* [Maintenance and contributions](https://www.google.com/search?q=%23maintenance-and-contributions)
* [License](https://www.google.com/search?q=%23license)

<img width="787" height="389" alt="MVC" src="https://github.com/user-attachments/assets/40d6b6b8-8663-436c-b01a-dcfb9221fbd6" />

## What the project does

EL‑Muze is a desktop application written in C# (Windows Forms) for managing the register of Elbląg monuments. The application interface is in Polish. The application allows viewing, adding, modifying, searching, and archiving entries regarding historical objects saved in an SQL Server database.

## Why it's worth it

* Simple, desktop application for managing a register of monuments.
* Built-in filtering and searching with multiple criteria.
* Archive mode (view of modified entries).
* Basic statistics (number of entries, oldest/newest entry, archive percentage).
* Typed DataSet facilitates binding code to the database table.

## Key features

* CRUD (Create / Read / Update / Delete) for monument entries
* Advanced search with multiple conditions
* Archive view (saved as `modyfikowano = true`)
* Statistical report (age of entries, top 5 streets, etc.)

## Requirements

* System: Windows
* Visual Studio (recommended) with support for .NET Framework projects
* .NET Framework 4.x (application uses System.Windows.Forms)
* SQL Server or LocalDB (`zabytki` database)

## Quick start

1. Clone the repository:
git clone [https://github.com/krlpopiel/EL-Muze.git](https://github.com/krlpopiel/EL-Muze.git)
2. Open the project/solution in Visual Studio:
* If there is a `.sln` file in the repo, open it; otherwise, open the folder as a project.


3. Configure the database connection (see below).
4. Build (Debug/Release) and run the application (F5 in Visual Studio).

## Database configuration

The application uses connections saved in settings (Settings). Edit connections in:

* EL‑Muze/Properties/Settings.settings or `EL-Muze/Properties/Settings.Designer.cs`

Connection keys used in the project:

* `centrala_muzeumConnectionString`
* `zabytkiConnectionString`

Example minimal table compatible with used columns:

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

Important:

* The exact column structure and types are located in `EL-Muze/zabytkiDataSet.Designer.cs` — if you make changes to the schema, update the typed DataSet in the project.
* Adjust the connection string to your SQL Server instance (Integrated Security or login/password).

## Running the application

* In Visual Studio: Build → Run (F5).
* From EXE file: run the file in `bin/Debug` or `bin/Release`.
* The application starts with a welcome screen (`Ekran_Powitalny`), then opens the main browser (`Przegladarka`).

Basic flow (UI in Polish):

* Add new entry → `Zabytek` form
* Edit entry → select record → modify (old record may be marked `modyfikowano = true`)
* Search → `WyszukiwanieZabytkow` → results in `WyszukaneZabytki`
* Archive → Archive button in `Przegladarka`
* Statistics → Statistics button shows report

## Project structure — relevant files

* EL-Muze/Program.cs — application entry point
* EL-Muze/Forms/
* Ekran_Powitalny.cs — welcome screen
* Przegladarka.cs — main interface (list, CRUD, statistics)
* Zabytek.cs — add/edit entry form
* WyszukiwanieZabytkow.cs, WyszukaneZabytki.cs — search mechanism


* EL-Muze/zabytkiDataSet.Designer.cs — typed DataSet (data schema)
* EL-Muze/Properties/Settings.Designer.cs — default connection strings
* https://www.google.com/search?q=LICENSE.txt — project license

Relative links:

* License: https://www.google.com/search?q=LICENSE.txt
* Settings: EL-Muze/Properties/Settings.Designer.cs
* Typed DataSet: EL-Muze/zabytkiDataSet.Designer.cs
* Main form: EL-Muze/Forms/Przegladarka.cs

## Where to get help

* Report bugs and questions via Issues: [https://github.com/krlpopiel/EL-Muze/issues](https://github.com/krlpopiel/EL-Muze/issues)
* For questions regarding the database schema, check `EL-Muze/zabytkiDataSet.Designer.cs`.
* For discussions on features or major changes, open Issues describing the proposed changes.

## Maintenance and contributions

Project maintainer: GitHub user `krlpopiel` — [https://github.com/krlpopiel](https://github.com/krlpopiel)

## License

Project available under the MIT license — see `LICENSE.txt`.
