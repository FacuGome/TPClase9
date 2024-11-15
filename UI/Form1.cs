using BLL;
using Entity;
using Entity.Model;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            actualizar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        EmpleadoBLL bLL = new EmpleadoBLL();
        List<EmpleadoEntity> empleados = new List<EmpleadoEntity>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoEntity empleado = new EmpleadoEntity()
                {
                    DNI = Convert.ToInt32(txtDNIAgregar.Text),
                    ApellidoNombre = txtNombreApellidoAgregar.Text,
                    SueldoBruto = Convert.ToDouble(txtSueldoBrutoAgregar.Text),
                };
                empleados.Add(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            actualizar();
        }



        public void actualizar()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = bLL.getEmpleados();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                bLL.CrearEmpleados(empleados);
            }catch(Exception ex) {  MessageBox.Show(ex.Message); }
            finally { actualizar(); }
        }
    }
}
