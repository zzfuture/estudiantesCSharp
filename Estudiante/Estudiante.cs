namespace suite.Estudiante
{
    public class Estudiante
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private byte edad;
        public byte Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        private List<float?> quices;
        public List<float?> Quices
        {
            get { return quices; }
            set { quices = value; }
        }
        
        private List<float?> trabajos;
        public List<float?> Trabajos
        {
            get { return trabajos; }
            set { trabajos = value; }
        }

        private List<float?> parciales;
        public List<float?> Parciales
        {
            get { return parciales; }
            set { parciales = value; }
        }
    }
}