using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videostore
{
    internal class Video
    {
        private bool isRented = false;
        private List<int> ratings = new List<int>();
        public string Title { get; set; }
        public bool IsRented { get => isRented; set => isRented = value; }
        public List<int> Ratings { get => ratings; set => ratings = value; }


        public Video(string title)
        {
            Title = title;

        }

        public void RentedOut()
        {

            IsRented = true;
        }
        public void Returned()
        {
            IsRented = false;
        }
        public void ReceivingRating(int rating)
        {
            if (rating > 5 || rating < 0)
            {
                throw new ArgumentException("Az értékelés 1 és 5 között kell legyen!!");
            }
            else
            {
                ratings.Add(rating);
            }


        }
        public string AvgRatings()
        {
            int counter = 0;          
            double avg = 0;
            StringBuilder sb = new StringBuilder();
            if (ratings.Count <= 4)
            {
                foreach (var rating in ratings)
                {
                    counter += rating;
                   // Console.Write(sb.Append(rating).Append(","));

                }
                avg = counter / (double)ratings.Count;
            }
            else
            {
                foreach (var rating in ratings)
                {
                    counter += rating;
                   // Console.Write(sb.Append(rating).Append(","));
                }
                
                avg = (counter - ratings.Min() - ratings.Max()) / ((double)ratings.Count-2);
            }
            return avg.ToString();
        }

        public override string? ToString()
        {
            return $"Name: {Title}, Isrented: {isRented}, AvgRating: {AvgRatings()} ";
        }
    }
}
