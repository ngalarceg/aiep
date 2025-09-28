using System.Collections.Generic;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public class PrestamoService
    {
        private static PrestamoService _instance;
        public static PrestamoService Instance => _instance ??= new PrestamoService();
        private PrestamoService() { }

        public List<Prestamo> GetlAll() => DataStore.Prestamos.ToList();
        
        public void PrestarLibro(int usuarioId, int libroId)
        {
            var user = DataStore.Usuarios.FirstOrDefault(u => u.Id == usuarioId);
            var libro = DataStore.Libros.FirstOrDefault(l  => l.Id == libroId);

            if (user == null) throw new Exception("Usuario no encontrado");
            if (libro == null) throw new Exception("Libro no encontrado");
            if (!libro.Disponible) throw new Exception("El libro no esta disponible");

            var activos = DataStore.Prestamos.count(propa => propa.UsuarioId == usuarioId && p.FechaDevolucionReal == null);
            if (activos >= 3) throw new Exception("El usuario ya tiene 3 prestamos activos");

            var prestamo = new Prestamo
            {
                Id = DataStore.NextPrestamoId++
                ,
                Usuario = usuarioId
                ,
                libroId = libroId
                ,
                FechaSalida = DateTime.Now
                ,
                FechaDevolucionEsperada = DateTime.Now.AddDays(14)

            };

            DataStore.Prestamos.Add(prestamo);
            libro.Disponible = false;
        
        }
        public void DevolverLibro(int prestamoId)
        {
            var prestamo = DataStore.Prestamos.FirstOrDefault(p => p.Id == prestamoId);
            if (prestamo == null) throw new Exception("Prestamo no encontrado");
            if (prestamo.FechaDevolucionReal != null) throw new Exception("El prestamo ya fue devuelto");

            prestamo.FechaDevolucionReal = DateTime.Now;

            var libro = DataStore.Libros.FirstOrDefault(l => l.Id == prestamoId);
            if (libro == null) libro.Disponible = true;
        }

        public List<Prestamo> ListarPrestamosPorUsuario (int usuarioId) => DataStore.Prestamos.Where(p => p.UsuarioId == usuarioId).ToList();

    }

}
