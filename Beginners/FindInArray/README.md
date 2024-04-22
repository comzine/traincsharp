# Übung: Suche von Werten in Arrays

## Ziel der Übung

Das Ziel dieser Übung ist es, ein Konsolenprogramm in C# zu erstellen, welches einen bestimmten Wert in einem Array von Ganzzahlen sucht und den Index und den Wert, sofern er gefunden wurde, zurückgibt. Hierbei soll der Einsatz von ref bzw. out Parameter geübt werden.

## Anforderungen

1. Arrayerstellung: Erstelle ein Array von int mit mindestens 10 Elementen und weise ihm beliebige Werte zu.

2. Benutzereingabe: Frage den Benutzer nach einer Zahl, die gesucht werden soll.

3. Suche nach dem Wert: Erstelle eine Methode FindValue, die das Array, den zu suchenden Wert und zwei out Parameter für den Index und den gefundenen Wert nimmt. Diese Methode soll das Array durchgehen und beim Finden des gesuchten Wertes die out Parameter entsprechend setzen und die Suche beenden.

4. Ausgabe: Gib aus, ob der Wert gefunden wurde und wenn ja, an welchem Index und welcher Wert gefunden wurde.

Hinweis: Verwende ﻿out Parameter in der FindValue Methode, um den Index und den gefundenen Wert an die aufrufende Methode zurückzugeben.

## Optional

* Erweitere das Programm, so dass es nach mehreren Werten fragt und sucht, bis der Benutzer eine bestimmte Eingabe (z.B. "Ende") macht.
* Ändere das Programm so ab, dass es einen ref Parameter verwendet, um bei erfolgreicher Suche den ursprünglichen gesuchten Wert mit einem neuen Wert zu ersetzen. Der neue Wert könnte zum Beispiel das Doppelte des alten Werts sein.