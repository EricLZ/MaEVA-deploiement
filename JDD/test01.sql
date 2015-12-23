IF EXISTS (SELECT * FROM sys.objects WHERE name = 'client')
	BEGIN
		DROP TABLE dbo.client;
	END

CREATE TABLE dbo.client (prenom nchar(15) , destination nchar(15), age integer);


-- Insertion en masse
INSERT INTO dbo.client VALUES ('Robert', 'Bordeaux', 10);
INSERT INTO dbo.client VALUES ('Jean', 'Marseille', 11);
INSERT INTO dbo.client VALUES ('Pierre', 'Paris', 12);
INSERT INTO dbo.client VALUES ('Paul', 'Bordeaux', 13);
INSERT INTO dbo.client VALUES ('Edith', 'Le Havre', 14);
INSERT INTO dbo.client VALUES ('Marie', 'Bordeaux', 15);
INSERT INTO dbo.client VALUES ('Jeanne', 'Bordeaux', 16);
INSERT INTO dbo.client VALUES ('Julie', 'Bordeaux', 17);
INSERT INTO dbo.client VALUES ('Enzo', 'Bordeaux', 18);


-- Ajout d'une colonne à la tale
alter table dbo.client add adresse nchar (25);
UPDATE dbo.client set adresse='6, rue du Maine';
-- Changements de destination
UPDATE dbo.client set destination = 'MADRID' WHERE destination = 'BORDEAUX';


