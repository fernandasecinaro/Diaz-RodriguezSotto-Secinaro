# Tablero Versión 2

En esta versión del tablero realizamos cambios a partir de haber [redefinido previamente nuestro proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinición%20Proceso%20Ingenier%C3%ADa/Redefinición%20Proceso%20Ingenieria.md).

El único cambio visual que realizamos en el tablero fue la eliminación de la columna "Deployment", ya que como explicamos en la redefinición del proceso de ingeniería, para esta instancia no vamos a realizar un despliegue. Por lo tanto, eliminamos la columna, ya que no se iba a usar, y decidimos que cuando sea necesario en futuras instancias la volvamos a agregar.

Igualmente, también definimos un flujo para los bugs, el cual no habíamos hecho anteriormente. Pero para esto no fue necesario agregar columnas al tablero.

Por lo tanto, el flujo de nuestro tablero al redefinir el proceso de ingeniería quedó de la siguiente forma:

- **Flujo para tareas no asociadas a user stories**: No se modificó respecto a como estaba antes. Para estas tareas se va a utilizar el tablero ágil de nuestro tablero. Cuando se reciban tareas de este tipo se van a colocar en la columna To Do. Luego cuando uno de los integrantes del equipo comience a trabajar en ella la tarjeta se debe pasar a la columna In Progress. Finalmente, cuando la tarea esté lista se pasa a la columna Done.

- **Flujo para user stories nuevas**: Para las user stories vamos a utilizar el tablero sustentable de nuestro tablero. Dicho tablero sustentable va a tener las siguientes columnas: Backlog, Requirements Definition, Test Cases Implementation, Application Implementation, Testing y Refactoring. Es decir, vamos a tener una columna por cada tarea de BDD y un backlog donde se van a ir agregando las user stories a medida que vayan llegando. Como dijimos antes, acá se puede observar la eliminación de la columna "Deployment" respecto a las versiones anteriores del tablero.

- **Flujo para bugs backend**: Como explicamos en la redefinición del proceso de ingeniería, el flujo va a ser los mismos pasos de BDD, a excepción de Requirements Definition. O sea, vamos a usar un subconjunto del tablero sustentable. Por lo tanto el flujo en este caso va a ser: Backlog, Test Cases Implementation, Application Implementation, Testing y Refactoring.

- **Flujo para bugs frontend**: En este caso también vamos a usar un subconjunto del tablero sustentable, ya que solo vamos a aplicar los pasos Application Implementation y Refactoring de TDD. Por lo tanto el flujo en este caso va a ser: Backlog, Application Implementation y Refactoring.

A continuación mostramos una imagen del tablero, con el tablero y la explicación de los distintos flujos:

![image](https://user-images.githubusercontent.com/56087826/169658596-c196dd0f-6609-4e79-8621-d360bf5a75c4.png)
