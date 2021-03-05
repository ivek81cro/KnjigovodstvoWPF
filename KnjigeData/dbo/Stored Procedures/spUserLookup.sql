CREATE PROCEDURE [dbo].[spUserLookup]
	@Id int
AS
BEGIN
SET NOCOUNT ON;

	SELECT Id, Oib, Naziv, Ulica, Broj, Posta, Mjesto, Telefon, Fax, Email, Iban, VrstaDjelatnosti, SifraDjelatnosti, NazivDjelatnosti, Mbo
	FROM [dbo].[User]
	WHERE Id=@Id;
END
