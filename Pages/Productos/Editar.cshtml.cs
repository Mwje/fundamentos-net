using CRUD_7_RAZOR.Datos;
using CRUD_7_RAZOR.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_7_RAZOR.Pages.Productos
{
    public class EditarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Producto Producto { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public async Task OnGet(int id)
        {
            Producto = await _contexto.Producto.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeDB = await _contexto.Producto.FindAsync(Producto.Id);

                CursoDesdeDB.NombreProducto = Producto.NombreProducto;
                CursoDesdeDB.Descripcion = Producto.Descripcion;
                CursoDesdeDB.EnStock = Producto.EnStock;
                CursoDesdeDB.Precio = Producto.Precio;

                await _contexto.SaveChangesAsync();
                Mensaje = "Producto editado correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage();

        }
    }
}
