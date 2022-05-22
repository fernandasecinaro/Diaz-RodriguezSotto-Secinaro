# Alta Puntos de Carga

Para realizar esta nueva funcionalidad, creamos una nueva User Story, con la siguiente narrativa:

```
Como administrador,
Quiero dar de alta un punto de carga para autos eléctricos,
Para informar a los turistas acerca de un nuevo lugar donde pueden cargar sus autos
```

Una vez realizado esto, la colocamos en el backlog. Y luego, cuando la persona asignada comenzó a trabajar en esta user story, realizó la implementación siguiendo los pasos definidos en el [proceso de ingeniería](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinici%C3%B3n%20Proceso%20Ingenier%C3%ADa/Redefinici%C3%B3n%20Proceso%20Ingenieria.md)

Es decir, primero se realizó el paso de Requirements Definitions (CCC), donde se escribieron los escenarios:

```
Escenario #1: Alta de punto de carga con datos validos
Dado el Id 1234, el nombre "punto de carga", la direccion "cuareim", el id de region "1" y la descripcion "Un nuevo punto de carga"
Cuando preciono el boton "Dar de alta"
Entonces se da de alta un nuevo punto de carga
```

```
Escenario #2: Alta de punto de carga con id invalida
Dado el Id 12345, el nombre "punto de carga", la direccion "cuareim", el id de region "1" y la descripcion "Un nuevo punto de carga"
Cuando preciono el boton "Dar de alta"
Entonces se muestra un mensaje de que el id es invalido
```

```
Escenario #3: Alta de punto de carga con nombre invalido
Dado el Id 1234, el nombre "punto de cargaaaaaaaa", la direccion "cuareim", el id de region "1" y la descripcion "Un nuevo punto de carga"
Cuando preciono el boton "Dar de alta"
Entonces se muestra un mensaje de que el nombre es invalido
```

```
Escenario #4: Alta de punto de carga con la direccion invalida
Dado el Id 1234, el nombre "punto de carga", la direccion "cuareim ", el id de region "1" y la descripcion "Un nuevo punto de carga"
Cuando preciono el boton "Dar de alta"
Entonces se muestra un mensaje de que la direccion es invalida
```
```
Escenario #5: Alta de punto de carga con region invalida
Dado el Id 1245, el nombre "punto de carga", la direccion "cuareim", el id de region "xyz" y la descripcion "Un nuevo punto de carga"
Cuando preciono el boton "Dar de alta"
Entonces se muestra un mensaje de que la region es invalida
```

```
Escenario #6: Alta de punto de carga con descripcion invalida
Dado el Id 1245, el nombre "punto de carga", la direccion "cuareim", el id de region "1" y la descripcion "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
Cuando preciono el boton "Dar de alta"
Entonces se muestra un mensaje de que la descripcion es invalida
```

Una vez definidos los escenarios se pasó al paso Test Cases Implementation, donde se escribieron los casos de prueba usando SpecFlow.

Luego se pasó al paso Application Implementation, donde se codificó en .NET la nueva funcionalidad. 

Una vez terminada la funcionalidad, pasamos al paso de Testing, donde se probó que todos los casos escritos en Test Cases Implementation pasaran.

Una vez que todos los casos de prueba pasaron, se realizó el paso de Refactoring, para mejorar el diseño de la aplicación.

Luego realizamos el commit, y verificamos que el pipeline corra y verifique la solución

