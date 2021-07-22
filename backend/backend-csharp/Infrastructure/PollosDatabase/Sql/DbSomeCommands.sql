--#########################################################################################################################
-- Some Commands Users
--#########################################################################################################################

SELECT * FROM users;

DROP TABLE users;

-- Select Order
SELECT * FROM users 
ORDER BY Id DESC;


-- Pagination And Sorting Default
SELECT * FROM users 
ORDER BY (SELECT NULL) 
OFFSET 1*2 ROWS
FETCH NEXT 2 ROWS ONLY;


-- Pagination And Sorting
SELECT * FROM users 
ORDER BY Name ASC, Lastname DESC, Dni ASC
OFFSET 0*2 ROWS
FETCH NEXT 2 ROWS ONLY;


-- Pagination And Sorting Filter
SELECT * FROM users 
WHERE Name='Walter' AND Lastname='White' 
ORDER BY Name ASC,Dni ASC
OFFSET 0*2 ROWS
FETCH NEXT 2 ROWS ONLY;


-- Pagination And Sorting Filter by LIKE
SELECT * FROM users 
WHERE Name LIKE '%r%' AND Lastname LIKE '%a%'
ORDER BY Name ASC,Dni ASC
OFFSET 0*2 ROWS
FETCH NEXT 2 ROWS ONLY;
