using System.Collections.Generic;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public class UsuarioService
    {
        public List <Usuario> GetAll () => DataStore.Usuarios.ToList ();
        public Usuario GetById(int id) => DataStore.Usuarios.FirstOrDefault(u => u.Id == id);

        public void Add(Usuario u)
        {
            u.Id = DataStore.NextUsuarioId++;
            DataStore.Usuarios.Add(u);
        
        }
        public void Update(Usuario u)
        {
            var idx = DataStore.Usuarios.FindIndex(x => x.Id == u.Id);
            if (idx >= 0) DataStore.Usuarios[idx] = u;
        
        }
        public void Delete(int id)
        {
            DataStore.Usuarios.RemoveAll(u => u.Id == id);
            DataStore.Prestamos.RemoveAll(p => p.UsuarioId == id);
        
        }
    }
}
