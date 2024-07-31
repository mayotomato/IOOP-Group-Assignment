CREATE TABLE [dbo].[Rooms] (
    [RoomId]               INT             IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [RoomNumber]       INT             NOT NULL,
    [Floor]            INT             NULL,
    [Amenities]        NVARCHAR (500)  NULL,
    [RatePerNight]     DECIMAL (10, 2) NULL,
    [Availability]     NVARCHAR (50)   NULL,
    [Condition]        NVARCHAR (50)   NULL,
    [LastCleanedDate]  DATE            NULL,
    [MaintenanceNotes] NVARCHAR (500)  NULL,
    PRIMARY KEY CLUSTERED ([RoomId] ASC)
);

