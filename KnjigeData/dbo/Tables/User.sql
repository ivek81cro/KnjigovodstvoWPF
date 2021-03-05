CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Oib] NVARCHAR(11) NOT NULL, 
    [Naziv] NVARCHAR(50) NOT NULL, 
    [Ulica] NVARCHAR(50) NOT NULL, 
    [Broj] NVARCHAR(50) NOT NULL, 
    [Posta] NVARCHAR(50) NOT NULL, 
    [Mjesto] NVARCHAR(50) NOT NULL, 
    [Telefon] NVARCHAR(50) NOT NULL, 
    [Fax] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Iban] NVARCHAR(50) NOT NULL, 
    [VrstaDjelatnosti] NVARCHAR(50) NOT NULL, 
    [SifraDjelatnosti] NVARCHAR(5) NOT NULL, 
    [NazivDjelatnosti] NVARCHAR(70) NOT NULL, 
    [Mbo] NVARCHAR(8) NULL
)
