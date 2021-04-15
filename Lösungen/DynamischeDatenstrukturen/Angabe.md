# Angabe zur Aufgabe (Paraphrased)

**Schritt 1 –**  
Implementieren Sie zunächst die interne Datenstruktur („Network“).  
Diese Datenstruktur soll auf einer verketteten Liste basieren, aber eine ringförmige Struktur aufweisen (d. h. das letzte Element soll wieder auf das erste Element verweisen)! Ein Listen-, oder besser gesagt „Ringelement“, soll dabei – wie oben beschrieben – ein Netzwerkgerät („Device“) darstellen.  
Jedes Netzwerkgerät soll neben den Informationen zur Verkettung (= eine „Nachfolger-Referenz“), die eigene Netzwerk-Adresse enthalten sowie eine Statistik (= zwei Zähler) wie viele Datenpakete es selbst gesendet („Upload“) und (erfolgreich) empfangen („Download“) hat.  

Die Netzwerk-Datenstruktur soll – neben eventueller weiterer benötigter Hilfsfunktionalität – die folgenden Operationen (Methoden) implementieren:  
  - Hinzufügen eines neuen Netzwerk-Gerätes (basierend auf einer angegeben Netzwerk-Adresse des Vorgänger-Gerätes), ...   
  - Entfernen eines Netzwerk-Gerätes (basierend auf einer angegebenen Netzwerk-Adresse), ...  
  - Ausgabe des Netzwerkes auf der Konsole (d. h. Auflistung aller enthaltenen Geräte, inklusive der jeweiligen Netzwerk-Adresse und der Statistikwerte). 


**Schritt 2 –**  
Implementieren Sie dann eine zweite Klasse „Simulator“, die das Versenden eines Datenpaketes von einer Sender- zu einer Empfänger-Adresse für ein vorgegebenes Netzwerk simuliert.  
Die Simulation kann über einer Methode („Start“) angestoßen werden, bei der die Sender- und Empfängeradressen sowie die eigentlichen Daten (also in dieser Aufgabe ein String) übergeben werden können. 

Die Methode solle dann das zugrundeliegende Netzwerk durchlaufen und dabei schrittweise ausgeben
  - welches Gerät sendet,
  - welches Gerät das Datenpaket weiterleitet und
  - welches Gerät das Datenpaket (erfolgreich) empfängt oder
  - wenn ein Datenpaket nicht zugestellt werden konnte.


**Schritt 3 –**  
Entwickeln Sie dann eine textbasierte Benutzeroberfläche, mit der Sie die Verwaltung des Netzwerks (z. B. Hinzufügen und Entfernen von Geräten) sowie den oben beschrieben Token-Ring-Netzwerk-Simulator steuern können.  

```
Status des Ringpuffer-Netzwerks:
Leer

Menü:
(1) Neue Geräte hinzufügen 
(2) Gerät entfernen
(3) Datenpaket versenden 
(4) Programm beenden
>1

Neue Geräte hinzufügen...
Anzahl neuer Geräte > 3
```

```
Menü:
(1) Neue Geräte hinzufügen 
(2) Gerät entfernen
(3) Datenpaket versenden 
(4) Programm beenden
>1

Neue Geräte hinzufügen...
Adresse des Vorgänger-Geräts > 2
Anzahl neuer Geräte > 1

```

```
Menü:
(1) Neue Geräte hinzufügen 
(2) Gerät entfernen
(3) Datenpaket versenden 
(4) Programm beenden
>3

Datenpaket versenden...
Datenwert: Testpaket
Adresse des Senders: 4
Adresse des Empfängers: 1

Starte Simulation...
Gerät 4 sendet Datenpaket („Testpaket“, 4, 1)
Gerät 3 leitet Datenpaket („Testpaket“, 4, 1) weiter 
Gerät 1 empfängt Datenpaket („Testpaket“, 4, 1)

Simulation beendet. Bitte eine Taste drücken...
```
Hiernach ist:
| Gerät   | Upload  | Download  |
| :-----: |:-------:| :--------:|
| 4       |    1    |      0    |
| 3       |    0    |      0    |
| 1       |    0    |      1    |
