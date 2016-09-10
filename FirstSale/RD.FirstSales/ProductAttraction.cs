using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.FirstSales
{
    /// <summary>
    /// Привлекательность продукта для первой покупки
    /// </summary>
    public class ProductAttraction
    {
        public ProductAttraction(int productId, int salesCount)
        {
            ProductId = productId;
            SalesCount = salesCount;
        }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId
        {
            get;
            private set;
        }

        /// <summary>
        /// Количество продаж продукта
        /// </summary>
        public int SalesCount
        {
            get;
            private set;
        }

        /// <summary>
        /// Определяет привлекательность продукта для первой покупки
        /// </summary>
        /// <param name="sales">Данные о продажах</param>
        /// <returns>Возвращает упорядоченный по количеству продаж список привлекательности продуктов</returns>
        public static IQueryable<ProductAttraction> GetAttraction(IQueryable<Sale> sales)
        {
            return sales.GroupBy(s => s.CustomerId)
                .Select(g => g.OrderBy(o => o.DateTime).First())
                .GroupBy(s => s.ProductId)
                .Select(g => new ProductAttraction(g.Key, g.Count()))
                .OrderByDescending(a => a.SalesCount);
        }
    }
}
