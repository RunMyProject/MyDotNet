using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlayTennis.Areas.HelpPage.Models
{
    public class GameModel
    {
        private static readonly Random getrandom = new Random();

        private int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public IEnumerable<string> GetPlayTheGame()
        {

            List<string> list = new List<string>();

            string[] points = new string[4] { "love", "fifteen", "thirty", "forty" };

            bool endGame = false;

            int count_one = 0;
            int count_two = 0;

            list.Add("Player One Vs Player Two");

            while (!endGame)
            {
                int playerWon = GetRandomNumber(0, 2);

                if (playerWon == 0)
                {
                    count_one++;
                }

                if (playerWon == 1)
                {
                    count_two++;
                }

                list.Add("table points: " + points[count_one] + " - " + points[count_two]);

                if (count_one == count_two) list.Add("deuce");
                if (count_one > count_two)  list.Add("adv. player one");
                if (count_two > count_one)  list.Add("adv. player two");

                if (count_one >= 3 || count_two >= 3)
                {
                    endGame = true;

                    if (count_one > count_two) list.Add("player one won");
                    if (count_two > count_one) list.Add("player two won");

                    return list;
                }
            }

            return list;
        }

    }
}
