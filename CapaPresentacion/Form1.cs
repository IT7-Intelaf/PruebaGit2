using CRUD_BD_Clientes1.CapaDatos;
using CRUD_BD_Clientes1.CapaDominio;
using System.Windows.Forms;

namespace CRUD_BD_Clientes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

       //Boton ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nit = " ";
                string dpi = " ";
                string pasaporte = "";
                string distr = null;
                string listaNegra = null;
                string agenteRetenedor = null;
                ClientesRepository clienteRepositoy = new ClientesRepository();
                Clientes cliente = new Clientes();

                if (rbnNit.Checked) nit = txtNitDpiPas.Text;
                if (rbnDpi.Checked) dpi = txtNitDpiPas.Text;
                if (rdbPasaporte.Checked) pasaporte = txtNitDpiPas.Text;

                if (rdbSiMayorista.Checked) distr = "1";
                if (rbnNoMayorista.Checked) distr = "0";

                if (rbnSiListaNegra.Checked) listaNegra = "S";
                if (rbnNoListaNegra.Checked) listaNegra = "N";

                if (cbxAgenteRetenedor.Text == "Exportadores") agenteRetenedor = "01";

                cliente = Clientes.Create(txtCodigo.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtFax.Text, nit, txtAtencion.Text, distr, txtCorreo1.Text, txtDescuento.Text, txtCorreo2.Text, txtAnotaciones.Text, listaNegra, agenteRetenedor, txtDireccionEntrega.Text, txtZonaEntrega.Text, dpi, pasaporte);
                clienteRepositoy.Add(cliente);
                MessageBox.Show("Datos Ingresados correctamente");
                limpiezaTexbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clientes = new Clientes();
                string codigo = txtCodigo.Text;
                Clientes cliente = Clientes.Buscar(codigo);

                if (cliente != null)
                {
                    // Asigna los demás campos de TextBox con los valores correspondientes
                    txtNombre.Text = cliente.NOMBRE;
                    txtDireccion.Text = cliente.DIRECCION;
                    txtTelefono.Text = cliente.TELEFONO;
                    txtFax.Text = cliente.FAX;
                    txtAtencion.Text = cliente.ATENCION;
                    txtCorreo1.Text = cliente.CORREO;
                    txtCorreo2.Text = cliente.E_MAIL;
                    txtDescuento.Text = cliente.DESCUENTO.ToString();
                    if(cliente.TIPO_DE_RETENEDOR == "01") cbxAgenteRetenedor.SelectedIndex = 0;
                    if (cliente.TIPO_DE_RETENEDOR == "02") cbxAgenteRetenedor.SelectedIndex = 1;
                    if (cliente.TIPO_DE_RETENEDOR == "03") cbxAgenteRetenedor.SelectedIndex = 2;
                    if (cliente.TIPO_DE_RETENEDOR == "0") cbxAgenteRetenedor.SelectedIndex = 3;
                    txtDireccionEntrega.Text = cliente.DIRECCION_ENTREGA;
                    txtZonaEntrega.Text = cliente.ZONA_ENTREGA.ToString();
                    txtAnotaciones.Text = cliente.ANOTACIONES;
                    if (cliente.NIT != null) { txtNitDpiPas.Text = cliente.NIT; rbnNit.Checked = true; };
                    if (cliente.DISTR == "1") { rdbSiMayorista.Checked = true; } else { rbnNoMayorista.Checked = true; }
                    if(cliente.LISTA_NEGRA == 'S') { rbnSiListaNegra.Checked = true; } else { rbnNoListaNegra.Checked = true; }

                    MessageBox.Show("Busqueda Realizada correctamente");


                }
                else
                {
                    // Manejo de caso cuando el cliente no se encuentra en la base de datos
                    MessageBox.Show("No existe cliente ingresado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Boton actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {


                string nit = " ";
                string dpi = " ";
                string pasaporte = "";
                string distr = null;
                string listaNegra = null;
                string agenteRetenedor = null;
                ClientesRepository clienteRepositoy = new ClientesRepository();
                Clientes cliente = new Clientes();

                if (rbnNit.Checked) nit = txtNitDpiPas.Text;
                if (rbnDpi.Checked) dpi = txtNitDpiPas.Text;
                if (rdbPasaporte.Checked) pasaporte = txtNitDpiPas.Text;

                if (rdbSiMayorista.Checked) distr = "1";
                if (rbnNoMayorista.Checked) distr = "0";

                if (rbnSiListaNegra.Checked) listaNegra = "S";
                if (rbnNoListaNegra.Checked) listaNegra = "N";

                if (cbxAgenteRetenedor.Text == "Exportadores") agenteRetenedor = "01";

                cliente = Clientes.Update(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtFax.Text, nit, txtAtencion.Text, distr, txtCorreo1.Text, txtDescuento.Text, txtCorreo2.Text, txtAnotaciones.Text, listaNegra, agenteRetenedor, txtDireccionEntrega.Text, txtZonaEntrega.Text, dpi, pasaporte);
                clienteRepositoy.Update(cliente, txtCodigo.Text);
                MessageBox.Show("Datos Actualizados correctamente");
                limpiezaTexbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //Boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clientes = new Clientes();
                clientes = Clientes.Eliminar(txtCodigo.Text);   
                MessageBox.Show("Dato Eliminado correctamente");
                limpiezaTexbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Metodo para limpieza de texbox
        private void limpiezaTexbox()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNitDpiPas.Clear();
            txtTelefono.Clear();
            txtFax.Clear();
            txtAtencion.Clear();
            txtCorreo1.Clear();
            txtDescuento.Clear();
            txtCorreo2.Clear();
            txtAnotaciones.Clear();
            cbxAgenteRetenedor.SelectedItem = null;
            txtDireccionEntrega.Clear();
            txtZonaEntrega.Clear();
            rbnDpi.Checked = false;
            rbnNit.Checked = false;
            rdbPasaporte.Checked = false;
            rbnNoMayorista.Checked = false;
            rdbSiMayorista.Checked = false;
            rbnNoListaNegra.Checked = false;
            rbnSiListaNegra.Checked = false;

        }
    }
}