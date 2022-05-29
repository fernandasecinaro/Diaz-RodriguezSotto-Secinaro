# Redefinición Proceso de Ingeniería

Realizamos ciertas adaptaciones respecto al [proceso de ingeniería de la entrega 2](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinición%20Proceso%20Ingenier%C3%ADa/Redefinición%20Proceso%20Ingenieria.md). Esto se debe a que en esta entrega hay que realizar las funcionalidades del lado del frontend, por lo tanto, definiremos un proceso de ingeniería para las user stories de frontend, separándolo del de backend.

Es decir, lo que cambió respecto al proceso de ingeniería de la entrega 2 es que agregamos una definición de proceso de ingeniería para las user stories de frontend, ya que en la entrega 2 cuando nos referimos a "Proceso de Ingeniería de nuevas User stories", hablábamos específicamente de user stories de backend, ya que no había que implementar nuevas funcionalidades del frontend, era solo backend. 

A continuación detallamos la división del proceso de ingeniería para user stories de backend y frontend, (el resto quedó igual que para la entrega anterior):

## Nuevas User Stories Backend

Sigue siendo el mismo proceso que el definido en la entrega 2. Es decir, se va a realizar BDD por excelencia. Por lo tanto, el proceso para las user stories de backend es:

- Requirements Definition (CCC): En este paso el input es la user story con solo el nombre y la narrativa definida, ya que esta información proviene del cliente o de quien haya actuado como product owner. El desarrollador encargado de esta tarea debe definir los criterios de aceptación de la user story, es decir, los distintos escenarios posibles en el lenguaje Gherkin. Esto lo logra a partir de la conversación con la persona que actuó como product owner. Al finalizar, el output de esta tarea es la user story con toda la información completa: nombre, narrativa y criterios de aceptación. Además, en la tarjeta de la user story se debe insertar el tamaño de la misma.

- Test Cases Implementation (Automation Tools): En esta tarea el input es la user story con toda su información, es decir, lo hecho en el paso de requirements definitions. A partir de esto se deben implementar los casos de prueba con herramientas de automatización. En nuestro caso, vamos a implementarlas con SpecFlow.

- Application Implementation (Code): En este paso el input es la user story con su respectiva implementación de test cases. En esta tarea se debe codificar la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso C#, porque solo se implementa el backend), de manera de cumplir con todos los criterios de aceptación escritos en el paso de requirements definition. Al finalizar esta tarea, tenemos la funcionalidad hecha.

- Testing (Automation Tools): Al llegar a este paso ya tenemos la funcionalidad codificada. Acá se deben correr los casos de prueba implementados en el paso 2 del proceso (Test Cases Implementation) y verificar que todos pasen, de lo contrario, se debe volver a corregir el código hasta que todos los casos de prueba lo hagan.

- Refactoring: Una vez que tenemos la funcionalidad hecha y todos nuestros casos de prueba pasaron, debemos hacer el refactoring. Esto es modificar el código para mejorar al mismo y al diseño de nuestra aplicación.

## Nuevas User Stories Frontend

En el caso del frontend también se van a realizar los pasos de BDD, pero usaremos Selenium en el paso de test cases implementation, para automatizar el test funcional. Además, agregamos un paso de Integration Testing, para probar la integración del frontend con el backend, y verificar que funcione bien todo unido. 
Por lo tanto, el proceso para las user stories de frontend es:

- Requirements Definition (CCC): En este paso el input es la user story con solo el nombre y la narrativa definida, ya que esta información proviene del cliente o de quien haya actuado como product owner. El desarrollador encargado de esta tarea debe definir los criterios de aceptación de la user story, es decir, los distintos escenarios posibles en el lenguaje Gherkin. Esto lo logra a partir de la conversación con la persona que actuó como product owner. Al finalizar, el output de esta tarea es la user story con toda la información completa: nombre, narrativa y criterios de aceptación. Además, en la tarjeta de la user story se debe insertar el tamaño de la misma.

- Test Cases Implementation (Automation Tools): En esta tarea el input es la user story con toda su información, es decir, el output del paso de requirements definitions. A partir de esto se deben implementar los casos de prueba con herramientas de automatización de testing funcional en base a la interfaz de usuario. En nuestro caso, vamos a realizarlo con Selenium.

- Application Implementation (Code): En este paso el input es la user story con su respectiva implementación de test cases. En esta tarea se debe codificar la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso Angular, porque se implementa el frontend), de manera de cumplir con todos los criterios de aceptación escritos en el paso de requirements definition. Al finalizar esta tarea, tenemos la funcionalidad hecha.

- Testing (Automation Tools): Al llegar a este paso ya tenemos la funcionalidad codificada. Acá se deben correr los casos de prueba implementados en el paso 2 del proceso (Test Cases Implementation) y verificar que todos pasen, de lo contrario, se debe volver a corregir el código hasta que todos los casos de prueba lo hagan.

- Refactoring: Una vez que tenemos la funcionalidad hecha y todos nuestros casos de prueba pasaron, debemos hacer el refactoring. Esto es modificar el código para mejorar al mismo y al diseño de nuestra aplicación.

- Integration Testing: Realizamos un paso de testing de integración manual para verificar que el frontend y backend funcionan bien juntos. Es importante aclarar que este paso solo lo agregamos en el caso de las user stories de frontend porque ya habíamos realizado en la entrega anterior las user stories de backend. O sea, en el caso de que se tenga que implementar una user story tanto del lado del frontend como del backend al mismo tiempo esto se debería hacer distinto. Como hablamos en clase, para este último caso, podríamos tener una user story general, que a partir del paso de Test Cases Implementation se divida en 2 user stories, una para el frontend y otra para el backend, y luego en el paso de testing de integración se vuelva a juntar todo. Pero como en nuestro caso no tenemos que realizar el frontend y backend al mismo tiempo no lo implementamos de esta manera. 

## ¿Cómo queda nuestro tablero al redefinir el proceso de ingeniería?

[Link a explicación del tablero luego de redefinir nuestro proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%203/Tablero/Tablero%20-%20Version%202.md)


