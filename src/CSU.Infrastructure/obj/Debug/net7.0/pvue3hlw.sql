IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [News] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [State] int NOT NULL,
    [ScheduledDate] datetime2 NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NOT NULL,
    [ModifiedDate] datetime2 NOT NULL,
    [ModifiedBy] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_News] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231112200128_InitialMigrations', N'7.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Image] (
    [Id] uniqueidentifier NOT NULL,
    [ImageData] varbinary(max) NOT NULL,
    [NewsId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Image] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Image_News_NewsId] FOREIGN KEY ([NewsId]) REFERENCES [News] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Image_NewsId] ON [Image] ([NewsId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231113151548_ImageMigration', N'7.0.13');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Image] DROP CONSTRAINT [FK_Image_News_NewsId];
GO

ALTER TABLE [Image] DROP CONSTRAINT [PK_Image];
GO

EXEC sp_rename N'[Image]', N'Images';
GO

EXEC sp_rename N'[Images].[IX_Image_NewsId]', N'IX_Images_NewsId', N'INDEX';
GO

ALTER TABLE [Images] ADD CONSTRAINT [PK_Images] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Images] ADD CONSTRAINT [FK_Images_News_NewsId] FOREIGN KEY ([NewsId]) REFERENCES [News] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231113215421_ImageMigrations', N'7.0.13');
GO

COMMIT;
GO

