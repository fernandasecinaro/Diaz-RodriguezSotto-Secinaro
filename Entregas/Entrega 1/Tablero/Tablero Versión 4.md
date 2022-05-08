# Tablero Versión 4

En esta versión del tablero agregamos columnas a partir de definir previamente nuestro [proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%201/Proceso%20de%20Ingenier%C3%ADa/Proceso%20de%20Ingenieria).

Decidimos implementar un tablero compuesto por dos "subtableros". Esto significa que nuestro tablero va a tener dentro un tablero ágil y un tablero 
sustentable. Esto se debe a que identificamos que vamos a tener user stories, (las cuales se componen de tareas asociadas a su respectiva user story), 
y tareas no asociadas a ninguna user story, como lo es, por ejemplo, "Crear repositorio". 

Por lo tanto, el flujo de nuestro tablero es de la siguiente forma:

- Flujo para tareas no asociadas a user stories: Para estas tareas se va a utilizar el tablero ágil de nuestro tablero. Cuando se reciban tareas de este
tipo se van a colocar en la columna To Do. Luego cuando uno de los integrantes del equipo comience a trabajar en ella la tarjeta se debe pasar a la columna
In Progress. Finalmente, cuando la tarea esté lista se pasa a la columna Done. 

- Flujo para user stories: Para las user stories vamos a utilizar el tablero sustentable de nuestro tablero. Dicho tablero sustentable va a tener las siguientes columnas: Backlog, Requirements Definition, Test Cases Implementation, Application Implementation, Testing, Refactoring y Deployment. Es decir, vamos a tener una columna por cada tarea de BDD + Deployment, y un backlog donde se van a ir agregando las user stories a medida que vayan llegando. Tomamos la decisión de realizarlo de esta manera ya que creímos que era más fácil ir moviendo la tarjeta de una user story a través de todas las columnas, en vez de descomponer cada user story en tarjetas para las distintas tareas que representan cada paso del proceso. 

A continuación mostramos una imagen del tablero, con el tablero y la explicación de los dos flujos:

![image](https://user-images.githubusercontent.com/56087826/167052675-3ced5fe3-a992-40dc-962a-02712455c376.png)
