using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDDPMIRas.Models
{
    public class CalendarioViewModels
    {
    }
    public class EventoViewModel
    {
        public string imagePath
        {
            get; set;
        }
        public string Nombre { get; set; }
        public string Local { get; set; }
        public string Mes { get; set; }
        public string Dia { get; set; }
        public string Imagen { get; set; }
        public string Hora { get; set; }
        public string Documento { get; set; }
        public string NombreDocumento { get; set; }
    }
    public class EventosViewModel
    {
        public IList<EventoViewModel> eventos { get; set; }
    }
}