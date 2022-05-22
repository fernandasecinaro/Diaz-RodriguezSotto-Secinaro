# Baja Puntos de Carga

Para realizar esta nueva funcionalidad, creamos una nueva User Story, con la siguiente narrativa:

```
Como administrador,
Quiero poder dar de baja un punto de carga,
Para indicar que ya no está disponible para que los turistas carguen su auto
```

Una vez realizado esto, la colocamos en el backlog. Y luego, cuando la persona asignada comenzó a trabajar en esta user story, realizó la implementación siguiendo los pasos definidos en el [proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinici%C3%B3n%20Proceso%20Ingenier%C3%ADa/Redefinici%C3%B3n%20Proceso%20Ingenieria.md), es decir, BDD.

Es decir, primero se realizó el paso de Requirements Definitions (CCC), donde se escribieron los escenarios:

```
Escenario #1: Baja de un punto de carga con un id válido
Dado el id 1234 y que el punto de carga correspondiente al id existe
Cuando presiono el botón "Dar de baja"
Entonces se da de baja el punto de carga
```

```
Escenario #2: Baja de un punto de carga con un id inválido
Dado el id 12345 y que no existe un punto de carga correspondiente al id
Cuando presiono el botón "Dar de baja"
Entonces se muestra un mensaje de que el punto de carga especificado no existe
```

Una vez definidos los escenarios se pasó al paso Test Cases Implementation, donde se escribieron los casos de prueba usando SpecFlow.

Luego se pasó al paso Application Implementation, donde se codificó en .NET la nueva funcionalidad.

Una vez terminada la funcionalidad, pasamos al paso de Testing, donde se probó que todos los casos escritos en Test Cases Implementation pasaran.

Una vez que todos los casos de prueba pasaron, se realizó el paso de Refactoring, para mejorar el diseño de la aplicación.

Luego realizamos el commit, y verificamos que el pipeline corra y verifique la solución
