ALTER VIEW Lejlighed AS
SELECT opskrevet, fNavn, eNavn, medlemId
FROM Venteliste, Medlem
WHERE boligType = 1 AND medlemId = mId


SELECT * FROM Lejlighed ORDER BY opskrevet ASC

CREATE VIEW Ungdomsbolig AS
SELECT opskrevet, fNavn, eNavn, medlemId
FROM Venteliste, Medlem
WHERE boligType = 2 AND medlemId = mId

CREATE VIEW Seniorbolig AS
SELECT opskrevet, fNavn, eNavn, medlemId
FROM Venteliste, Medlem
WHERE boligType = 3 AND medlemId = mId