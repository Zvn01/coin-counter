# Münzzähler
Dieser Code ist ein C# Programm, das einen Geldbetrag vom Benutzer entgegennimmt und den Betrag in Münzen wechselt. Der Code verwendet eine Schleife, um zu überprüfen, welche Münzen benötigt werden, um den Betrag zu wechseln, und gibt dann die Anzahl und den Wert der benötigten Münzen aus.

Der Code beginnt mit der Definition von drei Variablen: input_money ist der eingegebene Geldbetrag, muenzen ist ein Array, das die Werte der verschiedenen Münzen enthält, und muenzCount ist ein Array, das die Anzahl jeder Münze enthält, die benötigt wird, um den Betrag zu wechseln.

Der Code beginnt dann mit einem Try-Block, der eine Benutzereingabe von der Konsole erwartet. Wenn der Benutzer eine ungültige Eingabe macht (z.B. eine Zeichenfolge statt einer Zahl eingibt), wird eine FormatException ausgelöst und die Fehlermeldung wird ausgegeben.

Die Schleife durchläuft das muenzen-Array und prüft für jede Münze, ob sie in den eingegebenen Betrag passt. Wenn ja, wird die Anzahl der Münzen im muenzCount-Array erhöht und der Wert des input_money-Betrags wird entsprechend verringert. Die Schleife wiederholt diesen Vorgang für jede Münze, bis der gesamte Betrag in Münzen gewechselt wurde.

Schließlich gibt der Code die Anzahl und den Wert der benötigten Münzen auf der Konsole aus, indem er das muenzCount-Array durchläuft und die Elemente ausgibt, die größer als 0 sind.


