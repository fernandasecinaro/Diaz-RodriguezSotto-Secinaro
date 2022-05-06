# Templates de Issues

[Link a templates](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/issues/templates/edit)

## Labels

Creamos dos diferentes tipos de [labels](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/labels) para clasificar los distintos tipos de issues. Las labels creadas fueron:

- User Story (Color verde)
- Tarea (Color violeta)

La idea de las labels es que cada vez que creemos una nueva issue, se le asigne automáticamente, según el template elegido, una de estas labels para poder clasificar la issue según su tipo.
Esto es beneficioso ya que en el tablero se muestra la label, y por ende, es fácil identificar qué tipo de issue es.

## Template para Tareas

Para el template de las tareas, las cuales son independientes de una user story, creímos conveniente mostrar los siguientes datos:

- Título: Título corto pero descriptivo de la tarea
- Descripción: Detalle de la tarea a realizar.
- Esfuerzo: Una tabla con 2 columnas: esfuerzo estimado (cuanto estimamos que va a llevar la tarea antes de empezar a realizarla) y esfuerzo real (cuánto llevo realmente).
- Label: En este caso la label siempre va a ser "Tarea", esta se pone por defecto. 

A continuacion mostramos una imagen del template:

![image](https://user-images.githubusercontent.com/56087826/167061450-d5e02e9e-eed1-4ab1-9fbc-d16d4f781972.png)

### Adaptación de tareas en tablero

Con los templates ya terminados, actualizamos todas las tareas que ya habían sido creadas previamente para que cumplan con este template. Esto se puede
ver en la [versión 3 del tablero](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%201/Tablero/Tablero%20versión%203.md)

## Template para User Stories

Al finalizar nuestra definición de [proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%201/Proceso%20de%20Ingenier%C3%ADa/Proceso%20de%20Ingenieria.md) pudimos comenzar a realizar el template para las user stories, esto se debe a que primero debíamos definir dicho proceso para saber de qué tareas de BDD se componen las user stories y así poder armar la tabla de esfuerzos que se va a ver a continuación. 

Para este template creímos conveniente mostrar los siguientes datos:

- Nombre: Nombre de la user story
- Tamaño: Tamaño de la user story en story points
- Narrativa: Narrativa de la user story. Escrita con el template "Como, quiero, para".
- Criterios de aceptación: Se detallan todos los escenarios posibles para la user story. Deben ser escritos con el template "Dado, cuando, entonces".
- Esfuerzo: Una tabla con 3 columnas: nombre de la tarea, esfuerzo estimado (cuanto estimamos que va a llevar la tarea antes de empezar a realizarla) y esfuerzo real (cuánto llevo realmente). Por cada tarea del ciclo de BDD ponemos una fila, indicando los esfuerzos antes mencionados para dicha tarea. Además,
también se detalla el esfuerzo total, esto es, la suma de todos los esfuerzos reales.
- Label: En este caso la label siempre va a ser "User Story", esta se pone por defecto. 

A continuacion mostramos una imagen del template:

![image](https://user-images.githubusercontent.com/56087826/167060980-9e26597e-cbec-42c3-9851-e9fc89906c89.png)

## Template para Issues encontrados durante análisis de deuda técnica

Hicimos un template para los issues encontrados durannte el análisis de la deuda técnica.

- Nombre: Intentamos ponerles un título nombre, que permita identificar cuál es el problema, solo con leerlo.
- Descripción: Descripción detallada del issue. En caso de conocerse el motivo se explica.
- Resultado esperado: Qué resultado se espera obtener cuando se corrija el issue.
- Pasos a reproducir: Se enumeran los pasos en el sistema que llevan a generar ese issue.
- Prioridad: Qué prioridad tiene el issue para ser solucionado.
- Severidad: Qué impacto tiene el issue en el sistema.
- Clasificación: Si el issue es un bug, o un issue de usabilidad, problemas de estándar, etc.
- Imágenes: En caso de que se necesite realizar una explicación del issue de forma más gráfica se recurre a la ayuda de imágenes.

A continuacion mostramos una imagen del template:

<img width="453" alt="image" src="https://user-images.githubusercontent.com/56087826/167214718-16b53f76-523c-44f9-b20e-c3773c3f118d.png">
