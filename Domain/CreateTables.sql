USE VehicleMaintenance
CREATE TABLE dbo.Brand
(
	Id INT NOT NULL PRIMARY KEY, 
    Name VARCHAR(255) NOT NULL
);
CREATE TABLE dbo.MaintenanceOption
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(255) NOT NULL
)