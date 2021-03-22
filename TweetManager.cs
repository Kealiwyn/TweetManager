using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment03
{
    class TweetManager
    {
        //Fields
        private static Tweet[] tweets;
        private static string fileName = "tweets.txt";

        //Methods
        static TweetManager()
        {
            StreamReader reader = new StreamReader(fileName);
            tweets = new Tweet[File.ReadAllLines(fileName).Length];

            string line = reader.ReadLine();
            int arrayPosition = 0;
            while (line != null)
            {
                tweets.SetValue(Tweet.Process(line), arrayPosition);
                arrayPosition++;
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public static void ShowAll()
        {
            foreach (Tweet t in tweets)
            {
                Console.WriteLine(t);
            }
        }

        public static void ShowAll(string category)
        {
            bool tweetFound = false;
            foreach(Tweet t in tweets)
            {
                if(t.Category == category)
                {
                    Console.WriteLine(t);
                    tweetFound = true;
                }
            }
            if(!tweetFound) Console.WriteLine("No tweets with matching category found!");
        }

        public static void ConvertToJSON()
        {
            StreamWriter writer = new StreamWriter("tweets.json");

            foreach(Tweet t in tweets)
            {
                string jsonString = JsonSerializer.Serialize(t);
                writer.WriteLine(jsonString);
            }
            writer.Close();
        }
    }
}
