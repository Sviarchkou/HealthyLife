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
    internal class IngredientController : DefaultController
    {
        public async Task<List<Ingredient>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);

            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (DataRow row in dataTable.Rows)
            {
                ingredients.Add(await createIngredient(row));
            }

            db.Close();
            return ingredients;
        }

        public async Task<Ingredient> findById(string ingredient_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM ingredients WHERE id = '{ingredient_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Ingredient not found");
            }
            return await createIngredient(dataTable.Rows[0]);
        }

        private async Task<Ingredient> createIngredient(DataRow row)
        {
            Ingredient ingredient = new Ingredient();
            
            ingredient.id = (int)row[0];
            ingredient.weight = (int)row[1];
            
            ProductController productController = new ProductController();
            ingredient.product = await productController.findById(row[2].ToString());
            
            return ingredient;
        }

        public async Task<int> insertIngredient(Ingredient ingredients)
        {
            if (ingredients == null)
                throw new ArgumentNullException();
            if (ingredients.product == null)
                throw new ArgumentException("Product in not added");
            if (ingredients.recipe == null)
                throw new ArgumentException("Recipe in not added");

            string str = $"INSERT INTO ingredients (weight, product_id, recipe_id) " +
                $"VALUES ({ingredients.weight}, {ingredients.product.id}, {ingredients.recipe.id}) RETURNING id";

            DBConnector db = new DBConnector();
            db.Open();
            await db.insert(str);
            db.Close();
            
            return 0;
        }

    }
}
