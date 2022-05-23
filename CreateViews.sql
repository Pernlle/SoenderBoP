ALTER VIEW Lejlighed AS
SELECT vDato, fNavn, eNavn, mId
FROM Venteliste, Medlem
WHERE boligType = 1 AND vMid = mId


SELECT * FROM Lejlighed ORDER BY opskrevet ASC

ALTER VIEW Ungdomsbolig AS
SELECT vDato, fNavn, eNavn, mId
FROM Venteliste, Medlem
WHERE boligType = 2 AND vMid = mId

ALTER VIEW Seniorbolig AS
SELECT vDato, fNavn, eNavn, mId
FROM Venteliste, Medlem
WHERE boligType = 3 AND vMid = mId