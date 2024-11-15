using Entity;
using Entity.Model;
using Mapper;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class EmpleadoDAL
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }
        public void crearEmpleado(EmpleadoEntity empleadoentity)
        {
            try
            {

                var appDbContext = getAppDbContext();
                using(appDbContext)
                {
                    Empleado empleado = EmpleadoMapper.map(empleadoentity);
                    appDbContext.empleados.Add(empleado);
                    appDbContext.SaveChanges();

                }

            }catch (Exception ex) { throw; }
        }

        public List<EmpleadoEntity> GetEmpleados()
        {
            List<EmpleadoEntity> lista = new List<EmpleadoEntity>();
            try
            {
                AppDbContext appDbContext = getAppDbContext();
                foreach (var empleado in appDbContext.empleados)
                {
                    lista.Add(EmpleadoMapper.map(empleado));
                }
                

            }catch(Exception ex) { throw; }
            return lista;
        }
    }
}
