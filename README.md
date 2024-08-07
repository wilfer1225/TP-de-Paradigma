

```markdown
# Inmobiliaria WGLM

Inmobiliaria WGLM es una aplicación de consola para la gestión de propiedades, clientes, contratos, pagos y agentes inmobiliarios. La aplicación sigue el patrón de diseño en capas y utiliza JSON para el almacenamiento de datos.

## Estructura del Proyecto

El proyecto está dividido en las siguientes capas:

1. **Interfaz de usuario (UI)**:
   - `InmobiliariaApp`: Proporciona un menú para administrar todas las funcionalidades del sistema.

2. **Capa de negocio (Servicios)**:
   - `ServicioBase<T>`: Implementa las operaciones CRUD básicas.
   - `PropiedadService`, `ClienteService`, `ContratoService`, `PagoService`, `AgenteService`: Servicios específicos para cada entidad.

3. **Capa de acceso a datos (Repositorio)**:
   - `FileService<T>`: Lee y escribe datos en archivos JSON.

4. **Capa de entidades (Modelos)**:
   - `Propiedad`, `Cliente`, `Contrato`, `Pago`, `Agente`: Representan las entidades del sistema.

## Funcionalidades

### Menú Principal

El menú principal proporciona las siguientes opciones:

1. Administrar Propiedades
2. Administrar Clientes
3. Administrar Contratos
4. Administrar Pagos
5. Administrar Agentes
6. Reportes
7. Salir

### Administrar Entidades

Cada opción del menú principal permite gestionar las siguientes entidades con operaciones CRUD:

- **Propiedades**
- **Clientes**
- **Contratos**
- **Pagos**
- **Agentes**

### Reportes

La opción de reportes permite listar la información de todas las entidades:

1. Listar todas las Propiedades
2. Listar todos los Clientes
3. Listar todos los Contratos
4. Listar todos los Pagos
5. Listar todos los Agentes

## Instalación

Para clonar y ejecutar este proyecto, sigue los siguientes pasos:

1. Clona el repositorio:

   ```bash
   git clone https://github.com/tuusuario/inmobiliaria-wglm.git
   ```

2. Navega al directorio del proyecto:

   ```bash
   cd inmobiliaria-wglm
   ```

3. Abre el proyecto en tu IDE favorito (por ejemplo, Visual Studio).

4. Ejecuta el proyecto.

## Uso

1. Al iniciar la aplicación, se mostrará el menú principal.
2. Selecciona una opción del menú para gestionar las entidades o generar reportes.
3. Sigue las instrucciones en pantalla para realizar las operaciones deseadas.

## Contribuciones

Las contribuciones son bienvenidas. Si deseas contribuir, por favor sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una rama para tu característica (`git checkout -b feature/tu-rama`).
3. Realiza tus cambios y haz commit (`git commit -m 'Añadir alguna característica'`).
4. Haz push a la rama (`git push origin feature/tu-rama`).
5. Abre un Pull Request.

## Autor

- Wilfer Florentin
- Luciana Quaranta
- Gianella Chiappello
- Mailen Copponi

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.
```

Asegúrate de reemplazar `"https://github.com/tuusuario/inmobiliaria-wglm.git"` con la URL de tu repositorio en GitHub. También puedes agregar más detalles específicos sobre tu proyecto si lo deseas.
