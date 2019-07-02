## Requerimientos
* [PostMan](https://www.getpostman.com/downloads)

## Abrir solución
* realizar los puntos definidos en el apartado  ``Requerimientos``
* Clonar repositorio:```git clone https://gitlab.com/wilmarpanche/arbolbinario.git```
* En directorio ``./arbolBinario`` ejecutar el archivo ``arbolBinario.sln``

## Endpoints

la prueba cuenta con dos endpoints que deben ser ejecutados por metodo http POST 

1. http://localhost:56985/nuevoarbol
1. http://localhost:56985/ancestro

## Ejecutando: crear nuevo árbol

Realizar peticion al API Rest en el endpoint http://localhost:56985/nuevoarbol enviando un areglo de enteros en el payLoad de la petición HttpPOST con ``Content-Type →application/json``
