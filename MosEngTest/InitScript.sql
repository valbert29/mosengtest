-- через postgres базу
CREATE DATABASE mosengtest;

-- через mosengtext базу
CREATE TABLE IF NOT EXISTS MosEngTest.public."users"(
    "id" serial PRIMARY KEY,
    username varchar(50) NOT NULL,
    password varchar(255) NOT NULL    
);
CREATE TABLE IF NOT EXISTS MosEngTest.public.todos(
    "id" serial PRIMARY KEY,
    title varchar(50) NOT NULL,
    user_id int,
    FOREIGN KEY (user_id) REFERENCES MosEngTest.public."users"(id) ON DELETE CASCADE
);

INSERT INTO MosEngTest.public."users"(id, username, password)
VALUES 
       (1, 'Tom', '123'),
       (2, 'Sue', '123');

INSERT INTO MosEngTest.public.todos(title, user_id)
VALUES('Задача 1', 1),
      ('Задача 2', 1),
      ('Задача 3', 1),
      ('Задача 4', 2),
      ('Задача 5', 2);