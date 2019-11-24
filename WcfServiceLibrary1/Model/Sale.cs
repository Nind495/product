namespace WcfProduct
{
    using System;

    /// <summary>
    /// Класс для работы с таблицей Sale.
    /// </summary>
    public class Sale
    {
        /// <summary>
        /// Id продажи.
        /// </summary>
        public int SaleId { get; set; }

        /// <summary>
        /// Дата продажи.
        /// </summary>
        public TimeSpan DataSale { get; set; }

        /// <summary>
        /// Id клиента.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Id продукта.
        /// </summary>
        public int ProductId { get; set; }
    }
}
