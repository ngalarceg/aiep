using System.Collections.Generic;
using System.Linq;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public class LibroService
    {
        public List<Libro> GetAll() => DataStore.Libros.ToList();

        public Libro? GetById(int id) => DataStore.Libros.FirstOrDefault(l => l.Id == id);

        public void Add(Libro libro)
        {
            libro.Id = DataStore.NextLibroId++;
            DataStore.Libros.Add(libro);
        }

        public void Update(Libro libro)
        {
            var idx = DataStore.Libros.FindIndex(x => x.Id == libro.Id);
            if (idx >= 0)
            {
                DataStore.Libros[idx] = libro;
            }
        }

        public void Delete(int id)
        {
            DataStore.Libros.RemoveAll(l => l.Id == id);
            DataStore.Prestamos.RemoveAll(p => p.LibroId == id);
        }
    }
}
