# Análisis Calidad de Código Frontend

A continuación se presenta un informe sobre el analisis de la calidad del codigo del frontend. En este documento serán presentadas las observaciones hechas que a su vez serán convertidas en issues.

## Consideraciones generales

Una observación general del código es que en varios lugares se utiliza un constructor vacio para las clases. Esto en JavaScript suele ser una mala practica ya que forzamos una funcion vacia cuando el lenguaje en si provee un constructor por defecto que dependiendo de la clase no siempre es vacio. Si no debemos realizar una operacion en particular entonces en general es mejor omitir el constructor. Además, el frontend cuenta con un paquete @ngmodule/material-carousel el cual está deprecado hace dos años. Esto presenta un problema ya que no esta siendo mantenido y podria tener bugs los cuales no van a ser arreglados.

## Sección utilities

El analisis de esta seccion comenzó con el componente star-rating. La template de dicho componente cuenta con 5 tags span identicas que difieren solo en el indice utilizado por lo que estas podrian ser refactoreadas a un ng-for para mayor claridad.

## Seccion Enums

En esta sección se encuentra un único archivo el cual contiene un array con varios objetos clave-valor los cuales detallan varios posibles estados. El array en si no es un problema pero el estar ubicado en la carpeta enums puede llevar a confusiones si se tiene en cuenta que TypeScript cuenta con enums en si y este array no seria uno de ellos.

## Sección feature-modules

Aqui lo primero a notar es que tanto el admin-detail en su sección de modificar como el admin-create en su seccion para crear ambos utilizan los mismos campos de email y contraseña por lo que estos podrian ser extraidos a otro componente para simplificar el template. Luego, el admin-list-component tiene una template demasiado grande la cual termina dependiendo de comentarios para tratar de clarificar las secciones lo cual va en contra de Clean Code y de la filosofia de angular de componentizar. Siguiendo con la politica de componentizar, el input para chequear una reserva deberia de ver refactorizada su seccion de confirmacion ya que hay 3 secciones identicas donde solo se altera el texto que se muestra pero que comparten todos los estilos y layout. Este mismo componente en la parte de lógica cuenta con un problema de Clean Code en la función `validateReservationUniqueCode` ya que utiliza una expresión regular pero el nombre de la variable es simplemente `regex` y en ningún momento se dice que es lo que representa dicho patrón.

## Seccion guards

En cuanto a la guarda que existe para la autenticación, su codigo cuenta con comentarios que no aportan información lo cual va en contra de Clean Code.
