INSERT INTO Lejekontrakt (lDato) VALUES 
	('04-01-2022'),
	('04-01-2022')

INSERT INTO Medlem (fNavn, eNavn, tlf, email, mLNr, beboer) VALUES
	('Seamus', 'Finnigan', '93337866', 'seamusfinnigan@gmail.com', NULL, 0),
	('Petunia','Dursley', '32465067','petuniadursley@gmail.com', 1, 1),
	('Karen', 'Manager', '93337866', 'kaman@gmail.com', NULL, 0),
	('Fie', 'Potter', '54629374', 'potterfie@gamil.com', NULL, 0),
	('Pernille', 'Heidi', '91026401', 'heidipernille@gmail.com', NULL, 0),
	('Arsim', 'Thor', '35648138', 'thorarsim@gmail.com', 2, 1),
	('Tim', 'Jensen', '29340184', 'jensentim@gmail.com', NULL, 0),
	('Maya', 'Fjord', '92746204', 'fjordmaya@gmail.com', NULL, 0),
	('Thorbjørn', 'Perregaard', '75649102', 'perregaardthorbjørn@gmail.com', NULL, 0)

INSERT INTO Venteliste (vMId, vTId, vDato) VALUES
(4, 1, '03-01-2022'),
(4, 2, '03-01-2022'),
(3, 1, '01-04-2022'),
(3, 3, '04-01-2022'),
(1, 1, '01-04-2022'),
(1, 2, '01-02-2022'),
(5, 1, '07-06-2022'),
(7, 1, '18-07-2022'),
(7, 2, '12-03-2022'),
(8, 1, '15-03-2022'),
(9, 1, '17-08-2022')

INSERT INTO Bolig (mndPris, adr, kvm, bTId, bLNr) VALUES 
('6000', 'Ligustervænget 4', '72', '1', NULL),
('4000', 'Ligustervænget 11', '50', '2', NULL),
('3000', 'Ligustervænget 3', '45', '3', '1'),
('6000', 'Ligustervænget 6', '72', '1', NULL),
('4000', 'Ligustervænget 13', '50', '2', '2'),
('3000', 'Ligustervænget 32', '45', '3', NULL)

INSERT INTO Reserveret(rRId, rLNr, dStart, dSlut) VALUES 
('23', '1', '05-05-2022 12:00', '05-06-2022 12:00'),
('12', '2', '05-05-2022 12:00', '05-06-2022 12:00')

SELECT * FROM Lejekontrakt
SELECT * FROM Reserveret
SELECT * FROM Venteliste
SELECT * FROM Medlem
SELECT * FROM Lejekontrakt
SELECT * FROM Bolig


