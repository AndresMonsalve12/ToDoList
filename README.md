## Descripción
Aplicación de Gestión de Tareas en C#

Este proyecto es una aplicación de consola desarrollada en C# utilizando .NET Framework 4.8. La aplicación permite la gestión de una lista de tareas (To-Do List), ofreciendo funcionalidades para agregar, listar, marcar como completadas y eliminar tareas.

## Requisitos
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework-runtime)
- Visual Studio 2022

## Estructura del Proyecto
El proyecto está estructurado de la siguiente manera:

- **Program.cs**: Archivo principal que contiene la lógica de la aplicación y el menú de opciones.
- **Task.cs**: Clase que representa una tarea con sus propiedades y métodos.

## Funcionalidades
- **Agregar tareas**: Permite agregar nuevas tareas con una descripción y una fecha límite opcional.
- **Listar tareas**: Muestra un listado de todas las tareas registradas.
- **Marcar tareas como completadas**: Permite marcar una tarea como completada.
- **Eliminar tareas**: Permite eliminar una tarea de la lista.

## Instrucciones para Compilar y Ejecutar

1. **Clonar el Repositorio**:
   Clona el repositorio en tu máquina local utilizando el siguiente comando:
   ```bash
   git clone https://github.com/AndresMonsalve12/ToDoList.git
Abrir el Proyecto:

Abre el proyecto en Visual Studio 2022 o en tu IDE compatible con .NET Framework.
Compilar el Proyecto:

Compila el proyecto. Asegúrate de que el entorno esté configurado para usar .NET Framework 4.8.
Ejecutar la Aplicación:

Ejecuta la aplicación. Una vez que la aplicación esté en ejecución, se presentará un menú de opciones en la consola.
Uso
Utiliza las siguientes opciones en el menú de la consola para interactuar con la lista de tareas:

Agregar Tarea: Ingresa una descripción y, opcionalmente, una fecha límite para añadir una nueva tarea.
Listar Tareas: Muestra todas las tareas actuales, indicando si están completadas o no.
Marcar Tarea como Completada: Introduce el índice de la tarea que deseas marcar como completada.
Eliminar Tarea: Introduce el índice de la tarea que deseas eliminar.
Manejo de Errores
La aplicación maneja errores básicos como entradas inválidas y opciones no reconocidas, solicitando al usuario que ingrese valores válidos o seleccione opciones correctas.

Enlace al Repositorio
Puedes encontrar el repositorio en GitHub en el siguiente enlace: https://github.com/AndresMonsalve12/ToDoList
