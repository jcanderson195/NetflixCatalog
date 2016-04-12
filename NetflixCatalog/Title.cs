using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
     public class Title
    {
        public string titleName;
        public int time;
        public int rating;
        public string genre;
        

        public Title(string Name, int Rating, int Time)
        {
            
            titleName = Name;
            rating = Rating;
            time = Time;
        }

        public Title()
        {
          titleName = null;
          
        }

        public virtual void Rating()
        {
            
        }

        public static Genre operator +(Title a, Title b)
        {
            Title title = new Title();
            Genre newGenre = new Genre(a.titleName + b.titleName);

            
                      
            return newGenre;
        }



    }



}
