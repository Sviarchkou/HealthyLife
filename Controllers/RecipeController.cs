using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HealthyLife_Pt2.Controllers
{
    public class RecipeController : DefaultController
    {

        public async Task<List<Recipe>> select(string str)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select(str);

            List<Recipe> recipes = new List<Recipe>();

            foreach (DataRow row in dataTable.Rows)
            {
                recipes.Add(await createRecipe(row));
            }

            db.Close();
            return recipes;
        }

        public async Task<Recipe> findById(string? recipe_id)
        {
            if (recipe_id == null)
                throw new ArgumentNullException();

            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM recipes WHERE id = '{recipe_id}'");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("Product not found");
            }
            return await createRecipe(dataTable.Rows[0]);
        }
        private async Task<Recipe> createRecipe(DataRow row)
        {
            Recipe recipe = new Recipe();
            recipe.id = (int)row[0];
            recipe.name = (string)row[1];
            recipe.description = (string)row[2];

            ElementController elementController = new ElementController();
            recipe.element = await elementController.findById(row[3].ToString());

            if (!row[4].Equals(System.DBNull.Value))
            {
                recipe.photo = (string)row[4];
            }
            
            IngredientController ingredientController = new IngredientController();
            recipe.ingredients = await ingredientController.select($"SELECT * FROM ingredients WHERE recipe_id = '{recipe.id}'");
            foreach (Ingredient ingredient in recipe.ingredients)
                ingredient.recipe = recipe;

            return recipe;
        }

        public async Task<int> insertRecipe(Recipe recipe)
        {

            ElementController elementController = new ElementController();
            int element_id = await elementController.insertElement(recipe.element);

            StringBuilder commandHeader = new StringBuilder("INSERT INTO recipes (name, description, element_id");
            StringBuilder values = new StringBuilder($"VALUES ('{recipe.name}','{recipe.description}', {element_id}");

            if (recipe.photo != null && recipe.photo != "")
            {
                commandHeader.Append(", photo");
                values.Append($", '{recipe.photo}'");
            }
            commandHeader.Append(") ");
            values.Append($") RETURNING id;");

            DBConnector db = new DBConnector();
            db.Open();
            recipe.id = await db.insert(commandHeader.Append(values).ToString());
            db.Close();

            IngredientController ingredientController = new IngredientController();
            
            foreach (Ingredient i in recipe.ingredients)
            {
                i.recipe = recipe;
                await ingredientController.insertIngredient(i);
            }

            return recipe.id;
        }

        public async Task updateElement(Recipe recipe)
        {
            if (recipe.ingredients.Count == 0)
                return;
            
            ElementController elementController = new ElementController();
            elementController.clearElement(recipe.element);
            
            bool b = false;
            bool c = false;
            foreach (Ingredient ingredient in recipe.ingredients)
            {
                recipe.element.calories += (int) (ingredient.product.element.calories * ingredient.weight / 100);
                recipe.element.proteins += ingredient.product.element.proteins * ingredient.weight / 100;
                recipe.element.fats += ingredient.product.element.fats * ingredient.weight / 100;
                recipe.element.carbohydrates += ingredient.product.element.carbohydrates * ingredient.weight / 100;

                if (ingredient.product.element.minerals != null && ingredient.product.element.minerals != "")
                {
                    if (b)
                        recipe.element.minerals += ", ";
                    b = true;
                    recipe.element.minerals += ingredient.product.element.minerals;
                }

                if (ingredient.product.element.vitamins != null && ingredient.product.element.vitamins != "")
                {
                    if (c)
                        recipe.element.vitamins += ", ";
                    c = true;
                    recipe.element.vitamins = ingredient.product.element.vitamins;
                }
            }

            StringBuilder commandHeader = new StringBuilder("UPDATE elements SET ");
            StringBuilder values = new StringBuilder($"" +
                $"calories = {recipe.element.calories}, " +
                $"proteins = {doubleToDbString(recipe.element.proteins)}, " +
                $"fats = {doubleToDbString(recipe.element.fats)}, " +
                $"carbohydrates = {doubleToDbString(recipe.element.carbohydrates)}");

            if (recipe.element.minerals != null && recipe.element.minerals != "")
            {
                values.Append($", minerals = '{recipe.element.minerals}'");
            }

            if (recipe.element.vitamins != null && recipe.element.vitamins != "")
            {
                values.Append($", vitamins '{recipe.element.vitamins}'");
            }

            values.Append($" WHERE id = {recipe.element.id}");
            await elementController.update(commandHeader.Append(values).ToString());

        }


    }


}

/*
 

            foreach (Ingredient ingredients in recipe.ingredients)
            {
                
                element.calories += ingredients.element.calories;
                element.proteins += ingredients.element.proteins;
                element.fats += ingredients.element.fats;
                element.carbohydrates += ingredients.element.carbohydrates;
                
                if (ingredients.element.minerals != null && ingredients.element.minerals != "")
                {
                    if (b)
                        element.minerals += ", ";
                    b = true;    
                    element.minerals += ingredients.element.minerals;
                }

                if (ingredients.element.vitamins != null && ingredients.element.vitamins != "")
                {
                    if (b)
                        element.vitamins += ", ";
                    b = true;
                    element.vitamins = ingredients.element.vitamins;
                }
            }
            recipe.element = element;
*/