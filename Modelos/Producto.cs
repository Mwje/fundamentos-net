using System.ComponentModel.DataAnnotations;

namespace CRUD_7_RAZOR.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del Producto")]
        public string NombreProducto { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Cantidad en Stock")]
        public int EnStock { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }

    }
}
