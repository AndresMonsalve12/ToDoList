using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoListApp
{
    class Program
    {
        // Lista de tareas para almacenar todas las tareas agregadas por el usuario
        static List<Task> tareas = new List<Task>();

        static void Main(string[] args)
        {
            bool salir = false;

            // Bucle principal que muestra el menú y procesa la entrada del usuario
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Aplicación de Lista de Tareas");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Listar Tareas");
                Console.WriteLine("3. Marcar Tarea como Completada");
                Console.WriteLine("4. Eliminar Tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                // Leer la opción seleccionada por el usuario y llamar a la función correspondiente
                switch (Console.ReadLine())
                {
                    case "1":
                        AgregarTarea();
                        break;
                    case "2":
                        ListarTareas();
                        break;
                    case "3":
                        MarcarTareaComoCompletada();
                        break;
                    case "4":
                        EliminarTarea();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        // Mensaje de opción inválida y esperar para continuar
                        Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            Console.Write("Ingrese la fecha límite (aaaa-mm-dd) o deje en blanco: ");
            string fechaLimiteInput = Console.ReadLine();
            DateTime? fechaLimite = null;

            // Intentar convertir la fecha ingresada a DateTime y manejar errores si la entrada es incorrecta
            if (!string.IsNullOrWhiteSpace(fechaLimiteInput))
            {
                if (DateTime.TryParse(fechaLimiteInput, out DateTime fechaConvertida))
                {
                    fechaLimite = fechaConvertida;
                }
                else
                {
                    Console.WriteLine("Advertencia: Fecha no válida. La tarea se agregará sin fecha límite.");
                }
            }

            // Agregar la nueva tarea a la lista
            tareas.Add(new Task(descripcion, fechaLimite));
            Console.WriteLine("¡Tarea agregada con éxito!");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarTareas()
        {
            // Verificar si hay tareas para mostrar
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas disponibles.");
            }
            else
            {
                // Recorrer y mostrar todas las tareas
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void MarcarTareaComoCompletada()
        {
            // Mostrar la lista de tareas antes de solicitar la selección
            ListarTareas();

            Console.Write("Ingrese el número de la tarea a marcar como completada: ");
            // Validar que el número ingresado es válido y que existe en la lista de tareas
            if (int.TryParse(Console.ReadLine(), out int numeroTarea) && numeroTarea > 0 && numeroTarea <= tareas.Count)
            {
                tareas[numeroTarea - 1].MarcarComoCompletada();
                Console.WriteLine("¡Tarea marcada como completada!");
            }
            else
            {
                // Mostrar mensaje de error si el número de tarea es inválido
                Console.WriteLine("Número de tarea inválido.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void EliminarTarea()
        {
            // Mostrar la lista de tareas antes de solicitar la selección
            ListarTareas();

            Console.Write("Ingrese el número de la tarea a eliminar: ");
            // Validar que el número ingresado es válido y que existe en la lista de tareas
            if (int.TryParse(Console.ReadLine(), out int numeroTarea) && numeroTarea > 0 && numeroTarea <= tareas.Count)
            {
                tareas.RemoveAt(numeroTarea - 1);
                Console.WriteLine("¡Tarea eliminada con éxito!");
            }
            else
            {
                // Mostrar mensaje de error si el número de tarea es inválido
                Console.WriteLine("Número de tarea inválido.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    // Clase que representa una tarea con su descripción y fecha límite opcional
    class Task
    {
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool Completada { get; private set; }

        public Task(string descripcion, DateTime? fechaLimite)
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            Completada = false;
        }

        // Método para marcar la tarea como completada
        public void MarcarComoCompletada()
        {
            Completada = true;
        }

        // Sobrescribir el método ToString para una representación adecuada de la tarea
        public override string ToString()
        {
            string estado = Completada ? "[Completada]" : "[Pendiente]";
            string fechaTexto = FechaLimite.HasValue ? FechaLimite.Value.ToString("yyyy-MM-dd") : "Sin fecha límite";
            return $"{estado} {Descripcion} - {fechaTexto}";
        }
    }
}

