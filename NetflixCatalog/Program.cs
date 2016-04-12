using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Program
    {
        static void Main(string[] args)
        {


            //Genre action = new Genre("action");
            //Genre comedy = new Genre("comedy");

            //Genre actionComedy = action + comedy;
            //Console.WriteLine(actionComedy.genreName);


            //Catalog test = new Catalog();

            //test.AddMovieTitlesToAction();
            //test.AddMovieTitlesToAll();
            //test.AddMovieTitlesToComedy();
            //test.AddMovieTitlesToRomance();

            //foreach (Genre name in test.all)
            //{
            //    Console.WriteLine(name);
            //}

            //Catalog movieSelection = new Catalog();
            //movieSelection.ChooseYourGenreMovie();
            //Console.ReadLine();

            SystemOperation startMenu = new SystemOperation();
            startMenu.Start();


        }
    }
}
