using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
     public class SystemOperation
    {
        public SystemOperation()
        {

        }

        public void Start()
        {
            Console.WriteLine("Welcome to Netflix");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("Are you watching a TV Show or a Movie today?");
            Console.WriteLine("1. Movie");
            Console.WriteLine("2. TV Show");

            MovieOrShow();

        }

        public void MovieOrShow()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Catalog movieSelection = new Catalog();
                movieSelection.ChooseYourGenreMovie();
            }
            else if (choice == 2)
            {
                Catalog showSelection = new Catalog();
                showSelection.ChooseYourGenreShow();
            }
            else
            {
                Console.WriteLine("Sorry I don't recognize that command. Please enter the number associated with your decision!");
                MovieOrShow();
            }
        }

    }
}
