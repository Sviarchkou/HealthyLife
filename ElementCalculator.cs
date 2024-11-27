using HealthyLife_Pt2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;


namespace HealthyLife_Pt2
{

    // BMR - basal metabolic rate
    // DCR - daily calorie requirement
    // EIN -  energy index of nutrients.
    public class ElementCalculator
    {
        public const double LOW_ACTIVITY_INDEX = 1.25;
        public const double MEDIUM_ACTIVITY_INDEX = 1.55;
        public const double HIGH_ACTIVITY_INDEX = 1.75;

        public const double PROTEIN_EIN = 4;
        public const double FAT_EIN = 9;
        public const double CARBOHYDRATES_EIN = 4;

        public const double LOSS_GOAL_CALORIES_INDEX = 0.85;
        public const double MAINTENANCE_GOAL_CALORIES_INDEX = 1;
        public const double GAIN_GOAL_CALORIES_INDEX = 1.15;

        public const double LOSS_GOAL_PROTEIN_INDEX = 0.25;
        public const double MAINTENANCE_GOAL_PROTEIN_INDEX = 0.17;
        public const double GAIN_GOAL_PROTEIN_INDEX = 0.22;

        public const double LOSS_GOAL_FATS_INDEX = 0.25;
        public const double MAINTENANCE_GOAL_FATS_INDEX = 0.38;
        public const double GAIN_GOAL_FATS_INDEX = 0.23 ;

        public const double LOSS_GOAL_CARBOHYDRATES_INDEX = 0.5;
        public const double MAINTENANCE_GOAL_CARBOHYDRATES_INDEX = 0.45;
        public const double GAIN_GOAL_CARBOHYDRATES_INDEX = 0.55;


        public const int minMaleBMR = 1600;
        public const int minFemaleBMR = 1200;

        private double activityLevel;
        private Goal goal;
        private Sex sex;

        private double weight;
        private int height;
        private int age;
        public ElementCalculator(Sex sex, Activity activity, Goal goal)
        {
            switch (activity)
            {
                case Activity.low:
                    activityLevel = LOW_ACTIVITY_INDEX;
                    break;

                case Activity.medium:
                    activityLevel = MEDIUM_ACTIVITY_INDEX;
                    break;

                case Activity.high:
                    activityLevel = HIGH_ACTIVITY_INDEX;
                    break;
                default:
                    throw new ArgumentException();
            }

            this.sex = sex;
            this.goal = goal;
        }
        public ElementCalculator(User user) : this(user.sex, user.activity, user.goal) { }

        ///// BMR calculation /////
        private int maleFormulaBMR(double weight, int height, int age)
            => (int)((10 * weight) + (6.25 * height) - (5 * age) + 5);

        private int femaleFormulaBMR(double weight, int height, int age)
            => (int)((10 * weight) + (6.25 * height) - (5 * age) - 161);


        ///// DCR calculation /////

        public int maleDCR(double weight, int height, int age)
            => (int)(maleFormulaBMR(weight, height, age) * activityLevel);

        public int femaleDCR(double weight, int height, int age)
            => (int)(femaleFormulaBMR(weight, height, age) * activityLevel);

        public int calcDCR(double weight, int height, int age)
        {
            switch (sex)
            {
                case Sex.male:
                case Sex.other:
                    return maleDCR(weight, height, age);
                case Sex.female:
                    return femaleDCR(weight, height, age);
                default:
                    throw new ArgumentException();
            }
        }


        ///// Elements calculation /////

        public double proteinsCalc(double weight, int height, int age)
        {
            switch (goal) {
                case Goal.loss:
                    return (int) (calcDCR(weight, height, age) * LOSS_GOAL_CALORIES_INDEX * LOSS_GOAL_PROTEIN_INDEX / PROTEIN_EIN);                    
                case Goal.maintenance:
                    return (int)(calcDCR(weight, height, age) * MAINTENANCE_GOAL_CALORIES_INDEX * MAINTENANCE_GOAL_PROTEIN_INDEX / PROTEIN_EIN);
                case Goal.gain:
                    return (int)(calcDCR(weight, height, age) * GAIN_GOAL_CALORIES_INDEX * GAIN_GOAL_PROTEIN_INDEX / PROTEIN_EIN);
                default :
                    throw new ArgumentException();
            }
        }

        public double fatsCalc(double weight, int height, int age)
        {
            switch (goal)
            {
                case Goal.loss:
                    return (int)(maleDCR(weight, height, age) * LOSS_GOAL_CALORIES_INDEX * LOSS_GOAL_FATS_INDEX / FAT_EIN);
                case Goal.maintenance:
                    return (int)(maleDCR(weight, height, age) * MAINTENANCE_GOAL_CALORIES_INDEX * MAINTENANCE_GOAL_FATS_INDEX / FAT_EIN);
                case Goal.gain:
                    return (int)(maleDCR(weight, height, age) * GAIN_GOAL_CALORIES_INDEX * GAIN_GOAL_FATS_INDEX / FAT_EIN);
                default:
                    throw new ArgumentException();
            }
        }

        public double carohydratesCalc(double weight, int height, int age)
        {
            switch (goal)
            {
                case Goal.loss:
                    return (int)(calcDCR(weight, height, age) * LOSS_GOAL_CALORIES_INDEX * LOSS_GOAL_CARBOHYDRATES_INDEX / CARBOHYDRATES_EIN);
                case Goal.maintenance:
                    return (int)(calcDCR(weight, height, age) * MAINTENANCE_GOAL_CALORIES_INDEX * MAINTENANCE_GOAL_CARBOHYDRATES_INDEX / CARBOHYDRATES_EIN);
                case Goal.gain:
                    return (int)(calcDCR(weight, height, age) * GAIN_GOAL_CALORIES_INDEX * GAIN_GOAL_CARBOHYDRATES_INDEX / CARBOHYDRATES_EIN);
                default:
                    throw new ArgumentException();
            }
        }

    }
}
