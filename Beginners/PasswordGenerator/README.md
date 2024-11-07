# Übung: Zufälliger Passwortgenerator

## Ziel

Entwickle ein Konsolenprogramm in C#, das ein zufälliges Passwort mit einer benutzerdefinierten Länge generiert. Das Passwort soll Zahlen, Groß- und Kleinbuchstaben enthalten.

## Anforderungen

1. **Benutzereingabe**: Das Programm soll den Benutzer nach der gewünschten Länge des Passworts fragen.
2. **Zeichenauswahl**: Das generierte Passwort soll folgende Zeichen enthalten können:
   - Zahlen (0-9)
   - Großbuchstaben (A-Z)
   - Kleinbuchstaben (a-z)
3. **Zufallsgenerator**: Verwende die Random-Klasse zur Erzeugung zufälliger Zeichen.
4. **Ausgabe**: Zeige das generierte Passwort auf der Konsole an.

## Technische Details

- Verwende einen Zufallsbereich von 0-61 (62 mögliche Zeichen)
- Teile den Zufallsbereich wie folgt auf:
  - 0-9: Zahlen
  - 10-35: Großbuchstaben
  - 36-61: Kleinbuchstaben
- Nutze ASCII-Werte und Typumwandlung zur Zeichengenerierung

## Optional

- Erweitere das Programm um zusätzliche Sonderzeichen
- Füge eine Überprüfung für die minimale und maximale Passwortlänge hinzu
- Implementiere eine Validierung, dass mindestens ein Zeichen jeder Kategorie (Zahl, Groß- und Kleinbuchstabe) im Passwort vorkommt

## Hinweise

- Initialisiere den String `password` mit einem leeren String, um Nullreferenzfehler zu vermeiden
- Beachte die korrekte Berechnung der ASCII-Werte bei der Umwandlung der Zufallszahlen in Zeichen
