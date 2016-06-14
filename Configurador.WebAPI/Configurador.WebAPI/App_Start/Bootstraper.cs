using System.Data.Entity;
using BaseRepositorio.Repositorio;
using Configurador.Repositorio.Model;
using Configurador.Repositorio.ViewModel;
using Microsoft.Practices.Unity;

namespace Configurador.WebAPI
{
    public class Bootstraper
    {
        public static void Init(UnityContainer container)
        {
            
            container.RegisterType<DbContext, ConfiguradorEntities>();

            container.RegisterType<IRepositorio<Componente, ComponenteViewModel>,
            RepositorioEntity<Componente, ComponenteViewModel>>();
            
            container.RegisterType<IRepositorio<Cliente, ClienteViewModel>,
            RepositorioEntity<Cliente, ClienteViewModel>>();

            container.RegisterType<IRepositorio<Categoria, CategoriaViewModel>,
            RepositorioEntity<Categoria, CategoriaViewModel>>();

            container.RegisterType<IRepositorio<Configuracion, ConfiguracionViewModel>,
            RepositorioEntity<Configuracion, ConfiguracionViewModel>>();

            container.RegisterType<IRepositorio<Fabricante, FabricanteViewModel>,
            RepositorioEntity<Fabricante, FabricanteViewModel>>();
            
        }
    }
}