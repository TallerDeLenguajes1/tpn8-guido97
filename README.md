## Resolución TP8
### 2) Investigue sobre:
#### 	a) Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?
Una list, es un arreglo (de hecho es igual a ArrayList, pero con tipo genérico) mientras que LinkedList es una lista enlazada. Por ello la principal diferencia es en rendimiento, siendo mejor LinkedList cuando se añade o remueven valores lejanos del principio en memoria, ya que todas las operaciones son O(1), es decir, no dependen de la cantidad de elementos, ya que se usan nodos independientes. Además conviene usar LinkedList si se quiere acceder 
Para List, la operación Add puede ser O(1) si no tiene que aumentar la capacidad, u O(n) si se debe aumentar la capacidad. El método remove (y removeAt) es O(n) porque se deben reasignar posiciones. 
En LinkedList el remove implica una búsqueda, por lo que es O(n) pero removeFirst y RemoveLast son O(1).

#### 	b) Objeto Diccionario

El objeto diccionario es un conjunto de pares Valor, clave. La recuperación de elementos es muy rápida por usar una tabla hash siendo casi O(1). Por esta misma razón, los elementos no tienen un orden.

#### 	c) Beneficios de usar una biblioteca, por que pondria una clase en una biblioteca y cuando agregaria 	directamente la clase en su proyecto

El uso de bibliotecas está relacionado a la reutilización de código, es decir si mi código es propenso a reutilizarse, lo pondría en una biblioteca, sino directamente como clase. 
Un ejemplo de código reutilizable es aquel para el manejo de archivos.

#### 	d) como se agrega la referencia a una biblioteca de clase en su proyecto

A través de la interfaz gráfica, con boton derecho en referencias y agregando la de nuestro interés. O con la palabra clave "using"