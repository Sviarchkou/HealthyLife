using HealthyLife_Pt2.Controllers;
using HealthyLife_Pt2.Database;
using HealthyLife_Pt2.Forms;
using HealthyLife_Pt2.Models;
using HealthyLIfe_Pt2.Forms;
using Npgsql;
using System.Data;
using System.Drawing.Imaging;
using System.Resources;
using System.Text;
using System.Text.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HealthyLife_Pt2
{
    internal static class Program
    {

        [STAThread]
        //static async Task Main(string[] args)
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new WellcomeScrin()); ;



            /*
            StringBuilder commandHeader = new StringBuilder("INSERT INTO user_weight (user_id, updated_at, weight, goal) ");
            StringBuilder values = new StringBuilder($"VALUES (" +
                $"'67c1272e-c8e5-42e1-816e-aa326ecac90e', " +
                $"'2024-11-27', " +
                $"70," +
                $"75) RETURNING id;");

            DBConnector db = new DBConnector();
            db.Open();
            await db.insert(commandHeader.Append(values).ToString());
            db.Close();
            */

            /*
            byte[] image = File.ReadAllBytes("D:\\Лицей\\Выпускной\\IMG_1330.jpg");
            StringBuilder sb = new StringBuilder();
            foreach(byte b in image) {
                sb.Append(b + ",");
            }


            string str = "Host=localhost;Port=5432;Database=healthylife;Username=healthylife;Password=healthylife";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(str);
            npgsqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();

            command.Connection = npgsqlConnection;
            command.CommandType = CommandType.Text;


            command.CommandText = $"UPDATE products SET photo = '{sb}' WHERE id = 5";
            
            command.ExecuteNonQuery();

            command.Dispose();

            */

            /*
            Element element = new Element();
            element.calories = 1687;
            element.proteins = 76.5;
            element.fats = 49.5;
            element.carbohydrates = 270.9;
            ElementController elementController = new ElementController();
            int e_id = await elementController.insertElement(element);

            DailyElement dailyElement = new DailyElement();
            dailyElement.element = element;
            dailyElement.date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
            UserController userController = new UserController();
            dailyElement.user = await userController.findByUsername("Kasper");

            DailyElementControler dailyElementControler = new DailyElementControler();
            await dailyElementControler.insertDailyElement(dailyElement.user.id, e_id);
            */
            /*
            DietController dietController = new DietController();

            List<Diet> diets = await dietController.select("SELECT * FROM diets");
            Diet check = await dietController.findById("1");

            DailyMealController dailyMealController = new DailyMealController();
            List<DailyMeal> meals = await dailyMealController.select("SELECT * FROM user_daily_meal");

            Console.WriteLine();
            */
            /*
            
            DailyMealController dailyMealController = new DailyMealController();

            DailyMeal check = await dailyMealController.findById("1");
            DailyMeal today = await dailyMealController.findToday("f3635383-fbec-4361-849b-9452af8c0543");

            Console.WriteLine();
            */

            /*
            ProductController productController = new ProductController();
            List<Product> products =  await productController.select("SELECT * FROM products WHERE name = 'Babyfox' OR name = 'Chicken'");

            Meal meal = new Meal();
            meal.extraFood = products;

            RecipeController recipeController = new RecipeController();
            meal.breakfast = (await recipeController.select("SELECT * FROM recipes WHERE id = '1'"))[0];
            MealController mealController = new MealController();
            mealController.updateElement(meal);

            await mealController.insertMeal(meal);
            */

            /*
            
            
            Element element = new Element();
            element.calories = 320;
            element.proteins = 24;
            element.fats = 14;
            element.carbohydrates = 0;
            element.minerals = "Na, Zn, Fe";

            Product product = new Product();
            product.element = element;
            product.name = "Chicken";
            product.category = "meat";
            product.description = "";


            Element element1 = new Element();
            element1.calories = 520;
            element1.proteins = 7;
            element1.fats = 38;
            element1.carbohydrates = 50;

            Product product1 = new Product();
            product1.element = element1;
            product1.name = "Babyfox";
            product1.category = "chockolet";
            product1.description = "Вкусно конечно, но жирно";


            Element element2 = new Element();
            element2.calories = 350;
            element2.proteins = 12;
            element2.fats = 2;
            element2.carbohydrates = 70;
            element2.minerals = "Na, Zn, Fe, Клетчатка";

            Product product2 = new Product();
            product2.element = element2;
            product2.name = "Гречка";
            product2.category = "крупы/каши";
            product2.description = "";

            ProductController productController = new ProductController();
            await productController.insertProduct(product);
            await productController.insertProduct(product1);
            await productController.insertProduct(product2);
            
            Recipe recipe = new Recipe();
            Recipe recipe2 = new Recipe();
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Product> products = new List<Product>();

            ProductController productController = new ProductController();
            RecipeController recipeController = new RecipeController(); 
            IngredientController ingredientController = new IngredientController();
            

            products = await productController.select("SELECT * FROM products");

            for(int i = 0; i < products.Count; i++)
            {
                if (i == 1) continue;
                Ingredient ingredient = new Ingredient();
                ingredient.product = products[i];
                ingredient.weight = 200;
                ingredient.recipe = recipe;
                ingredient.recipe = recipe2;

                ingredients.Add(ingredient);
            }

            recipe.ingredients = ingredients;
            recipe.name = "Курица с гречкой";
            await recipeController.updateElement(recipe);
            await recipeController.insertRecipe(recipe);

            recipe.ingredients = ingredients;
            recipe.name = "Гречкой";
            await recipeController.updateElement(recipe);
            await recipeController.insertRecipe(recipe2);

            for (int i = 0; i < products.Count; i++){
                await ingredientController.insertIngredient(ingredients[i]);
            }
            
            */


            /*
             
            Element element = new Element();
            element.calories = 320;
            element.proteins = 24;
            element.fats = 14;
            element.carbohydrates = 0;
            element.minerals = "Na, Zn, Fe";

            Product product = new Product();
            product.element = element;
            product.name = "Chicken";
            product.category = "meat";
            product.description = "";


            Element element1 = new Element();
            element1.calories = 520;
            element1.proteins = 7;
            element1.fats = 38;
            element1.carbohydrates = 50;

            Product product1 = new Product();
            product1.element = element1;
            product1.name = "Babyfox";
            product1.category = "chockolet";
            product1.description = "Вкусно конечно, но жирно";


            Element element2 = new Element();
            element2.calories = 350;
            element2.proteins = 12;
            element2.fats = 2;
            element2.carbohydrates = 70;
            element2.minerals = "Na, Zn, Fe, Клетчатка";

            Product product2 = new Product();
            product2.element = element;
            product2.name = "Гречка";
            product2.category = "крупы/каши";
            product2.description = "";

            */

            /*
            UserWeight userWeight = new UserWeight();
            userWeight.weight = 75.6;
            userWeight.goal = 75.6;
            userWeight.user = new User();
            userWeight.user.id = new Guid("67c1272e-c8e5-42e1-816e-aa326ecac90e");

            UserWeightController userWeightController = new UserWeightController();
            await userWeightController.insertUserWeight(userWeight);

            */


            /*
            
            Product product = new Product();
            product.name = "Рулут Бисквитный CAFE de Paris";
            product.category = "cake";
            product.description = "Description";
            Element e = new Element();
            e.calories = 340;
            e.fats = 9.5;
            e.proteins = 4.1;
            e.carbohydrates = 58.9;
            e.minerals = "Na";
            product.element = e;

            ProductController productController = new ProductController();
            await productController.insertProduct(product);
            
            
            */
            /*
            string str = "Host=localhost;Port=5432;Database=healthylife;Username=healthylife;Password=healthylife";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(str);
            npgsqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();

            command.Connection = npgsqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = 
                "ALTER TABLE extra_food " +
                "DROP COLUMN id";

            command.ExecuteNonQuery();

            command.Dispose();
            
            */
            /*
        var dbContext = new MyDbContext();
        string migrationScript = File.ReadAllText("path/to/migration.sql");
        dbContext.RunMigrationScript(migrationScript);
            


            string str = "Host=localhost;Port=5432;Database=healthylife;Username=healthylife;Password=healthylife";
            Npgsql.NpgsqlConnection npgsqlConnection = new Npgsql.NpgsqlConnection(str);
            npgsqlConnection.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand();
            command.Connection = npgsqlConnection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText =
                "INSERT INTO users (username, password, role, sex,weight,height,activity,goal) " +
                "VALUES ('admin', '12345678', 'true', 'male','74.7','179','medium','loss'),";
            command.Dispose();
            npgsqlConnection.Close();
            */

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }


    }


}