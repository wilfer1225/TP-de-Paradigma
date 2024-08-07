using System;
using Inmobiliaria.Models;
using Inmobiliaria.Services;

namespace Inmobiliaria.UI
{
    public class InmobiliariaApp
    {
        private PropiedadService propiedadService;
        private ClienteService clienteService;
        private ContratoService contratoService;
        private PagoService pagoService;
        private AgenteService agenteService;

        public InmobiliariaApp()
        {
            propiedadService = new PropiedadService();
            clienteService = new ClienteService();
            contratoService = new ContratoService();
            pagoService = new PagoService();
            agenteService = new AgenteService();
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n ---Bienvenido a la Inmobiliaria WGLM---");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Administrar Propiedades");
                Console.WriteLine("2. Administrar Clientes");
                Console.WriteLine("3. Administrar Contratos");
                Console.WriteLine("4. Administrar Pagos");
                Console.WriteLine("5. Administrar Agentes");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MenuPropiedades();
                        break;
                    case "2":
                        MenuClientes();
                        break;
                    case "3":
                        MenuContratos();
                        break;
                    case "4":
                        MenuPagos();
                        break;
                    case "5":
                        MenuAgentes();
                        break;
                    case "6":
                        MenuReportes();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void MenuPropiedades()
        {
            while (true)
            {
                Console.WriteLine("\n -Administración de Propiedades-");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Listar Propiedades");
                Console.WriteLine("2. Agregar Propiedad");
                Console.WriteLine("3. Editar Propiedad");
                Console.WriteLine("4. Eliminar Propiedad");
                Console.WriteLine("5. Volver al Menú Principal");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Listar(propiedadService);
                        break;
                    case "2":
                        Agregar(propiedadService);
                        break;
                    case "3":
                        Editar(propiedadService);
                        break;
                    case "4":
                        Eliminar(propiedadService);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void MenuClientes()
        {
            while (true)
            {
                Console.WriteLine("\n -Administración de Clientes-");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Listar Clientes");
                Console.WriteLine("2. Agregar Cliente");
                Console.WriteLine("3. Editar Cliente");
                Console.WriteLine("4. Buscar Cliente por Apellido");
                Console.WriteLine("5. Eliminar Cliente");
                Console.WriteLine("6. Volver al Menú Principal");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Listar(clienteService);
                        break;
                    case "2":
                        Agregar(clienteService);
                        break;
                    case "3":
                        Editar(clienteService);
                        break;
                    case "4":
                        BuscarCliente(clienteService);
                        break;
                    case "5":
                        Eliminar(clienteService);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void MenuContratos()
        {
            while (true)
            {
                Console.WriteLine("\n -Administración de Contratos-");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Listar Contratos");
                Console.WriteLine("2. Agregar Contrato");
                Console.WriteLine("3. Editar Contrato");
                Console.WriteLine("4. Eliminar Contrato");
                Console.WriteLine("5. Volver al Menú Principal");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Listar(contratoService);
                        break;
                    case "2":
                        Agregar(contratoService);
                        break;
                    case "3":
                        Editar(contratoService);
                        break;
                    case "4":
                        Eliminar(contratoService);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void MenuPagos()
        {
            while (true)
            {
                Console.WriteLine("\n -Administración de Pagos-");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Listar Pagos");
                Console.WriteLine("2. Agregar Pago");
                Console.WriteLine("3. Editar Pago");
                Console.WriteLine("4. Eliminar Pago");
                Console.WriteLine("5. Volver al Menú Principal");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Listar(pagoService);
                        break;
                    case "2":
                        Agregar(pagoService);
                        break;
                    case "3":
                        Editar(pagoService);
                        break;
                    case "4":
                        Eliminar(pagoService);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void MenuAgentes()
        {
            while (true)
            {
                Console.WriteLine("\n -Administración de Agentes-");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Listar Agentes");
                Console.WriteLine("2. Agregar Agente");
                Console.WriteLine("3. Editar Agente");
                Console.WriteLine("4. Eliminar Agente");
                Console.WriteLine("5. Volver al Menú Principal");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Listar(agenteService);
                        break;
                    case "2":
                        Agregar(agenteService);
                        break;
                    case "3":
                        Editar(agenteService);
                        break;
                    case "4":
                        Eliminar(agenteService);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void MenuReportes()
        {
            while (true)
            {
                Console.WriteLine("\n -Generación de Reportes-");
                Console.Write("\n -Selecciona una opción: ");
                Console.WriteLine("\n\n1. Listar todas las Propiedades");
                Console.WriteLine("2. Listar todos los Clientes");
                Console.WriteLine("3. Listar todos los Contratos");
                Console.WriteLine("4. Listar todos los Pagos");
                Console.WriteLine("5. Listar todos los Agentes");
                Console.WriteLine("6. Volver al Menú Principal");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Listar(propiedadService);
                        break;
                    case "2":
                        Listar(clienteService);
                        break;
                    case "3":
                        Listar(contratoService);
                        break;
                    case "4":
                        Listar(pagoService);
                        break;
                    case "5":
                        Listar(agenteService);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }
        }

        private void Listar<T>(ServicioBase<T> servicio) where T : class, new()
        {
            var items = servicio.Listar();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private void Agregar<T>(ServicioBase<T> servicio) where T : class, new()
        {
            T item = new T();
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                if (prop.Name != "Id")
                {
                    Console.WriteLine($"Ingresa {prop.Name}: ");
                    string input = Console.ReadLine();
                    var convertedValue = Convert.ChangeType(input, prop.PropertyType);
                    prop.SetValue(item, convertedValue);
                }
            }
            servicio.Agregar(item);
            Console.WriteLine($"{typeof(T).Name} agregado con éxito.");
        }

        private void Editar<T>(ServicioBase<T> servicio) where T : class, new()
        {
            Console.WriteLine($"Ingresa el ID de la {typeof(T).Name} a editar: ");
            int id = int.Parse(Console.ReadLine());
            T item = new T();
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                if (prop.Name != "Id")
                {
                    Console.WriteLine($"Ingresa nuevo valor para {prop.Name} (deja en blanco para mantener el actual): ");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        var convertedValue = Convert.ChangeType(input, prop.PropertyType);
                        prop.SetValue(item, convertedValue);
                    }
                }
            }
            if (servicio.Editar(id, item))
            {
                Console.WriteLine($"{typeof(T).Name} editado con éxito.");
            }
            else
            {
                Console.WriteLine($"{typeof(T).Name} no encontrado.");
            }
        }

        private void Eliminar<T>(ServicioBase<T> servicio) where T : class, new()
        {
            Console.WriteLine($"Ingresa el ID de la {typeof(T).Name} a eliminar: ");
            int id = int.Parse(Console.ReadLine());
            if (servicio.Eliminar(id))
            {
                Console.WriteLine($"{typeof(T).Name} eliminado con éxito.");
            }
            else
            {
                Console.WriteLine($"{typeof(T).Name} no encontrado.");
            }
        }

        private void BuscarCliente(ServicioBase<Cliente> servicio)
        {
            Console.WriteLine("Ingresa el apellido del cliente a buscar: ");
            string apellido = Console.ReadLine();
            var clientes = servicio.BuscarCliente(apellido);
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }
    }
}
