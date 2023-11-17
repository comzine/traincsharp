# Übung: Überprüfen der Gültigkeit einer IP-Adresse

## Ziel

Diese Übung soll die Fähigkeit trainieren, Algorithmen zur Überprüfung der Gültigkeit von IP-Adressen in C# zu entwickeln und zu verstehen.

## Beschreibung

Schreiben Sie ein C#-Programm, das eine IP-Adresse vom Benutzer einliest und überprüft, ob diese IP-Adresse gültig ist. Eine gültige IP-Adresse besteht aus vier Teilen, getrennt durch Punkte, wobei jeder Teil eine Zahl zwischen 0 und 255 ist.

## Anforderungen

- Implementieren Sie das Programm in der `Main`-Funktion.
- Fordern Sie den Benutzer auf, eine IP-Adresse einzugeben.
- Überprüfen Sie, ob die eingegebene IP-Adresse gültig ist.
- Geben Sie das Ergebnis auf der Konsole aus: "IP Address: [IP] is valid" oder "IP Address: [IP] is invalid", je nachdem, ob die IP-Adresse gültig ist oder nicht.

## Beispiel

```
Enter an IP address: 192.168.1.1
IP Address: 192.168.1.1 is valid

Enter an IP address: 256.100.50.25
IP Address: 256.100.50.25 is invalid
```

## Hinweise

- Verwenden Sie eine Schleife und bedingte Anweisungen, um die einzelnen Teile der IP-Adresse zu extrahieren und zu überprüfen.
- Beachten Sie, dass jeder Teil der IP-Adresse eine Zahl zwischen 0 und 255 sein muss.
- Behandeln Sie Ausnahmen, die auftreten können, wenn die Teile der IP-Adresse nicht in Zahlen umgewandelt werden können.