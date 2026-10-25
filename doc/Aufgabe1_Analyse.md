# Aufgabe 1.1 Analyse

## Welche Daten wiederholen sich?

In der ursprünglichen Tabelle wiederholen sich mehrere Informationen regelmäßig. Dazu gehören:

- die Umschulung bzw. der Kurs
- der Raum
- der Kostenträger
- der Ansprechpartner des Kostenträgers
- die Telefonnummer des Kostenträgers

Diese Daten werden für mehrere Teilnehmer mehrfach gespeichert und führen zu Redundanzen.

---

## Mindestens zwei Datenfehler

Folgende mögliche Datenfehler können auftreten:

1. Derselbe Kostenträger wird unterschiedlich geschrieben (z. B. Abkürzungen oder verschiedene Schreibweisen).
2. Derselbe Ansprechpartner wird in unterschiedlichen Schreibweisen erfasst (z. B. vollständiger Name oder Abkürzungen).

Dadurch können Inkonsistenzen in der Datenverwaltung entstehen.

---

## Welches Feld ist nicht atomar?

Das Feld „Name“ ist nicht atomar, da es mehrere Informationen enthält.

Für eine bessere Datenstruktur sollte das Feld in folgende Attribute aufgeteilt werden:

- Vorname
- Nachname

Dadurch können die Daten einfacher verarbeitet, gesucht und sortiert werden.