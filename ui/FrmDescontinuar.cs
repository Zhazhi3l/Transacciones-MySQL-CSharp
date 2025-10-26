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
    }
}
