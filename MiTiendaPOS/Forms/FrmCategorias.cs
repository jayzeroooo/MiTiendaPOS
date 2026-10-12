using MiTiendaPOS.Models;
using MiTiendaPOS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTiendaPOS.Forms
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaService _servicio = new();
        private int _idSeleccionado = 0;//para registro nuevo
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarFormulario();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = _servicio.Listar(txtBuscar.Text)
                .Select(c => new { c.Id, c.Nombre })
                .ToList();
        }
        private void LimpiarFormulario()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            btnEliminar.Enabled = false;
            dgvCategorias.ClearSelection();
            txtNombre.Focus();
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categoria
                {
                    Id = _idSeleccionado,
                    Nombre = txtNombre.Text
                };
                if (_idSeleccionado == 0)
                    _servicio.Crear(categoria);


                else
                    _servicio.Actualizar(categoria);
                CargarCategorias();
                MessageBox.Show("Categoría guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarCategorias();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;
            var respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar la categoría \"{txtNombre.Text}\"?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)

                try
                {
                    _servicio.Eliminar(_idSeleccionado);
                    MessageBox.Show("Categoría eliminada correctamente.", "MiTiendaPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarCategorias();
                    LimpiarFormulario();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            {
                var fila = dgvCategorias.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                Categoria? categoria = _servicio.ObtenerPorId(id);
                if (categoria == null) return;
                {
                    _idSeleccionado = categoria.Id;
                    txtNombre.Text = categoria.Nombre;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
