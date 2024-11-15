using DAL;
using Entity;
using Entity.Model;
using System.Transactions;

namespace BLL
{
    public class EmpleadoBLL
    {
        EmpleadoDAL DAL = new EmpleadoDAL();

        public void CrearEmpleado(EmpleadoEntity empleado)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    RevisarDatos(empleado);
                    DAL.crearEmpleado(empleado);

                }

            } catch (Exception ex) { throw; }
        }
        public void CrearEmpleados(List<EmpleadoEntity> empleados)
        {
            try
            {
                using (var trx = new TransactionScope())
                {

                    foreach (var emp in empleados)
                    {
                        CrearEmpleado(emp);
                    }
                }
            }catch (Exception ex) { throw; }
        }
        public List<EmpleadoEntity> getEmpleados()
        {
            return DAL.GetEmpleados();
        }

        void RevisarDatos(EmpleadoEntity empleado)
        {

            if(empleado.ApellidoNombre.Length <= 5) { throw new Exception("El nombre y apellido son demasiado cortos"); }
            if(Convert.ToString(empleado.DNI).Length != 8) { throw new Exception("El dni tiene que tener exactamente 11 caracteres"); }
            if(empleado.SueldoBruto < 100000) { throw new Exception("El salario ingresado es menor al salario minimo, vital y movil de $100.000. Intente de nuevo sin poner puntos o comas"); }

        }
    }
}
