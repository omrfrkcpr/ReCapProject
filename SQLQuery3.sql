CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)

CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)


INSERT INTO Cars(ID,BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','1','2019','320000','Dizel'),
	('2','1','2','2020','280000','Manuel'),
	('3','2','3','2018','300000','Otomatik'),
	('4','2','4','2015','400000','Benzinli'),
	('5','3','5','2017','200000','Yarı Otomatik');

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Kırmızı');

INSERT INTO Brands(BrandName)
VALUES
	('BMW'),
	('MERCEDES'),
	('AUDI');