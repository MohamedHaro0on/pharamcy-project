CREATE TABLE [dbo].[MedicineStock_tb] (
    [medicineName] VARCHAR (50) NOT NULL,
    [buyingPrice]  INT          NOT NULL,
    [sellingPrice] INT          NOT NULL,
    [quantity]     INT          NOT NULL,
    [expireDate]   VARCHAR (50) NOT NULL,
    [company]      VARCHAR (50) NOT NULL,  
    CONSTRAINT [PK_MedicineStock_tb] PRIMARY KEY ([medicineName])
);

