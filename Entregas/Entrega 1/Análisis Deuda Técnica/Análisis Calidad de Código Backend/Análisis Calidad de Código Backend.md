# Análisis Calidad de Código Backend

## Clean code
- Inicio: 06/05/2022 - 18:30
- Tester: Martina
- Duración: 45 minutos
#### Defectos encontrados
- No se cumple SRP

## Chequeo de validaciones
- Inicio: 06/05/2022 - 19:15
- Tester: Martina
- Duración: 10 minutos
#### Defectos encontrados
- No se valida al crear la entidad si no que más tarde
- Se hacen validaciones en el acceso a datos que se deberían hacer en la lógica

## Análisis de manejo de excepciones
- Inicio: 06/05/2022 - 19:25
- Tester: Martina
- Duración: 15 minutos
#### Defectos encontrados
- Se manejan cuatro únicas excepciones, dos de las cuales son propias del sistema (las otras son de la biblioteca System) pero heredan directamente de System.Exception, es decir no hay un intermediario entre ellos que facilite el manejo de los múltiples tipos de excepciones que deberían haber.
- Se hace catch de una excepcion genérica (tipo Exception) en lugar de manjear las excepciones particulares

## Análisis de WebApi
- Inicio: 06/05/2022 - 19:40
- Tester: Martina
- Duración: 10 minutos
#### Defectos encontrados

## Análisis de BusinessLogic
- Inicio: 06/05/2022 - 19:50
- Tester: Martina
- Duración: 40 minutos
### Defectos encontrados
Se accede únicamente a repositorios sin utilizar otras lógicas.

## Análisis de DataAccess
- Inicio: 06/05/2022 - 20:30
- Tester: Martina
- Duración: 20 minutos
#### Defectos encontrados
Por el defecto que se encontro en BusinessLogic (todas las lógicas acceden a todos los repositorios) hay lógica en los repositorios, donde debería haber únicamente acceso a datos

## Análisis de Domain
- Inicio: 07/05/2022 - 10:30
- Tester: Martina
- Duración: 15 minutos
#### Defectos encontrados
No se validan los atributos

## Chequeo de la cobertura de tests
- Inicio: 07/05/2022 - 10:45
- Tester: Martina
- Duración: 5 minutos
#### Defectos encontrados
No se encontraron defectos, la cobertura es alta (en promedio por encima del 95%)

## Defectos encontrados de forma inintencional realizando los tests anteriores
- Hay alto acoplamiento entre BusinessLogic y DataAccess (consecuencia de que haya lógica en el acceso a datos)
- Se comparan strings con == en múltiples capas del sistema 
