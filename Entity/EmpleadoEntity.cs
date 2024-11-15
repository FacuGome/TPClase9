namespace Entity
{
    public class EmpleadoEntity
    {
        public string ApellidoNombre {  get; set; }
        public int DNI {  get; set; }
        public double SueldoBruto {  get; set; }

        public int Id {  get; set; }
        double CalcularSueldoNeto(double sueldoBruto)
        {
            return sueldoBruto * 0.83;
        }
    }
}
