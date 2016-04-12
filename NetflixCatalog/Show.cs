using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
     public class Show : Title
    {


        List<Episode> FamilyGuyEpisodes = new List<Episode>();
        List<Episode> ScoobyDooEpisodes = new List<Episode>();
        List<Episode> NarutoEpisodes = new List<Episode>();

        public Show(string Name, int Rating)
        {
            
            titleName = Name;
            rating = Rating;
            
        }

        public override string ToString()
        {
            return string.Format("[{0}, Total episodes: {1}]",titleName, 5);
        }

        public override void Rating()
        {

            

        }
        

        

        public void AddFamilyGuyEpisodes()
        {
            
            Episode episode1 = new Episode(5);
            FamilyGuyEpisodes.Add(episode1);

            Episode episode2 = new Episode(4);
            FamilyGuyEpisodes.Add(episode2);

            Episode episode3 = new Episode(5);
            FamilyGuyEpisodes.Add(episode3);

            Episode episode4 = new Episode(5);
            FamilyGuyEpisodes.Add(episode4);

            Episode episode5 = new Episode(5);
            FamilyGuyEpisodes.Add(episode5);
        }

        public void AddScoobyDooEpisodes()
        {
            
            Episode episode1 = new Episode(5);
            ScoobyDooEpisodes.Add(episode1);

            Episode episode2 = new Episode(4);
            ScoobyDooEpisodes.Add(episode2);

            Episode episode3 = new Episode(5);
            ScoobyDooEpisodes.Add(episode3);

            Episode episode4 = new Episode(5);
            ScoobyDooEpisodes.Add(episode4);

            Episode episode5 = new Episode(5);
            ScoobyDooEpisodes.Add(episode5);
        }

        public void AddNarutoEpisodes()
        {
            
            Episode episode1 = new Episode(5);
            NarutoEpisodes.Add(episode1);

            Episode episode2 = new Episode(4);
            NarutoEpisodes.Add(episode2);

            Episode episode3 = new Episode(5);
            NarutoEpisodes.Add(episode3);

            Episode episode4 = new Episode(5);
            NarutoEpisodes.Add(episode4);

            Episode episode5 = new Episode(5);
            NarutoEpisodes.Add(episode5);
        }

    }
}
