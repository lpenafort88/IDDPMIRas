using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDDPMIRas.Models
{
    public class HomeViewModels
    {
    }
    public class HomeViewModel
    {
        public IEnumerable<EventoViewModel> Eventos { get; set; }
    }
}