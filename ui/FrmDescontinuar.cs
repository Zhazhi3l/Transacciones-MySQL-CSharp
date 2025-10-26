using Transacciones_MySQL_CSharp.accesoDatos;
using Transacciones_MySQL_CSharp.modelos;

namespace Transacciones_MySQL
{
    public partial class FrmDescontinuar : Form
    {
        private ConexionBD _conexion;
        private List<Producto> _listaProductos;
        public FrmDescontinuar()
        {
            InitializeComponent();
            _conexion = new ConexionBD();
            _listaProductos = new List<Producto>();

            cmbFiltros.Items.Add("Todos");
            cmbFiltros.Items.Add("Activos");
            cmbFiltros.Items.Add("Descontinuados");
        }

        private void FrmDescontinuar_Load(object sender, EventArgs e)
        {
            _listaProductos = _conexion.ObtenerTodosLosProductos();
            dgvProductos.DataSource = _listaProductos;
            cmbFiltros.SelectedIndex = 0;
            txtBuscarCodigo.Focus();
        }

        private void FiltrarGrid()
        {
            if (cmbFiltros.SelectedItem == null) return;

            string filtro = cmbFiltros.SelectedItem.ToString();
            List<Producto> listaFiltrada;

            switch (filtro)
            {
                case "Activos":
                    listaFiltrada = _listaProductos.Where(p => !p.Descontinuado).ToList();
                    break;
                case "Descontinuados":
                    listaFiltrada = _listaProductos.Where(p => p.Descontinuado).ToList();
                    break;
                case "Todos":
                default:
                    listaFiltrada = _listaProductos.ToList();
                    break;
            }

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarYMostrarProducto(txtBuscarCodigo.Text.Trim());
        }

        private void btnDescontinuar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarCodigo.Focus();
                return;
            }

            Producto productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            var confirmacion = MessageBox.Show(
                $"¿Seguro que desea descontinuar '{productoSeleccionado.Nombre}'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool si = _conexion.DescontinuarProducto(productoSeleccionado.ClaveENA_13);

                if (si)
                {
                    MessageBox.Show("Producto descontinuado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _listaProductos = _conexion.ObtenerTodosLosProductos();
                    FiltrarGrid();
                }
                else
                {
                    MessageBox.Show("Error al descontinuar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtBuscarCodigo.Focus();
        }

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
            txtBuscarCodigo.Focus();
        }

        private void txtBuscarCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarYMostrarProducto(txtBuscarCodigo.Text.Trim());
            }
        }

        private void BuscarYMostrarProducto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                FiltrarGrid();
                return;
            }
            Producto productoEncontrado = _listaProductos
                .FirstOrDefault(p => p.ClaveENA_13 == codigo);
            dgvProductos.DataSource = null;

            if (productoEncontrado != null)
            {
                List<Producto> listaResultado = new List<Producto> { productoEncontrado };
                dgvProductos.DataSource = listaResultado;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtBuscarCodigo.Clear();
            txtBuscarCodigo.Focus();
        }
    }
}
