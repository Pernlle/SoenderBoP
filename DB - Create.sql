/*Lejekontrakt forbinder Medlem og Bolig, den bliver kaldet i begge tabeller, men kalder ikke nogle af tabellerne*/
/*SQL tager ikke h�jde for hvorn�r lejer underskriver kontrakt og kommer af venteliste, kun hvorn�r lejer indflytter*/
CREATE TABLE Lejekontrakt(
	lNr INT IDENTITY (1,1) PRIMARY KEY,
	lDato VARCHAR(10),
);

/*BoligType bliver fastsat s� bruger ikke laver stavefejl i forbindelse med registrering. Kan evt. v�lges gennem dropdown menu*/
CREATE TABLE BoligType(
	id INT PRIMARY KEY NOT NULL,
	navn VARCHAR(12)
);

INSERT INTO BoligType(id, navn) VALUES 
('1','Lejlighed'),
('2','Ungdomsbolig'),
('3','Seniorbolig')

/*PK skrives med Identity for at undg� dubletter i systemet. Bolig har FK l�beNr. og bolig type. L�beNr. kan v�re NULL.*/

CREATE TABLE Bolig(
	bId INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	mndPris INT,
	adr VARCHAR(60),
	kvm INT,
	bType INT FOREIGN KEY REFERENCES BoligType(id),
	bLNr INT FOREIGN KEY REFERENCES Lejekontrakt(lNr)
);

/*FM - L�beNr fra Lejekontrakt - Kan v�re NULL uden lejekontrakt.
Venteliste refereres ikke, da ventelisten ikke skal have et id,
r�kkef�lgen bliver bestemt efter dato opskrevet + Boligtype, 
s� at Databasen ikke skal �ndre ID for hver enkelt Medlem, hver gang et Medlem rykker frem i r�kken*/

CREATE TABLE Medlem(
	mId INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	fNavn VARCHAR(50) NOT NULL,
	eNavn VARCHAR(50),
	tlf INT,
	email VARCHAR(50),
	mLNr INT FOREIGN KEY REFERENCES Lejekontrakt(lNr)
);

/*Ventelisten 'generer' i databasen en dato, i koden bestemmes venteliste nr. efter dato. */ 
/*Potentielle ufleksible elementer i SQL: Man kan ikke bestemme bolig og hvis man registreres samme dato f�r man samme nr.*/

CREATE TABLE Venteliste(
	vMid INT FOREIGN KEY REFERENCES Medlem(mId),
	boligType INT FOREIGN KEY REFERENCES BoligType(id),
	vDato VARCHAR(50),
);

CREATE TABLE Ressource(
	rId INT PRIMARY KEY NOT NULL,
	rType VARCHAR(13),
	rNr INT
);

CREATE TABLE Reserveret(
	rId INT FOREIGN KEY REFERENCES Ressource(rId),
	rLNr INT FOREIGN KEY REFERENCES Lejekontrakt(lNr),
	dStart VARCHAR(50),
	dSlut VARCHAR(50)
	/*
		Problemet med DATE skal fixes i c#. En string skal convertes til et DATE format. I will find out 
		Update: I found out. Stop med at bruge DATE. C# kan ikke h�ndtere dig :(
	*/
);

INSERT INTO Ressource (rId, rType, rNr) VALUES
('1','Festsal','1'),
('2','Festsal','2'),
('3','Festsal','3'),
('4','Festsal','4'),
('5','Festsal','5'),
('6','Festsal','6'),
('7','Festsal','7'),
('8','Festsal','8'),
('9','Festsal','9'),
('10','Festsal','10'),

('11','Parkering','1'),
('12','Parkering','2'),
('13','Parkering','3'),
('14','Parkering','4'),
('15','Parkering','5'),
('16','Parkering','6'),
('17','Parkering','7'),
('18','Parkering','8'),
('19','Parkering','9'),
('20','Parkering','10'),

('21','Vaskemaskine','1'),
('22','Vaskemaskine','2'),
('23','Vaskemaskine','3'),
('24','Vaskemaskine','4'),
('25','Vaskemaskine','5'),
('26','Vaskemaskine','6'),
('27','Vaskemaskine','7'),
('28','Vaskemaskine','8'),
('29','Vaskemaskine','9'),
('30','Vaskemaskine','10')
