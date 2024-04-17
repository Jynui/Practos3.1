INSERT INTO Orders ( order_date, total_amount) VALUES
('2024-04-10', 150.00),
('2024-04-11', 200.00),
('2024-04-11', 120.00);

-- Добавление данных в таблицу Товары
INSERT INTO Products ( product_name, price, stock_quantity) VALUES
( 'Футболка', 25.00, 50),
( 'Джинсы', 40.00, 30),
( 'Кроссовки', 60.00, 20),
( 'Рубашка', 30.00, 40);

-- Добавление данных в таблицу Доставка
INSERT INTO Delivery ( orders_id, delivery_status, estimated_delivery_date) VALUES
( 1, 'в пути', '2024-04-12'),
( 1, 'в обработке', '2024-04-11'),
( 1, 'доставлено', '2024-04-13');

-- Добавление данных в промежуточную таблицу Order_Products

INSERT INTO Order_Products (order_id,products_id, quantity) VALUES
(1, 1, 2),
(1, 1, 1),
(1, 1, 3),
(1, 1, 2),
(1, 1, 1);
