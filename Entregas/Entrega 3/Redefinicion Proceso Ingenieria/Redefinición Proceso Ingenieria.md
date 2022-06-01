# Redefinición Proceso de Ingeniería

Realizamos ciertas adaptaciones respecto al [proceso de ingeniería de la entrega 2](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinición%20Proceso%20Ingenier%C3%ADa/Redefinición%20Proceso%20Ingenieria.md). Esto se debe a que en esta entrega hay que realizar las funcionalidades del lado del frontend, por lo tanto, definiremos un proceso de ingeniería para las user stories teniendo en cuenta que el desarrollo es tanto del lado del frontend como del backend.

Es decir, lo que cambió respecto al proceso de ingeniería de la entrega 2 es que agregamos una definición de proceso de ingeniería teniendo en cuenta que ahora también hay desarrollo en el lado del frontend, ya que en la entrega 2 cuando nos referimos a "Proceso de Ingeniería de nuevas User stories", hablábamos específicamente de user stories de backend, ya que no había que implementar nuevas funcionalidades en el frontend, era solo backend. 

A continuación detallamos el proceso de ingeniería para nuevas user stories, (para los bugs y tareas no asociadas a user stories quedó igual que para la entrega anterior):

## Nuevas User Stories

Como ahora hay que realizar también la implementación del frontend, definimos el siguiente proceso de ingeniería:

Se va a realizar BDD, pero además, le vamos a agregar un paso extra, que es el de Integration Testing. Por lo tanto, el proceso para las user stories es:

- Requirements Definition (CCC): En este paso el input es la user story con solo el nombre y la narrativa definida, ya que esta información proviene del cliente o de quien haya actuado como product owner. El desarrollador encargado de esta tarea debe definir los criterios de aceptación de la user story, es decir, los distintos escenarios posibles en el lenguaje Gherkin (es importante aclarar que los escenarios de backend y frontend pueden variar entre sí). Esto lo logra a partir de la conversación con la persona que actuó como product owner. Al finalizar, el output de esta tarea es la user story con toda la información completa: nombre, narrativa y criterios de aceptación. Además, en la tarjeta de la user story se debe insertar el tamaño de la misma.

A partir de este paso la user story se subdivide en 2 user stories: una de backend y otra de frontend. Las cuales se pueden trabajar en paralelo por diferentes desarrolladores. Por ende, los siguientes 4 pasos se desarrollan de forma paralela (hasta refactoring inclusive), mientras que al llegar al último paso (integration testing) se vuelven a juntar para verificar que funcionen bien de forma unida.

- Test Cases Implementation (Automation Tools): En esta tarea el input es la user story con toda su información, es decir, lo hecho en el paso de requirements definitions. A partir de esto se deben implementar los casos de prueba con herramientas de automatización, para automatizar el testing funcional. En el caso del backend vamos a implementarlas con SpecFlow, mientras que en el frontend se realiza con protractor y Cucumber.

- Application Implementation (Code): En este paso el input es la user story con su respectiva implementación de test cases. En esta tarea se debe codificar la funcionalidad de la user story en un lenguaje de programación previamente definido (en nuestro caso .NET para el backend y Angular para el frontend), de manera de cumplir con todos los criterios de aceptación escritos en el paso de requirements definition. Al finalizar esta tarea, tenemos la funcionalidad hecha.

- Testing (Automation Tools): Al llegar a este paso ya tenemos la funcionalidad codificada. Acá se deben correr los casos de prueba implementados en el paso 2 del proceso (Test Cases Implementation) y verificar que todos pasen, de lo contrario, se debe volver a corregir el código hasta que todos los casos de prueba lo hagan.

- Refactoring: Una vez que tenemos la funcionalidad hecha y todos nuestros casos de prueba pasaron, debemos hacer el refactoring. Esto es modificar el código para mejorar al mismo y al diseño de nuestra aplicación.

- Integration Testing: Una vez que las funcionalidades de backend y frontend están terminadas, las volvemos a unir en este paso. Para esto realizamos un paso de testing de integración automático para verificar que el frontend y backend funcionan bien juntos. Este paso lo realizamos con el IDE de Selenium. Al usar esto primero debemos realizar la prueba manualmente, grabándola con Selenium, y luego el resto de las veces que queramos probar el caso de prueba basta con correr la grabación, ya que queda automatizado.

## ¿Cómo queda nuestro tablero al redefinir el proceso de ingeniería?

[Link a explicación del tablero luego de redefinir nuestro proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%203/Tablero/Tablero%20-%20Version%202.md)


