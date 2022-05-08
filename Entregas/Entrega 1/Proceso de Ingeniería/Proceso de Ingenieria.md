# Proceso de Ingeniería

Para definir el proceso de ingeniería identificamos que vamos a tener user stories, (las cuales se componen de tareas asociadas a su respectiva user story), 
y tareas no asociadas a ninguna user story, como lo es, por ejemplo, "Crear repositorio". A raíz de esto definimos dos "subprocesos" distintos, uno para 
cada tipo.

## User stories

Considerando que vamos a utilizar el ciclo de BDD para el desarrollo de las user stories definimos el siguiente proceso:

- Requirements Definition (CCC): En este paso el input es la user story con solo el nombre y la narrativa definida, ya que esta información proviene 
del cliente o de quien haya actuado como product owner. El desarrollador encargado de esta tarea debe definir los criterios de aceptación de la user story, 
es decir, los distintos escenarios posibles en el lenguaje Gherkin. Esto lo logra a partir de la conversación con la persona que actuó como product owner. 
Al finalizar, el output de esta tarea es la user story con toda la información completa: nombre, narrativa y criterios  de aceptación. Además, en la 
tarjeta de la user story se debe insertar el tamaño de la misma. 

- Test Cases Implementation (Automation Tools): En esta tarea el input es la user story con toda su información, es decir, lo hecho en el paso de 
requirements definitions. A partir de esto se deben implementar los casos de prueba con herramientas de automatización. En nuestro caso, vamos a 
implementarlas con SpecFlow.

- Application Implementation (Code): En este paso el input es la user story con su respectiva implementación de test cases. En esta tarea se debe codificar
la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso C# y Angular), de manera de cumplir con todos los 
criterios de aceptación escritos en el paso de requirements definition. Al finalizar esta tarea, tenemos la funcionalidad hecha. 

- Testing (Automation Tools): Al llegar a este paso ya tenemos la funcionalidad codificada. Acá se deben correr los casos de prueba implementados en el 
paso 2 del proceso (Test Cases Implementation) y verificar que todos pasen, de lo contrario, se debe volver a corregir el código hasta que todos los casos
de prueba lo hagan.

- Refactoring: Una vez que tenemos la funcionalidad hecha y todos nuestros casos de prueba pasaron, debemos hacer el refactoring. Esto es modificar el 
código para mejorar al mismo y al diseño de nuestra aplicación. 

- Deployment: Una vez que nuestro código está listo, y hacemos el commit a GitHub, se desencandena toda la pipline hasta que los cambios se despliegan a 
producción. Este proceso se va a realizar automáticamente con prácticas de CI/CD.

## Tareas no asociadas a ninguna user story

En este caso las tareas pasan simplemente de To Do a Doing y una vez listas de Doing a Done. Esto se debe a que como no están asociadas a ninguna user story
no se aplica el proceso de BDD.

## ¿Cómo queda nuestro tablero al definir el proceso de ingeniería?

[Link a explicación del tablero luego de definir nuestro proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%201/Tablero/Tablero%20Versión%204.md)

## Método de branching

Dentro de nuestro proceso de ingeniería también consideramos importante definir que método de branching vamos a utilizar. En nuestro caso, decidimos implementar
el método GitFlow. 

¿Por qué elegimos GitFlow por encima de Trunk based development?

- En el futuro, cuando realicemos pull requests de cambios en el código vamos a hacer reviews como actividad de revisión manual. Esto es para que los desarrolladores
podamos comentar los cambios hechos y discutir la solución, para posteriormente aprobarlo y recién ahí hacer el merge. Consideramos que esto era fundamental
para nuestro equipo, ya que, si bien hemos trabajado con las tecnologías utilizadas para el desarrollo de la aplicación, ninguno de los integrantes es 
experto en las mismas, por lo tanto creímos conveniente que realizar reviews de los pull requests iba a ser una buena práctica de desarrollo.

- Nuestro equipo está formado por pocos integrantes (3 en total), por lo tanto, no va a haber problemas grandes de conflictos al mergear a develop. 

- No está pensado escalar el proyecto a un equipo con muchos integrantes

- Es una aplicación de tipo monolítico

- Es una aplicación de tipo Brown-field.

- Usar el método trunk based requeriría de implementar una página de feature toggles, para poder desactivar las funcionalidades que aún no están
listas para ser mostradas a los usuarios en producción. Creímos que realizar esto era una complejidad muy grande, ya que requeriría de mucho tiempo.
