# Quiz de Películas de los 90

Aplicación de Quiz que combina C# y Node.js/Express. Permite responder preguntas sobre películas de los años 90, gestionar la puntuación del usuario y llevar un registro de esta puntuación mediante un JSON.

# Herramientas necesarias para iniciar el proyecto

- C# 12
- .NET 8
- .NET SDK (ajustar según la versión instalada)
- Node.js (v18 o superior recomendado, ya implementa npm)

# Instalación

1. Clonar el repositorio o descargarlo.

2. Abrir entorno de desarrollo (Recomendado → Visual Studio Code).

3. Abrir terminal en el proyecto y ejecutar los comandos:

```
npm install
dotnet restore
dotnet run
```

# Ejemplo de salida del programa

<img width="698" height="188" alt="image" src="https://github.com/user-attachments/assets/f44d9ca5-f7c3-40b6-9989-44645658e6ac" />
<img width="698" height="151" alt="image" src="https://github.com/user-attachments/assets/e66be11f-5e9d-48fa-8e14-8f5a09ee1344" />

# Endpoints de la API (Express)
| Método | Ruta             | Descripción                                                                                       |
| ------ | ---------------- | ------------------------------------------------------------------------------------------------- |
| GET    | /movies          | Devuelve todas las preguntas disponibles.                                                         |
| GET    | /movies/random   | Devuelve una pregunta aleatoria.                                                                  |
| GET    | /score           | Devuelve la puntuación actual del usuario.                                                        |
| PUT    | /score/update    | Actualiza los datos incrementando la puntuación del usuario en 20 puntos.                         |
| DELETE | /score/reset     | Resetea la puntuación del usuario a a su estado inicial ( 0 puntos).                              |

- En la ruta scores.js se crea un JSON donde se puede seguir la pista de la puntuación y queda registrada, al salid de la aplicación
 y volver a entrar, la puntuación permanece.

# Funciones principales
### ShowMenu

- Muestra el menú principal con las opciones:
1) Mostrar Quiz
2) Mostrar puntuación
3)Borrar puntuación
4)Salir
- Permite al usuario:
  - Responder preguntas aleatorias del quiz.
  - Consultar su puntuación actual.
  - Reiniciar la puntuación a 0.
  - Salir del programa.

- Valida entradas con int.TryParse y asegura que solo se acepten opciones válidas.
- Si la puntuación llega a 100 puntos, muestra un mensaje de felicitación.
- Retorna: Task (ejecución asincrónica).
  
### Mostrar Quiz

- Cada vez que el usuario selecciona “Mostrar Quiz”, el programa muestra una pregunta sobre películas de los 90.
- La respuesta correcta suma puntos al usuario.
- El flujo se repite hasta que el usuario decida salir del quiz.

### Mostrar Puntuación

- La puntuación del usuario se guarda durante la ejecución del programa.
- Se puede consultar en cualquier momento desde el menú.
- Se puede reiniciar a 0 usando la opción “Borrar puntuación”.
  
### Validaciones

- IsValid: asegura que las opciones de menú sean correctas.

# Autora

Ruth Collado García
