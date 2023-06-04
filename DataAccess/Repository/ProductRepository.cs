﻿using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product p) => ProductDAO.InsertProduct(p);

        public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);

        public Product GetProductByID(int id) => ProductDAO.FindProductById(id);

        public List<Product> GetProducts() => ProductDAO.GetProducts();

        public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);
    }
}
