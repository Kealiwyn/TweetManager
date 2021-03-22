using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays all Tweets
            TweetManager.ShowAll();

            //Displays tweets with category tag
            Console.Write("Please type a tweet category: ");
            string myCategory = Console.ReadLine();
            TweetManager.ShowAll(myCategory);

            //Convert txt file to json.
            TweetManager.ConvertToJSON();
        }
    }
}
