CREATE TABLE [dbo].[DayTracking]
(
	[Id] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
	[UserId] uniqueidentifier NOT NULL,
	[Day] date NOT NULL, 
    [CalorieGoal] FLOAT NULL
)
