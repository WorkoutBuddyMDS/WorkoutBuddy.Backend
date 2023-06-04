# Workout buddy

Proiect realizat pentru disciplina "Metode de dezvoltare software" din cadrul Facultății de Matematică și Informatică, Universitatea București.

Cerințele din barem sunt descrise aici [link](https://app.box.com/notes/46831554845?s=6ly7x02gnt1i3yyjb5hec4no4narasnu).

## Membrii echipei:

1. [Alexia Aldea](https://github.com/allee15)
2. [George Florea](https://github.com/jovialjoker)
3. [Sergiu Stanciu](https://github.com/Sergiu44)
4. [Dragos Teleaga](https://github.com/dragosteleaga)

## Descrierea proiectului

Aplicația "Workout Buddy Service" este scrisă în C#, un limbaj de programare puternic, orientat pe obiect, dezvoltat și susținut de Microsoft. C# este frecvent utilizat pentru dezvoltarea aplicațiilor web, serviciilor backend, aplicațiilor desktop și multe altele, având o sintaxă similară cu alte limbaje de programare populare, precum Java și C++.Aplicația "Workout Buddy Service" utilizează și platforma ASP.NET, care este un framework dezvoltat de Microsoft și este frecvent utilizat pentru dezvoltarea aplicațiilor web în limbajul C#.

ASP.NET permite construirea rapidă și scalabilă a aplicațiilor web prin intermediul modelului de programare bazat pe componente. Acesta oferă funcționalități puternice pentru gestionarea rutei, gestionarea cererilor și generarea dinamică a paginilor web.

### Structura proiectului
Proiectul este împărțit în mai multe module, care includ:

- Backend.BusinessLogic: Acest modul conține logica de afaceri a aplicației. Aici sunt implementate funcționalitățile pentru gestionarea rutinelor de antrenament și a exercițiilor, inclusiv operații de creare, vizualizare, actualizare și ștergere.

- Backend.Common: Acest modul conține infrastructura comună necesară pentru funcționarea aplicației. Include funcții, clase și alte componente reutilizabile care sunt utilizate în diferite părți ale proiectului.

- Backend.DataAccess: Acest modul este responsabil de gestionarea accesului la date. Aici sunt implementate funcționalitățile de interacțiune cu baza de date pentru a stoca și recupera informațiile despre utilizatori, rutinele de antrenament și exercițiile.

- Backend.Entities: Acest modul definește entitățile și structurile de date utilizate în cadrul aplicației. Aici sunt definite modelele de date pentru utilizatori, rutinele de antrenament, exercițiile și alte obiecte relevante.

- Backend.WebApp: Acest modul reprezintă aplicația web propriu-zisă. Aici sunt implementate endpoint-urile și rutele API-ului, gestionarea cererilor HTTP și integrarea cu celelalte module pentru a furniza funcționalitățile aplicației Workout Buddy.

Funcționalități
- Autentificare și gestionare conturi de utilizator: Aplicația oferă funcționalități pentru înregistrarea și autentificarea utilizatorilor. Aceasta permite utilizatorilor să creeze conturi, să se autentifice în sistem și să gestioneze informațiile de profil, inclusiv schimbarea parolei.

- Gestionarea rutinelor de antrenament: Utilizatorii pot crea, vizualiza, actualiza și șterge rutine de antrenament personalizate. Aceasta include adăugarea exercițiilor la rutine, stabilirea numărului de repetări și seturi, precum și planificarea zilelor de antrenament.

- Gestionarea exercițiilor: Utilizatorii pot adăuga, vizualiza, actualiza și șterge exerciții. Pentru fiecare exercițiu, pot fi specificate detalii precum numele, descrierea, grupa musculară țintă și echipamentul necesar.

- Jurnalizarea activităților utilizatorului: Aplicația înregistrează activitățile utilizatorilor, cum ar fi adăugarea sau modificarea rutinelor de antrenament, adăugarea exercițiilor sau antrenamentele finalizate. Aceasta poate ajuta utilizatorii să monitorizeze progresul și să-și urmărească activitățile anterioare.

- Securitate și autorizare: Aplicația oferă endpoint-uri securizate, care necesită autentificare și autorizare pentru a accesa resursele protejate. Aceasta asigură confidențialitatea și securitatea datelor utilizatorilor și restricționează accesul la anumite funcționalități doar pentru utilizatorii autorizați.

- Integrare cu o bază de date: Aplicația utilizează un sistem de gestionare a bazelor de date pentru a stoca și recupera datele utilizatorilor, rutinelor de antrenament și exercițiilor. Aceasta asigură persistența datelor și accesul rapid la informațiile necesare.

## Diagrama UML :
![WhatsApp Image 2023-06-03 at 17 26 37](https://github.com/WorkoutBuddyMDS/workout-buddy.service/assets/91975287/5202c378-db2e-477b-ba09-60add1976250)

