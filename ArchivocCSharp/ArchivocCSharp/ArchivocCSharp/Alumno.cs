namespace ArchivocCSharp
{
    public class Alumno
    {

        public Alumno(long dni)
        {
            //creo un alumno, con el dni obligatoriamente
            this.DNI = dni;
        }

        public Alumno(string linea)
        {
            //reconstruyo el objeto a partir de los datos levantados del archivo
            string[] datos = linea.Split(',');

            this.DNI = long.Parse(datos[0]);
            this.Apellido = datos[1];
            this.Nombre = datos[2];

        }
        public long DNI { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public string GenerarRegistro()
        {
            //genero el registro de datos que guardaré en el archivo para poder reconstruir el objeto en unfuturo
            return $"{DNI},{Apellido},{Nombre}";
        }
    }
}