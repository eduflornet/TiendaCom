
using BaseRepositorio.ViewModel;
using Configurador.Repositorio.Model;

namespace Configurador.Repositorio.ViewModel
{
    public class CategoriaViewModel : IViewModel<Categoria>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria ToBaseDatos()
        {
            return new Categoria()
            {
                Id = Id,
                Nombre = Nombre
            };
        }

        public void FromBaseDatos(Categoria modelo)
        {
            Id = modelo.Id;
            Nombre = modelo.Nombre;
        }

        public void UpdateBaseDatos(Categoria modelo)
        {
            modelo.Id = Id;
            modelo.Nombre = Nombre;
            
        }

        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}