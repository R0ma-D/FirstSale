SELECT Result.ProductId, COUNT(*) AS SalesCount 
FROM 
(
	-- Выбираем продукты, которые были первой покупкой пользователя
	SELECT s.ProductId
	FROM 
	(
		-- Определяем первую покупку покупателя 
		SELECT CustomerId, MIN([DateTime]) AS FirstSaleDate
		FROM Sales 
		GROUP BY CustomerId
	) AS c 
	-- Добавляем в первую покупку все данные
	INNER JOIN Sales AS s 
	ON s.CustomerId = c.CustomerId AND s.[DateTime] = c.FirstSaleDate
) AS Result 
-- Группируем по продукту
GROUP BY Result.ProductId 
-- Упорядочиваем по количеству покупок
ORDER BY SalesCount DESC

GO