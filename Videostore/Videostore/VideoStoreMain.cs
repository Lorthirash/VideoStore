using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videostore
{
    internal class VideoStoreMain
    {
        static void Main(string[] args)
        {
            

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            VideoStore videoStore = new VideoStore();

            videoStore.AddVideo("Lord of the Rings");
            videoStore.AddVideo("Matrix");
            videoStore.AddVideo("Game of thrones");
            videoStore.AddVideo("Interstellar");
            videoStore.AddVideo("Schindler List");

            //videoStore.ListInventory();

            videoStore.ReceiveRating("Matrix", 1);
            videoStore.ReceiveRating("Matrix", 2);
            videoStore.ReceiveRating("Matrix", 4);

            videoStore.ReceiveRating("Lord of the Rings", 5);
            videoStore.ReceiveRating("Lord of the Rings", 4);
            videoStore.ReceiveRating("Lord of the Rings", 1);
            videoStore.ReceiveRating("Lord of the Rings", 4);
            videoStore.ReceiveRating("Lord of the Rings", 4);
            videoStore.ReceiveRating("Lord of the Rings", 4);
            videoStore.ReceiveRating("Lord of the Rings", 3);
            videoStore.ReceiveRating("Lord of the Rings", 2);
            
           

            videoStore.RentVideo("Matrix");

          //  videoStore.RentVideo();

            Console.WriteLine();
            videoStore.ListInventory();
        }
    }
}
