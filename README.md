1. MvcAppMovies

MvcAppMovies jest aplikacją webową stworzoną w technologii ASP.NET Core MVC.  
Celem projektu jest realizacja aplikacji typu CRUD umożliwiającej zarządzanie listą filmów z wykorzystaniem Entity Framework Core oraz bazy danych SQLite.

Projekt został przygotowany jako projekt zaliczeniowy w ramach zajęć akademickich.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2. Zakres funkcjonalny

Aplikacja umożliwia:
- wyświetlanie listy filmów,
- dodawanie nowych filmów,
- edycję istniejących filmów,
- wyświetlanie szczegółów filmu,
- usuwanie filmów z potwierdzeniem operacji,
- walidację danych w formularzach,
- wyświetlanie komunikatu po zapisaniu danych.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 
 3. Wykorzystane technologie

Backend
- C#
- ASP.NET Core MVC
- Entity Framework Core

Baza danych
- SQLite

Frontend
- HTML5
- CSS3
- JavaScript
- Bootstrap 5

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

4. Architektura aplikacji

Projekt został zrealizowany zgodnie z architekturą Model–View–Controller (MVC):
- Model odpowiada za reprezentację danych,
- View odpowiada za warstwę prezentacji,
- Controller odpowiada za logikę aplikacji oraz obsługę żądań użytkownika.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

5. Interfejs użytkownika

Interfejs użytkownika został zaprojektowany z uwzględnieniem czytelności oraz spójności wizualnej.  
Zastosowano własny motyw graficzny typu dark oraz komponenty frameworka Bootstrap 5.

Usuwanie danych wymaga potwierdzenia w oknie modalnym, co zabezpiecza przed przypadkowym usunięciem rekordów.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

6. Walidacja danych

Formularze dodawania i edycji filmu posiadają walidację danych:
- po stronie klienta (HTML, JavaScript),
- po stronie serwera (ASP.NET Core MVC).

Przykładowo długość filmu musi być większa od zera, a pola wymagane nie mogą pozostać puste.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

7. Responsywność

Aplikacja została zaprojektowana w sposób responsywny i poprawnie wyświetla się na:
- komputerach stacjonarnych,
- tabletach,
- telefonach komórkowych.

Responsywność została osiągnięta poprzez wykorzystanie frameworka Bootstrap 5.

Więcej informacji na temat projektu w dokumentacji.
