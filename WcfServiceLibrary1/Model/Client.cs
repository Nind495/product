namespace WcfProduct
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Класс для таблицы Client
    /// </summary>
    [DataContract]
    public class Client
    {
        /// <summary>
        /// Id Клиента.
        /// </summary>
        [DataMember]
        public int ClientId { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        [DataMember]
        public string LastName { get; set; }
    }
};



