SELECT * FROM Medlem
SELECT * FROM Lejekontrakt
SELECT * FROM BoligType

SELECT * FROM Bolig
SELECT mId AS 'Medlem ID',fNavn AS 'Fornavn',eNavn AS 'Efternavn',tlf AS 'Telefonnummer',email AS 'Email',lNr AS 'Løbenummer' FROM Medlem
SELECT loebeNr AS 'Løbenummer', adr AS 'Adresse', navn AS 'Bolig', indflytter AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Medlem, Lejekontrakt, Bolig, BoligType WHERE loebeNr = lNr AND id = bType AND loebenummer = lNr


INSERT INTO Lejekontrakt (indflytter) VALUES ('02-07-2022')

SELECT TOP 1 * FROM Lejekontrakt ORDER BY loebeNr DESC

UPDATE Medlem SET lNr = 2 /*lNr skal gemmes gennem ovenstående query*/ WHERE mId = 3 /*mId skal gemmes med User-Input*/

UPDATE Bolig SET loebenummer = 2 WHERE bId = 6

DELETE FROM Venteliste WHERE medlemId = 3 /*også user-input*/

