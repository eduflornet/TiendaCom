using System;
using BaseRepositorio.ViewModel;
using Configurador.Repositorio.Model;

namespace Configurador.Repositorio.ViewModel
{
    public class ConfiguracionViewModel : IViewModel<Configuracion>
    {
        public int idComponente { get; set; }
        public int idCliente { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> total { get; set; }
        public int id { get; set; }

        public Configuracion ToBaseDatos()
        {
            return new Configuracion()
            {
                idComponente = idComponente,
                idCliente = idCliente,
                fecha = fecha,
                total = total,
                id = id
            };
        }

        public void FromBaseDatos(Configuracion modelo)
        {
            idComponente = modelo.idComponente;
            idCliente = modelo.idCliente;
            fecha = modelo.fecha;
            total = modelo.total;
            id = id;
        }

        public void UpdateBaseDatos(Configuracion modelo)
        {
            modelo.idComponente = idComponente;
            modelo.idCliente = idCliente;
            modelo.fecha = fecha;
            modelo.total = total;
            modelo.id = id;
        }

        public object[] GetKeys()
        {
            return new object[] { id };
        }
    }
}