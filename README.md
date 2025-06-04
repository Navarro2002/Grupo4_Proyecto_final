# Grupo4_Proyecto_final
# BASE DE DATOS DEL PROYECTO 
Script de base de datos -- Tabla: ctl_rol
CREATE TABLE ctl_rol (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100)
);

-- Tabla: mnt_usuarios
CREATE TABLE mnt_usuarios (
    id INT PRIMARY KEY IDENTITY(1,1), -- Para SQL Server
    usuario VARCHAR(100),
    contrasenia VARCHAR(100),
    id_rol INT FOREIGN KEY REFERENCES ctl_rol(id)
);

-- Tabla: ctl_seccion
CREATE TABLE ctl_seccion (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100)
);

-- Tabla: mnt_grado
CREATE TABLE mnt_grado (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100),
    id_seccion INT FOREIGN KEY REFERENCES ctl_seccion(id),
    cantidad_materias INT
);

-- Tabla: mnt_alumno
CREATE TABLE mnt_alumno (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombres VARCHAR(100),
    apellidos VARCHAR(100),
    telefono VARCHAR(15),
    edad INT,
    fecha_nacimiento DATE,
    id_grado INT FOREIGN KEY REFERENCES mnt_grado(id),
    id_seccion INT FOREIGN KEY REFERENCES ctl_seccion(id),
    id_usuario INT FOREIGN KEY REFERENCES mnt_usuarios(id)
);

-- Tabla: mnt_docente
CREATE TABLE mnt_docente (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombres VARCHAR(100),
    apellidos VARCHAR(100),
    telefono VARCHAR(15),
    edad INT,
    fecha_nacimiento DATE,
    id_grado INT FOREIGN KEY REFERENCES mnt_grado(id),
    id_seccion INT FOREIGN KEY REFERENCES ctl_seccion(id),
    id_usuario INT FOREIGN KEY REFERENCES mnt_usuarios(id)
);

-- Tabla: ctl_materia
CREATE TABLE ctl_materia (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100)
);

-- Tabla: Trimestre
CREATE TABLE mnt_trimestre (
    id INT PRIMARY KEY IDENTITY(1,1),
    trimestre varchar(20),
    promedio_final FLOAT,
    nota_minima FLOAT
);

-- Tabla: Evaluaciones
CREATE TABLE mnt_evaluaciones (
    id INT PRIMARY KEY IDENTITY(1,1),
    evaluacion VARCHAR(100),
    id_alumno INT FOREIGN KEY REFERENCES mnt_alumno(id),
    id_materia INT FOREIGN KEY REFERENCES ctl_materia(id),
    id_trimestre INT FOREIGN KEY REFERENCES mnt_trimestre(id),
    nota FLOAT
);



-- Obtener el promedio de un estudiante
CREATE PROCEDURE sp_PromedioPorTrimestre
    @id_alumno INT
AS
BEGIN
    SELECT 
        t.trimestre,
        AVG(e.nota) AS promedio
    FROM mnt_evaluaciones e
    INNER JOIN mnt_trimestre t ON e.id_trimestre = t.id
    WHERE e.id_alumno = @id_alumno
    GROUP BY t.trimestre
END;
-- LLamar el procedimiento 

-- Procedimiento para obtener materias aprobadas y reprobadas por estudiante
CREATE PROCEDURE sp_MateriasAprobadasReprobadas
    @id_alumno INT
AS
BEGIN
    SELECT 
        m.nombre AS materia,
        t.trimestre,
        n.nota,
        CASE 
            WHEN n.nota >= t.nota_minima THEN 'Aprobada'
            ELSE 'Reprobada'
        END AS estado
    FROM mnt_evaluaciones n
    INNER JOIN ctl_materia m ON n.id_materia = m.id
    INNER JOIN mnt_trimestre t ON n.id_trimestre = t.id
    WHERE n.id_alumno = @id_alumno
END;


-- Procedimiento para obtener porcentaje de alumnos aprobados y reprobados
CREATE OR ALTER PROCEDURE sp_PorcentajeAprobacion
AS
BEGIN
    DECLARE @total_alumnos FLOAT;

    SELECT @total_alumnos = COUNT(*) FROM mnt_alumno;

    IF @total_alumnos = 0
    BEGIN
        SELECT 
            0 AS porcentaje_aprobados,
            0 AS porcentaje_reprobados;
    END
    ELSE
    BEGIN
        SELECT 
            ROUND(COUNT(DISTINCT a.id) * 100.0 / @total_alumnos, 2) AS porcentaje_aprobados,
            ROUND((@total_alumnos - COUNT(DISTINCT a.id)) * 100.0 / @total_alumnos, 2) AS porcentaje_reprobados
        FROM mnt_alumno a
        WHERE NOT EXISTS (
            SELECT 1
            FROM mnt_evaluaciones n
            INNER JOIN mnt_trimestre t ON n.id_trimestre = t.id
            WHERE n.id_alumno = a.id AND n.nota < t.nota_minima
        );
    END
END;


-- Procedimiento para obtener materias aprobadas y reprobadas por estudiante
CREATE PROCEDURE sp_MateriasAprobadasReprobadas 
    @id_alumno INT,
    @id_trimestre INT
AS
BEGIN
    SELECT 
        m.nombre AS materia,
        t.trimestre,
        AVG(CAST(n.nota AS DECIMAL(5,2))) AS promedio,
        CASE 
            WHEN AVG(CAST(n.nota AS DECIMAL(5,2))) >= t.nota_minima THEN 'Aprobada'
            ELSE 'Reprobada'
        END AS estado
    FROM mnt_evaluaciones n
    INNER JOIN ctl_materia m ON n.id_materia = m.id
    INNER JOIN mnt_trimestre t ON n.id_trimestre = t.id
    WHERE n.id_alumno = @id_alumno
      AND n.id_trimestre = @id_trimestre
    GROUP BY m.nombre, t.trimestre, t.nota_minima
END;

--- Registros iniciales 
INSERT INTO ctl_rol (nombre) VALUES ('Administrador');
INSERT INTO ctl_rol (nombre) VALUES ('Docente');
INSERT INTO ctl_rol (nombre) VALUES ('Estudiante');

INSERT INTO mnt_usuarios (usuario, contrasenia, id_rol) VALUES ('admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1);
INSERT INTO mnt_usuarios (id, usuario, contrasenia, id_rol) VALUES (2, '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'docente456', 2);
INSERT INTO mnt_usuarios (id, usuario, contrasenia, id_rol) VALUES (3, '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'estudiante789', 3);
