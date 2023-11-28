-- Create database and tables of ImageMatch_Desktop Application
CREATE DATABASE IF NOT EXISTS ImageMatch_Desktop;
USE ImageMatch_Desktop;
CREATE TABLE IF NOT EXISTS Locations (
    LocationID INT AUTO_INCREMENT PRIMARY KEY,
    LocationName VARCHAR(255),
    Timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS JewelryItems (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Type VARCHAR(255),
    LocationID INT,
    Description TEXT,
    ImagePath VARCHAR(255),
    Timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)
);
CREATE USER IF NOT EXISTS 'imd_user'@'localhost' IDENTIFIED BY 'imd_user_pwd';
GRANT ALL PRIVILEGES ON ImageMatch_Desktop.* TO 'imd_user'@'localhost';
FLUSH PRIVILEGES;
