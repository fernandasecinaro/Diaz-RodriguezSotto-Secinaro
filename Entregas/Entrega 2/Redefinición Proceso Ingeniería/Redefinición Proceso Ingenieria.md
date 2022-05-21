# Redefinición Proceso de Ingeniería

Realizamos ciertas adaptaciones respecto al [proceso de ingeniería de la entrega 1](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%201/Proceso%20de%20Ingenier%C3%ADa/Proceso%20de%20Ingenieria.md)

## Tareas no asociadas a ninguna user story
El flujo de estas tareas sigue igual que para la entrega 1. En este caso las tareas pasan simplemente de To Do a Doing y una vez listas de Doing a Done. Esto se debe a que como no están asociadas a ninguna user story no se aplica el proceso de BDD.

## Nuevas User Stories
La diferencia respecto a la entrega 1 es que se eliminó el paso "Deployment". Esto se debe a que, como hablamos en clase, y de acuerdo a la definition of done, no vamos a realizar el despliegue en esta entrega. Es decir, se va a realizar BDD por excelencia. Por lo tanto, el proceso para las user stories es:

- Requirements Definition (CCC): En este paso el input es la user story con solo el nombre y la narrativa definida, ya que esta información proviene del cliente o de quien haya actuado como product owner. El desarrollador encargado de esta tarea debe definir los criterios de aceptación de la user story, es decir, los distintos escenarios posibles en el lenguaje Gherkin. Esto lo logra a partir de la conversación con la persona que actuó como product owner. Al finalizar, el output de esta tarea es la user story con toda la información completa: nombre, narrativa y criterios de aceptación. Además, en la tarjeta de la user story se debe insertar el tamaño de la misma.

- Test Cases Implementation (Automation Tools): En esta tarea el input es la user story con toda su información, es decir, lo hecho en el paso de requirements definitions. A partir de esto se deben implementar los casos de prueba con herramientas de automatización. En nuestro caso, vamos a implementarlas con SpecFlow.

- Application Implementation (Code): En este paso el input es la user story con su respectiva implementación de test cases. En esta tarea se debe codificar la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso C#, porque solo se implementa el backend), de manera de cumplir con todos los criterios de aceptación escritos en el paso de requirements definition. Al finalizar esta tarea, tenemos la funcionalidad hecha.

- Testing (Automation Tools): Al llegar a este paso ya tenemos la funcionalidad codificada. Acá se deben correr los casos de prueba implementados en el paso 2 del proceso (Test Cases Implementation) y verificar que todos pasen, de lo contrario, se debe volver a corregir el código hasta que todos los casos de prueba lo hagan.

- Refactoring: Una vez que tenemos la funcionalidad hecha y todos nuestros casos de prueba pasaron, debemos hacer el refactoring. Esto es modificar el código para mejorar al mismo y al diseño de nuestra aplicación.

## Bugs
No habíamos definido un proceso para los bugs anteriormente. Debemos separar los bugs de backend respecto a los de frontend. Ya que, en el primer caso,  aplicaremos la metodología TDD, pero en el segundo no.

### Bug Backend
Como explicamos antes, la metodología usada para los bugs de backend va a ser TDD. O sea el proceso en este caso va a ser igual que para las nuevas user stories, a excepción del paso "Requirements Definition" que se va a omitir. Es decir, son los mismos pasos de BDD, a excepción del primero, que no se va a realizar en este caso. Además, el paso de Test Cases Implementation son pruebas unitarias, usando MsTets (En las nuevas US usamos SpecFlow, acá no):

- Test Cases Implementation (Automation Tools): A diferencia de las nuevas user stories no vamos a usar SpecFlow, sino que vamos a realizar pruebas unitarias, usando MsTest como librería.

- Application Implementation (Code): En esta tarea se debe codificar la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso C#), de manera de arreglar el bug. Al finalizar esta tarea, tenemos la funcionalidad correcta.

- Testing (Automation Tools): Acá se deben correr los casos de prueba implementados en el paso 2 del proceso (Test Cases Implementation) y verificar que todos pasen, de lo contrario, se debe volver a corregir el código hasta que todos los casos de prueba lo hagan.

- Refactoring: Una vez que tenemos la funcionalidad hecha y todos nuestros casos de prueba pasaron, debemos hacer el refactoring. Esto es modificar el código para mejorar al mismo y al diseño de nuestra aplicación.

### Bug Frontend
En este caso, como mencionamos antes, no vamos a aplicar TDD, porque no vamos a realizar pruebas unitarias del lado del frontend. Por lo tanto, solo vamos a realizar los pasos de codificación y refactoring:

- Application Implementation (Code): En esta tarea se debe codificar la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso Angular), de manera de arreglar el bug. Al finalizar esta tarea, tenemos la funcionalidad correcta.

- Refactoring: Una vez que arreglamos el bug en el frontend debemos hacer el refactoring. Esto es modificar el código para mejorar al mismo y al diseño de nuestra aplicación.
