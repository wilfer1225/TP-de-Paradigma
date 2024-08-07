namespace Inmobiliaria.Models
{
    public class Propiedad
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    }
    
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Teléfono: {Telefono}";
        }
    }

    public class Contrato
    {
        public int Id { get; set; }
        public int PropiedadId { get; set; }
        public int AgenteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Precio { get; set; }
    }

    public class Pago
    {
        public int Id { get; set; }
        public int ContratoId { get; set; }
        public DateTime FechaPago { get; set; }
        public double Monto { get; set; }
    }

    public class Agente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
    }
}
