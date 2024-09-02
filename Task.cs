using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoListApp
{
    public class Tarea
    {
        // Propiedades de la tarea: descripción, fecha límite y estado de completitud
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool EstaCompletada { get; set; }

        // Constructor para inicializar la tarea con una descripción y una fecha límite opcional
        public Tarea(string descripcion, DateTime? fechaLimite = null)
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            EstaCompletada = false; // Inicialmente, la tarea no está completada
        }

        // Método para marcar la tarea como completada
        public void MarcarComoCompletada()
        {
            EstaCompletada = true;
        }

        // Sobrescribir el método ToString para proporcionar una representación de la tarea como cadena de texto
        public override string ToString()
        {
            string estado = EstaCompletada ? "Completada" : "Pendiente"; // Determina el estado de la tarea
            string fechaLimiteTexto = FechaLimite.HasValue ? FechaLimite.Value.ToString("d") : "Sin fecha límite"; // Formato de la fecha límite
            return $"Tarea: {Descripcion}, Fecha Límite: {fechaLimiteTexto}, Estado: {estado}"; // Devolver la representación como cadena de texto
        }
    }
}
