using System;

namespace RPPOON_LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();
            int numberOfDice = 20;
            for (int i = 0; i < numberOfDice; i++)
            {
                //diceRoller.InsertDie(new Die(6, randomGenerator)); predaja generatora 2. zadatak
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            diceRoller.GetRollingResults();

            foreach (int result in diceRoller.GetRollingResults())
            {
                Console.WriteLine(result);
            }
        }
    }
}