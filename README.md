# sliding
# CONSEGNA DELL'ESERCIZIO: Larghest Series Product

Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.

**Ad esempio:**

- data in ingresso la stringa "1027839564", 
- il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)
- e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).

- Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

# Procedimento

Si dichiarano due vettori di interi che hanno come dimensione la lunghezza della stringa data digits.

```
        int[] valori = new int[digits.Length];
        int[] array = new int[digits.Length];
```C#

A questo punto si esegue il primo ciclo, che si esegue per ogni valore contenuto in uno degli array, in quanto lo scopo di questo primo for è quello di trasferire i dati della stringa digits (convertiti in intero) all'interno del vettore array.

```
        for (int i = 0; i < digits.Length; i++){
            array[i] = Convert.ToInt32(digits[i]);
        }
```C#
