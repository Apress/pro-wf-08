USE [ProWorkflow]
GO
/*
reset account table
*/
DELETE FROM [account]
GO
INSERT INTO [account]
([accountId],[description],[balance])
VALUES(1001, 'account 1', 100.00)
GO
INSERT INTO [account]
([accountId],[description],[balance])
VALUES(2002, 'account 2', 100.00)
GO
INSERT INTO [account]
([accountId],[description],[balance])
VALUES(9000, 'company account', 1000.00)
GO
/*
reset itemInventory table
*/
DELETE FROM [itemInventory]
GO
INSERT INTO [itemInventory]
([itemId],[description],[qtyOnHand])
VALUES(51,'hammer', 10)
GO
INSERT INTO [itemInventory]
([itemId],[description],[qtyOnHand])
VALUES(52,'shop vac', 2)
GO
INSERT INTO [itemInventory]
([itemId],[description],[qtyOnHand])
VALUES(53,'extension ladder', 5)
GO
/*
reset orderDetail table
*/
DELETE FROM [orderDetail]
GO

