using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Models;
using System.Data;
using System.Text;

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

        public async Task<List<Recipe>> selectUserRecipes(string user_id)
        {
            DBConnector db = new DBConnector();
            db.Open();
            DataTable dataTable = await db.select($"SELECT * FROM user_has_recipes WHERE user_id = '{user_id}'");

            List<Recipe> recipes = new List<Recipe>();

            foreach (DataRow row in dataTable.Rows)
            {
                try
                {
                    recipes.Add(await findById(row[1].ToString()));
                }
                catch (Exception ex) { }
                
            }
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

            recipe.verified = (bool)row[5];

            IngredientController ingredientController = new IngredientController();
            recipe.ingredients = await ingredientController.select($"SELECT * FROM ingredients WHERE recipe_id = '{recipe.id}'");
            
            //foreach (Ingredient ingredient in recipe.ingredients)
              //  ingredient.recipe = recipe;

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

        public async Task insertUserRecipe(User user, Recipe recipe)
        {
            DBConnector db = new DBConnector();
            db.Open();
            await db.insert($"INSERT INTO user_has_recipes (recipe_id, user_id) VALUES ({recipe.id}, '{user.id}');");
            db.Close();
        }

        public void updateElement(Recipe recipe)
        {
            if (recipe.ingredients.Count == 0)
                return;
            
            ElementController elementController = new ElementController();
            elementController.clearElement(recipe.element);

            HashSet<string> minerals = new HashSet<string>();
            HashSet<string> vitamins = new HashSet<string>();

            foreach (Ingredient ingredient in recipe.ingredients)
            {
                recipe.element.calories += (int) (ingredient.product.element.calories * ingredient.weight / 100);
                recipe.element.proteins += ingredient.product.element.proteins * ingredient.weight / 100;
                recipe.element.fats += ingredient.product.element.fats * ingredient.weight / 100;
                recipe.element.carbohydrates += ingredient.product.element.carbohydrates * ingredient.weight / 100;

                if (ingredient.product.element.minerals != null && ingredient.product.element.minerals != "")
                {                    
                    foreach (string str in ingredient.product.element.minerals.Split(", "))
                    {
                        minerals.Add(str);
                    }
                }

                if (ingredient.product.element.vitamins != null && ingredient.product.element.vitamins != "")
                {
                    foreach (string str in ingredient.product.element.vitamins.Split(", "))
                    {
                        vitamins.Add(str);
                    }
                }
            }

            recipe.element.minerals = String.Join(", ", minerals);
            recipe.element.vitamins = String.Join(", ", vitamins);
           
        }

        public async Task<bool> isUnreleted(Recipe recipe)
        {
            
            DBConnector db = new DBConnector();
            DataTable dataTable;
            
            db.Open();
            dataTable = await db.select($"SELECT * FROM diet_has_meals");
            db.Close();
            if (dataTable.Rows.Count == 0)
            {
                return true;
            }

            List<Meal> meals = new List<Meal>();
            MealController mealController = new MealController();
            foreach (DataRow row in dataTable.Rows)
            {
                meals.AddRange(await mealController.select($"SELECT * FROM meals WHERE id = '{(int)row[0]}'"));
            }

            foreach (Meal m in meals)
            {
                if (m.breakfast != null && m.breakfast.id == recipe.id)
                    return false;

                if (m.lunch != null && m.lunch.id == recipe.id)
                    return false;

                if (m.dinner != null && m.dinner.id == recipe.id)
                    return false;
            }

            return true;
        }
           
        public async Task deleteRecipe(Recipe recipe)
        {
            List<Meal> meals = new List<Meal>();
            MealController mealController = new MealController();
            meals = await mealController.select($"SELECT * FROM meals WHERE breakfast_id = '{recipe.id}' OR lunch_id = '{recipe.id}' OR dinner_id = '{recipe.id}'");            
            foreach(Meal m in meals)
            {
                if (m.breakfast != null && m.breakfast.Equals(recipe)) m.breakfast = null;
                if (m.lunch != null && m.lunch.Equals(recipe)) m.lunch = null;
                if (m.dinner != null && m.dinner.Equals(recipe)) m.dinner = null;
                await mealController.updateMeal(m);
            }

            DBConnector db = new DBConnector();
            db.Open();
            await db.remove($"DELETE FROM ingredients WHERE recipe_id = '{recipe.id}'");            
            await db.remove($"DELETE FROM recipes WHERE id = '{recipe.id}'");
            await db.remove($"DELETE FROM elements WHERE id = '{recipe.element.id}'");            
            db.Close();
        }

    }


}
