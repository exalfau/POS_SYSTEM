WITH TransactionDetails AS (SELECT
                            t.id,
                            c.name AS customer_name,
                            st.name AS staff_name,
                            s.payment_type,
                            s.shipping_type,
                            t.date,
                            t.date_added,
                            t.date_updated,
                            LEFT(t.time, LEN(t.time) - 11) AS time,
                            t.information,
                            STRING_AGG(p.name, ', ') WITHIN GROUP (ORDER BY s.id) AS products_name,
                            STRING_AGG(CONVERT(VARCHAR(10), s.quantity), ', ') WITHIN GROUP (ORDER BY s.id) AS quantities,
                            STRING_AGG(CONVERT(VARCHAR(10), s.coli), ', ') WITHIN GROUP (ORDER BY s.id) AS coli,
                            STRING_AGG(CONVERT(VARCHAR(10), p.nett_price), ', ') WITHIN GROUP (ORDER BY s.id) AS nett_prices,
                            SUM(s.total_price) AS total_price
                            FROM [Transaction] t
                            JOIN Sales_Detail s ON s.id_transaction = t.id
                            JOIN Product p ON s.id_product = p.id
                            JOIN Customer c ON s.id_customer = c.id
                            JOIN Staff st ON s.id_staff = st.id
                            WHERE t.type = 'sale'
                            GROUP BY t.id,c.name, st.name, s.payment_type, s.shipping_type, t.date, t.date_added, t.date_updated, t.time, t.information
                        )
                        SELECT
                            id,
                            customer_name,
                            products_name,
                            staff_name,
                            quantities,
                            coli,
                            nett_prices,
                            total_price,
                            payment_type,
                            shipping_type,
                            date,
                            time,
                            information,
                            date_added,
                            date_updated 
                        FROM TransactionDetails;

SELECT t.id, s.name AS supplier_name, t.date, t.time,  
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
    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), p.nett_price)
           FROM Stock_In si
           JOIN Product p ON si.id_product = p.id
           WHERE si.id_transaction = t.id
           FOR XML PATH('')), 1, 2, '') AS nett_prices,
    SUM(si.total_price) AS total_price, t.information
FROM [Transaction] t 
JOIN Supplier s ON t.ID_supplier = s.id 
JOIN Stock_In si ON si.id_transaction = t.id
JOIN Product p ON si.id_product = p.id 
WHERE t.type = 'purchase' 
GROUP BY t.id, s.name, t.date, t.time, t.information ORDER BY id desc;
SELECT id, name FROM product WHERE id_supplier = 2