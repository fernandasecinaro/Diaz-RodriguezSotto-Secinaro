# Alta Punto de Carga

Como comentario importante queremos destacar que realizamos un cambio en la narrativa de la user story, respecto a la de la entrega 2. Ya que, en la entrega anterior, habíamos considerado que solo los administradores de la aplicación podían realizar el alta de un punto de carga. En cambio, ahora decidimos realizar una modificación, pasando a considerar que cualquier usuario del sistema puede realizar dicha funcionalidad. Por lo tanto, la nueva narrativa es:

```
Como usuario,
Quiero dar de alta un punto de carga para autos eléctricos,
Para informar acerca de un nuevo lugar donde se pueden cargar los autos eléctricos
```

A partir de realizar estos cambios, tuvimos que hacer ciertas modificaciones en lo que ya habíamos implementado para el backend. Además, de realizar la nueva funcionalidad para el frontend.

Por lo tanto, como lo definimos en nuestro proceso de ingeniería, realizamos los siguientes pasos:

- **Requirements Definition**: Escribimos los criterios de aceptación.

- **Test Cases Implementation**: En el caso del backend realizamos los casos de prueba con SpecFlow. Por otro lado, en el frontend realizamos los casos de prueba usando Selenium. Vale destacar que hubo que realizar ciertas modificaciones de los escenarios escritos en el primero paso para adaptarlos a las distintas tecnologías. Por ejemplo, en el caso del frontend, en Selenium no podemos automatizar los escenarios que se pasaban del largo máximo de caracteres del input, ya que al implementarlos en el paso 3, los inputs tendrían un atributo "max" que no deja que se escriba más de ese largo.

- **Application Implementation**: En este paso codificamos la funcionalidad. En el caso del backend lo hicimos en .NET, mientras que en el frontend usamos Angular.

- **Testing**: Verificamos que todos los casos de prueba que hicimos en el paso 2 pasen.

- **Refactoring**: Realizamos refactoring del código para mejorar la calidad del mismo.

- **Integration Testing**: Realizamos una prueba de integración para comprobar que el frontend y el backend funcionen juntos tal cual es esperado. Para esto usamos el IDE de Cucumber.

Algo importante a destacar de esta funcionalidad para el frontend es que lo ideal sería que cuando se realice correctamente el alta del punto de carga se borren los valores del formulario. Realmente quisimos hacer esto, pero de la forma que están implementado los inputs iba a llevar un buen tiempo, por lo que decidimos agregarlo como una issue a realizar, como posible mejora de usabilidad. 
