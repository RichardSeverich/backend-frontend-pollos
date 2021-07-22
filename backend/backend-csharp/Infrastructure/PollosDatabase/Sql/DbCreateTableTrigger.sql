--#########################################################################################################################
-- Create TRIGGERS
--#########################################################################################################################

-- Trigger for update users
CREATE TRIGGER triggerUpdateDateUser 
ON dbo.users AFTER UPDATE 
AS
   UPDATE dbo.users 
   SET UpdateDate = CURRENT_TIMESTAMP 
   FROM Inserted i 
   WHERE dbo.users.Id = i.Id; Go


-- Trigger for update products
CREATE TRIGGER triggerUpdateDateProduct 
ON dbo.products AFTER UPDATE 
AS
   UPDATE dbo.products 
   SET UpdateDate = CURRENT_TIMESTAMP 
   FROM Inserted i 
   WHERE dbo.products.Id = i.Id; Go


-- Trigger for update clients
CREATE TRIGGER triggerUpdateDateClient 
ON dbo.clients AFTER UPDATE 
AS
   UPDATE dbo.clients 
   SET UpdateDate = CURRENT_TIMESTAMP 
   FROM Inserted i 
   WHERE dbo.clients.Id = i.Id;
