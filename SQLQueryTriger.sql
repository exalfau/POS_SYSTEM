CREATE TRIGGER UpdateProductQuantity
ON [Transaction]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(confirm)
    BEGIN
        UPDATE Product
        SET quantity_in = quantity_in + si.quantity
        FROM Product
        INNER JOIN Stock_In si ON Product.id = si.id_product
        INNER JOIN inserted i ON si.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_in';
    END
END;


CREATE TRIGGER UpdateProductColi
ON [Transaction]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(confirm)
    BEGIN
        UPDATE Product
        SET coli_in = coli_in + si.coli
        FROM Product
        INNER JOIN Stock_In si ON Product.id = si.id_product
        INNER JOIN inserted i ON si.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_in';
    END
END;

CREATE TRIGGER SubtractProductQuantity
ON [Transaction]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(confirm)
    BEGIN
        UPDATE Product
        SET quantity_out = quantity_out + so.quantity
        FROM Product
        INNER JOIN Stock_Out so ON Product.id = so.id_product
        INNER JOIN inserted i ON so.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_out';
    END
END;


CREATE TRIGGER SubtractProductColi
ON [Transaction]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(confirm)
    BEGIN
        UPDATE Product
        SET coli_out = coli_out + so.coli
        FROM Product
        INNER JOIN Stock_Out so ON Product.id = so.id_product
        INNER JOIN inserted i ON so.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_out';
    END
END;

CREATE TRIGGER DeleteProductColi
ON [Stock_In]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.coli_in = p.coli_in - d.coli
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'stock_in';
END;

CREATE TRIGGER DeleteProductQuantity
ON [Stock_In]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.quantity_in = p.quantity_in - d.quantity
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'stock_in';
END;

CREATE TRIGGER SubDelProductColi
ON [Stock_Out]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.coli_out = p.coli_out - d.coli
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'stock_out';
END;
DROP TRIGGER SubDelProductColi
SELECT * FROM [Transaction]
SELECT * FROM Stock_In
SELECT t.id, so.id as SOID, t.confirm, s.name, t.date, t.time, p.name, so.quantity, so.coli, so.price, 
                            so.total_price, so.cause, t.information
                            FROM [Transaction] t 
                            JOIN Stock_Out so ON so.id_transaction = t.id
                            JOIN Supplier s ON so.id_supplier = s.id 
                            JOIN Product p ON so.id_product = p.id 
CREATE TRIGGER SubDelProductQuantity
ON [Stock_Out]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.quantity_out = p.quantity_out - d.quantity
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'stock_out';
END;

SELECT * FROM Product
UPDATE Product SET coli_in = 0 WHERE id = 1
SELECT t.id, s.name as supplier_name, t.date, t.time,  
                    STUFF((SELECT ', ' + p.name
                           FROM Stock_In si
                           JOIN Product p ON si.id_product = p.id
                           WHERE si.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS products_name,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), si.quantity)
                           FROM Stock_In si
                           WHERE si.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS quantities,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), si.coli)
                           FROM Stock_In si
                           WHERE si.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS coli,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), si.price)
                           FROM Stock_In si
                           WHERE si.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS prices,
                    SUM(si.total_price) AS total_price, t.information
                FROM [Transaction] t 
                JOIN Stock_In si ON si.id_transaction = t.id
                JOIN Supplier s ON si.id_supplier = s.id 
                JOIN Product p ON si.id_product = p.id 
                GROUP BY t.id, s.name, t.date, t.time, t.information ORDER BY id desc

SELECT * FROM Product
UPDATE Product SET coli_out = 0 WHERE id = 2

SELECT cd.id, c.name, cd.date, cd.type, s.invoice_id, cd.amount, cd.total, cd.information
                            FROM Customer_Deposit cd 
                            JOIN Customer c ON cd.id_customer = c.id
                            JOIN Sales_Detail s ON cd.id_sales = s.id 

CREATE TRIGGER UpdateTotal
ON [dbo].[Customer_Deposit]
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_customer INT;

    -- Get the id_customer from the inserted records
    SELECT @id_customer = id_customer FROM inserted;

    -- Update the total column for the specific id_customer
    UPDATE [dbo].[Customer_Deposit]
    SET total = (SELECT SUM(amount) FROM [dbo].[Customer_Deposit] WHERE id_customer = @id_customer)
    WHERE id_customer = @id_customer;
END;

CREATE TRIGGER DeleteTotal
ON [dbo].[Customer_Deposit]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_customer INT;

    -- Get the id_customer from the deleted records
    SELECT @id_customer = id_customer FROM deleted;

    -- Update the total column for the specific id_customer
    UPDATE [dbo].[Customer_Deposit]
    SET total = (SELECT SUM(amount) FROM [dbo].[Customer_Deposit] WHERE id_customer = @id_customer)
    WHERE id_customer = @id_customer;
END;


DROP TRIGGER DeleteTotalDeposit
DROP TABLE Customer_Deposit

CREATE TRIGGER InsertTotalDeposit
ON [dbo].[Customer_Deposit]
AFTER INSERT
AS
BEGIN
    UPDATE cd
    SET cd.total = ISNULL(cd.amount, 0) + ISNULL((SELECT TOP 1 cd_prev.total
                                                  FROM inserted i
                                                  JOIN [dbo].[Customer_Deposit] cd_prev ON i.id_customer = cd_prev.id_customer AND i.id > cd_prev.id
                                                  ORDER BY cd_prev.id DESC), 0)
    FROM [dbo].[Customer_Deposit] cd
    JOIN inserted i ON cd.id = i.id;
END;

CREATE TRIGGER DeleteTotalDeposit
ON [dbo].[Customer_Deposit]
AFTER DELETE
AS
BEGIN
    DECLARE @DeletedAmount DECIMAL(10, 2);

    -- Get the sum of the deleted amounts
    SELECT @DeletedAmount = SUM(amount)
    FROM deleted;
       -- Update the totals by subtracting the deleted amount
    UPDATE cd
    SET cd.total = cd.total - @DeletedAmount
    FROM [dbo].[Customer_Deposit] cd
    JOIN deleted d ON cd.id_customer = d.id_customer AND cd.id > d.id;
END;

-- Trigger for UPDATE
CREATE TRIGGER UpdateTotalDeposit
ON [dbo].[Customer_Deposit]
AFTER UPDATE
AS
BEGIN
    DECLARE @UpdatedAmount DECIMAL(10, 2);

    -- Get the sum of the updated amounts
    SELECT @UpdatedAmount = ISNULL(SUM(amount), 0)
    FROM inserted;

    -- Update the total for the updated row
    UPDATE cd
    SET cd.total = cd.total + @UpdatedAmount - ISNULL(d.amount, 0)
    FROM [dbo].[Customer_Deposit] cd
    JOIN inserted i ON cd.id_customer = i.id_customer AND cd.id = i.id
    LEFT JOIN deleted d ON cd.id_customer = d.id_customer AND cd.id = d.id;

    -- Update subsequent rows
    UPDATE cd
    SET cd.total = cd.total + @UpdatedAmount
    FROM [dbo].[Customer_Deposit] cd
    JOIN inserted i ON cd.id_customer = i.id_customer
    WHERE cd.id > i.id;
END;

SELECT t.confirm, t.id, sd.invoice_id, c.name, s.name, t.date, t.time,  
                    STUFF((SELECT ', ' + p.name 
                           FROM Sales_Detail sd
                           JOIN Product p ON sd.id_product = p.id
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS products_name,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), sd.quantity)
                           FROM Sales_Detail sd
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS quantities,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), sd.coli)
                           FROM Sales_Detail sd
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS coli,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), sd.price)
                           FROM Sales_Detail sd
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS prices,
                    SUM(sd.total_price) AS total_price, t.information
                FROM [Transaction] t 
                JOIN Sales_Detail sd ON sd.id_transaction = t.id
                JOIN Customer c ON sd.id_customer = c.id 
                JOIN Staff s ON sd.id_staff = s.id 
                JOIN Product p ON sd.id_product = p.id 
                GROUP BY t.confirm, t.id, sd.invoice_id, c.name, s.name, t.date, t.time, t.information ORDER BY id desc