INSERT INTO Lejekontrakt (loebeNr, indflytter) VALUES 
	(1, '2022-04-01')

INSERT INTO Medlem (fNavn, eNavn, tlf, email, loebeNr) VALUES
	('Seamus', 'Finnigan', '93337866', 'seamusfinnigan@gmail.com', NULL),
	('Petunia','Dursley', '32465067','petuniadursley@gmail.com', 1)

INSERT INTO Venteliste (mId, bType, opskrevet) VALUES 
(1, 1, '2022-02-01'),
(1, 2, '2022-02-01')

INSERT INTO Bolig (mndPris, adr, kvm, bType, loebeNr) VALUES 
('6000', 'Ligusterv�nget 4', '72', '1', NULL),
('4000', 'Ligusterv�nget 11', '50', '2', NULL),
('3000', 'Ligusterv�nget 3', '45', '3', '1'),
('6000', 'Ligusterv�nget 6', '72', '1', NULL),
('4000', 'Ligusterv�nget 13', '50', '2', NULL),
('3000', 'Ligusterv�nget 32', '45', '3', NULL)

INSERT INTO Reserveret(rId, loebeNr, dStart, dSlut) VALUES 
('1', '1', '2022-06-1', '2022-06-2')


SELECT * FROM Reserveret
SELECT * FROM Venteliste
SELECT * FROM Medlem
SELECT * FROM Lejekontrakt
SELECT * FROM Bolig


