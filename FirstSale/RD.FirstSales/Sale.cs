using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.FirstSales
{
    /// <summary>
    /// Продажа продукта
    /// </summary>
    public class Sale
    {
        /// <summary>
        /// Идентификатор продажи
        /// </summary>
        public int SaleId
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор покупателя
        /// </summary>
        public int CustomerId
        {
            get;
            set;
        }

        /// <summary>
        /// Дата продажи
        /// </summary>
        public DateTime DateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор проданного продукта
        /// </summary>
        public int ProductId
        {
            get;
            set;
        }
    }
}
