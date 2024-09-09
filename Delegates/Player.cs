using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Player
    {
        public int Points { get; set; }

        public delegate void AchievementUnlockedHandler(int points);

        public event AchievementUnlockedHandler? AchievementUnlocked;

        public async Task AddPoints(int points)
        {
            Points += points;
            Console.WriteLine($"Player earned {points} points. Total points {Points}");
            await Task.Delay( 1000 );

            if(Points >= 100)
            {
                AchievementUnlocked?.Invoke(Points);
            }
        }
    }
}
