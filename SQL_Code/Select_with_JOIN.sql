SELECT * FROM Attachment;
SELECT * FROM Firearm WHERE Id = 7;
SELECT * FROM SniperRifle WHERE Id = 7;
SELECT * FROM SniperRifle ;
SELECT * FROM Firearm ;
SELECT * FROM SniperRifle
INNER JOIN Firearm 
ON Firearm.Id = SniperRifle.Id ;