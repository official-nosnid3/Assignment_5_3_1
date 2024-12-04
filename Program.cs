namespace Assignment_5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 5.3.1
             * 
             * You have a long flowerbed in which some of the plots are planted, 
             * and some are not. However, flowers cannot be planted in adjacent plots.
             * Given an integer array flowerbed containing 0's and 1's, where 0 means 
             * empty and 1 means not empty, and an integer n, return true if n new 
             * flowers can be planted in the flowerbed without violating the 
             * no-adjacent-flowers rule and false otherwise.
             * 
             * Example 1:
             * Input: flowerbed = [1,0,0,0,1], n = 1
             * Output: true
             * 
             * Example 2:
             * Input: flowerbed = [1,0,0,0,1], n = 2
             * Output: false
            */

            int[] flowerBed = { 0, 1, 0, 0, 0, 0, 0, 0, 1 };
            int canBePlantedAmount = 2;

            Console.Write( confirmCanBePlantedAmount(flowerBed, canBePlantedAmount) );
        }

        static bool confirmCanBePlantedAmount(int[] FlowerBed_, int Amount)
        {

            int plantedAmount = 0;
            int leftStep = 1; int rightStep = 1;

            for (int i = 0; i < FlowerBed_.Length; i++)
            {
                if (i == 0)
                    leftStep = 0;
                else leftStep = 1;
                
                if (i == FlowerBed_.Length - 1)
                    rightStep = 0;
                else rightStep = 1;
                
                if (FlowerBed_[i] == 0 && FlowerBed_[i - leftStep] == 0 && FlowerBed_[i + rightStep] == 0)
                {
                    FlowerBed_[i] = 1;
                    plantedAmount++;
                }

                if (plantedAmount ==  Amount)
                    return true;
            }

            return false;
        }
    }
}
