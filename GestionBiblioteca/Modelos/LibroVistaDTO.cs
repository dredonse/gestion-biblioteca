using System;

namespace GestionBiblioteca.Modelos
{
    // Esta clase representa la fila completa que se mostrará y gestionará en el DataGridView
    public class LibroVistaDTO
    {        
        public int IdLibro { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Género { get; set; }
        public string Idioma { get; set; }
        public DateTime? Fecha_Publicación { get; set; }
        public string EstadoActual { get; set; }
        public int? Número_Lectura { get; set; }        
        public string Comentario { get; set; } 
    }
}