DROP TABLE IF EXISTS FinePayment;
DROP TABLE IF EXISTS document_returns;
DROP TABLE IF EXISTS document_loans;
DROP TABLE IF EXISTS Document;
DROP TABLE IF EXISTS Author;
DROP TABLE IF EXISTS Genre;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS User_Role;
DROP TABLE IF EXISTS Regulation;

-- Tạo lại cơ sở dữ liệu
CREATE DATABASE LibraryManagementDatabase;
DROP DATABASE LibraryManagementDatabase
use master
USE LibraryManagementDatabase;

-- Bảng Quy định (Regulation)
CREATE TABLE Regulation (
    RegulationID INT PRIMARY KEY,
    Description NVARCHAR(100),
    MaxBorrowDays INT,
    FinePerDay DECIMAL(10,2),
    MaxBooksAllowed INT
);



-- Bảng Vai trò người dùng (User_Role)
CREATE TABLE User_Role (
    userType_id INT PRIMARY KEY ,
    userType_name VARCHAR(50),
    description NVARCHAR(MAX)
);

-- Bảng Người dùng (User)
CREATE TABLE Users(
    user_id INT PRIMARY KEY,
    user_name VARCHAR(50) NOT NULL,
    user_birth DATE,
    user_Role INT ,
    user_country VARCHAR(50),
    user_username VARCHAR(50),
    user_password VARCHAR(50),
    user_email VARCHAR(50),
    user_createdAt DATE,
    user_phone VARCHAR(20),
    user_avatar NVARCHAR(MAX),
	FOREIGN KEY (user_Role) REFERENCES User_Role(userType_id)
);
ALTER TABLE Users 
ADD CONSTRAINT user_phone_check 
CHECK (user_phone LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]');

ALTER TABLE Users
ADD CONSTRAINT user_email_check
CHECK (user_email LIKE '%gmail.com'OR user_email LIKE '%email.com')



-- Bảng Tác giả (Author)
CREATE TABLE Author (
    Author_id INT PRIMARY KEY NOT NULL,
    Author_name VARCHAR(50),
    
    Author_place_of_birth DATE,
	Author_date_created_at DATE,
	Author_place VARCHAR(50)

);



-- Bảng Thể loại (Genre)
CREATE TABLE Genre (
    Genre_id INT PRIMARY KEY NOT NULL,
    Genre_name nVARCHAR(100),
    Genre_description NVARCHAR(MAX)
);


CREATE TABLE DocumentType (
    TypeId INT PRIMARY KEY ,  -- Khóa chính, tự tăng
    TypeName NVARCHAR(MAX) NOT NULL,        -- Tên loại tài liệu (Sách, Tạp chí, Báo, ...)
    description NVARCHAR(MAX)                        -- Mô tả loại tài liệu
);
SELECT * FROM DocumentType
DROP TABLE DocumentType
ALTER table DocumentType ALTER Column description NVARCHAR(MAX)
--Bang tai lieu
CREATE TABLE Document (
    document_id INT PRIMARY KEY NOT NULL,
    Publication_Year DATE,
    Title NVARCHAR(100),
    Language NVARCHAR(100),
    quantity INT,
    price money,
    author_id INT NOT NULL,
    document_page INT,
    genre_id INT NOT NULL,
	DocumentType_id INT,
    FOREIGN KEY (author_id) REFERENCES Author(Author_id),
    FOREIGN KEY (genre_id) REFERENCES Genre(Genre_id),
	document_image NVARCHAR(MAX)
	
);

--them khoa ngoai cho DocumentType_id
ALTER TABLE Document  
ADD CONSTRAINT Document_type_id_FK 
FOREIGN KEY (DocumentType_id) REFERENCES DocumentType(TypeId);


--Them cot anh vao document
ALTER TABLE document add  document_image NVARCHAR(MAX)

SELECT * FROM Document
--Bang muon tai lieu
CREATE TABLE document_loans (
    loan_id INT PRIMARY KEY NOT NULL,
    document_id INT NOT NULL,
    user_id INT NOT NULL,
    loan_from DATE,
    loan_status VARCHAR(50),
    loan_to DATE,
    loan_created DATE,
    status VARCHAR(50),
    FOREIGN KEY (document_id) REFERENCES Document(document_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);
-- Bảng tra tài liệu (document_returns)
CREATE TABLE Document_returns (
    return_id INT PRIMARY KEY NOT NULL,
    loan_id INT,
    return_created DATE,
    return_date DATE,
    status VARCHAR(50),
    FOREIGN KEY (loan_id) REFERENCES Document_loans(loan_id) on DELETE  CASCADE
);

-- Bảng Thanh toán tiền phạt (FinePayment)
CREATE TABLE FinePayment (
    PaymentID INT PRIMARY KEY,
    
    Amount DECIMAL(10,2),
    PaymentDate DATE,
    Status VARCHAR(50),
    UserID INT,
    return_id INT,
    
    FOREIGN KEY (UserID) REFERENCES USERS(user_id),
    FOREIGN KEY (return_id) REFERENCES Document_returns(return_id) ON DELETE CASCADE
);