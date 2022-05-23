INSERT INTO Lejekontrakt (lDato) VALUES 
	('04-01-2022'),
	('04-01-2022')

INSERT INTO Medlem (fNavn, eNavn, tlf, email, mLNr) VALUES
	('Seamus', 'Finnigan', '93337866', 'seamusfinnigan@gmail.com', NULL),
	('Petunia','Dursley', '32465067','petuniadursley@gmail.com', 1),
	('Karen', 'Manager', '93337866', 'kaman@gmail.com', NULL),
	('Fie', 'Potter', '54629374', 'potterfie@gamil.com', NULL),
	('Pernille', 'Heidi', '91026401', 'heidipernille@gmail.com', NULL),
	('Arsim', 'Thor', '35648138', 'thorarsim@gmail.com', 2),
	('Tim', 'Jensen', '293401849', 'jensentim@gmail.com', NULL),
	('Maya', 'Fjord', '927462048', 'fjordmaya@gmail.com', NULL),
	('Thorbjørn', 'Perregaard', '756491026', 'perregaardthorbjørn@gmail.com', NULL)

INSERT INTO Venteliste (vMid, boligType, vDato) VALUES
(2, 1, '03-01-2022'),
(2, 2, '03-01-2022'),
(3, 1, '01-04-2022'),
(3, 3, '04-01-2022'),
(1, 1, '01-04-2022'),
(1, 2, '01-02-2022')

INSERT INTO Bolig (mndPris, adr, kvm, bType, bLNr) VALUES 
('6000', 'Ligustervænget 4', '72', '1', NULL),
('4000', 'Ligustervænget 11', '50', '2', NULL),
('3000', 'Ligustervænget 3', '45', '3', '1'),
('6000', 'Ligustervænget 6', '72', '1', NULL),
('4000', 'Ligustervænget 13', '50', '2', 2),
('3000', 'Ligustervænget 32', '45', '3', NULL)

INSERT INTO Reserveret(rId, rLNr, dStart, dSlut) VALUES 
('23', '1', '2022-05-05 12:00', '2022-06-05 12:00'),
('12', '2', '2022-05-05 12:00', '2022-06-05 12:00')

SELECT * FROM Lejekontrakt
SELECT * FROM Reserveret
SELECT * FROM Venteliste
SELECT * FROM Medlem
SELECT * FROM Lejekontrakt
SELECT * FROM Bolig


