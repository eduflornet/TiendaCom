using BaseRepositorio.ViewModel;
using Configurador.Repositorio.Model;

namespace Configurador.Repositorio.ViewModel
{   
    public class ComponenteViewModel : IViewModel<Componente>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Iva { get; set; }
        public int idCategoria { get; set; }
        public int idFabricante { get; set; }

        public Componente ToBaseDatos()
        {
            return new Componente()
            {
                Id = Id,
                Nombre = Nombre,
                Descripcion = Descripcion,
                Precio = Precio,
                Iva = Iva,
                idCategoria = idCategoria,
                idFabricante = idFabricante
            };
        }

        public void FromBaseDatos(Componente modelo)
        {
            Id = modelo.Id;
            Nombre = modelo.Nombre;
            Descripcion = modelo.Descripcion;
            Precio = modelo.Precio;
            Iva = modelo.Iva;
            idCategoria = modelo.idCategoria;
            idFabricante = modelo.idFabricante;
        }

        public void UpdateBaseDatos(Componente modelo)
        {
            modelo.Id = Id;
            modelo.Nombre = Nombre;
            modelo.Descripcion = Descripcion;
            modelo.Precio = Precio;
            modelo.idCategoria = idCategoria;
            modelo.idFabricante = idFabricante;
        }

        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}