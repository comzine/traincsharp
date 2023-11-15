# Schäfer-Rätsel

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das herausfindet, wie viele Schafe ein Schäfer hat, wenn bekannt ist, dass, wenn seine Schafe in Gruppen von 2, 3, 4, 5 oder 6 laufen, immer 1 Schaf übrig bleibt, aber wenn sie in Gruppen von 7 laufen, es genau aufgeht. Der Schäfer hat weniger als 400 Schafe.

## Anforderungen

### Algorithmus

- Finde die Anzahl der Schafe, die der Bedingung entspricht:
  - Wenn in Gruppen von 2, 3, 4, 5, 6 geordnet wird, bleibt 1 Schaf übrig.
  - Wenn in Gruppen von 7 geordnet wird, geht es genau auf.
  - Es gibt weniger als 400 Schafe.

### Ausgabe

- Gib die Anzahl der Schafe aus, die die oben genannten Kriterien erfüllen.

### Hinweise

- Betrachte die Verwendung von Schleifen und bedingten Anweisungen.
- Prüfe Zahlen bis zu der angegebenen Obergrenze (weniger als 400).
- Überprüfe für jede Zahl, ob sie den Anforderungen entspricht.
- Der gesuchte Wert ist die kleinste Zahl, die allen Bedingungen genügt.

### Bonus

- Versuche, den Algorithmus so effizient wie möglich zu gestalten.

## Tipp

- Denke daran, dass Zahlen, die nach Division durch 2, 3, 4, 5 und 6 den Rest 1 ergeben, eine besondere Eigenschaft haben. Wie kannst du diese Eigenschaft nutzen, um deine Suche zu optimieren?
