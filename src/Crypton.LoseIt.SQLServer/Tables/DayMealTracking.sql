CREATE TABLE [dbo].[DayMealTracking]
(
	[Id] uniqueidentifier NOT NULL PRIMARY KEY default newid(), 
    [DayTrackingId] UNIQUEIDENTIFIER NOT NULL, 
    [DayMealClassId] NVARCHAR(255) NULL,

)
