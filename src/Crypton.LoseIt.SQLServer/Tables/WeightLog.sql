CREATE TABLE [dbo].[WeightLog]
(
	[Id] uniqueidentifier PRIMARY KEY default newid(),
	[UserId] uniqueidentifier NOT NULL, 


    [DateCreated] DATETIMEOFFSET NOT NULL, 
    [Measurement] FLOAT NOT NULL, 
    CONSTRAINT [FK_WeightLog_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]) ON DELETE CASCADE
)
