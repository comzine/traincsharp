# Übung: Verwaltung einer Musik-Playlist mithilfe von Arrays

## Ziel der Übung
Das Ziel dieser Übung ist es, ein Konsolenprogramm in C# zu erstellen, welches eine Playlist von Musiktiteln verwaltet (hinzufügen und anzeigen). Hierbei sollen Arrays und Benutzereingabe geübt werden. Da Arrays eine feste Länge haben, nehmen wir an, dass die Playlist auf maximal 10 Titel beschränkt ist.

## Anforderungen
1. **Playlist-Erstellung:** Erstelle ein Array von Strings mit 10 Elementen zur Darstellung der Musiktitel. Initialisiere alle Elemente mit dem leeren String.

2. **Listenverwaltung:** Erstelle Funktionen 'AddSong' und 'DisplayPlaylist'.
    - '`AddSong`': Frage den Benutzer nach einem Titel und füge den eingegebenen Titel an die erste verfügbare Position der Playlist hinzu (d.h. an den Ort, der noch den leeren String hält). Wenn alle Positionen belegt sind, informiere den Benutzer, dass keine weiteren Titel hinzugefügt werden können.
    - '`DisplayPlaylist`': Gehe durch das Array und drucke alle Einträge, die nicht der leere String sind aus.
   
3. **Benutzereingabe:** Frage den Benutzer, welche Aktion er durchführen möchte - einen Titel hinzufügen oder die Playlist anzeigen.

## Hinweise
-  Achte darauf, dass du nach jeder Hinzufügung prüfst, ob noch Platz in der Playlist ist.
-  Bei der Anzeige der Playlist, filtere die leeren Strings aus, um nur die tatsächlichen Titel anzuzeigen.

## Optional
Erweitere das Programm, sodass es weiterhin nach Aktionen vom Benutzer fragt, bis er eine bestimmte Eingabe (z.B. "Ende") macht.