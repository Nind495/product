namespace WcfProduct
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        int InsertClient(Client clients);

        [OperationContract]
        List<Client> SelectClient();

        [OperationContract]
        List<Product> SelectProduct();

        [OperationContract]
        List<Sale> SelectSale();
    }
}