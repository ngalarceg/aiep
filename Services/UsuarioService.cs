using System.Collections.Generic;
using System.Linq;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public class UsuarioService
    {
        public List<Usuario> GetAll() => DataStore.Usuarios.ToList();

        public Usuario? GetById(int id) => DataStore.Usuarios.FirstOrDefault(u => u.Id == id);

        public void Add(Usuario usuario)
        {
            usuario.Id = DataStore.NextUsuarioId++;
            DataStore.Usuarios.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            var idx = DataStore.Usuarios.FindIndex(x => x.Id == usuario.Id);
            if (idx >= 0)
            {
                DataStore.Usuarios[idx] = usuario;
            }
        }

        public void Delete(int id)
        {
            DataStore.Usuarios.RemoveAll(u => u.Id == id);
            DataStore.Prestamos.RemoveAll(p => p.UsuarioId == id);
        }
    }
}
