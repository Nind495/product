namespace WcfProduct
{
    using System;
    /// <summary>
    /// Класс для таблицы Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id продукта.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Наименование продукта.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата истечения срока годности продукта.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        public Product()
        {
            ProductId = -1;
            Name = "";
            ExpirationDate = new DateTime();
        }
    }
}
