using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDDPMIRas.Models;

namespace IDDPMIRas.Sample
{
    public class CalendarioSampleData
    {
        public static IList<EventoViewModel> getEventos()
        {
            string imagesPath = "/images/blog/";
            string docPath = "/documentos/blog/";
            List<EventoViewModel> eventos = new List<EventoViewModel>();
            EventoViewModel evento1 = new EventoViewModel();
            evento1.Dia = "8";
            evento1.Mes = "Octubre";
            evento1.Nombre = "Culto Misionero";
            evento1.Local = "Por Distritos";
            evento1.NombreDocumento = "events-01-420x420.png";
            evento1.Imagen = imagesPath + evento1.NombreDocumento;
            evento1.Documento = docPath + evento1.NombreDocumento;
            evento1.Hora = "10:00 AM";
            eventos.Add(evento1);

            EventoViewModel evento2 = new EventoViewModel();
            evento2.Dia = "15-16";
            evento2.Mes = "Octubre";
            evento2.Nombre = "Campamento ASOCHEC";
            evento2.Local = "White Oak Conference Center";
            evento2.NombreDocumento= "events-02-420x420.png";
            evento2.Imagen = imagesPath + evento2.NombreDocumento;
            evento2.Hora = "TBD";
            evento2.Documento = docPath + evento2.NombreDocumento;
            eventos.Add(evento2);

            EventoViewModel evento3 = new EventoViewModel();
            evento3.Dia = "4 y 5";
            evento3.Mes = "Noviembre";
            evento3.Hora = "TBD";
            evento3.Nombre = "Seminario De Capacitacion";
            evento3.Local = "TBD";
            evento3.NombreDocumento = "events-04-420x420.jpg";
            evento3.Imagen = imagesPath + evento3.NombreDocumento;
            
            evento3.Documento = docPath + evento3.NombreDocumento;
            eventos.Add(evento2);

            EventoViewModel evento4 = new EventoViewModel();
            evento4.Dia = "3";
            evento4.Mes = "Diciembre";
            evento4.Hora = "TBD";
            evento4.Nombre = "Agape Ministerial";
            evento4.Local = "Por Distrito";
            evento4.NombreDocumento = "events-01-420x420.jpg";
            evento4.Imagen = imagesPath + evento4.NombreDocumento;            
            evento4.Documento = docPath + evento4.NombreDocumento;
            eventos.Add(evento4);

            EventoViewModel evento5 = new EventoViewModel();
            evento5.Dia = "10";
            evento5.Mes = "Diciembre";
            evento5.Hora = "TBD";
            evento5.Nombre = "Agape AJEC";
            evento5.Local = "TBD";
            evento5.NombreDocumento = "events-01-420x420.jpg";
            evento5.Imagen = imagesPath + evento5.NombreDocumento;            
            evento5.Documento = docPath + evento5.NombreDocumento;
            eventos.Add(evento5);

            return eventos;


        }
    }

    
    
}