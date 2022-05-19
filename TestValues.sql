INSERT INTO Lejekontrakt (indflytter) VALUES 
	('04-01-2022')



INSERT INTO Medlem (fNavn, eNavn, tlf, email, lNr) VALUES
	('Seamus', 'Finnigan', '93337866', 'seamusfinnigan@gmail.com', NULL),
	('Petunia','Dursley', '32465067','petuniadursley@gmail.com', 1),
	('Karen', 'Manager', '93337866', 'kaman@gmail.com', NULL)


INSERT INTO Venteliste (medlemId, boligType, opskrevet) VALUES
(2, 1, '3-1-2022'),
(2, 2, '3-1-2022'),
(3, 1, '1-4-2022'),
(3, 3, '4-1-2022'),
(1, 1, '1-4-2022'),
(1, 2, '1-2-2022')

INSERT INTO Bolig (mndPris, adr, kvm, bType, loebeNr) VALUES 
('6000', 'Ligustervænget 4', '72', '1', NULL),
('4000', 'Ligustervænget 11', '50', '2', NULL),
('3000', 'Ligustervænget 3', '45', '3', '1'),
('6000', 'Ligustervænget 6', '72', '1', NULL),
('4000', 'Ligustervænget 13', '50', '2', NULL),
('3000', 'Ligustervænget 32', '45', '3', NULL)

INSERT INTO Reserveret(rId, lId, dStart, dSlut) VALUES 
('1', '1', '1-6-2022 12:00', '2-6-2022 12:00')

SELECT * FROM Lejekontrakt
SELECT * FROM Reserveret
SELECT * FROM Venteliste
SELECT * FROM Medlem
SELECT * FROM Lejekontrakt
SELECT * FROM Bolig

SELECT mId AS 'ID', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', loebeNr 'Løbenummer', indflytter AS 'Indflytter' FROM Medlem, Lejekontrakt WHERE loebeNr = lNr
