using System;
using System.Collections.Generic;
using System.Linq;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public class PrestamoService
    {
        private static PrestamoService? _instance;

        public static PrestamoService Instance => _instance ??= new PrestamoService();

        private PrestamoService()
        {
        }

        public List<Prestamo> GetAll() => DataStore.Prestamos.ToList();

        public void PrestarLibro(int usuarioId, int libroId)
        {
            var usuario = DataStore.Usuarios.FirstOrDefault(u => u.Id == usuarioId);
            var libro = DataStore.Libros.FirstOrDefault(l => l.Id == libroId);

            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado");
            }

            if (libro == null)
            {
                throw new Exception("Libro no encontrado");
            }

            if (!libro.Disponible)
            {
                throw new Exception("El libro no está disponible");
            }

            var prestamosActivos = DataStore.Prestamos.Count(p => p.UsuarioId == usuarioId && p.FechaDevolucionReal == null);
            if (prestamosActivos >= 3)
            {
                throw new Exception("El usuario ya tiene 3 préstamos activos");
            }

            var prestamo = new Prestamo
            {
                Id = DataStore.NextPrestamoId++,
                UsuarioId = usuarioId,
                LibroId = libroId,
                FechaSalida = DateTime.Now,
                FechaDevolucionEsperada = DateTime.Now.AddDays(14)
            };

            DataStore.Prestamos.Add(prestamo);
            libro.Disponible = false;
        }

        public void DevolverLibro(int prestamoId)
        {
            var prestamo = DataStore.Prestamos.FirstOrDefault(p => p.Id == prestamoId);
            if (prestamo == null)
            {
                throw new Exception("Préstamo no encontrado");
            }

            if (prestamo.FechaDevolucionReal != null)
            {
                throw new Exception("El préstamo ya fue devuelto");
            }

            prestamo.FechaDevolucionReal = DateTime.Now;

            var libro = DataStore.Libros.FirstOrDefault(l => l.Id == prestamo.LibroId);
            if (libro != null)
            {
                libro.Disponible = true;
            }
        }

        public List<Prestamo> ListarPrestamosPorUsuario(int usuarioId) =>
            DataStore.Prestamos.Where(p => p.UsuarioId == usuarioId).ToList();
    }
}
