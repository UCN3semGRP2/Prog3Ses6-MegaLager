﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    interface IInventoryCtrl
    {
        void CreateItem();
        void UpdateStock(Product p, int newSupply);
        void UpdatePrice(Product p, double price);
        IEnumerable<Product> GetAllSoldoutProducts();

        IEnumerable<Product> FindProductByName(string name);
        IEnumerable<Product> FindProductByProductNo(int productNo);
    }
}