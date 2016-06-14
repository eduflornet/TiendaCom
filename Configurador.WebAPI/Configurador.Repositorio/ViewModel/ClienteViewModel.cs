using BaseRepositorio.ViewModel;
using Configurador.Repositorio.Model;

namespace Configurador.Repositorio.ViewModel
{
    public class ClienteViewModel : IViewModel<Cliente>
    {

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public Cliente ToBaseDatos()
        {
            return new Cliente()
            {
                Id = Id,
                Nombre = Nombre,
                Apellidos = Apellidos,
                Email = Email,
                Password = Password
             };
        }

        public void FromBaseDatos(Cliente modelo)
        {
            Id = modelo.Id;
            Nombre = modelo.Nombre;
            Apellidos = modelo.Apellidos;
            Email = Email;
            Password = Password;
        }

        public void UpdateBaseDatos(Cliente modelo)
        {
            modelo.Id = Id;
            modelo.Nombre = Nombre;
            modelo.Apellidos = Apellidos;
            modelo.Email = Email;
            modelo.Password = Password;
        }

        public object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}