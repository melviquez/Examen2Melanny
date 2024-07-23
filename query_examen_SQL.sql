CREATE TABLE casa_noble (
    casa_id int IDENTITY(5,5) NOT NULL PRIMARY KEY,
    casa_nombre varchar(50) NOT NULL,
    lord_nombre varchar(50) NOT NULL
);

CREATE TABLE votos_lealtad (
    voto_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    fecha_votacion date NOT NULL DEFAULT getdate(),
    casa_nombre varchar(255) NOT NULL
);

CREATE VIEW conteo_lealtad AS
SELECT 
    casa_noble.casa_nombre,
    COUNT(votos_lealtad.voto_id) AS total_votos,
    CAST(COUNT(votos_lealtad.voto_id) AS float) / CAST((SELECT COUNT(*) FROM votos_lealtad) AS float) * 100 AS porcentaje_votos
FROM 
    votos_lealtad
JOIN 
    casa_noble ON votos_lealtad.casa_nombre = casa_noble.casa_nombre
GROUP BY 
    casa_noble.casa_nombre;



INSERT INTO casa_noble (casa_nombre, lord_nombre)
VALUES 
('Stark', 'Eddard Stark'),
('Lannister', 'Tywin Lannister'),
('Targaryen', 'Daenerys Targaryen'),
('Baratheon', 'Robert Baratheon');


INSERT INTO votos_lealtad (casa_nombre)
VALUES 
('Stark'),
('Stark'),
('Lannister'),
('Targaryen'),
('Targaryen'),
('Targaryen'),
('Baratheon'),
('Stark');

select * from casa_noble

select * from votos_lealtad

select * from conteo_lealtad

