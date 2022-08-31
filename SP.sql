CREATE PROCEDURE CheckEmail
	@email VARCHAR(50)
AS
	IF EXISTS (SELECT * FROM Cliente WHERE Cliente.Email = @email)
		RETURN (SELECT Id FROM Cliente WHERE Cliente.Email = @email)
	ELSE
		RETURN 0
GO
CREATE PROCEDURE Registar
       @Nome VARCHAR(50), 
       @Data_Nascimento DATE, 
       @CC int,
	   @Email VARCHAR(50),
	   @Telefone int = NULL
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM Cliente WHERE Cliente.Email = @Email)
			DECLARE @Id int
			SET @Id = (SELECT COUNT(Id) FROM Cliente)+1
			INSERT INTO Pessoa VALUES (@Nome, @Data_Nascimento, @CC)
			INSERT INTO Cliente VALUES ( @Email,@Telefone,@CC,@Id)
			RETURN @Id
		RETURN 0
	END
GO
CREATE PROCEDURE CheckCC
       @CC int
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM Pessoa WHERE Pessoa.CC = @CC)
			RETURN 1
		RETURN 0
	END
GO
CREATE PROCEDURE Search
       @Origem VARCHAR(50), 
       @Destino VARCHAR(50)
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM Estacao WHERE Estacao.Nome = @Origem)
			RETURN 1
		ELSE IF NOT EXISTS (SELECT * FROM Estacao WHERE Estacao.Nome = @Destino)
			RETURN 2
		RETURN 3
	END
GO