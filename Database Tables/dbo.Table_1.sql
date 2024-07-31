CREATE TABLE [dbo].[Reservation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ReservationID] NVARCHAR(50) NOT NULL, 
    [RoomId] NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Rooms, 
    [PaymentID] NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Payment, 
    [ReservationMade] DATE NULL, 
    [CheckInDate] DATE NOT NULL, 
    [CheckOutDate] DATE NOT NULL, 
    [TotalGuests] INT NOT NULL, 
    [Nights] INT NOT NULL, 
    [ReservationStatus] NVARCHAR(50) NOT NULL, 
    [Balance] DECIMAL(10, 2) NOT NULL, 
    [Notes] NVARCHAR(500) NOT NULL
)
