-- =====================================================================
-- Gestión de Biblioteca · datos de ejemplo
-- Ejecutar DESPUÉS del primer arranque de la aplicación: Entity Framework
-- (Code-First) crea la base de datos Biblioteca y sus tablas al arrancar.
--
--   sqlcmd -S "(localdb)\MSSQLLocalDB" -d Biblioteca -i sql\datos-ejemplo.sql
--
-- Solo inserta si la tabla Libros está vacía. 25 libros, cada uno con su lectura.
-- =====================================================================
SET NOCOUNT ON;

IF EXISTS (SELECT 1 FROM dbo.Libros)
BEGIN
    PRINT 'La tabla Libros ya tiene datos: no se inserta nada.';
    RETURN;
END

BEGIN TRANSACTION;

SET IDENTITY_INSERT dbo.Libros ON;
INSERT INTO dbo.Libros (IdLibro, [Título], Autor, Editorial, [Género], Idioma, [Fecha Publicación]) VALUES
    (1, N'Don Quijote de la Mancha', N'Miguel de Cervantes', N'Alfaguara', N'Ficción', N'Español', '1605-01-16'),
    (2, N'Cien años de soledad', N'Gabriel García Márquez', N'Sudamericana', N'Ficción', N'Español', '1967-05-30'),
    (3, N'El nombre de la rosa', N'Umberto Eco', N'Lumen', N'Misterio/Thriller', N'Español', '1980-10-01'),
    (4, N'Sapiens', N'Yuval Noah Harari', N'Debate', N'Ensayo', N'Español', '2011-01-01'),
    (5, N'El Señor de los Anillos', N'J.R.R. Tolkien', N'Minotauro', N'Fantasía', N'Español', '1954-07-29'),
    (6, N'1984', N'George Orwell', N'Destino', N'Ciencia Ficción', N'Español', '1949-06-08'),
    (7, N'Dune', N'Frank Herbert', N'Acervo', N'Ciencia Ficción', N'Español', '1965-08-01'),
    (8, N'El código Da Vinci', N'Dan Brown', N'Umbriel', N'Misterio/Thriller', N'Español', '2003-03-18'),
    (9, N'Memorias de África', N'Karen Blixen', N'Alfaguara', N'Biografía', N'Español', '1937-01-01'),
    (10, N'El principito', N'Antoine de Saint-Exupéry', N'Salamandra', N'Ficción', N'Español', '1943-04-06'),
    (11, N'Fahrenheit 451', N'Ray Bradbury', N'Minotauro', N'Ciencia Ficción', N'Español', '1953-10-19'),
    (12, N'La sombra del viento', N'Carlos Ruiz Zafón', N'Planeta', N'Misterio/Thriller', N'Español', '2001-04-01'),
    (13, N'Orgullo y prejuicio', N'Jane Austen', N'Alba', N'Ficción', N'Español', '1813-01-28'),
    (14, N'El hobbit', N'J.R.R. Tolkien', N'Minotauro', N'Fantasía', N'Español', '1937-09-21'),
    (15, N'Crimen y castigo', N'Fiódor Dostoyevski', N'Alianza', N'Ficción', N'Español', '1866-01-01'),
    (16, N'Homo Deus', N'Yuval Noah Harari', N'Debate', N'Ensayo', N'Español', '2015-09-04'),
    (17, N'El médico', N'Noah Gordon', N'Ediciones B', N'Novela Histórica', N'Español', '1986-01-01'),
    (18, N'Los pilares de la Tierra', N'Ken Follett', N'Plaza & Janés', N'Novela Histórica', N'Español', '1989-09-01'),
    (19, N'Juego de tronos', N'George R.R. Martin', N'Gigamesh', N'Fantasía', N'Español', '1996-08-01'),
    (20, N'Rebelión en la granja', N'George Orwell', N'Destino', N'Ficción', N'Español', '1945-08-17'),
    (21, N'El retrato de Dorian Gray', N'Oscar Wilde', N'Alianza', N'Ficción', N'Español', '1890-06-20'),
    (22, N'Fundación', N'Isaac Asimov', N'Robots y Androides', N'Ciencia Ficción', N'Español', '1951-05-01'),
    (23, N'El nombre del viento', N'Patrick Rothfuss', N'Plaza & Janés', N'Fantasía', N'Español', '2007-03-27'),
    (24, N'La regenta', N'Leopoldo Alas Clarín', N'Anagrama', N'Ficción', N'Español', '1884-01-01'),
    (25, N'La metamorfosis', N'Franz Kafka', N'Anagrama', N'Ficción', N'Español', '1915-10-01');
SET IDENTITY_INSERT dbo.Libros OFF;

SET IDENTITY_INSERT dbo.Lecturas ON;
INSERT INTO dbo.Lecturas (IdLectura, IdLibro, Estado, Comentario, [Número Lectura]) VALUES
    (1, 1, N'Completado', N'Una obra maestra de la literatura universal.', 5),
    (2, 2, N'Completado', N'Realismo mágico en su máxima expresión.', 2),
    (3, 3, N'Completado', N'Apasionante combinación de historia y misterio.', 1),
    (4, 4, N'Completado', N'Cambia la perspectiva sobre la historia humana.', 1),
    (5, 5, N'Completado', N'La épica fantástica definitiva.', 3),
    (6, 6, N'Completado', N'Perturbador y más vigente que nunca. La última parte se me hizo pesada.', 4),
    (7, 7, N'Completado', N'Una obra de ciencia ficción sin igual.', 10),
    (8, 8, N'Completado', N'Entretenido aunque algo predecible.', 1),
    (9, 9, N'Completado', N'Relato poético y emotivo de una vida en África.', 1),
    (10, 10, N'Completado', N'Un clásico imprescindible para todas las edades.', 5),
    (11, 11, N'Completado', N'Lectura 1: reflexión poderosa sobre la censura y el conocimiento.
Lectura 2: me ha vuelto a encantar.', 2),
    (12, 12, N'Completado', N'Barcelona y el misterio entrelazados perfectamente.', 2),
    (13, 13, N'Completado', N'Ingenio y romanticismo en su mejor versión.', 1),
    (14, 14, N'Completado', N'La aventura que dio origen a la Tierra Media.', 2),
    (15, 15, N'En Progreso', N'Psicología profunda y muy intensa.', 1),
    (16, 16, N'En Progreso', N'Continuación fascinante de Sapiens.', 1),
    (17, 17, N'Pendiente', NULL, 0),
    (18, 18, N'Completado', N'Épica medieval absolutamente absorbente.', 1),
    (19, 19, N'En Progreso', N'Complejo pero adictivo.', 1),
    (20, 20, N'Completado', N'Alegoría política brillante y concisa.', 1),
    (21, 21, N'Completado', N'Elegante y filosófico. Wilde en estado puro.', 1),
    (22, 22, N'Pendiente', NULL, 0),
    (23, 23, N'Abandonado', N'Prometedor, pero lo dejé a medias.
Lectura 2: lo intenté de nuevo y tampoco pude acabarlo.', 2),
    (24, 24, N'En Progreso', N'Estupendo aunque un poco trasnochado el estilo', 1),
    (25, 25, N'Pendiente', NULL, 0);
SET IDENTITY_INSERT dbo.Lecturas OFF;

COMMIT TRANSACTION;
PRINT 'Datos de ejemplo insertados.';
