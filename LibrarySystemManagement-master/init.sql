use LibraryManagementDatabase;
SELECT * FROM Author
SELECT * FROM Genre
SELECT * FROM DocumentType
SELECT * FROM USERS
select * from Document
select * from document_loans
select * from Document_returns
INSERT INTO Author (Author_id, Author_name, Author_place_of_birth, Author_date_created_at, Author_place)
VALUES
(1, 'Anne Frank', '1929-06-12', '1942-07-06', 'Frankfurt, Germany'),
(2, 'Virginia Woolf', '1882-01-25', '1915-01-01', 'London, England'),
(3, 'Sylvia Plath', '1932-10-27', '1959-01-01', 'Boston, USA'),
(4, 'Jean Lucey Pratt', '1906-12-09', '1925-01-01', 'England'),
(5, 'Franz Kafka', '1883-07-03', '1912-01-01', 'Prague, Czech Republic'),
(6, 'Stephen King', '1947-09-21', '1974-01-01', 'Bangor, Maine, USA'),
(7, 'Charles Baudelaire', '1821-04-09', '1857-01-01', 'Paris, France'),
(8, 'Francis Carco', '1886-07-03', '1920-01-01', 'Paris, France'),
(9, 'Henry Crabb Robinson', '1775-05-13', '1800-01-01', 'London, England'),
(10, 'Ilya Ehrenburg', '1891-01-27', '1920-01-01', 'Moscow, Russia'),
(11, 'Nguyễn Đình Chu', '1877-01-01', '1896-09-17', 'Hà Nội, Việt Nam')
GO
DELETE FROM Genre
INSERT INTO Genre (Genre_id, Genre_name, Genre_description)
VALUES
(1,N'Nhật ký', N'Những ghi chép cá nhân, thường phản ánh cuộc sống hàng ngày và suy nghĩ của tác giả.'),
(2,N'Lịch sử', N'Thể loại viết về các sự kiện lịch sử, đặc biệt là những câu chuyện thực tế về những thời kỳ quan trọng.'),
(3,N'Tự truyện', N'Một thể loại văn học mô tả cuộc đời của tác giả, tập trung vào các sự kiện, suy nghĩ và cảm xúc cá nhân.'),
(4,N'Tiểu thuyết', N'Một thể loại văn học tập trung vào việc kể chuyện qua các nhân vật và sự kiện, thường phản ánh xã hội và con người trong các bối cảnh khác nhau.'),
(5,N'Thơ', N'Một thể loại văn học đặc trưng với hình thức ngắn gọn và nhấn mạnh vào cảm xúc, ngôn ngữ hình ảnh.'),
(6,N'Báo chí', N'Viết về các vấn đề xã hội, chính trị, và các sự kiện thời sự.'),
(7,N'Hồi ký', N'Tác phẩm tự thuật, ghi lại cuộc đời và những trải nghiệm cá nhân của tác giả, thường phản ánh những sự kiện lịch sử quan trọng.'),
(8,N'Truyện ngắn', N'Một thể loại văn học tập trung vào việc kể những câu chuyện ngắn, phản ánh những khoảnh khắc, tình huống trong đời sống con người.');


INSERT INTO DocumentType (TypeId, TypeName, description)
VALUES
(1, N'Sách', N'Một tác phẩm viết hoặc in bao gồm các trang được kết hợp lại với nhau, thường có bìa, bao gồm các tiểu thuyết, bài luận, và các tác phẩm dài khác.'),
(2, N'Sách điện tử', N'Một phiên bản kỹ thuật số của sách có thể đọc trên các thiết bị điện tử như máy đọc sách, máy tính và điện thoại thông minh.'),
(3, N'Sách nói', N'Một phiên bản của sách được ghi âm, thường do người đọc đọc lại, có thể nghe trên các thiết bị âm thanh.'),
(4, N'Tiểu thuyết đồ họa', N'Một cuốn sách kết hợp các yếu tố của tiểu thuyết và truyện tranh, thường có hình ảnh kèm theo văn bản viết.')

INSERT INTO User_Role
values ('1','ADMIN',N'Người quản trị hệ thống'),
 ('2','User',N'Người dùng hệ thống'),
 ('3','Staff',N'Nhân viên quản lý thư viện')

SET DATEFORMAT DMY
INSERT INTO Users(user_id,	user_name,	user_birth,	user_Role,	user_country,	user_username	,user_password,	user_email,	user_createdAt,	user_phone,	user_avatar)
values
--(1,N'Tran Trong Tan','19/06/2004',1,N'Việt Nam','tantt365','Tan2901345@','trantrongtan3000@gmail.com',GETDATE(),'0335181139','..\..\IMG\hinh1.jpg'),
--(2,N'Tran Thi Truc Mai',null,3,N'Việt Nam','mai118','mai179@',null,GETDATE(),null,'..\..\IMG\hinh1.jpg'),
(3, N'Nguyễn Văn An', '15/03/1990', 2, N'Việt Nam', 'an.nguyen90', 'AnPass123@', 'an.nguyen90@gmail.com', GETDATE(), '0901234567', '..\..\IMG\hinh1.jpg'),
(4, N'Trần Thị Bích Ngọc', '22/07/1992', 2, N'Việt Nam', 'bichngoc.tran92', 'NgocPass456@', 'bichngoc.tran92@gmail.com', GETDATE(), '0912345678', '..\..\IMG\hinh1.jpg'),
(5, N'Lê Hoàng Minh', '10/11/1985', 2, N'Việt Nam', 'hoangminh.le85', 'MinhPass789@', 'hoangminh.le85@gmail.com', GETDATE(), '0923456789', '..\..\IMG\hinh1.jpg'),
(6, N'Phạm Thị Hồng', '05/05/1995', 2, N'Việt Nam', 'hong.pham95', 'HongPass012@', 'hong.pham95@gmail.com', GETDATE(), '0934567890', '..\..\IMG\hinh1.jpg'),
(7, N'Hoàng Văn Tuấn', '30/09/1988', 2, N'Việt Nam', 'tuan.hoang88', 'TuanPass345@', 'tuan.hoang88@gmail.com', GETDATE(), '0945678901', '..\..\IMG\hinh1.jpg');

SET DATEFORMAT DMY
INSERT INTO Document (document_id, Publication_Year, Title, Language, quantity, price, author_id, document_page, genre_id, DocumentType_id, document_image)
VALUES
(1, '1947-06-25', N'Nhật ký Anne Frank', N'Tiếng Hà Lan', 10, 200000, 1, 283, 1, 1, null),
(2, '1952-06-01', N'Anne Frank: Diary of a Young Girl', N'Tiếng Anh', 8, 180000, 1, 304, 1, 1, null),
(3, '1989-10-01', N'Tales from the Secret Annex', N'Tiếng Anh', 6, 150000, 1, 164, 8, 1, null),
(4, '1956-10-01', N'The Diary of Anne Frank (Kịch bản)', N'Tiếng Anh', 5, 170000, 1, 256, 1, 1, null),
(5, '1991-09-12', N'Anne Frank Remembered', N'Tiếng Anh', 7, 190000, 1, 400, 2, 1, null);
-- Thêm tài liệu "The Waves"
INSERT INTO Document (document_id, Publication_Year, Title, Language, quantity, price, author_id, document_page, genre_id, DocumentType_id, document_image)
VALUES
(6 ,'1931-01-01', 'The Waves', 'English', 10, 25.99, 1, 300, 4, 1, null),
(7, '1929-01-01', 'A Room of One'+' '+'s Own', 'English', 15, 18.99, 2, 150, 3, 1, null),



(8, '1978-01-01', 'The Diary of Virginia Woolf', 'English', 20, 30.99, 2, 400, 7, 1, null),

(9, '1975-01-01', 'The Letters of Virginia Woolf', 'English', 12, 28.50, 2, 500, 7, 1, '..\..\IMG\hinh1.jpg'),


(10, '2001-01-01', 'Virginia Woolf', 'English', 8, 22.99, 2, 200, 6, 1, '..\..\IMG\hinh1.jpg')
-- Tài liệu "Mrs. Dalloway" - Sách điện tử nói
INSERT INTO Document (document_id, Publication_Year, Title, Language, quantity, price, author_id, document_page, genre_id, DocumentType_id, document_image)
VALUES
(11, '1925-01-01', 'Mrs. Dalloway', 'English', 50, 14.99, 2, 200, 4, 2, '..\..\IMG\hinh1.jpg');

-- Tài liệu "The Bell Jar" - Sách điện tử nói
INSERT INTO Document (document_id, Publication_Year, Title, Language, quantity, price, author_id, document_page, genre_id, DocumentType_id, document_image)
VALUES
(12, '1963-01-01', 'The Bell Jar', 'English', 50, 13.99, 3, 250, 4, 2, '..\..\IMG\hinh1.jpg');

-- Tài liệu "The Metamorphosis" - Sách điện tử nói
INSERT INTO Document (document_id, Publication_Year, Title, Language, quantity, price, author_id, document_page, genre_id, DocumentType_id, document_image)
VALUES
(13, '1915-01-01', 'The Metamorphosis', 'English', 60, 9.99, 5, 150, 4, 2, '..\..\IMG\hinh1.jpg');

-- Tài liệu "The Outsider" - Sách điện tử nói
INSERT INTO Document (document_id, Publication_Year, Title, Language, quantity, price, author_id, document_page, genre_id, DocumentType_id, document_image)
VALUES
(14, '1942-01-01', 'The Outsider', 'English', 40, 11.99, 6, 180, 4, 2, '..\..\IMG\hinh1.jpg');

-- Dòng 1
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (1, 1, 3, '2025-04-01', 'Pending', '2025-04-15', '2025-04-01', 'Active');

-- Dòng 2
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (2, 2, 4, '2025-04-02', 'Pending', '2025-04-16', '2025-04-02', 'Active');

-- Dòng 3
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (3, 3, 5, '2025-04-03', 'Pending', '2025-04-17', '2025-04-03', 'Active');

-- Dòng 4
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (4, 4, 6, '2025-04-04', 'Pending', '2025-04-18', '2025-04-04', 'Active');

-- Dòng 5
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (5, 5, 7, '2025-04-05', 'Pending', '2025-04-19', '2025-04-05', 'Active');

-- Dòng 6
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (6, 6, 3, '2025-04-06', 'Pending', '2025-04-20', '2025-04-06', 'Active');

-- Dòng 7
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (7, 7, 4, '2025-04-07', 'Pending', '2025-04-21', '2025-04-07', 'Active');

-- Dòng 8
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (8, 8, 5, '2025-04-08', 'Pending', '2025-04-22', '2025-04-08', 'Active');

-- Dòng 9
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (9, 9, 6, '2025-04-09', 'Pending', '2025-04-23', '2025-04-09', 'Active');

-- Dòng 10
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (10, 10, 7, '2025-04-10', 'Pending', '2025-04-24', '2025-04-10', 'Active');

-- Dòng 11
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (11, 1, 3, '2025-04-11', 'Pending', '2025-04-25', '2025-04-11', 'Active');

-- Dòng 12
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (12, 2, 4, '2025-04-12', 'Pending', '2025-04-26', '2025-04-12', 'Active');

-- Dòng 13
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (13, 3, 5, '2025-04-13', 'Pending', '2025-04-27', '2025-04-13', 'Active');

-- Dòng 14
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (14, 4, 6, '2025-04-14', 'Pending', '2025-04-28', '2025-04-14', 'Active');

-- Dòng 15
INSERT INTO document_loans (loan_id, document_id, user_id, loan_from, loan_status, loan_to, loan_created, status)
VALUES (15, 5, 7, '2025-04-15', 'Pending', '2025-04-29', '2025-04-15', 'Active');

-- Dòng 1
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (1, 1, '2025-04-15', '2025-04-15', 'Returned');

-- Dòng 2
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (2, 2, '2025-04-16', '2025-04-16', 'Returned');

-- Dòng 3
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (3, 3, '2025-04-17', '2025-04-17', 'Returned');

-- Dòng 4
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (4, 4, '2025-04-18', '2025-04-18', 'Returned');

-- Dòng 5
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (5, 5, '2025-04-19', '2025-04-19', 'Returned');

-- Dòng 6
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (6, 6, '2025-04-20', '2025-04-20', 'Returned');

-- Dòng 7
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (7, 7, '2025-04-21', '2025-04-21', 'Returned');

-- Dòng 8
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (8, 8, '2025-04-22', '2025-04-22', 'Returned');

-- Dòng 9
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (9, 9, '2025-04-23', '2025-04-23', 'Returned');

-- Dòng 10
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (10, 10, '2025-04-24', '2025-04-24', 'Returned');

-- Dòng 11
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (11, 11, '2025-04-25', '2025-04-25', 'Returned');

-- Dòng 12
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (12, 12, '2025-04-26', '2025-04-26', 'Returned');

-- Dòng 13
INSERT INTO Document_returns (return_id, loan_id, return_created, return_date, status)
VALUES (13, 13, '2025-04-27', '2025-04-27', 'Returned');

DELETE FROM Document