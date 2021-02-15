using System;

namespace Battle_Arena_Dream_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int userStamina = 10;
            int userpanicLevel = 10;
            int enemyHitPoints = 10;

            int totalRolls = 10;
            int rollNumber = 0;

            while (rollNumber <= totalRolls) {
                
                int diceRoll = new Random().Next(1, 7);
                rollNumber = rollNumber + 1;

                Console.WriteLine($"Roll #{rollNumber}");
                
                if (diceRoll == 1) {
                    userpanicLevel = userpanicLevel - 2;
                } else if (diceRoll == 2) {
                    userStamina = userStamina - 1;
                } else if (diceRoll == 4) {
                    userStamina = userStamina + 1;
                } else if (diceRoll == 5) {
                    userpanicLevel = userpanicLevel - 1;
                    enemyHitPoints = enemyHitPoints - 3;
                } else if (diceRoll == 6) {
                    userpanicLevel = userpanicLevel - 3;
                    userStamina = userStamina + 2;
                    enemyHitPoints = enemyHitPoints - 5;
                } else {}
                
                Console.WriteLine($"You rolled {diceRoll}. Your panic level is: {userpanicLevel}. Your stamina is: {userStamina}. Your enemy's hit points are: {enemyHitPoints}.");

                if (rollNumber == totalRolls) {
                    userpanicLevel = 20;
                }
                        
                if (enemyHitPoints > 0) {
                    userStamina = userStamina - 1;
                    userpanicLevel = userpanicLevel + 1;
                    Console.WriteLine($"Your enemy has not died. Your panic level is now {userpanicLevel}. Your Stamina is now: {userStamina}.");
                } else if (enemyHitPoints <= 0) {
                    Console.WriteLine("Your enemy has died. A new enemy enters the dream.");
                    enemyHitPoints = 10;
                    rollNumber = 0;
                }
                
                if (userStamina <= 0 || userpanicLevel >= 20) {
                    Console.WriteLine("You have died.");
                    userStamina = 10;
                    userpanicLevel = 10;
                    enemyHitPoints = 10;
                    rollNumber = 0;
                }
            }
        }
    }
}
