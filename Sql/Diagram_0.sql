/*
   segunda-feira, 25 de setembro de 201722:42:43
   Usuário: 
   Servidor: .\
   Banco de Dados: Lancamentos
   Aplicativo: 
*/

/* Para impedir possíveis problemas de perda de dados, analise este script detalhadamente antes de executá-lo fora do contexto do designer de banco de dados.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.estabelecimento SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.estabelecimento', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.estabelecimento', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.estabelecimento', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.venda_consolidada
	(
	id_lancamento int NOT NULL IDENTITY (1, 1),
	id_estabelecimento int NOT NULL,
	data_movimento date NOT NULL,
	valor_mercearia decimal(15, 2) NOT NULL,
	valor_acougue decimal(15, 2) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.venda_consolidada ADD CONSTRAINT
	PK_venda_consolidada PRIMARY KEY CLUSTERED 
	(
	id_lancamento
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.venda_consolidada ADD CONSTRAINT
	FK_venda_consolidada_estabelecimento FOREIGN KEY
	(
	id_estabelecimento
	) REFERENCES dbo.estabelecimento
	(
	id_estabelecimento
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.venda_consolidada SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.venda_consolidada', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.venda_consolidada', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.venda_consolidada', 'Object', 'CONTROL') as Contr_Per 