# Repositorio

Creamos el repositorio en GitHub, agregando a los tres integrantes del equipo. 

A continuación se detalla la explicación de la estructura del repositorio. Esta también se puede encontrar en el README de la raíz del repositorio, a excepción del versionado.

## Estructura repositorio

En la raíz del repositorio se encuentran dos carpetas: Entregas y Material Obligatorio.

- Entregas: Esta carpeta está subdividida en varias carpetas, una para cada entrega a medida que se van realizando. Al ser 4 entregas, cuando se haga la entrega final habrán cuatro carpetas: Entrega 1, Entrega 2, Entrega 3 y Entrega Final. Dentro de cada una de estas carpetas se ubicará toda la información y detalles relacionados con la respectiva entrega. En la raíz de cada una de dichas carpetas de entrega, se dispondrá de un archivo similar a este, explicando la estructura, para facilitar la ubicación y entendimiento de nuestro trabajo. Por ejemplo, dentro de la carpeta de la Entrega 1, en la raíz hay un archivo llamado "README.md" que guía la explicación de nuestro trabajo para dicha entrega en particular. 

- Material Obligatorio: En esta carpeta se encuentra el material originalmente provisto por la cátedra, con el cual vamos a estar trabando a lo largo de las entregas. Esto incluye: la letra del problema, la guía de despliegue, documentación, el código fuente tanto de backend como frontend, bases de datos y el release para correr la aplicación. 

## Forma de trabajo

Decidimos que al finalizar cada entrega hagamos un release, para que se pueda diferenciar fácilmente qué cosas se hicieron en cada una de las entregas.

## Versionado

En nuestro caso, decidimos implementar el método GitFlow. 

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
