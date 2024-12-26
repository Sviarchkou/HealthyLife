using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyLife_Pt2.Models;

namespace HealthyLife_Pt2
{
    public class SearchPanelFilterButtonList
    {
        public List<Button> productFilterButtons { get; private set; } = new List<Button>();
        public List<Button> recipeFilterButtons { get; private set; } = new List<Button>();
        public List<Button> dietFilterButtons { get; private set; } = new List<Button>();

        public List<Comparison<Product>> productComparisons { get; private set; } = new List<Comparison<Product>>();
        public List<Comparison<Recipe>> recipeComparisons { get; private set; } = new List<Comparison<Recipe>>();
        public List<Comparison<Diet>> dietComparisons { get; private set; } = new List<Comparison<Diet>>();

        public SearchPanelFilterButtonList()
        {
            fillProductFilterButtons();
            fillRecipeFilterButtons();
            fillDietFilterButtons();
        }
        public SearchPanelFilterButtonList(Product? p)
        {
            fillProductFilterButtons();
        }
        public SearchPanelFilterButtonList(Recipe? r)
        { 
            fillRecipeFilterButtons();
        }
        public SearchPanelFilterButtonList(Diet? d)
        {
            fillDietFilterButtons();
        }

        private void fillProductFilterButtons()
        {
            productFilterButtons.Add(createButton("Сортировать по названию а->я"));
            productComparisons.Add(delegate(Product p1, Product p2)
            {
                return String.Compare(p1.name.ToLower(), p2.name.ToLower());
            });
            
            productFilterButtons.Add(createButton("Сортировать по названию я->а"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                return String.Compare(p2.name.ToLower(), p1.name.ToLower());
            });
            
            productFilterButtons.Add(createButton("Сортировать по категории а->я"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                return String.Compare(p1.category.ToLower(), p2.category.ToLower());
            }); 
            
            productFilterButtons.Add(createButton("Сортировать по категории я->а"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                return String.Compare(p2.category.ToLower(), p1.category.ToLower());
            });

            productFilterButtons.Add(createButton("Сначала верефицированные"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if ((p1.verified && p2.verified) || (!p1.verified && !p2.verified))
                    return 0;
                if (p1.verified)
                    return -1;
                return 1;
            });

            productFilterButtons.Add(createButton("Менее каллорийные сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.calories > p2.element.calories)
                    return 1;
                if (p1.element.calories < p2.element.calories)
                    return -1;
                return 0;
            });

            productFilterButtons.Add(createButton("Более каллорийные сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.calories > p2.element.calories)
                    return -1;
                if (p1.element.calories < p2.element.calories)
                    return 1;
                return 0;
            }); 
            
            productFilterButtons.Add(createButton("Менее белковые сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.calories > p2.element.calories)
                    return 1;
                if (p1.element.calories < p2.element.calories)
                    return -1;
                return 0;
            }); 
            
            productFilterButtons.Add(createButton("Более белковые сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.proteins > p2.element.proteins)
                    return 1;
                if (p1.element.proteins < p2.element.proteins)
                    return -1;
                return 0;
            }); 
            
            productFilterButtons.Add(createButton("Менее жирные сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.proteins > p2.element.proteins)
                    return -1;
                if (p1.element.proteins < p2.element.proteins)
                    return 1;
                return 0;
            }); 
            
            productFilterButtons.Add(createButton("Более жирные сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.fats > p2.element.fats)
                    return -1;
                if (p1.element.fats < p2.element.fats)
                    return 1;
                return 0;
            }); 
            
            productFilterButtons.Add(createButton("Где больше углеводов сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.carbohydrates > p2.element.carbohydrates)
                    return 1;
                if (p1.element.carbohydrates < p2.element.carbohydrates)
                    return -1;
                return 0;
            }); 
            
            productFilterButtons.Add(createButton("Где меньше углеводов сначала"));
            productComparisons.Add(delegate (Product p1, Product p2)
            {
                if (p1.element.carbohydrates > p2.element.carbohydrates)
                    return -1;
                if (p1.element.carbohydrates < p2.element.carbohydrates)
                    return 1;
                return 0;
            });

        }

        private void fillRecipeFilterButtons()
        {
            recipeFilterButtons.Add(createButton("Сортировать по названию а->я"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                return String.Compare(r1.name.ToLower(), r2.name.ToLower());
            });

            recipeFilterButtons.Add(createButton("Сортировать по названию я->а"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                return String.Compare(r2.name.ToLower(), r1.name.ToLower());
            });

            recipeFilterButtons.Add(createButton("Сначала верефицированные"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if ((r1.verified && r2.verified) || (!r1.verified && !r2.verified))
                    return 0;
                if (r1.verified)
                    return -1;
                return 1;
            });

            recipeFilterButtons.Add(createButton("Менее каллорийные сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.calories > r2.element.calories)
                    return 1;
                if (r1.verified)
                    return -1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Более каллорийные сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.calories > r2.element.calories)
                    return -1;
                if (r1.element.calories < r2.element.calories)
                    return 1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Менее белковые сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.proteins > r2.element.proteins)
                    return 1;
                if (r1.element.proteins < r2.element.proteins)
                    return -1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Более белковые сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.proteins > r2.element.proteins)
                    return -1;
                if (r1.element.proteins < r2.element.proteins)
                    return 1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Менее жирные сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.fats > r2.element.fats)
                    return 1;
                if (r1.element.fats < r2.element.fats)
                    return -1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Более жирные сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.fats > r2.element.fats)
                    return -1;
                if (r1.element.fats < r2.element.fats)
                    return 1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Где меньше углеводов сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.carbohydrates > r2.element.carbohydrates)
                    return 1;
                if (r1.element.carbohydrates < r2.element.carbohydrates)
                    return -1;
                return 0;
            });

            recipeFilterButtons.Add(createButton("Где больше углеводов сначала"));
            recipeComparisons.Add(delegate (Recipe r1, Recipe r2)
            {
                if (r1.element.carbohydrates > r2.element.carbohydrates)
                    return -1;
                if (r1.element.carbohydrates < r2.element.carbohydrates)
                    return 1;
                return 0;
            });

        }

        private void fillDietFilterButtons()
        {
            dietFilterButtons.Add(createButton("Сортировать по названию а->я"));            
            dietComparisons.Add(delegate (Diet d1, Diet d2)
            {
                return String.Compare(d1.name.ToLower(), d2.name.ToLower());
            });

            dietFilterButtons.Add(createButton("Сортировать по названию я->а"));
            dietComparisons.Add(delegate (Diet d1, Diet d2)
            {
                return String.Compare(d2.name.ToLower(), d1.name.ToLower());
            });

            dietFilterButtons.Add(createButton("Для похудения сначала"));
            dietComparisons.Add(delegate (Diet d1, Diet d2)
            {
                if (d1.goal == d2.goal) 
                    return 0;
                if (d1.goal == Goal.loss) 
                    return -1;
                return 1;
            });

            dietFilterButtons.Add(createButton("Для поддержания веса сначала"));
            dietComparisons.Add(delegate (Diet d1, Diet d2)
            {
                if (d1.goal == d2.goal)
                    return 0;
                if (d1.goal == Goal.maintenance)
                    return -1;
                return 1;
            });

            dietFilterButtons.Add(createButton("Для набора массы сначала"));
            dietComparisons.Add(delegate (Diet d1, Diet d2)
            {
                if (d1.goal == d2.goal)
                    return 0;
                if (d1.goal == Goal.gain)                    
                    return -1;
                return 1;
            });
        }

        public Button createButton(string text)
        {
            Button button = new Button();
            button.Size = new Size(300, 30);
            button.Text = text;
            button.AutoSize = false;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Font = new Font("Verdana", 9.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;            
            button.Margin = new Padding(0, 0, 0, 0);
            return button;
        }
    }
}
