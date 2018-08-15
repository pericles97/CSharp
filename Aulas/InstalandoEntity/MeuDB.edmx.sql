
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/14/2018 22:19:39
-- Generated from EDMX file: C:\Users\1617156\Documents\CSharp\CSharp\Aulas\InstalandoEntity\MeuDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Cpf] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'EnderecoSet'
CREATE TABLE [dbo].[EnderecoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Logradouro] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL,
    [CEP] nvarchar(max)  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EnderecoSet'
ALTER TABLE [dbo].[EnderecoSet]
ADD CONSTRAINT [PK_EnderecoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'EnderecoSet'
ALTER TABLE [dbo].[EnderecoSet]
ADD CONSTRAINT [FK_ClienteEndereco]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteEndereco'
CREATE INDEX [IX_FK_ClienteEndereco]
ON [dbo].[EnderecoSet]
    ([ClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------