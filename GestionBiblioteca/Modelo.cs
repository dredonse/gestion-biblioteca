using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

// ===================================================================
// CLASE DB CONTEXT: En el namespace raíz 'GestionBiblioteca'
// ===================================================================
namespace GestionBiblioteca
{
    using GestionBiblioteca.Modelos; // Importamos el namespace de las entidades

    public class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        // Las referencias a los DbSet son GestionBiblioteca.Modelos.LibroDTO
        public virtual DbSet<LibroDTO> Libros
        {
            get; set;
        }
        public virtual DbSet<LecturasDTO> Lecturas
        {
            get; set;
        }
    }
}


// ===================================================================
// CLASES DE ENTIDAD/DTO: En el namespace 'GestionBiblioteca.Modelos'
// ===================================================================
namespace GestionBiblioteca.Modelos
{
    // Lógica de Validación Compartida (Reemplazo de LibroDTO.ValidarCampoTexto) ---
    public static class ValidacionHelper
    {
        public static bool ValidarCampoTexto(string value, out string mensajeError)
        {
            mensajeError = string.Empty;
            if (string.IsNullOrWhiteSpace(value))
            {
                mensajeError = "El campo no puede estar vacío.";
                return false;
            }
            return true;
        }
    }


    // CLASE LibroDTO (campos, anotaciones, y validación)
    [Table("Libros")]
    public partial class LibroDTO
    {
        // Campos privados
        private int idLibro;
        private string titulo;
        private string autor;
        private string editorial;
        private string genero;
        private string idioma;
        private DateTime? fechaPublicacion;


        [Key]
        public int IdLibro
        {
            get
            {
                return idLibro;
            }
            set
            {
                idLibro = value;
            }
        }

        [Required]
        [Column("Título", TypeName = "varchar")]
        [StringLength(120)]
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                string error;
                if (ValidacionHelper.ValidarCampoTexto(value, out error))
                    titulo = value;
                else
                    throw new Exception("ErrorTitulo");
            }
        }

        [Required]
        [Column("Autor", TypeName = "varchar")]
        [StringLength(100)]
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                string error;
                if (ValidacionHelper.ValidarCampoTexto(value, out error))
                    autor = value;
                else
                    throw new Exception("ErrorAutorVacio");
            }
        }

        [Required]
        [Column("Editorial", TypeName = "varchar")]
        [StringLength(80)]
        public string Editorial
        {
            get
            {
                return editorial;
            }
            set
            {
                string error;
                if (ValidacionHelper.ValidarCampoTexto(value, out error))
                    editorial = value;
                else
                    throw new Exception("ErrorEditorial"); // Usando clave simple
            }
        }

        [Required]
        [Column("Género", TypeName = "varchar")]
        [StringLength(70)]
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                string error;
                if (ValidacionHelper.ValidarCampoTexto(value, out error))
                    genero = value;
                else
                    throw new Exception("ErrorGenero"); // Usando clave simple
            }
        }

        [Required]
        [Column("Idioma", TypeName = "varchar")]
        [StringLength(50)]
        public string Idioma
        {
            get
            {
                return idioma;
            }
            set
            {
                string error;
                if (ValidacionHelper.ValidarCampoTexto(value, out error))
                    idioma = value;
                else
                    throw new Exception("ErrorIdioma"); // Usando clave simple
            }
        }

        [Required]
        [Column("Fecha Publicación", TypeName = "date")]
        public DateTime? FechaPublicacion
        {
            get
            {
                return fechaPublicacion;
            }
            set
            {
                // La validación original revisa que la fecha no sea futura
                if (value.HasValue && value.Value <= DateTime.Today)
                    fechaPublicacion = value;
                else
                    throw new Exception("ErrorFechaPublicacionInvalida");
            }
        }

        // Propiedad de Navegación (Relación uno a muchos)
        public virtual List<LecturasDTO> Lecturas { get; set; } = new List<LecturasDTO>();
    }


    // CLASE LECTURASDTO (campos y anotaciones)
    [Table("Lecturas")]
    public partial class LecturasDTO
    {
        // Campos privados
        private int idLectura;
        private int idLibro;
        private string estado;
        private string comentario;
        private int numeroLectura;

        [Key]
        public int IdLectura
        {
            get
            {
                return idLectura;
            }
            set
            {
                idLectura = value;
            }
        }

        [ForeignKey("Libro")]
        public int IdLibro
        {
            get
            {
                return idLibro;
            }
            set
            {
                idLibro = value;
            }
        }

        [Required]
        [Column("Estado", TypeName = "varchar")]
        [StringLength(50)]
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        [Column("Comentario", TypeName = "varchar")]
        [StringLength(250)]
        public string Comentario
        {
            get
            {
                return comentario;
            }
            set
            {
                comentario = value;
            }
        }

        [Required]
        [Column("Número Lectura")]
        public int NumeroLectura
        {
            get
            {
                return numeroLectura;
            }
            set
            {
                numeroLectura = value;
            }
        }

        // Propiedad de Navegación
        public virtual LibroDTO Libro
        {
            get; set;
        }
    }

    /// DTO auxiliar utilizado para transferir un libro y su lectura asociada
    /// desde el DAO al formulario de edición (BookForm).
    public class LibroCompletoDTO
    {
        // Contiene todos los datos del libro
        public LibroDTO Libro
        {
            get; set;
        }

        // Contiene todos los datos de la lectura asociada
        public LecturasDTO Lectura
        {
            get; set;
        }
    }
}