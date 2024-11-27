using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2.Controllers
{
    internal class ProductController : DefaultController
    {
        public async Task<List<Product>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);

            List<Product> products = new List<Product>();

            foreach (DataRow row in dataTable.Rows)
            {
                products.Add(await createProduct(row));
            }

            db.Close();
            return products;
        }

        public async Task<List<Product>> selectFromExtraFood(string meal_id)
        {
            
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM extra_food WHERE meal_id = '{meal_id}'");
            db.Close();

            List<Product> products = new List<Product>();
            
            foreach (DataRow row in dataTable.Rows)
            {
                List<Product> ps = await select($"SELECT * FROM products WHERE id = '{row[0]}'");
                foreach (Product p in ps)
                    products.Add(p);
            }

            return products;
        }

        public async Task<Product> findById(string? product_id)
        {
            if (product_id == null)
                throw new ArgumentNullException();

            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM products WHERE id = '{product_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Product not found");
            }
            return await createProduct(dataTable.Rows[0]);
        }

        private async Task<Product> createProduct(DataRow row)
        {   
            Product product = new Product();

            product.id = (int)row[0];
            product.name = (string)row[1];
            product.category = (string)row[2];
            product.description = (string)row[3];

            ElementController elementController = new ElementController();
            Element? element = await elementController.findById(row[4].ToString());
            if (element != null)
            {
                product.element = element;
            }

            return product;
        }

        public async Task<int> insertProduct(Product product)
        {
            ElementController elementController = new ElementController();
            int element_id = await elementController.insertElement(product.element);

            StringBuilder commandHeader = new StringBuilder("INSERT INTO products (name, category, description, element_id ");
            StringBuilder values = new StringBuilder($"VALUES ('{product.name}', '{product.category}', '{product.description}', '{element_id}'");
            if (product.photo != null || product.photo == "")
            {
                commandHeader.Append(", photo");
                values.Append($", '{product.photo}'");
            }
            commandHeader.Append(") ");
            values.Append(") RETURNING id");

            DBConnector db = new DBConnector();
            db.Open();
            int product_id = await db.insert(commandHeader.Append(values).ToString());
            db.Close();
            
            return product_id;
        }

    }
}
