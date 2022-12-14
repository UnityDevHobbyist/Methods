using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        // declarations
        static int score;
        static int health;
        static void Main(string[] args)
        {
            string studio_name;
            studio_name = "Big Games";
            string game_title;
            game_title = "Collectors";
            int score;
            score = 0;
            int hp;
            hp = 100;
            int lives;
            lives = 3;
            float score_multiplier;
            score_multiplier = 1.0f;
            int shield;
            shield = 50;
            int current_xp;
            current_xp = 0;

            void ShowHUD()
            {
                Console.WriteLine("Studio Name: " + studio_name + " | Score: " + score + " | Game Title: " + game_title + " | Health: " + hp + " | Lives: " + lives +
                    " | Score Multiplier: " + score_multiplier + " | Shield: " + shield);
                Console.WriteLine("Xp: " + current_xp);
            }

            void TakeDamage(int damage)
            {
                int storeHealth = hp;
                int newValue = hp -= damage;
                Console.WriteLine("Player's health has changed from " + storeHealth + " to " + newValue);
            }

            void AddScore(int pointsEarned, float scoreMultiplier)
            {
                int newScore = pointsEarned *= (int)scoreMultiplier;
                int Score = score += newScore;
                Console.WriteLine("Player's score is now " + Score);
            }

            void AddXp(int xp)
            {
                current_xp += xp;
                Console.WriteLine("Player's xp is now " + current_xp);
            }

            ShowHUD();
            TakeDamage(10);
            AddScore(100, 2.0f);
            AddXp(10);
            AddXp(30);

            Console.WriteLine("Methods:");
            Console.WriteLine();

            // initializations
            score = 0;
            health = 100;

            ShowHUD2(); // usage

            // earn points
            score = score + 500;
            // get hurt
            health = health - 10;

            ShowHUD2(); // usage

            // earn points
            score = score + 50;
            // get hurt
            health = health - 25;

            ShowHUD2(); // usage

            // earn points
            score = score + 0;
            // get hurt
            health = health - 5;

            ShowHUD2();

            Heal(5);

            ShowHUD2();

            FullRestore();

            ShowHUD2();

            Console.ReadKey(false);
        }
        static void ShowHUD2() // declaration
        {
            // display HUD
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
        }
        static void FullRestore()
        {
            health = 100;
        }
        static void Heal(int healamount)
        {
            health = health + healamount;
        }
    }
}