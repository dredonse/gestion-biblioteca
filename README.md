# 📚 Sistema de Gestión de Biblioteca Personal

Aplicación de escritorio Windows para gestionar una colección de libros personal y llevar un seguimiento detallado de las lecturas.

Desarrollada en **C# con Windows Forms** sobre **.NET Framework 4.7.2**, con persistencia de datos mediante **Entity Framework 6.5.1** y **SQL Server** en modalidad Code-First.

---

## ✨ Funcionalidades

- **Catálogo de libros** — consulta todos tus libros en un listado con búsqueda y filtros
- **Filtrado combinado** por autor, editorial, género y estado de lectura
- **Alta de libros** — registra título, autor, editorial, género, idioma y fecha de publicación
- **Seguimiento de lecturas** — guarda el estado (Pendiente / En Progreso / Completado / Abandonado), el número de lectura y comentarios personales
- **Modificación y borrado** de libros con eliminación en cascada de sus lecturas
- **Vista de comentarios** — al seleccionar un libro en el listado se muestra su reseña personal al instante

---

## 🏗️ Arquitectura

El proyecto sigue el patrón **MVC (Modelo-Vista-Controlador)** con separación clara de responsabilidades:

```
GestionBiblioteca/
├── Modelo.cs                  # DbContext (EF) + entidades LibroDTO y LecturasDTO
├── Modelos/
│   ├── LibroDAO.cs            # Acceso a datos: CRUD de libros y consultas LINQ
│   ├── LecturaDAO.cs          # Acceso a datos: grabación de lecturas
│   └── LibroVistaDTO.cs       # Proyección plana para el DataGridView
├── Controladores/
│   ├── BookController.cs      # Lógica de alta y modificación de libros
│   └── BookListController.cs  # Lógica de listado, filtrado y borrado
└── Vistas/
    ├── MainForm              # Pantalla de inicio
    ├── BookListForm          # Catálogo principal con búsqueda y gestión
    └── BookForm              # Formulario de alta y edición
```

**Base de datos** generada automáticamente por EF Code-First al primer arranque:

```
LIBROS    ( IdLibro PK, Título, Autor, Editorial, Género, Idioma, FechaPublicación )
LECTURAS  ( IdLectura PK, IdLibro FK, Estado, Comentario, NúmeroLectura )
```

---

## 🛠️ Requisitos

| Componente | Versión mínima |
|---|---|
| Windows | 10 (64 bits) |
| .NET Framework | 4.7.2 |
| SQL Server | 2017 (edición Express es suficiente) |

### Instalar SQL Server Express (gratuito)
👉 https://www.microsoft.com/es-es/sql-server/sql-server-downloads

---

## 🚀 Instalación y puesta en marcha

### 1. Clonar el repositorio

```bash
git clone https://github.com/TU_USUARIO/gestion-biblioteca.git
cd gestion-biblioteca
```

### 2. Restaurar paquetes NuGet

Abre la solución en **Visual Studio 2022** y haz clic derecho sobre la solución → *Restaurar paquetes NuGet*.

O desde la terminal del Paquete de NuGet:
```
nuget restore GestionBiblioteca.sln
```

### 3. Configurar la cadena de conexión

Edita `GestionBiblioteca/App.config` y sustituye `NOMBRE_INSTANCIA` por el nombre real de tu instancia de SQL Server:

```xml
<add name="Modelo"
     connectionString="data source=NOMBRE_INSTANCIA;
                       initial catalog=Biblioteca;
                       integrated security=True;
                       MultipleActiveResultSets=True;
                       App=EntityFramework"
     providerName="System.Data.SqlClient" />
```

> **Nota:** Si instalaste SQL Server Express con los ajustes por defecto, el nombre suele ser `.\SQLEXPRESS` o `NOMBRE_DE_TU_PC\SQLEXPRESS`.

### 4. Compilar y ejecutar

Pulsa `F5` en Visual Studio o compila con:

```bash
msbuild GestionBiblioteca.sln /p:Configuration=Release
```

Al arrancar por primera vez, **Entity Framework crea automáticamente** la base de datos `Biblioteca` con todas sus tablas. No es necesario ejecutar ningún script SQL.

---

## 📖 Uso rápido

1. Al abrir la app aparece la **pantalla de inicio** con dos opciones: ver la biblioteca o añadir un libro directamente.
2. Desde el **listado** puedes filtrar por autor, editorial, género o estado y ver el comentario de cada libro en el panel lateral.
3. Usa los botones **Insertar / Modificar / Borrar** para gestionar tu colección.
4. El **formulario de libro** valida todos los campos antes de guardar: ningún campo obligatorio puede estar vacío y la fecha de publicación no puede ser futura.

---

## 🧰 Tecnologías utilizadas

| Tecnología | Versión | Uso |
|---|---|---|
| C# / .NET Framework | 4.7.2 | Lenguaje y plataforma base |
| Windows Forms | incluida en .NET | Interfaz gráfica |
| Entity Framework | 6.5.1 | ORM Code-First |
| SQL Server Express | 2017+ | Base de datos local |
| Visual Studio | 2022 Community | IDE de desarrollo |

---

## 📁 Estructura del repositorio

```
gestion-biblioteca/
├── GestionBiblioteca.sln
├── GestionBiblioteca/         # Proyecto principal
│   ├── App.config             # Cadena de conexión (ajustar antes de ejecutar)
│   ├── packages.config        # Dependencias NuGet
│   ├── Modelo.cs
│   ├── Modelos/
│   ├── Controladores/
│   ├── Vistas/
│   └── Properties/
└── Documentacion/             # Memoria del proyecto
```

---

## 📋 Historial de cambios

### v1.1.0 — Revisión y limpieza de código
*Correcciones aplicadas antes de la publicación en GitHub*

**Errores críticos corregidos**
- `MainForm.cs` — Eliminado bloque de comentarios de cabecera perteneciente a un proyecto anterior
- `BookListForm.cs` — El bloque `catch` vacío en `CargarDatosEnDataGridView()` ahora muestra un `MessageBox` con el error al usuario en lugar de silenciarlo
- `BookForm.cs` + `Modelo.cs` — Las claves de excepción internas (`ErrorTitulo`, `ErrorAutorVacio`, etc.) se traducen a mensajes legibles en español mediante el método `ObtenerMensajeErrorValidacion()` antes de mostrarse al usuario

**Refactorización**
- `BookListForm.cs` — `BookListController` pasa de instanciarse dentro de cada evento a ser un campo `private readonly`, eliminando objetos innecesarios en cada llamada
- `BookForm.cs` — Eliminado el método `limpiarPantalla()` que estaba declarado pero nunca se llamaba

**Limpieza de código**
- `Program.cs` — Eliminados cuatro `using` innecesarios; `[STAThread]` se escribe explícito como `[System.STAThread]`
- `MainForm.cs` — Eliminado `using GestionBiblioteca.Controladores` no utilizado
- `Modelo.cs` — Eliminado el `$` de interpolación innecesario en los cinco `throw new Exception(...)` de `LibroDTO`
- `BookForm.cs` y `BookListForm.cs` — Eliminados todos los bloques de código comentado que ya no se usaban
- `LecturaDAO.cs` — Marcada como `// Reservado para uso futuro` al no estar referenciada desde ningún otro fichero

**Configuración del repositorio**
- Añadido `.gitignore` para excluir `bin/`, `obj/`, `.vs/`, `.vscode/`, `packages/`, `Documentacion/` y archivos temporales de Visual Studio

---

## 📄 Licencia

Proyecto académico desarrollado para el módulo **Proyecto DAM** del Ciclo Formativo de Grado Superior en Desarrollo de Aplicaciones Multiplataforma.

---

*Autor: [Tu nombre] · IES [Nombre del centro] · Curso 2024-2025*
