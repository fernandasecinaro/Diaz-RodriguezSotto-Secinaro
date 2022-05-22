# Pipeline

La idea inicial para el pipeline era realizar dos workflows, uno para el build y otro para los tests. Lamentablemente, el workflow para tests nos daba un error que buscamos arreglar por horas, pero no pudimos, y que causaba que falle siempre. Por lo tanto, decidimos dejar solo el de build, y arreglarlo para la próxima entrega.

## Build

Realizamos un [workflow para el build](https://github.com/fernandasecinaro/Diaz-RodriguezSotto-Secinaro/blob/develop/.github/workflows/build-validation.yml). Es decir, una acción que se ejecuta cuando realizamos un push o un pull request a main o develop, ya que estamos siguiendo el método de branching GitFlow. Cuando realizamos un pull request se corre está acción y verifica que la compliación sea exitosa. En caso de que sea exitosa, nos deja hacer el merge a la rama. Pero en caso contrario, el merge está bloqueado hasta que el build sea exitoso. Esto lo configuramos con la herramienta de GitHub llamada Branch Protection Rules, que vamos a explicar en la próxima sección en detalle.

El objetivo de realizar este worfklow es que tanto Develop como Main estén siempre "verdes", o sea, que no se pueda implementar código que no compile. Queremos que ambas ramas estén siempre estables.

## Branch Protection Rules

Configuramos en el proyecto reglas de protección para las ramas Main y Develop. Estas son reglas que se pueden configurar a las ramas deseadas para proteger de errores 
y acciones no deseadas sobre ellas.

En este caso, tanto para la rama Develop como Main configuramos las siguientes reglas:

- Requerir un pull request antes de mergear: Esto significa que no se pueden hacer commits directamente a las ramas, sino que se deben realizar cambios únicamente a través de pull requests. Esto lo configuramos a partir de haber decidido usar GitFlow, donde se deben realizar ramas para hacer nuevas features, hotfixes, releases, etc.

- Requerir que pasen los status checks antes de mergear: Se puede configurar qué workflows deben pasar sí o sí para poder mergear. Nosotros configuramos el workflow de build. Es decir, debe compilar exitosamente para poder mergear, en caso contrario, no deja realizar el merge.

- Incluir reglas a administradores: Signfica que las reglas antes mencionadas también son solicitadas a los administradores del proyecto.
