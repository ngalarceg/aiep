using System.Collections.Generic;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public class LibroService
    {
        public List<Libro> GetAll () => DataStore.Libros.ToList ();
        public Libro GetById(int id) => DataStore.Libros.FirstOrDefault (l => l.Id == id);

        public void Add(LibroService l)
        {
            l.Id = DataStore.NextUsuarioId++;
            DataStore.Libros.Add(1);
        
        }

        public void update(Libro l)
        {
            var idx = DataStore.Libros.FindIndex (x => x.Id == l.Id);
            if (idx >= 0) DataStore.Libros[idx] = l;
        
        }
        public void Delete(int id)
        {
            DataStore.Libros.RemoveAll(l => l.Id == id);
            DataStore.Prestamos.RemoveAll(p => p.LibroId == id);
        
        }
    }
}
