using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
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


