# Testing exploratorio

## Test #1

- Misión: Validar que la gramática y ortografía sean correctas en toda la aplicación.
- Inicio: 06/05/2022 - 18:20
- Tester: Fernanda
- Duración: 3 horas y media
- Incovenientes: Sin incovenientes

### Defectos encontrados: 

#### Header
En el header, falta el signo de pregunta "¿" en el texto "Eres administrador?" y también le falta el tilde en el botón de "Iniciar Sesión".

#### Sidebar
- En el sidebar, falta el tilde en la opción "Tu Opinión".

#### Página inicial (Explorar)
- El texto de bienvenida tiene varias faltas de ortografía (todas las palabras que llevan tilde no lo tienen) y errores gramaticales (por ejemplo, dice "de el" en vez de "del").
- En la sección "Comienza tu búsqueda" le falta un tilde en la palabra "turísticos" y en el título de la misma falta el tilde en la palabra "búsqueda".

#### Ver reserva
- En la sección "Ver Reserva", en el componente para ingresar el código de reserva, falta el tilde en la palabra "Código". Además, cuando se ingresa un código inválido, se muestra un componente mostrando el error, al cual le faltan los tildes en las palabras "código", "único", "inválido". Y también, cuando se ingresa un código válido, al componente de confirmación le faltan los tildes en las palabras "Éxito" y "confirmación".

#### Tu opinión
- En la sección "Tu Opinión" falta el tilde en el título y debajo de este en la palabra "código". Además, en el componente "Cuéntanos cómo te ha ido" faltan los tildes en las palabras "Cuéntanos", "cómo", "código", "calificación", 
- Cuando se ingresa una opinión, en el componente mostrado falta el tilde en la palabra "página".
- Cuando se ve la opinión ingresada, falta el tilde en la palabra "Calificación".
- Cuando se ingresa una opinión sin calificación, sale un mensaje de error, al cual le falta el tilde en la palabra "puntuación".
- Si se aprieta "Reservar" al ingresar una opinión, pero no se ha puesto un código de reserva, sale un mensaje de error, al cual le falta el tilde en las palabras "código", "único" e "inválido".

#### Elegir punto turístico
- En el título de "Elige un punto Turístico", falta el tilde en la palabra "Turístico". Además, en el texto debajo del título faltan los tildes en las palabras "turísticos" y "estadías".
- En el componente que sirve para mostrar los distintos puntos turísticos, falta el tilde en las palabras "Región" y "Categorías".
- Cuando se elige un punto turístico en el filtrado falta el tilde en "categorías". Además, en la opción "Áreas Protegidas", la palabra "Protegídas" tiene un tilde que no va.
- En la sección de elegir un punto turístico, si no se elige uno, se muestra un mensaje de error, al cual le falta el tilde en la palabra "turístico".
- En el componente para elegir la cantidad de bebés a la hora de elegir punto turistico, falta el tilde en la label. 

#### Elegir un hospedaje
- En la sección "Elegir un hospedaje", en el texto debajo del título falta el tilde en la palabra "más". Además, en los componentes que muestran los hospejades falta el tilde en la palabra "puntuación".
- Cuando se ingresa una búsqueda, y no se encuentran hospedajes, sale un mensaje de error, al cual le falta el tilde en la palabra "búsqueda".

#### Completar reserva
- En la página para completar las reservas, cuando se muestra la info del hospedaje, falta el tilde en las palabras "Dirección" y "Puntuación". Además, en el componente para completar la reserva falta el tilde en las palabras "Completa" (en el título), "estadía", "Huéspedes".
- En la sección para completar una reserva, falta el tilde en la palabra "bebés".
- En la sección para completar una reserva, cuando se ingresa reservar y no se ingresó un nombre o apellido aparece un mensaje de error al cual le falta los tildes en las palabras "inválido" y "alfabéticos".
- Cuando se confirma la reserva de un hospedaje, aparece un componente mostrando que la operación tuvo éxito. Al mismo le falte el tilde en las palabras "confirmación",  "código", "trámites". Además, debería decir "Número" en vez de "Numbero". 

#### Login
- En el login, falta el tilde en las palabras "Ingresá" (en título) y "Sesión" (en boton).

#### Administrador 

##### Reporte
- En la página de reporte, en el texto bajo el título, faltan los tildes en las palabras "turístico" y "válidas". Además, en el select para elegir un punto turístico, falta el tilde en la palabra "turístico".
- Si no elegís un punto turístico y apretás el botón de generar reporte, aparece un mensaje de error, al cual le falta el tilde en "turístico".
- Cuando en el rango de fechas no seleccionas una fecha final que sea mayor a la inicial, aparece un mensaje de error, el cual debe decir "...a la inicial" en vez de "a la de inicial".

##### Detalle de administrador
- Al realizar con éxito una modificación, aparece un mensaje "Éxito" al cual le falta el tilde.

##### Cambiar disponibilidad de un hospedaje 
- Falta el tilde en la palabra "cuál" en el texto debajo del título. 
- Cuando cambias la disponibilidad  en el mensaje de "Éxito" falta el tilde.

##### Crear hospedaje
- En el componente de seleccionar archivos debería decir "Seleccione uno o más archivos"
- Cuando no se ingresa una imagen sale un mensaje de error que debería decir "Es necesario especificar al menos una imagen".
- Cuando se carga una imagen, aparece un texto que debería decir "Imagen/es cargada/s"

##### Tabla hospedajes
- El título de la columna debería ser "Disponibilidad", tiene error de tipeo

##### Actualizar estado de reserva
- El placeholder de descripción le falta el tilde en "cambió"
- La opción de elegir disponibilidad debería ser "Esperando por pago"
- Al actualizar el estado de la reserva aparece un mensaje "Éxito" al cual le falta el tilde.

##### Crear punto turístico:
- "Imagen" y "Protegidas" no deben llevar tilde.
- Falta el tilde en "Categorías"
