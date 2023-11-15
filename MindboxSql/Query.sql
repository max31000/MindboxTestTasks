/*
  Products — это таблица, в которой хранится информация о продукте, а ProductID — это первичный ключ.

  Categories — это таблица, в которой хранится информация о категориях, а CategoryID — это первичный ключ.

  ProductCategories это связующая таблица, соединяющую продукты с категориями, и она содержит ProductID и CategoryID в качестве внешних ключей, ссылающихся на соответствующие таблицы.
*/

SELECT
    P.ProductName,
    COALESCE(C.CategoryName, 'No Category') AS CategoryName
FROM
    Products P
LEFT JOIN
    ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN
    Categories C ON PC.CategoryID = C.CategoryID
ORDER BY
    P.ProductName, CategoryName;