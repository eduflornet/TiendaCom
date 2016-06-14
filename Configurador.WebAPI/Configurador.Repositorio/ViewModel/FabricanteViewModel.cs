using BaseRepositorio.ViewModel;
using Configurador.Repositorio.Model;

namespace Configurador.Repositorio.ViewModel
{
    public class FabricanteViewModel : IViewModel<Fabricante>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Fabricante ToBaseDatos()
        {
            return new Fabricante()
            {
                Id = Id,
                Nombre = Nombre
            };
        }

        public void FromBaseDatos(Fabricante modelo)
        {
            Id = modelo.Id;
            Nombre = modelo.Nombre;
        }

        public void UpdateBaseDatos(Fabricante modelo)
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