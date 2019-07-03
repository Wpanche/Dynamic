
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

Realizar peticion al API Rest en el endpoint http://localhost:56985/nuevoarbol enviando un areglo de enteros en el payLoad de la petición **HttpPOST** con ``Content-Type →application/json``

payLoad: 
   ```json
     [7,3,4,8,2,76,74,85,83,87,67,39,44,28,29,76,74,85,83,87]
   ```

**Postman** 
<img alt="Creative Commons License" style="border-width:0" src="https://gitlab.com/wilmarpanche/arbolbinario/raw/master/arbolBinario/img/EjempoNuevoArbol.PNG" />

## Retorno 

El endpoint del APIRest retrona el árbol binarion en un objeto **Json** con la siguiente estructura :
```json
{
    "valor": 7,
    "nodoIzquierda": {
        "valor": 3,
        "nodoIzquierda": {
            "valor": 2,
            "nodoIzquierda": null,
            "nodoDerecha": null
        },
        "nodoDerecha": {
            "valor": 4,
            "nodoIzquierda": null,
            "nodoDerecha": null
        }
    },
    "nodoDerecha": {
        "valor": 8,
        "nodoIzquierda": null,
        "nodoDerecha": {
            "valor": 76,
            "nodoIzquierda": {
                "valor": 74,
                "nodoIzquierda": {
                    "valor": 67,
                    "nodoIzquierda": {
                        "valor": 39,
                        "nodoIzquierda": {
                            "valor": 28,
                            "nodoIzquierda": null,
                            "nodoDerecha": {
                                "valor": 29,
                                "nodoIzquierda": null,
                                "nodoDerecha": null
                            }
                        },
                        "nodoDerecha": {
                            "valor": 44,
                            "nodoIzquierda": null,
                            "nodoDerecha": null
                        }
                    },
                    "nodoDerecha": null
                },
                "nodoDerecha": {
                    "valor": 74,
                    "nodoIzquierda": null,
                    "nodoDerecha": null
                }
            },
            "nodoDerecha": {
                "valor": 85,
                "nodoIzquierda": {
                    "valor": 83,
                    "nodoIzquierda": {
                        "valor": 76,
                        "nodoIzquierda": null,
                        "nodoDerecha": null
                    },
                    "nodoDerecha": {
                        "valor": 83,
                        "nodoIzquierda": null,
                        "nodoDerecha": null
                    }
                },
                "nodoDerecha": {
                    "valor": 87,
                    "nodoIzquierda": {
                        "valor": 85,
                        "nodoIzquierda": null,
                        "nodoDerecha": null
                    },
                    "nodoDerecha": {
                        "valor": 87,
                        "nodoIzquierda": null,
                        "nodoDerecha": null
                    }
                }
            }
        }
    }
}
```
## Ejecutando: buscar ancestro mas cercano

Realizar peticion al API Rest en el endpoint http://localhost:56985/ancestro enviando un objeto **Json** con la siguiente estructura en el payLoad de la petición **HttpPOST** con ``Content-Type →application/json``

**Postman** 
<img alt="Creative Commons License" style="border-width:0" src="https://gitlab.com/wilmarpanche/arbolbinario/raw/master/arbolBinario/img/EjempoAncestro.PNG" />



payLoad: 
   ```json
    {
	"nodoUno":"83",
	"nodoDos":"87",
	"arbol":{
	    "valor": 7,
	    "nodoIzquierda": {
	        "valor": 3,
	        "nodoIzquierda": {
	            "valor": 2,
	            "nodoIzquierda": null,
	            "nodoDerecha": null
	        },
	        "nodoDerecha": {
	            "valor": 4,
	            "nodoIzquierda": null,
	            "nodoDerecha": null
	        }
	    },
	    "nodoDerecha": {
	        "valor": 8,
	        "nodoIzquierda": null,
	        "nodoDerecha": {
	            "valor": 76,
	            "nodoIzquierda": {
	                "valor": 74,
	                "nodoIzquierda": {
	                    "valor": 67,
	                    "nodoIzquierda": {
	                        "valor": 39,
	                        "nodoIzquierda": {
	                            "valor": 28,
	                            "nodoIzquierda": null,
	                            "nodoDerecha": {
	                                "valor": 29,
	                                "nodoIzquierda": null,
	                                "nodoDerecha": null
	                            }
	                        },
	                        "nodoDerecha": {
	                            "valor": 44,
	                            "nodoIzquierda": null,
	                            "nodoDerecha": null
	                        }
	                    },
	                    "nodoDerecha": null
	                },
	                "nodoDerecha": {
	                    "valor": 74,
	                    "nodoIzquierda": null,
	                    "nodoDerecha": null
	                }
	            },
	            "nodoDerecha": {
	                "valor": 85,
	                "nodoIzquierda": {
	                    "valor": 83,
	                    "nodoIzquierda": {
	                        "valor": 76,
	                        "nodoIzquierda": null,
	                        "nodoDerecha": null
	                    },
	                    "nodoDerecha": {
	                        "valor": 83,
	                        "nodoIzquierda": null,
	                        "nodoDerecha": null
	                    }
	                },
	                "nodoDerecha": {
	                    "valor": 87,
	                    "nodoIzquierda": {
	                        "valor": 85,
	                        "nodoIzquierda": null,
	                        "nodoDerecha": null
	                    },
	                    "nodoDerecha": {
	                        "valor": 87,
	                        "nodoIzquierda": null,
	                        "nodoDerecha": null
	                    }
	                }
	            }
	        }
	    }
	}
}
   ```
