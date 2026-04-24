CREATE DATABASE RestaurantMenuDB;

USE RestaurantMenuDB;

CREATE TABLE MenuItems (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Category NVARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);

INSERT INTO MenuItems (Name, Description, Category, Price) VALUES
('Spring Rolls', 'Crispy vegetable rolls served with sweet chili sauce', 'Appetizers', 350),
('Chicken Wings', 'Spicy grilled wings with garlic dip', 'Appetizers', 550),
('Garlic Bread', 'Toasted bread with garlic butter and herbs', 'Appetizers', 250),
('Chicken Biryani', 'Aromatic basmati rice with spiced chicken', 'Main Course', 850),
('Beef Steak', 'Grilled beef steak with mashed potatoes', 'Main Course', 1500),
('Pasta Alfredo', 'Creamy white sauce pasta with mushrooms', 'Main Course', 750),
('Grilled Fish', 'Herb marinated grilled fish with vegetables', 'Main Course', 950),
('Chocolate Lava Cake', 'Warm chocolate cake with molten center', 'Desserts', 450),
('Mango Cheesecake', 'Creamy cheesecake with fresh mango topping', 'Desserts', 400),
('Ice Cream Sundae', 'Three scoops with chocolate sauce and nuts', 'Desserts', 350);

SELECT * FROM MenuItems;

Select * from MenuItems where Category = 'Appetizers';