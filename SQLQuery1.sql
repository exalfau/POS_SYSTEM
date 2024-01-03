SELECT * FROM privilege  [cashier z>,']D"_87]
SELECT * FROM Product WHERE name = 'cimory' AND id_supplier = (SELECT id FROM Supplier WHERE name = 'supplier 1')
SELECT * FROM Stock_In
SELECT id_product FROM Stock_In WHERE id_transaction = 45
SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 9 AND id_role = 1
SELECT * FROM product
DELETE Delivery WHERE id = 3
UPDATE [transaction] SET Confirm = 0 WHERE id = 82

SELECT * FROM Delivery

CREATE TABLE [dbo].[Account] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [id_staff]     INT           NOT NULL,
    [username]     VARCHAR (255) NOT NULL,
    [password]     VARCHAR (255) NOT NULL,
    [information]  VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_staff]) REFERENCES [dbo].[Staff] ([id])
);

CREATE TABLE [dbo].[Category] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [name]          VARCHAR (255) NOT NULL,
    [category_code] VARCHAR (255) NOT NULL,
    [information]   VARCHAR (255) NULL,
    [date_added]    DATETIME      DEFAULT (getdate()) NULL,
    [date_updated]  DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Courier] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [id_staff]      INT           NOT NULL,
    [license_plate] VARCHAR (255) NOT NULL,
    [information]   VARCHAR (255) NULL,
    [date_added]    DATETIME      DEFAULT (getdate()) NULL,
    [date_updated]  DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_staff]) REFERENCES [dbo].[Staff] ([id])
);

CREATE TABLE [dbo].[Customer] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [customer_id]  VARCHAR (255) NOT NULL,
    [name]         VARCHAR (255) NOT NULL,
    [image]        IMAGE         NULL,
    [join_date]    DATE          NOT NULL,
    [birth_date]   DATE          NOT NULL,
    [gender]       CHAR (1)      NOT NULL,
    [phone]        CHAR (15)     NOT NULL,
    [address]      VARCHAR (255) NOT NULL,
    [information]  VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CHECK ([gender]='M' OR [gender]='F')
);

CREATE TABLE [dbo].[Customer_Credit] (
    [id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_transaction]INT             NOT NULL,
    [id_customer]  INT             NOT NULL,
    [amount]       DECIMAL (10, 2) NOT NULL,
    [due]          DATE            NOT NULL,
    [date_paid]    DATE            NULL,
    [instalment]   INT             NOT NULL,
    [status]       CHAR (10)       NOT NULL,
    [information]  VARCHAR (255)   NULL,
    [date_added]   DATETIME        DEFAULT (getdate()) NULL,
    [date_updated] DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_transaction]) REFERENCES [dbo].[Transaction] ([id]),
    FOREIGN KEY ([id_customer]) REFERENCES [dbo].[Customer] ([id]),
    CHECK ([status] = 'pending'
           OR [status] = 'paid')
);
SELECT * FROM Customer_Credit
DROP TABLE Customer_Credit

CREATE TABLE [dbo].[Customer_Deposit] (
    [id]           INT             IDENTITY (1, 1) NOT NULL,
    [id_transaction]INT            NULL,
    [id_customer]  INT             NOT NULL,
    [date]         DATE            NOT NULL,
    [amount]       DECIMAL (10, 2) NOT NULL,
    [total]        DECIMAL (10, 2) NULL,
    [type]         CHAR (10)       NOT NULL,
    [information]  VARCHAR (255)   NULL,
    [date_added]   DATETIME        DEFAULT (getdate()) NULL,
    [date_updated] DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_transaction]) REFERENCES [dbo].[Transaction] ([id]),
    FOREIGN KEY ([id_customer]) REFERENCES [dbo].[Customer] ([id]),
    CHECK ([type]='deposit' OR [type]='payment')
);

SELECT * FROM [Customer_Deposit]
DELETE Customer_Deposit where id = 4
GO
CREATE TRIGGER InsertTotalDepositPayment
ON [dbo].[Customer_Deposit]
AFTER INSERT
AS
BEGIN
    UPDATE cd
    SET cd.total = 
        CASE 
            WHEN i.type = 'deposit' THEN ISNULL(cd.amount, 0) + ISNULL((
                SELECT TOP 1 cd_prev.total
                FROM inserted i
                JOIN [dbo].[Customer_Deposit] cd_prev ON i.id_customer = cd_prev.id_customer AND i.id > cd_prev.id
                WHERE i.type = 'deposit'
                ORDER BY cd_prev.id DESC
            ), 0)
            WHEN i.type = 'payment' THEN ISNULL(cd.amount, 0) - ISNULL((
                SELECT TOP 1 cd_prev.total
                FROM inserted i
                JOIN [dbo].[Customer_Deposit] cd_prev ON i.id_customer = cd_prev.id_customer AND i.id > cd_prev.id
                WHERE i.type = 'payment'
                ORDER BY cd_prev.id DESC
            ), 0)
            ELSE cd.total
        END
    FROM [dbo].[Customer_Deposit] cd
    JOIN inserted i ON cd.id = i.id
    WHERE i.type IN ('deposit', 'payment');
END;
CREATE TRIGGER InsertTotalDepositPayment
ON [dbo].[Customer_Deposit]
AFTER INSERT
AS
BEGIN
    UPDATE cd
    SET cd.total = 
        CASE 
            WHEN i.type = 'deposit' THEN ISNULL(cd.amount, 0) + ISNULL((
                SELECT TOP 1 cd_prev.total
                FROM inserted i
                JOIN [dbo].[Customer_Deposit] cd_prev ON i.id_customer = cd_prev.id_customer AND i.id > cd_prev.id
                WHERE i.type = 'deposit'
                ORDER BY cd_prev.id DESC
            ), 0)
            WHEN i.type = 'payment' THEN ISNULL((
                SELECT TOP 1 cd_prev.total
                FROM inserted i
                JOIN [dbo].[Customer_Deposit] cd_prev ON i.id_customer = cd_prev.id_customer AND i.id > cd_prev.id
                WHERE i.type = 'payment'
                ORDER BY cd_prev.id DESC
            ), 0) - ISNULL(cd.amount, 0)
            ELSE cd.total
        END
    FROM [dbo].[Customer_Deposit] cd
    JOIN inserted i ON cd.id = i.id
    WHERE i.type IN ('deposit', 'payment');
END;


DROP TRIGGER InsertTotalDepositPayment
CREATE TRIGGER DeleteTotalDepositPayment
ON [dbo].[Customer_Deposit]
AFTER DELETE
AS
BEGIN
    DECLARE @DeletedAmount DECIMAL(10, 2);

    SELECT @DeletedAmount = SUM(d.amount)
    FROM deleted d
    WHERE d.type IN ('deposit', 'payment');

    UPDATE cd
    SET cd.total = 
        CASE 
            WHEN d.type = 'deposit' THEN cd.total - @DeletedAmount
            WHEN d.type = 'payment' THEN cd.total + @DeletedAmount
            ELSE cd.total 
        END
    FROM [dbo].[Customer_Deposit] cd
    JOIN deleted d ON cd.id_customer = d.id_customer AND cd.id > d.id
    WHERE d.type IN ('deposit', 'payment');
END;

CREATE TABLE [dbo].[Delivery] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [id_transaction] INT            NULL,
    [id_customer]    INT             NOT NULL,
    [id_courier]     INT             NOT NULL,
    [address]        VARCHAR (255)   NOT NULL,
    [date_sent]      DATE            NULL,
    [time_sent]      TIME (7)        NULL,
    [date_delivered] DATE            NULL,
    [time_delivered] TIME (7)        NULL,
    [cost]           DECIMAL (10, 2) NULL,
    [status]         CHAR (10)       NOT NULL,
    [information]    VARCHAR (255)   NULL,
    [date_added]     DATETIME        DEFAULT (getdate()) NULL,
    [date_updated]   DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_transaction]) REFERENCES [dbo].[Transaction] ([id]),
    FOREIGN KEY ([id_customer]) REFERENCES [dbo].[Customer] ([id]),
    FOREIGN KEY ([id_courier]) REFERENCES [dbo].[Courier] ([id]),
    CHECK ([status]='on process' OR [status]='sent' OR [status]='delivered')
);
DROP TABLE Delivery
ALTER TABLE delivery COLUMN status

CREATE TABLE [dbo].[Feature] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [item]         VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO [Feature] (item)
VALUES ('Dashboard'),('Staff Group'),('Role'),('Staff List'),('Account'),('Courier'),
       ('Inventory Group'), ('Unit'), ('Category'), ('Product'), ('Stock In'), ('Stock Out'),
       ('Customer Group'), ('Customer List'), ('Loan'), ('Deposit'),('Supplier'),('Sale'),('Delivery'),('Finance')
       SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 19 AND id_role =1
CREATE TABLE [dbo].[Privilege] (
    [id]           INT      IDENTITY (1, 1) NOT NULL,
    [id_role]      INT      NOT NULL,
    [id_feature]   INT      NOT NULL,
    [view]         INT      NULL,
    [create]       INT      NULL,
    [update]       INT      NULL,
    [delete]       INT      NULL,
    [export]       INT      NULL,
    [import]       INT      NULL,
    [date_added]   DATETIME DEFAULT (getdate()) NULL,
    [date_updated] DATETIME DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_role]) REFERENCES [dbo].[Role] ([id]),
    FOREIGN KEY ([id_feature]) REFERENCES [dbo].[Feature] ([id])
);
SELECT * FROM Privilege
CREATE TABLE [dbo].[Product] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [id_unit]        INT             NOT NULL,
    [id_category]    INT             NOT NULL,
    [id_supplier]    INT             NOT NULL,
    [product_code]   VARCHAR (255)   NOT NULL,
    [name]           VARCHAR (255)   NOT NULL,
    [image]          IMAGE           NOT NULL,
    [quantity_in]    INT             NULL,
    [quantity_out]   INT             NULL,
    [quantity_total] INT             NULL,
    [coli_in]        INT             NULL,
    [coli_out]       INT             NULL,
    [coli_total]     INT             NULL,
    [nett_price]     DECIMAL (10, 2) NOT NULL,
    [margin]         INT             NOT NULL,
    [tax]            INT             NULL,
    [discount]       INT             NULL,
    [sell_price]     DECIMAL (10, 2) NULL,
    [information]    VARCHAR (255)   NULL,
    [date_added]     DATETIME        DEFAULT (getdate()) NULL,
    [date_updated]   DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_unit]) REFERENCES [dbo].[Unit] ([id]),
    FOREIGN KEY ([id_category]) REFERENCES [dbo].[Category] ([id]),
    FOREIGN KEY ([id_supplier]) REFERENCES [dbo].[Supplier] ([id])
);

ALTER TABLE [dbo].[Product]
ALTER COLUMN     [image]          IMAGE           NULL


GO
CREATE TRIGGER UpdateColiTotal
ON [dbo].[Product]
AFTER INSERT, UPDATE
AS
BEGIN
    IF UPDATE(coli_in) OR UPDATE(coli_out)
    BEGIN
        UPDATE p
        SET p.coli_total = ISNULL(i.coli_in, 0) - ISNULL(i.coli_out, 0)
        FROM [dbo].[Product] p
        INNER JOIN inserted i ON p.id = i.id
    END
END;
GO
CREATE TRIGGER UpdateQuantityTotal
ON [dbo].[Product]
AFTER INSERT, UPDATE
AS
BEGIN
    IF UPDATE(quantity_in) OR UPDATE(quantity_out)
    BEGIN
        UPDATE p
        SET p.quantity_total = ISNULL(i.quantity_in, 0) - ISNULL(i.quantity_out, 0)
        FROM [dbo].[Product] p
        INNER JOIN inserted i ON p.id = i.id
    END
END;

CREATE TABLE [dbo].[Role] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [name]         VARCHAR (255) NOT NULL,
    [code]         VARCHAR (10)   NOT NULL,
    [information]  VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Sales_Detail] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [id_transaction] INT             NOT NULL,
    [id_customer]    INT             NOT NULL,
    [id_staff]       INT             NOT NULL,
    [id_product]     INT             NOT NULL,
    [quantity]       INT             NULL,
    [coli]           INT             NULL,
    [price]          DECIMAL (10, 2) NULL,
    [total_price]    DECIMAL (10, 2) NULL,
    [date_added]     DATETIME        DEFAULT (getdate()) NULL,
    [date_updated]   DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_transaction]) REFERENCES [dbo].[Transaction] ([id]),
    FOREIGN KEY ([id_product]) REFERENCES [dbo].[Product] ([id]),
    FOREIGN KEY ([id_staff]) REFERENCES [dbo].[Staff] ([id]),
    FOREIGN KEY ([id_customer]) REFERENCES [dbo].[Customer] ([id]),
);

GO
CREATE TRIGGER UpdateProductQuantityOut
ON [dbo].[Sales_Detail]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Product]
    SET quantity_out = quantity_out + i.quantity
    FROM [dbo].[Product] AS p
    INNER JOIN [dbo].[Sales_Detail] AS sd ON p.id = sd.id_product
    INNER JOIN inserted AS i ON sd.id = i.id
    WHERE i.id_transaction IN (SELECT id FROM [dbo].[Transaction] WHERE [type] = 'sales');
END;

GO
CREATE TRIGGER DeleteProductQuantityOut
ON [dbo].[Sales_Detail]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[Product]
    SET quantity_out = p.quantity_out - d.quantity
    FROM [dbo].[Product] AS p
    INNER JOIN deleted AS d ON p.id = d.id_product;
END;
DROP TRIGGER DeleteProductQuantityOut


GO
CREATE TRIGGER DeleteProductDetailsSales
ON [Sales_Detail]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.quantity_out = p.quantity_out - d.quantity,
        p.coli_out = p.coli_out - d.coli
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'Sales';
END;

CREATE TABLE [dbo].[Staff] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [staff_id]     VARCHAR (255) NOT NULL,
    [id_role]      INT           NOT NULL,
    [name]         VARCHAR (255) NOT NULL,
    [image]        IMAGE         NULL,
    [join_date]    DATE          NOT NULL,
    [gender]       CHAR (1)      NOT NULL,
    [phone]        CHAR (15)     NOT NULL,
    [address]      VARCHAR (255) NOT NULL,
    [information]  VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_role]) REFERENCES [dbo].[Role] ([id]),
    CHECK ([gender]='M' OR [gender]='F')
);

CREATE TABLE [dbo].[Stock_In] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [id_transaction] INT             NOT NULL,
    [id_supplier]    INT             NOT NULL,
    [id_product]     INT             NOT NULL,
    [quantity]       INT             NULL,
    [coli]           INT             NULL,
    [price]          DECIMAL (10, 2) NULL,
    [total_price]    DECIMAL (10, 2) NULL,
    [date_added]     DATETIME        DEFAULT (getdate()) NULL,
    [date_updated]   DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_transaction]) REFERENCES [dbo].[Transaction] ([id]),
    FOREIGN KEY ([id_supplier]) REFERENCES [dbo].[Supplier] ([id]),
    FOREIGN KEY ([id_product]) REFERENCES [dbo].[Product] ([id])
);

SELECT c.id, s.name FROM Courier c JOIN Staff s ON c.id_staff = s.id
DROP TABLE Stock_In
SELECT* FROM Customer_deposit
delete Customer_deposit where id = 6
DBCC CHECKIDENT ('[Customer_deposit]', RESEED, 5)
SELECT * FROM product
update product set quantity_in = 0, coli_in = 0 where id = 3
GO
CREATE TRIGGER DeleteProductDetailsStockIn
ON [Stock_In]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.quantity_in = p.quantity_in - d.quantity,
        p.coli_in = p.coli_in - d.coli
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'stock_in';
END;

CREATE TABLE [dbo].[Stock_Out] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [id_transaction] INT             NOT NULL,
    [id_supplier]    INT             NOT NULL,
    [id_product]     INT             NOT NULL,
    [quantity]       INT             NULL,
    [coli]           INT             NULL,
    [price]          DECIMAL (10, 2) NULL,
    [total_price]    DECIMAL (10, 2) NULL,
    [cause]          VARCHAR (255)   NOT NULL,
    [date_added]     DATETIME        DEFAULT (getdate()) NULL,
    [date_updated]   DATETIME        DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([id_transaction]) REFERENCES [dbo].[Transaction] ([id]),
    FOREIGN KEY ([id_supplier]) REFERENCES [dbo].[Supplier] ([id]),
    FOREIGN KEY ([id_product]) REFERENCES [dbo].[Product] ([id])
);

GO
CREATE TRIGGER DeleteProductDetailsStockOut
ON [Stock_Out]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE p
    SET p.quantity_out = p.quantity_out - d.quantity,
        p.coli_out = p.coli_out - d.coli
    FROM Product p
    INNER JOIN deleted d ON p.id = d.id_product
    INNER JOIN [Transaction] t ON d.id_transaction = t.id
    WHERE t.confirm = 1 AND t.type = 'stock_out';
END;

CREATE TABLE [dbo].[Supplier] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [supplier_id]  VARCHAR (255) NOT NULL,
    [name]         VARCHAR (255) NOT NULL,
    [image]        IMAGE         NULL,
    [join_date]    DATE          NOT NULL,
    [phone]        CHAR (15)     NOT NULL,
    [address]      VARCHAR (255) NOT NULL,
    [information]  VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

SELECT 
    COALESCE(SUM(sd.total_price), 0) AS total_sales,
    COALESCE(SUM(cc.amount), 0) AS total_customer_credit
FROM 
    Sales_Detail sd
LEFT JOIN 
    [Transaction] t ON sd.id_transaction = t.id
LEFT JOIN 
    Customer_Credit cc ON t.id = cc.id_transaction
WHERE 
    (t.payment_type = 'cash' OR t.payment_type = 'deposit')
    OR (cc.status = 'paid')

CREATE TABLE [dbo].[Transaction] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [invoice_id]   VARCHAR (255)   NULL,
    [date]          DATE          NOT NULL,
    [time]          TIME (7)      NOT NULL,
    [image]         IMAGE         NULL,
    [type]          CHAR (10)     NOT NULL,
    [confirm]       INT           NOT NULL,
    [payment_type]  CHAR (10)     NULL,
    [shipping_type] CHAR (20)     NULL,
    [information]   VARCHAR (255) NULL,
    [date_added]    DATETIME      DEFAULT (getdate()) NULL,
    [date_updated]  DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CHECK ([payment_type]='cash' OR [payment_type]='credit 3x' OR [payment_type]='credit 6x' OR [payment_type]='credit 12x' OR [payment_type]='deposit'),
    CHECK ([shipping_type]='self-pickup' OR [shipping_type]='delivery'),
    CHECK ([type]='sales' OR [type]='stock_out' OR [type]='stock_in')
);


GO
CREATE TRIGGER UpdateProductDetailsStockIn
ON [Transaction]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(confirm)
    BEGIN
        UPDATE Product
        SET coli_in = coli_in + si.coli,
            quantity_in = quantity_in + si.quantity
        FROM Product
        INNER JOIN Stock_In si ON Product.id = si.id_product
        INNER JOIN inserted i ON si.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_in';
    END
END;

GO
CREATE TRIGGER UpdateProductDetailsStockOut
ON [Transaction]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(confirm)
    BEGIN
        UPDATE Product
        SET coli_out = coli_out + so.coli,
            quantity_out = quantity_out + so.quantity
        FROM Product
        INNER JOIN Stock_Out so ON Product.id = so.id_product
        INNER JOIN inserted i ON so.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_out';
    END
END;

CREATE TRIGGER UpdateProductDetailsInsert
ON [Transaction]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the inserted rows have 'confirm' set to 1
    IF (SELECT COUNT(*) FROM inserted WHERE confirm = 1) > 0
    BEGIN
        -- Update Product details
        UPDATE p
        SET p.coli_in = p.coli_in + si.coli,
            p.quantity_in = p.quantity_in + si.quantity
        FROM Product p
        INNER JOIN Stock_In si ON p.id = si.id_product
        INNER JOIN inserted i ON si.id_transaction = i.id
        WHERE i.confirm = 1 AND i.type = 'stock_in';
    END
END;


CREATE TABLE [dbo].[Unit] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [name]         VARCHAR (255) NOT NULL,
    [unit_code]    VARCHAR (255) NOT NULL,
    [information]  VARCHAR (255) NULL,
    [date_added]   DATETIME      DEFAULT (getdate()) NULL,
    [date_updated] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
