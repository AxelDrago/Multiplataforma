using System;

namespace PortalNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Noticia() {
            FechaCreacion = DateTime.Now;
        }
    }
}