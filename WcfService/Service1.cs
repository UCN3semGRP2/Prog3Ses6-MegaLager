﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;
using Business;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private IInventoryCtrl invCtrl;

        public Service1()
        {

        }

        public void CreateItem()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindProductByName(string name)
        {
            return invCtrl.FindProductByName(name);
        }

        public IEnumerable<Product> FindProductByProductNo(int productNo)
        {
            return invCtrl.FindProductByProductNo(productNo);
        }

        public IEnumerable<Product> GetAllSoldoutProducts()
        {
            return invCtrl.GetAllSoldoutProducts();
        }

        public void UpdatePrice(Product p, double price)
        {
            invCtrl.UpdatePrice(p, price);
        }

        public void UpdateStock(Product p, int newSupply)
        {
            invCtrl.UpdateStock(p, newSupply);
        }
    }
}
