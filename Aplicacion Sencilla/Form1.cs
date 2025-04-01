using Aplicacion_Sencilla.Dato;
using Aplicacion_Sencilla.Modelo;
using System.Data;
using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aplicacion_Sencilla
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        private DataGridView dataGridView1; // Changed from object to DataGridView

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguadar_Click(object sender, EventArgs e)
        {
            Guardar(); 
            Iniciar(); 
            limpiar();  
            consultar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
             limpiar();     
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;

        }
        private void Guardar()
        {

            UsuarioModel modelo = new UsuarioMdel()
            {
                Nombre = txtnombre.Text,
                edad = int.Parse(txtedad.Text)

            };
            dato.guardar(modelo);
        }

        private void consultar()
        {

            foreach (var item in dato.consultar())
            { 
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.edad;
                tabla.Rows.Add(fila);

            }

        }
        private void limpiar() {
            txtnombre.Text = "";
            txtedad.Text = "";
        }
        
           
    }

}
