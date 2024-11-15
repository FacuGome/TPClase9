using Entity;
using Entity.Model;

namespace Mapper
{
    public class EmpleadoMapper
    {
        public static Empleado map(EmpleadoEntity empleado)
        {
            return new Empleado
            {
                DNI = empleado.DNI,
                ApellidoNombre = empleado.ApellidoNombre,
                SueldoBruto = empleado.SueldoBruto,
                Id = empleado.Id,
            };
        }
        public static EmpleadoEntity map(Empleado empleado)
        {
            return new EmpleadoEntity
            {
                DNI = empleado.DNI,
                ApellidoNombre = empleado.ApellidoNombre,
                SueldoBruto = empleado.SueldoBruto,
                Id = empleado.Id,
            };
        }
    }
}
