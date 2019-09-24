CREATE TABLE [dbo].[User]
(
	[Id] uniqueidentifier NOT NULL PRIMARY KEY DEFAULT newid(),
	[Email] nvarchar(255) NOT NULL,
	[Password] nvarchar(300) NOT NULL,
	[FirstName] nvarchar(255) NULL,
	[LastName] nvarchar(255) NULL,
	[DateCreated] datetimeoffset NOT NULL DEFAULT getutcdate(),
	[DateModified] datetimeoffset NOT NULL DEFAULT getutcdate(),
	[Birthdate] date NULL,
	[Height] float NULL,		-- centimeters
	[TargetWeight] float NULL,	-- kilograms
    [Preferences] NVARCHAR(MAX) NOT NULL, -- json document
    [DailyGoal] FLOAT NULL)

GO

CREATE UNIQUE INDEX [IX_User_Email] ON [dbo].[User] ([Email])
