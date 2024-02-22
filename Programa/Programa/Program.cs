namespace program;
public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
            {
                throw new ArgumentException("Información incorrecta para crear una persona");
            }

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }
    }

    public class Alumno : Persona
    {
        public string Carnet { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string carnet, DateTime fechaIngreso)
            : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            this.Carnet = carnet;
            this.FechaIngreso = fechaIngreso;
        }
    }

    public class Profesor : Persona
    {
        public string Materia { get; set; }
        public int Experiencia { get; set; }

        public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string materia, int experiencia)
            : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            this.Materia = materia;
            this.Experiencia = experiencia;
        }
    }
public string GetContenido()
{
    return contenido;
}
