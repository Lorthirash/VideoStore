using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videostore
{
    internal class VideoStore
    {
        private List<Video> videos = new List<Video>();
        private List<Customer> customers = new List<Customer>();

        internal List<Video> Videos { get => videos; set => videos = value; }
        internal List<Customer> Customers { get => customers; set => customers = value; }

        public void AddVideo(string title)
        {
            videos.Add(new Video(title));
        }
        public void RentVideo(string title)
        {
            foreach (var video in videos)
            {
                if (video.Title.Equals(title))
                {
                    video.RentedOut();
                }
            }
          
        }
        public void ReturnVideo(string title)
        {
            foreach (var video in videos)
            {
                if (video.Title.Equals(title))
                {
                    video.Returned();
                }
            }

        }
        public void ReceiveRating(string title, int rating)
        {
            foreach (var video in videos)
            {
                if (video.Title.Equals(title))
                {
                    video.ReceivingRating(rating);
                }
            }

        }
        public void ListInventory()
        {
            foreach (Video video in videos)
            {
                Console.WriteLine(video);
            }
        }

        public void enrollCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void SuggestVideo()
        {

        }
    }
}
