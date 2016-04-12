using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
   public class Movie : Title
    {


        

        public Movie(string Name ,int Time)
        {
            titleName = Name;
            time = Time;
            
        }

        public override string ToString()
        {
            return string.Format("[{0}, Time: {1} minutes]",titleName , time);
        }


        //public Movie SpiderMan()
        //{
        //    Movie movie = new Movie("Spider Man", 121);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Action
        //}

        //public Movie RushHour3()
        //{
        //    Movie movie = new Movie("Rush Hour 3", 91);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Action Comedy
        //}

        //public Movie Movie300()
        //{
        //    Movie movie = new Movie("300", 117);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Action
        //}

        //public Movie TheNoteBook()
        //{
        //    Movie movie = new Movie("The Note Book", 123);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Romance
        //}

        //public Movie ThePunisher()
        //{
        //    Movie movie = new Movie("The Punisher", 124);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Action
        //}

        //public Movie Frozen()
        //{
        //    Movie movie = new Movie("Frozen", 102);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Comedy
        //}

        //public Movie KillBill()
        //{
        //    Movie movie = new Movie("Kill Bill: Vol. 1", 111);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Action
        //}

        //public Movie DefinitelyMaybe()
        //{
        //    Movie movie = new Movie("Definitely, Maybe", 112);
        //    Console.WriteLine(movie);

        //    return movie;
        //    //Romantic Comedy
        //}
    }
}
