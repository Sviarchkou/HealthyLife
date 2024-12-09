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

            if (!row[5].Equals(System.DBNull.Value))
                product.photo = (string)row[5];

            product.verified = (bool)row[6];

            return product;
        }

        public async Task<int> insertProduct(Product product)
        {
            ElementController elementController = new ElementController();
            int element_id = await elementController.insertElement(product.element);

            StringBuilder commandHeader = new StringBuilder("INSERT INTO products (name, category, description, element_id, verified ");
            StringBuilder values = new StringBuilder($"VALUES ('{product.name}', '{product.category}', '{product.description}', '{element_id}', {product.verified}");
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

        public async Task<bool> isUnreleted(Product product)
        {
            
            IngredientController ingredientController = new IngredientController();
            if ((await ingredientController.select($"SELECT * FROM ingredients WHERE product_id = '{product.id}'")).Count > 0)
                return false;

            ExtraFoodController extraFoodController = new ExtraFoodController();
            if ((await extraFoodController.select($"SELECT * FROM extra_food WHERE product_id = '{product.id}'")).Count > 0)
                return false;

            return true;
        }

        public async Task deleteProduct(Product product)
        {
            DBConnector db = new DBConnector();
            db.Open();

            await db.remove($"DELETE FROM products WHERE id = '{product.id}'");
            await db.remove($"DELETE FROM elements WHERE id = '{product.element.id}'");
            
            db.Close();
        }

    }
}
