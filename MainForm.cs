using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BoockWorldApp.Models;
using BoockWorldApp.Services;

namespace BoockWorldApp
{
    public partial class MainForm : Form
    {
        private readonly UsuarioService _usuarioService = new();
        private readonly LibroService _libroService = new();
        private readonly PrestamoService _prestamoService = PrestamoService.Instance;

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            RefrescarUsuarios();
            RefrescarLibros();
            RefrescarPrestamos();
            RefrescarReporte();
        }

        private void RefrescarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _usuarioService.GetAll();
            cmbPrestamoUsuario.DataSource = null;
            cmbPrestamoUsuario.DataSource = _usuarioService
                .GetAll()
                .Select(u => new ComboItem<Usuario>(u, u.Nombre))
                .ToList();
            cmbPrestamoUsuario.DisplayMember = nameof(ComboItem<Usuario>.Display);
        }

        private void RefrescarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = _libroService.GetAll();
            cmbPrestamoLibro.DataSource = null;
            cmbPrestamoLibro.DataSource = _libroService
                .GetAll()
                .Where(l => l.Disponible)
                .Select(l => new ComboItem<Libro>(l, l.Titulo))
                .ToList();
            cmbPrestamoLibro.DisplayMember = nameof(ComboItem<Libro>.Display);
        }

        private void RefrescarPrestamos()
        {
            dgvPrestamosActivos.DataSource = null;
            dgvPrestamosActivos.DataSource = ObtenerPrestamosView(p => p.FechaDevolucionReal == null);
        }

        private void RefrescarReporte()
        {
            dgvReportePrestamos.DataSource = null;
            dgvReportePrestamos.DataSource = ObtenerPrestamosView(p => true);
        }

        private List<PrestamoView> ObtenerPrestamosView(Func<Prestamo, bool> filtro)
        {
            var usuarios = _usuarioService.GetAll();
            var libros = _libroService.GetAll();
            return _prestamoService
                .GetAll()
                .Where(filtro)
                .Select(p =>
                {
                    var usuario = usuarios.FirstOrDefault(u => u.Id == p.UsuarioId);
                    var libro = libros.FirstOrDefault(l => l.Id == p.LibroId);
                    return new PrestamoView
                    {
                        PrestamoId = p.Id,
                        Usuario = usuario?.Nombre ?? "Desconocido",
                        Libro = libro?.Titulo ?? "Desconocido",
                        FechaSalida = p.FechaSalida,
                        FechaDevolucionEsperada = p.FechaDevolucionEsperada,
                        FechaDevolucionReal = p.FechaDevolucionReal
                    };
                })
                .OrderBy(p => p.Usuario)
                .ThenBy(p => p.Libro)
                .ToList();
        }

        private void btnUsuarioAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario
                {
                    Nombre = txtUsuarioNombre.Text.Trim(),
                    Correo = txtUsuarioCorreo.Text.Trim(),
                    Telefono = txtUsuarioTelefono.Text.Trim()
                };

                if (string.IsNullOrWhiteSpace(usuario.Nombre))
                {
                    MessageBox.Show("Ingrese el nombre del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _usuarioService.Add(usuario);
                LimpiarCamposUsuario();
                RefrescarUsuarios();
                MessageBox.Show("Usuario registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuarioActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow?.DataBoundItem is not Usuario usuario)
            {
                MessageBox.Show("Seleccione un usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                usuario.Nombre = txtUsuarioNombre.Text.Trim();
                usuario.Correo = txtUsuarioCorreo.Text.Trim();
                usuario.Telefono = txtUsuarioTelefono.Text.Trim();

                _usuarioService.Update(usuario);
                RefrescarUsuarios();
                MessageBox.Show("Usuario actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuarioEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow?.DataBoundItem is not Usuario usuario)
            {
                MessageBox.Show("Seleccione un usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _usuarioService.Delete(usuario.Id);
                LimpiarCamposUsuario();
                RefrescarUsuarios();
                RefrescarPrestamos();
                RefrescarReporte();
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow?.DataBoundItem is Usuario usuario)
            {
                txtUsuarioNombre.Text = usuario.Nombre;
                txtUsuarioCorreo.Text = usuario.Correo;
                txtUsuarioTelefono.Text = usuario.Telefono;
            }
        }

        private void LimpiarCamposUsuario()
        {
            txtUsuarioNombre.Clear();
            txtUsuarioCorreo.Clear();
            txtUsuarioTelefono.Clear();
        }

        private void btnLibroAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtLibroAnio.Text, out var anio))
                {
                    MessageBox.Show("Ingrese un año válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var libro = new Libro
                {
                    Titulo = txtLibroTitulo.Text.Trim(),
                    Autor = txtLibroAutor.Text.Trim(),
                    Genero = txtLibroGenero.Text.Trim(),
                    AnioPublicacion = anio,
                    Disponible = true
                };

                if (string.IsNullOrWhiteSpace(libro.Titulo))
                {
                    MessageBox.Show("Ingrese el título del libro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _libroService.Add(libro);
                LimpiarCamposLibro();
                RefrescarLibros();
                MessageBox.Show("Libro registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLibroActualizar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow?.DataBoundItem is not Libro libro)
            {
                MessageBox.Show("Seleccione un libro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (!int.TryParse(txtLibroAnio.Text, out var anio))
                {
                    MessageBox.Show("Ingrese un año válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                libro.Titulo = txtLibroTitulo.Text.Trim();
                libro.Autor = txtLibroAutor.Text.Trim();
                libro.Genero = txtLibroGenero.Text.Trim();
                libro.AnioPublicacion = anio;

                _libroService.Update(libro);
                RefrescarLibros();
                RefrescarPrestamos();
                RefrescarReporte();
                MessageBox.Show("Libro actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLibroEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow?.DataBoundItem is not Libro libro)
            {
                MessageBox.Show("Seleccione un libro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar el libro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _libroService.Delete(libro.Id);
                LimpiarCamposLibro();
                RefrescarLibros();
                RefrescarPrestamos();
                RefrescarReporte();
            }
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow?.DataBoundItem is Libro libro)
            {
                txtLibroTitulo.Text = libro.Titulo;
                txtLibroAutor.Text = libro.Autor;
                txtLibroAnio.Text = libro.AnioPublicacion.ToString();
                txtLibroGenero.Text = libro.Genero;
            }
        }

        private void LimpiarCamposLibro()
        {
            txtLibroTitulo.Clear();
            txtLibroAutor.Clear();
            txtLibroAnio.Clear();
            txtLibroGenero.Clear();
        }

        private void btnGenerarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbPrestamoUsuario.SelectedItem is not ComboItem<Usuario> usuarioItem)
            {
                MessageBox.Show("Seleccione un usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbPrestamoLibro.SelectedItem is not ComboItem<Libro> libroItem)
            {
                MessageBox.Show("Seleccione un libro disponible", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _prestamoService.PrestarLibro(usuarioItem.Value.Id, libroItem.Value.Id);
                RefrescarLibros();
                RefrescarPrestamos();
                RefrescarReporte();
                MessageBox.Show("Préstamo registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolverPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamosActivos.CurrentRow?.DataBoundItem is not PrestamoView vista)
            {
                MessageBox.Show("Seleccione un préstamo activo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _prestamoService.DevolverLibro(vista.PrestamoId);
                RefrescarLibros();
                RefrescarPrestamos();
                RefrescarReporte();
                MessageBox.Show("Préstamo devuelto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private record ComboItem<T>(T Value, string Display)
        {
            public override string ToString() => Display;
        }

        private class PrestamoView
        {
            public int PrestamoId { get; set; }
            public string Usuario { get; set; } = string.Empty;
            public string Libro { get; set; } = string.Empty;
            public DateTime FechaSalida { get; set; }
            public DateTime FechaDevolucionEsperada { get; set; }
            public DateTime? FechaDevolucionReal { get; set; }
        }
    }
}
