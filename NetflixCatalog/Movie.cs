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


        
    }
}
