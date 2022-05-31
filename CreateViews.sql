ALTER VIEW Lejlighed AS
SELECT vDato, fNavn, eNavn, vMId
FROM Venteliste, Medlem
WHERE vTId = 1 AND vMId = mId

ALTER VIEW Ungdomsbolig AS
SELECT vDato, fNavn, eNavn, vMId
FROM Venteliste, Medlem
WHERE vTId = 2 AND vMId = mId

ALTER VIEW Seniorbolig AS
SELECT vDato, fNavn, eNavn, vMId
FROM Venteliste, Medlem
WHERE vTId = 3 AND vMId = mId

SELECT vDato AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', vMId AS 'ID' FROM Lejlighed ORDER BY vDato ASC

SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Lejlighed ORDER BY vDato ASC

SELECT email FROM Medlem WHERE mLNr IS NOT NULL