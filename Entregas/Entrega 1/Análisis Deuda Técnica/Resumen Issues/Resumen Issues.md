# Resumen Issues

A continuación listamos los issues creados. Es importante destacar que es un resumen, por lo tanto, no está toda la información de los issues. Para ver la información completa de cada issue hay que dirigirnos a la [sección de Issues provista por GitHub](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/issues)

## Errores de ortografía
- Descripción: Corregir los errores de ortografía de toda la aplicación. 
- Severidad: Baja
- Clasificación: Issues de ortografía

## Agregar largo máximo a inputs y cantidad máxima a componentes para seleccionar cantidad
- Descripción: Agregar largo máximo a inputs y cantidad máxima a componentes para seleccionar cantidad
- Severidad: Baja
- Clasificación: Usabilidad

## Actualizar hospedaje información por defecto
- Descripción: En la página de actualizar hospedaje debe aparecer la información actual del hospedaje por defecto
- Severidad: Media
- Clasificación: Usabilidad

## Borrar formulario al crear un hospedaje
- Descripción: Borrar formulario al apretar botón de crear un hospedaje
- Severidad: Media
- Clasificación: Usabilidad

## Borrar hospedaje no pregunta por confirmación
- Descripción:  Borrar hospedaje no pregunta por confirmación. Debería preguntar para confirmar el borrado, ya que se puede haber clickeado el botón de borrar sin querer
- Severidad: Alta
- Clasificación: Usabilidad

## Eliminar mensajes en inglés
- Descripción: Eliminar todos los textos en la aplicación que aparezcan en inglés
- Severidad: Alta
- Clasificación: Usabilidad

## Borrar administrador no pregunta por confirmación
- Descripción: Borrar administrador no pregunta por confirmación. Debería preguntar para confirmar el borrado, ya que se puede haber clickeado el botón de borrar sin querer
- Severidad: Alta
- Clasificación: Usabilidad

## Información en tablas aparece cortada
- Descripción: Información en tablas aparece cortada cuando el texto es largo y no se puede ver el texto por completo
- Severidad: Media
- Clasificación: Usabilidad

## Borrar formulario al cambiar estado de reserva
- Descripción: Borrar formulario al cambiar estado de reserva
- Severidad: Media
- Clasificación: Usabilidad

## Borrar formulario al crear punto turístico
- Descripción: Borrar formulario al crear punto turístico
- Severidad: Media
- Clasificación: Usabilidad

## Actualizar estado de reserva información por defecto
- Descripción: En la página de Actualizar estado de reserva debe aparecer la información actual de la reserva por defecto
- Severidad: Media
- Clasificación: Usabilidad

## Cambiar texto de botón al crear una review
- Descripción: Cambiar texto de botón al crear una review. Este actualmente muestra "Reservar"
- Severidad: Baja
- Clasificación: Usabilidad

## Ubicación botón de "buscar hospedaje"
- Descripción: El botón de "buscar hospedaje"en su ubicación actual invita a presionarlo antes de elegir uno de los puntos turísticos que aparecen debajo
- Severidad: Media
- Clasificación: Usabilidad

## Flechas carrusel de imagenes de hospedaje
- Descripción: Cuando se aprietan las flechas para ver más imagenes de un hospedaje, en vez de cambiar de imagen en el carrusel de imagenes, selecciona a dicho hospedaje y pasa al siguiente paso
- Severidad: Baja
- Clasificación: Usabilidad

## Titulo de reporte
- Descripción:  El título en la sección Reporte es "Reporte (A)". No se entiende qué es "A".
- Severidad: Baja
- Clasificación: Usabilidad

## Centrar texto de botones
- Descripción: Centrar texto de botones de la aplicación
- Severidad: Baja
- Clasificación: UI

## Borrar texto en Sección Importar
- Descripción: Borrar el título "Ver Reserva" y el texto "Ingresar el código único de tu reserva..." en Sección Importar.
- Severidad: Baja
- Clasificación: UI

## Borrar texto en modificar administrador
- Descripción: Borrar texto en modificar administrador, ya que aparece a la izquierda el id, email y password.
- Severidad: Baja
- Clasificación: UI

## Botón "Volver" en modificar administrador
- Descripción: Se debe cambiar la ubicación del botón "Volver" en modificar administrador
- Severidad: Baja
- Clasificación: UI

## Botón "Volver" en crear administrador
- Descripción: Se debe cambiar la ubicación del botón "Volver" en crear administrador
- Severidad: Baja
- Clasificación: UI

## Eliminar imagenes en tabla de administradores
- Descripción:  Hoy en día en cada fila de la tabla de administradores se muestra una foto de perfil. Pero los administradores no tienen foto de perfil.
- Severidad: Baja
- Clasificación: UI

## Bug al crear review
- Descripción: Si previo a presionar "Reservar" nunca se escribió nada en el campo de reseña, te sale error de que hay que completarlo. Pero si escribís algo y después lo borras, dejando el campo vacío, lo acepta.
- Severidad: Media
- Clasificación: Bug

## Login con administrador
- Descripción: Al hacer login con un administrador te redirecciona a la página inicial de la aplicación. Pero luego no se puede volver ahí a través de la UI.
- Severidad: Alta
- Clasificación: Bug

## Modificar administrador
- Descripción: Si queres modificar la contraseña pero el email no, no lo permite. Te obliga a cambiar el email.
- Severidad: Alta
- Clasificación: Bug

## Template star-rating con codigo repetido
- Descripción:  La template del componente star-rating cuenta con 5 tags span idénticas que difieren solo en el índice utilizado por lo que estas podrían ser refactoreadas a un ng-for para mayor claridad.
- Severidad: Baja
- Clasificación: Problema de estandar

## Array clave-valor en carpeta de enums
- Descripción: En la carpeta 'enums' se encuentra un único archivo el cual contiene un array con varios objetos clave-valor los cuales detallan varios posibles estados. El array en si no es un problema pero el estar ubicado en la carpeta enums puede llevar a confusiones si se tiene en cuenta que TypeScript cuenta con enums en sí y este array no sería uno de ellos.
- Severidad: Baja
- Clasificación: Problemas de estándar

## Extracción de campos para crear y modificar admins
- Descripción: Tanto el admin-detail en su sección de modificar como el admin-create en su sección para crear ambos utilizan los mismos campos de email y contraseña por lo que estos podrían ser extraídos a otro componente para simplificar el template.
- Severidad: Media
- Clasificación: Problemas de estándar

## Template de lista de admins es demasiado larga
- Descripción: El [admin-list-component](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Material%20Obligatorio/Obligatorio/MinTurFrontend/src/app/feature-modules/admin-list/admin-list.component.html) tiene una template demasiado grande la cual termina dependiendo de comentarios para tratar de clarificar las secciones lo cual va en contra de Clean Code y de la filosofía de angular de componentizar.
- Severidad: Media
- Clasificación: Problema de estándar

## Codigo repetido en sección de confirmación
- Descripción: El input para chequear una reserva debería de ver refactorizada su sección de confirmación ya que hay 3 secciones idénticas donde solo se altera el texto que se muestra pero que comparten todos los estilos y layout.
- Severidad: Media
- Clasificación: Problemas de estándar

## Expresión regular con nombre genérico
- Descripción: El componente [check-reservation-inputs](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Material%20Obligatorio/Obligatorio/MinTurFrontend/src/app/feature-modules/check-reservation/check-reservation-inputs/check-reservation-inputs.component.ts) en la parte de lógica cuenta con un problema de Clean Code en la función `validateReservationUniqueCode` ya que utiliza una expresión regular pero el nombre de la variable es simplemente `regex` y en ningún momento se dice que es lo que representa dicho patrón.
- Severidad: Media
- Clasificación: Problemas de estándar

## Comentarios innecesarios
- Descripción: En la guarda que existe para la autenticación, su codigo cuenta con comentarios que no aportan información lo cual va en contra de Clean Code.
- Severidad: Baja
- Clasificación: Problemas de estándar

## Clean code
- Descripción:  No cumple SRP
- Severidad: Media
- Clasificación: Problemas de estándar

## Validar atributos en los sets
- Descripción: Mover las validaciones de los atributos de las entidades a los setters de los atributos
- Severidad: Media
- Clasificación: Problemas de estándar

## Mover validaciones lógicas
- Descripción: Mover validaciones lógicas que se encuentran en DataAccess
- Severidad: Media
- Clasificación: Problemas de estándar

## Chequear manejo de excepciones
- Descripción: Se maneja la excepción general Exception y pocas excepciones concretas
- Severidad: Media
- Clasificación: Problemas de estándar

## Mover lógica y eliminar dependencias innecesarias
- Descripción: Hay lógica en el acceso a datos y las clases lógicas solo acceden a repositorios
- Severidad: Media
- Clasificación: Problemas de estándar

## Comparación de strings
- Descripción: Los strings se comparan actualmente con ==
- Severidad: Baja
- Clasificación: Problemas de estándar
