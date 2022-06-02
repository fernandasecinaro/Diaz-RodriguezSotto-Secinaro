# Mantenimiento Pipeline

En la entrega anterior habíamos agregado un workflow para el build de .NET. En esta entrega a dicho worfklow le agregamos los siguientes checks:

## Automatización de Test Unitarios

En la entrega anterior quisimos agregarlo pero tuvimos varios problemas con la implementación. Finalmente en esta entrega pudimos corregirlo. Cuando corre el job se crea un archivo que indica el resultado de las pruebas:

![Captura de pantalla 2022-06-01 231257](https://user-images.githubusercontent.com/56087826/171533955-2b1055da-bd82-4157-a877-6e831cca983b.png)

## Build Para Angular

Agregamos un job para que cuando se realice un push o pull request a main o develop se ejecute el build de la aplicación de Frontend. Esto es para asegurarnos de que siempre compile, y no se pueda commitear código que no lleve a la aplicación a fallar. Recordemos que tanto Main como Develop deben estar siempre en verde.

## Revisión de código

Agregamos la revisión de código en el pipeline. O sea, cuando alguno de los desarrolladores realiza un pull request debe esperar a que otro desarrollador apruebe sus cambios al solicitarle una revisión de código. Si la revisión es aprobada (y los workflows pasaron), entonces se puede hacer el merge. De lo contrario, si el reviewer solicita cambios, el solicitante debe realizar dichos cambios, y una vez hecho esto debe resolicitar la revisión de código. Así hasta que sea aprobado.

El motivo de hacer esto es aumentar la calidad de nuestro código, identificar posibles problemas, conocer el código implementado por otros, etc.

<img width="677" alt="image" src="https://user-images.githubusercontent.com/56087826/170895857-7fbcb538-d0e6-4289-891b-e402bd57678b.png">

## Link a workflow

https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/.github/workflows/pipeline.yml
