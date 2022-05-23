# Reparación Bugs

Se decidió reparar los siguientes bugs:

## [Modificar administrador](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/issues/48)

```
Modificar administrador
Descripción: Si queres modificar la contraseña pero el email no, no lo permite. Te obliga a cambiar el email.
Resultado esperado: Permitir que solamente se modifique la contraseña, manteniendo el mismo email
Pasos a reproducir:
- Entrar como admin
- Ir a tabla de administradores
- Seleccionar un admin a modificar
- Dejar el email actual, y cambiar la contraseña
Prioridad: Alta
Severidad: Alta
Clasificación: Bug
```

Este bug fue únicamente de backend. Ya que estaba mal implementada la funcionalidad de ese lado. Por lo tanto, seguimos el [proceso de ingeniería para los bugs de backend](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinici%C3%B3n%20Proceso%20Ingenier%C3%ADa/Redefinici%C3%B3n%20Proceso%20Ingenieria.md).

Es decir, primero se realizaron casos de prueba, ya que no eran suficientes los que habían, porque se implementaron nuevas validaciones. Una vez hecho los casos de prueba, se realizó la codificación. Terminada la codificación, se corrieron los casos de prueba, y se verificó que todos pasaran, para luego realizar un refactoring, para mejorar el código.

## [Bug al crear review](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/issues/46)

```
Bug al crear review
Descripción: Si previo a presionar "Reservar" nunca se escribió nada en el campo de reseña, te sale error de que hay que completarlo. Pero si escribís algo y después lo borras, dejando el campo vacío, lo acepta.
Resultado esperado: Decidir si permitir agregar una review con solo puntuación (estrellas) y no texto, o que siempre se deba agregar texto y que si el campo esté vacío emita un error
Pasos a reproducir:
Ir a sección de tu opinion
Completar los campos del formulario de hacer una review
Borrar el campo de "reseña"
Enviar la reseña
Prioridad: Alta
Severidad: Alta
Clasificación: Bug
```

Este bug fue también únicamente de backend. Ya que estaba mal implementada la funcionalidad de ese lado, porque faltaban validaciones. Por lo tanto, nuevamente seguimos el [proceso de ingeniería para los bugs de backend](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/Entregas/Entrega%202/Redefinici%C3%B3n%20Proceso%20Ingenier%C3%ADa/Redefinici%C3%B3n%20Proceso%20Ingenieria.md).

## ¿Por qué elegimos estos bugs?

Elegimos estos bugs porque consideramos que eran los que mayor severidad y prioridad tenían. 

El bug que ocurría en modificar administrador era un error grande en la funcionalidad del sistema, y puede llegar a afectar altamente a los usuarios.

Por otro lado, el bug al crear la review afecta enormemente a la integridad del sistema, ya que permitía publicar reviews sin texto, cuando supusimos que esto no era posible.

Además, también elegimos estos bugs, porque a diferencia de los demás issues que encontramos, afectaban la funcionalidad (ya que son bugs). Es decir, el resto de las issues encontradas permitían hacer las funcionalidades, y no eran bloqueantes para que los usuarios pudieran realizar una funcionalidad, y tampoco afectaban la integridad del sistema, ya que las verificaciones requeridas se validaban bien. En cambio, como mencionamos antes, el bug de modificar administrador sí era un bloqueante para los usuarios, porque estaba mal hecha la funcionalidad. Y en el caso del bug de publicar reviews sin texto se afectaba la integridad porque no se realizaba correctamente la validación de que el texto no podía ser null o vacío.
