using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Tweet
    {
        //Fields
        private static int recentId = 1;
        //Properties
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public string Category { get; set; }

        //Methods
        public Tweet(string from, string to, string message, string category)
        {
            From = from;
            To = to;
            Message = message;
            Category = category;
            Id = recentId;
            recentId++;
        }

        public override string ToString()
        {
            return $"From: {From}, To: {To}, Message: { (Message.Length<=20 ? Message : Message.Substring(0,20) + "...") }, Category: {Category}.";
        }

        public static Tweet Process(string line)
        {
            string[] lineValues = line.Split(new char[] {'\t'});
            Tweet tweetObject;
            try
            {
                tweetObject = new Tweet(lineValues[0], lineValues[1], lineValues[2], lineValues[3]);
            }
            catch (IndexOutOfRangeException)
            {
                tweetObject = new Tweet("Invalid", "Invalid", "Invalid", "Invalid");
            }
            return tweetObject;
        }
    }
}
