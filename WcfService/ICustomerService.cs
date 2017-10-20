using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean);
        [OperationContract]
        Customer CreatePrivCustomer(String name, String phone, String address, String zip, String accountNo);
        [OperationContract]
        void UpdateCustomer(string name, String phone, string CustomerNo, String Zip, String AccountNo, String address);
        [OperationContract]
        void DeleteCustomer(Customer customer);
    }
}
