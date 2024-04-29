using System;
using System.ComponentModel.DataAnnotations;

namespace GestorEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del evento es requerido.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La fecha del evento es requerida.")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El nombre del lugar es requerido.")]
        public string? NombreLugar { get; set; }


       
    }
}

