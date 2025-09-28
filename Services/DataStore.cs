using System.Collections.Generic;
using BoockWorldApp.Models;

namespace BoockWorldApp.Services
{
    public static class DataStore
    {
        public static List<Usuario> Usuarios { get; } = new List<Usuario>();
        public static List<Libro> Libros { get; } = new List<Libro>();
        public static List<Prestamo> Prestamos { get; } = new List<Prestamo>();

        public static int NextUsuarioId = 1;
        public static int NextLibroId = 1;
        public static int NextPrestamoId = 1;
    }
}
