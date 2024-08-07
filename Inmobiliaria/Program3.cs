using System.Collections.Generic;
using Inmobiliaria.Models;

namespace Inmobiliaria.Services
{
    public class ServicioBase<T> where T : class, new()
    {
        private List<T> items;

        public ServicioBase()
        {
            items = FileService<T>.Leer();
        }

        public List<T> Listar()
        {
            return items;
        }

        public void Agregar(T item)
        {
            int nextId = items.Count > 0 ? (int)typeof(T).GetProperty("Id").GetValue(items[^1]) + 1 : 1;
            typeof(T).GetProperty("Id").SetValue(item, nextId);
            items.Add(item);
            FileService<T>.Guardar(items);
        }

        public bool Editar(int id, T itemEditado)
        {
            T item = items.Find(p => (int)typeof(T).GetProperty("Id").GetValue(p) == id);
            if (item == null) return false;

            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                if (prop.Name != "Id")
                {
                    prop.SetValue(item, prop.GetValue(itemEditado));
                }
            }
            FileService<T>.Guardar(items);
            return true;
        }

        public List<T> BuscarCliente(string apellido)
        {
            var propApellido = typeof(T).GetProperty("Apellido");
            if (propApellido == null)
                throw new InvalidOperationException("La clase no tiene una propiedad 'Apellido'.");

            return items.Where(p => propApellido.GetValue(p)?.ToString().Equals(apellido, StringComparison.OrdinalIgnoreCase) == true).ToList();
        }

        public bool Eliminar(int id)
        {
            T item = items.Find(p => (int)typeof(T).GetProperty("Id").GetValue(p) == id);
            if (item == null) return false;

            items.Remove(item);
            FileService<T>.Guardar(items);
            return true;
        }
    }

    public class PropiedadService : ServicioBase<Propiedad> { }
    public class ClienteService : ServicioBase<Cliente> { }
    public class ContratoService : ServicioBase<Contrato> { }
    public class PagoService : ServicioBase<Pago> { }
    public class AgenteService : ServicioBase<Agente> { }
}
