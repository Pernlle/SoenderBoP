SELECT * FROM Medlem
SELECT * FROM Lejekontrakt

INSERT INTO Lejekontrakt (indflytter) VALUES ('02-07-2022')

SELECT TOP 1 * FROM Lejekontrakt ORDER BY loebeNr DESC

UPDATE Medlem SET lNr = 2 /*lNr skal gemmes gennem ovenstående query*/ WHERE mId = 3 /*mId skal gemmes med User-Input*/

DELETE FROM Venteliste WHERE medlemId = 3 /*også user-input*/

