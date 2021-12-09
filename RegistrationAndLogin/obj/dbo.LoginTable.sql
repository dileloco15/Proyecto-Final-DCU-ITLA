CREATE TABLE [dbo].[LoginTable] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
    [mail]     NVARCHAR (50) NULL,
    [phone]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

