# Teilnehmerverwaltung

## Projektbeschreibung

Die Anwendung „Teilnehmerverwaltung“ wurde mit C# und WPF entwickelt.

Ziel des Projekts ist die Verwaltung von Teilnehmern einer Umschulung. Die Anwendung ermöglicht das Anzeigen, Erstellen, Bearbeiten und Löschen von Teilnehmern.

Die Teilnehmerdaten werden über eine ObservableCollection verwaltet und in einer grafischen Benutzeroberfläche dargestellt.

---

## Funktionen

### Teilnehmerliste anzeigen

Alle vorhandenen Teilnehmer werden in einem DataGrid angezeigt.

### Teilnehmerdetails anzeigen

Nach Auswahl eines Teilnehmers werden folgende Informationen angezeigt:

- Vorname
- Nachname
- Geburtsdatum
- E-Mail
- Status
- Umschulung
- Kostenträger

### Teilnehmer anlegen

Neue Teilnehmer können über die Eingabemaske erstellt und gespeichert werden.

### Teilnehmer bearbeiten

Bereits vorhandene Teilnehmer können ausgewählt, bearbeitet und gespeichert werden.

### Teilnehmer löschen

Teilnehmer können nach einer Sicherheitsabfrage gelöscht werden.

### Eingabevalidierung

Folgende Validierungen wurden umgesetzt:

- Vorname ist erforderlich
- Nachname ist erforderlich
- E-Mail muss ein „@“ enthalten
- Umschulung muss ausgewählt werden
- Kostenträger muss ausgewählt werden

---

## Verwendete Technologien

- C#
- .NET
- WPF
- ObservableCollection
- Objektorientierte Programmierung (OOP)

---

## Projektstruktur

```text
Teilnehmerverwaltung
│
├── Models
│   ├── Teilnehmer.cs
│   ├── Umschulung.cs
│   └── Kostentraeger.cs
│
├── Services
│   └── TeilnehmerVerwaltung.cs
│
├── doc
│   ├── Aufgabe1_Analyse.md
│   ├── Testprotokoll.md
│   ├── ER_Diagramm.png
│   ├── UML_Klassendiagramm.png
│   └── Wireframe.png
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── App.xaml
├── App.xaml.cs
├── Teilnehmerverwaltung.csproj
└── README.md
```

---

## Klassenstruktur

### Teilnehmer

Enthält alle Informationen eines Teilnehmers:

- TeilnehmerNr
- Vorname
- Nachname
- Geburtsdatum
- Email
- Status
- Umschulung
- Kostentraeger

### Umschulung

Enthält Informationen zu einem Kurs:

- KursNr
- Bezeichnung
- Beginn
- Ende
- Raum

### Kostentraeger

Enthält Informationen zum Kostenträger:

- Id
- Name
- Ansprechpartner
- Telefon

### TeilnehmerVerwaltung

Verwaltet die Daten der Anwendung:

- TeilnehmerListe
- Umschulungen
- KostentraegerListe

---

## Dokumentation

Die vollständige Projektdokumentation befindet sich im Ordner:

```text
doc
```

Enthaltene Dokumente:

- Aufgabe1_Analyse.md
- Testprotokoll.md
- ER_Diagramm.png
- UML_Klassendiagramm.png
- Wireframe.png

---

## Testdaten

Für die Demonstration der Anwendung wurden fiktive Testdaten aus dem Universum „Game of Thrones“ verwendet.

Beispielteilnehmer:

- Jon Snow
- Arya Stark
- Tyrion Lannister
- Hodor
- Night King
- Sandor Clegane

Beispielkurse:

- Nachtwache und Grenzsicherung
- Drachenaufzucht und Flugtechnik
- Armee der Weißen Wanderer

Beispielkostenträger:

- Haus Targaryen
- Armee der Toten

---

## Durchgeführte Tests

Folgende Funktionen wurden erfolgreich getestet:

- Teilnehmerliste anzeigen
- Teilnehmerdetails anzeigen
- Teilnehmer anlegen
- Teilnehmer bearbeiten
- Teilnehmer löschen
- Eingabevalidierung

Die detaillierten Testergebnisse befinden sich im Dokument:

```text
doc/Testprotokoll.md
```

---

## Autorin

Ekaterina Chernova

Fachinformatikerin für Anwendungsentwicklung

Projekt: Teilnehmerverwaltung