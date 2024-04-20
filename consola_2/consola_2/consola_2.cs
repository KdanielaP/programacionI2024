namespace consola_2
{
    internal class consola_2
    {
        // Clase Persona
        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }

            public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
            {
                // Validar que la información sea correcta
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío");
                }
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    throw new ArgumentException("El apellido no puede estar vacío");
                }
                if (fechaNacimiento >= DateTime.Now)
                {
                    throw new ArgumentException("La fecha de nacimiento no puede ser mayor o igual a la actual");
                }
                if (string.IsNullOrWhiteSpace(telefono))
                {
                    throw new ArgumentException("El teléfono no puede estar vacío");
                }
                if (string.IsNullOrWhiteSpace(direccion))
                {
                    throw new ArgumentException("La dirección no puede estar vacía");
                }

                Nombre = nombre;
                Apellido = apellido;
                FechaNacimiento = fechaNacimiento;
                Telefono = telefono;
                Direccion = direccion;
            }
        }

        // Clase Alumno
        public class Alumno : Persona
        {
            public string Carnet { get; set; }
            public DateTime FechaIngreso { get; set; }

            public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string carnet, DateTime fechaIngreso)
                : base(nombre, apellido, fechaNacimiento, telefono, direccion)
            {
                Carnet = carnet;
                FechaIngreso = fechaIngreso;
            }
        }

        // Clase Profesor
        public class Profesor : Persona
        {
            public string Materia { get; set; }
            public decimal Salario { get; set; }

            public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string materia, decimal salario)
                : base(nombre, apellido, fechaNacimiento, telefono, direccion)
            {
                Materia = materia;
                Salario = salario;
            }
        }
    }
}
