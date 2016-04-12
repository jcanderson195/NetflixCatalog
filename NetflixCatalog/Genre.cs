using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{

    public class Genre : IEnumerable
    {
        public List<Title> Titles;

        public string genreName;

       
        public Genre(string Name)
        {
            genreName = Name;
            Titles = new List<Title>();
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Titles");

            for (int i = 0; i < Titles.Count; i++)
            {
                yield return Titles[i];
                yield return "";
                yield return "\n";
            }
            yield return "No More Titles";
        }


        public static Genre operator +(Genre a, Genre b)
        {
            Genre newGenre = new Genre(a.genreName + b.genreName);

            foreach (Title title in a.Titles)
            {
                newGenre.Titles.Add(title);
            }

            foreach (Title title in b.Titles)
            {
                newGenre.Titles.Add(title);
            }


            return newGenre;
        }


        public static Genre operator +(Genre a, Title b)
        {
            Genre newGenre = new Genre(a.genreName + b.titleName);

            foreach (Title title in a.Titles)
            {
                newGenre.Titles.Add(title);
            }
           
                newGenre.Titles.Add(b);
           
            return newGenre;
        }





    }
}
    


