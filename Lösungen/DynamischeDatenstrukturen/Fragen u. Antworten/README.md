# Programmieren II Arbeitsblatt/Übung 2
## Dynamische Datenstrukturen

Die Übungsaufgabe findet sich im vorherigen Ordner implementiert.  
Für eventuelle Fragen gerne auch mich zukommen!

Die **Übungsfragen** findet ihr nachfolgend noch beantwortet.  
Falls ihr dort noch mehr Input habt und euch auf GitHub befindet, gerne einen PR erstellen ;)

### Übungsfragen
<br>
a) Wieso werden Arrays auch als statische Datenstrukturen bezeichnet?  
<details>
<summary>Antwort</summary>
Arrays werden einmal angelegt und haben dann eine feste Länge (wie vom User definiert).  
Da diese Länge nicht mehr geändert werden kann, werden Arrays als statisch bezeichnet.

```csharp
int[] a = new int[3]; // <- diese Länge ist fest, kann nicht mehr geändert werden.
```

Dem gegenüber stehen sog **dynamische** Datenstrukturen, welche eine variable Länge haben.
</details>
<br>
b) Welche Datenstruktur-Operationen können Arrays gut, und welche nicht?
<details>
<summary>Antwort</summary>
Vor allem Index-Operationen können Arrays sehr gut, da hängen die (einfach) verketteten Listen hinterher.
</details>
<br>
c) Wie kann man die „dynamischen Operationen“ mit Arrays simulieren?
<details>
<summary>Antwort</summary>
Beispiel: variable Länge des Arrays.

Dafür müsste eine extra Methode angelegt werden, welche bei einem Index, welcher OutOfBounds liegt, eine neues, größeres Array erstellt, und Elemente dementsprechend kopiert.  
Das ist nicht nur sehr umständlich, sondern bei vielen Elementen auch nicht mehr performant. Deshalb gibt es dynamische Datenstrukturen.

```csharp
int[] a = new int[3];
a = add(a, 2, 1);
a = add(a, 3, 2);
a = add(a, 1, 3);
a = add(a, 6, 4); // hier tritt ein Fehler auf, der behandelt werden muss, da nur 4 Elemente in einem Array mit der Länge 3 liegen.

public int[] add(int[] a, int data, int index) 
{
    try 
    {
        a[index] = data;
    }
    catch (Exception e)
    {
        // Hier muss das Array vergrößert werden.
        
        int[] temp = a;
        a = new int[temp.Length + 1];
        
        for (int i = 0; i < temp.Length; i++)
        {
            a[i] = temp[i];
        }        
        temp[index] = data;
    }
    
    return a;
}
```

An dieser kurzen Implementierung ist auch zu Erkennen, dass es nach jetzigem Stand für jeden Datentyp eine eigene Methode braucht.  
Dies ist natürlich sehr umständlich. Allerdings gibt es keinen anderen Weg, dynamische Operationen auf statischen Arrays abzubilden.
</details>
<br>
d) Wie ist „dynamische Datenstruktur“ definiert?
<details>
<summary>Antwort</summary>
Kurze Definition: Dynamische Datenstrukturen können sich zur Laufzeit des Programms an den wachsenden (oder sinkenden) Speicherbedarf anpassen.  
Falls neue Elemente hinzugefügt werden, wächst der Speicherbedarf -> die Liste muss sich daran anpassen (geschieht bei einfach verketteten Listen relativ einfach durch die Nachfolger-Referenz).
</details>
<br>
e) Wie kann man eine lineare Verkettung von Daten implementieren?
<details>
<summary>Antwort</summary>
Nachfolger-Referenzen (bzw. bei doppelt verketteten Listen noch Vorgänger-Referenzen).
</details>
<br>
f) Wie findet man den „Anfang“ einer verketteten Liste
<details>
<summary>Antwort</summary>
    
Der Anfang einer einfach verketteten Liste ist in der Liste als `head`-Referenz gespeichert.

```csharp
public class List {
    public Node head;
    
    public Node findStartOfListe {
        return head;
    }   
    
    // ...
}
```
Nachfolger-Referenzen (bzw. bei doppelt verketteten Listen noch Vorgänger-Referenzen).
</details>
<br>
g) Welche Detailschritte sind notwendig zum Anhängen und Einfügen von neuen Listendaten?
<details>
<summary>Antwort</summary>
Antwort hier in Pseudo-Code gegeben (sollte in der Prüfung bei solch einer Fragestellung auch reichen)

**Anhängen**:
```
Liste:
    anhaengen'(daten):
        wenn head noch nicht gesetzt:
            head <- neuer knoten(daten)
        sonst:
            rufe head.anhaengen mit daten auf
        end
    end
end
            
Knoten:
    anhaengen(daten):
        wenn nachfolger nicht gesetzt (jetziger knoten ist letztes element):
            nachfolger <- neuer knoten(daten)
        sonst:
            rekursiver aufruf nachfolger.anhaengen(daten)
        end
    end
end
```

**Einfügen** (in sortierter Reihenfolge):
```
Liste:
    einfügen'(daten):
        wenn head nicht gesetzt:
            head <- neuer Knoten(daten)
        sonst wenn daten < head.daten:
            vorne_einfügen(daten) // hier nicht implementiert
        sonst
            rufe head.einfügen mit daten auf
        end
    end
end

Knoten:
    einfügen:
        wenn nachfolger nicht gesetzt:
            nachfolger <- neuer knoten(daten)
        sonst wenn daten < nachfolger.daten:
            temp <- neuer knoten(daten)
            temp.nachfolger <- nachfolger
            nachfolger <- temp
        sonst:
            nachfolger.einfügen(daten)
        end
    end
end         
```
</details>
<br>
h) Welche Detailschritte sind notwendig zum Löschen von Listendaten?
<details>
<summary>Antwort</summary>

```
Liste:
    lösche'(daten):
        wenn head.daten gleich daten:
            head <- head.next
        sonst:
            head.next.lösche(daten)
        end
    end
end

Knoten:
    lösche(daten):
        wenn nachfolger.daten gleich daten:
            nachfolger = nachfolger.nachfolger
        sonst:
            nachfolger.lösche(daten)
        end
    end
end
```
</details>
<br>
i) Was bedeutet Listentraversierung und wie kann dies implementiert werden?
<details>
<summary>Antwort</summary>
    
Listentraversierung bedeutet das Durchlaufen einer Liste. Dies kann implementiert werden, indem die Liste durchgegangen wird, solange der Nachfolger nicht `null` ist.
</details>
<br>
j) Wie kann man Daten in einer Liste suchen?
<details>
<summary>Antwort</summary>

```
Knoten:
    suche(daten):
        wenn this.daten = daten:
            ausgabe gefunden
        sonst:
            nachfolger.suche(daten)
        end
    end
end
```
</details>
<br>
k) Was sind die Limitationen und Probleme einer einfachen verketteten Liste?
<details>
<summary>Antwort</summary>
    
- Vorgänger nicht bekannt -> etwas schwerer beim Löschen und Einfügen von Elementen
- Indexing nicht so einfach wie bei Arrays
- braucht vergleichweise mehr Speicherplatz als Arrays
</details>
<br>
l) Wie ist eine Liste zu erweitern, damit Daten in „richtiger“ Reihenfolge abgespeichert werden?
<details>
<summary>Antwort</summary>
    
Siehe Antwort g) zum Thema **Einfügen**
</details>
