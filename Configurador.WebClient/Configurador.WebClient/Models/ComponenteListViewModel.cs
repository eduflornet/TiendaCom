using System.Collections.Generic;
using Configurador.Repositorio.Model;
using Configurador.Repositorio.ViewModel;

namespace Configurador.WebClient.Models
{
    public class ComponenteListViewModel
    {
        public IEnumerable<Componente> Componentes { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int CurrentCategory { get; set; }
    }

    
}