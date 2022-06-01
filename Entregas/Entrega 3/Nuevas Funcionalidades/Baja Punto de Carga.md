# Baja Punto de Carga

Como comentario importante queremos destacar que realizamos un cambio en la narrativa de la user story, respecto a la de la entrega 2. Ya que, en la entrega anterior, habíamos considerado que solo los administradores de la aplicación podían realizar la baja de un punto de carga. En cambio, ahora decidimos realizar una modificación, pasando a considerar que cualquier usuario del sistema puede realizar dicha funcionalidad. Por lo tanto, la nueva narrativa es:

```
Como usuario,
Quiero poder dar de baja un punto de carga,
Para indicar que ya no está disponible para que los turistas carguen su auto
```

A partir de realizar estos cambios, tuvimos que hacer ciertas modificaciones en lo que ya habíamos implementado para el backend. Además, de realizar la nueva funcionalidad para el frontend.

Por lo tanto, como lo definimos en nuestro proceso de ingeniería, realizamos los siguientes pasos:

- **Requirements Definition**: Escribimos los criterios de aceptación para el backend y el frontend

- **Test Cases Implementation**: En el caso del backend realizamos los casos de prueba con SpecFlow. Por otro lado, en el frontend realizamos los casos de prueba usando protractor y cucumber. 

- **Application Implementation**: En este paso codificamos la funcionalidad. En el caso del backend lo hicimos en .NET, mientras que en el frontend usamos Angular.

- **Testing**: Verificamos que todos los casos de prueba que hicimos en el paso 2 pasen.

- **Refactoring**: Realizamos refactoring del código para mejorar la calidad del mismo.

- **Integration Testing**: Realizamos una prueba de integración para comprobar que el frontend y el backend funcionen juntos tal cual es esperado. Para esto usamos el IDE de Cucumber.
