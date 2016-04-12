using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
   public class Catalog 
    {
       public Genre all;
       public Genre action;
       public Genre comedy;
       public Genre romance;

        public  Catalog()
        {
            all = new Genre("All");
            action = new Genre("Action");
            comedy = new Genre("Comedy");
            romance = new Genre("Romance");
        }

        
        public void AddMovieTitlesToAction()
        {
            action.Titles.Add(new Title("Spider Man",3,121));
            action.Titles.Add(new Title("300",4,117));

            Console.WriteLine("Titles Under Action genre");
            foreach (Title name in action.Titles)
            {
                
                Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time)); 
                
            }
        }

        public void AddMovieTitlesToComedy()
        {
            comedy.Titles.Add(new Title("Rush Hour 3",3 ,91));
            comedy.Titles.Add(new Title("Frozen", 5,102));

            Console.WriteLine("Titles Under Comedy genre");
            foreach (Title name in comedy.Titles)
            {

                Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time));
            }
        }

        public void AddMovieTitlesToRomance()
        {
            romance.Titles.Add(new Title("The Note Book",5 ,102));
            romance.Titles.Add(new Title("Definitely Maybe", 4, 112));

            Console.WriteLine("Titles Under Romance genre");
            foreach (Title name in romance.Titles)
            {

                Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time));
            }
        }


        public void AddMovieTitlesToAll()
        {
            all.Titles.Add(new Title ("Spider Man",3 ,121));
            all.Titles.Add(new Title("Rush Hour 3", 3,91));
            all.Titles.Add(new Title("Frozen", 5,102));
            all.Titles.Add(new Title("The Note Book", 5,102));
            all.Titles.Add(new Title("Definitely Maybe",4 ,112));
            all.Titles.Add(new Title("300", 4,117));

            Console.WriteLine("All available movie titles");
            foreach (Title name in all.Titles)
            {

                Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time));
            }
        }

        public void AddShowTitlesToAll()
        {
            
            all.Titles.Add(new Title("Naruto",5, 30));

            
            all.Titles.Add(new Title("Scooby Doo", 4, 30));
            all.Titles.Add(new Title("Family Guy", 5, 30));

            Console.WriteLine("All available show titles");
            foreach (Title name in all.Titles)
            {

                Console.WriteLine(string.Format("[Show: {0}, Total episodes: {1}]", name.titleName, 5));
            }
        }

        public void AddShowTitleToAction()
        {
            action.Titles.Add(new Title("Naruto", 5, 30));

            Console.WriteLine("Titles Under Action genre");
            foreach (Title name in action.Titles)
            {

                Console.WriteLine(string.Format("[Show: {0}, Total episodes: {1}]", name.titleName, 5));
            }
        }

        public void AddShowTitleToComedy()
        {
            comedy.Titles.Add(new Title("Scooby Doo", 4, 30));
            comedy.Titles.Add(new Title("Family Guy", 5, 30));

            Console.WriteLine("Titles Under Comedy genre");
            foreach (Title name in comedy.Titles)
            {

                Console.WriteLine(string.Format("[Show: {0}, Total episodes: {1}]", name.titleName, 5));
            }
        }


        public void DisplayAllTitles()
        {
            AddMovieTitlesToAll();

        }

        public void DisplayActionTitles()
        {
            AddMovieTitlesToAction();

        }

        public void DisplayComedyTitles()
        {
            AddMovieTitlesToComedy();

        }

        public void DisplayRomanceTitles()
        {
            AddMovieTitlesToRomance();

        }

        public void ChooseYourGenreShow()
        {
            Console.WriteLine("What show genre would you like to view?");
            Console.WriteLine("1.All");
            Console.WriteLine("2.Action");
            Console.WriteLine("3.Comedy");
            Console.WriteLine("-------------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                AddShowTitlesToAll();
            }
            else if (choice == 2)
            {
                AddShowTitleToAction();
            }
            else if (choice == 3)
            {
                AddShowTitleToComedy();
            }
            else
            {
                Console.WriteLine("Sorry I don't recognize that command. Please enter the numerical value associated with your choice.");
                Console.WriteLine("-------------------");
                ChooseYourGenreShow();
            }
        }

        public void ChooseYourGenreMovie()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("What movie genre would you like to view?");
            Console.WriteLine("1.All");
            Console.WriteLine("2.Action");
            Console.WriteLine("3.Comedy");
            Console.WriteLine("4.Romance");
            Console.WriteLine("-------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                DisplayAllTitles();
            }
            else if (choice == 2)
            {
                DisplayActionTitles();
                MultiGenreSearchAction();
            }
            else if (choice == 3)
            {
                DisplayComedyTitles();
                MultiGenreSearchComedy();
            }
            else if (choice == 4)
            {
                DisplayRomanceTitles();
                MultiGenreSearchRomance();
            }
            else
            {
                Console.WriteLine("Sorry I don't recognize that command. Please enter the numerical value associated with your choice.");
                Console.WriteLine("-------------------");
                ChooseYourGenreMovie();
            }
        }

        public void MultiGenreSearchAction()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Would you like to narrow your search with another genre?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            Console.WriteLine("----------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Based on our movie selections these are the available genre option(s)");
                Console.WriteLine("1. Comedy");
                Console.WriteLine("2.Romance");
                Console.WriteLine("-------------");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {
                    Genre action = new Genre("Action");
                    Genre comedy = new Genre("Comedy");
                    Genre ActionComedy = action + comedy;

                    ActionComedy.Titles.Add(new Title("Rush Hour 3", 3, 91));

                    Console.WriteLine("Title(s) available under Action Comedy");

                    foreach (Title name in ActionComedy.Titles)
                    {

                        Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time));
                    }

                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Sorry, there are no movies under the genre Action Romance.");
                    Console.WriteLine("---------------------");
                    MultiGenreSearchAction();
                }
            }
            else if (choice == 2)
            {
                SystemOperation startMenu = new SystemOperation();
                startMenu.Start();
            }
        }

        public void MultiGenreSearchComedy()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Would you like to narrow your search with another genre?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            Console.WriteLine("----------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Based on our movie selections these are the available genre option(s)");
                Console.WriteLine("1. Romance");
                Console.WriteLine("2.Action");
                Console.WriteLine("-------------");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {
                    Genre romance = new Genre("Romance");
                    Genre comedy = new Genre("Comedy");
                    Genre RomanticComedy = romance + comedy;

                    RomanticComedy.Titles.Add(new Title("Frozen", 5, 102));
                    RomanticComedy.Titles.Add(new Title("Definitely Maybe", 4, 112));

                    Console.WriteLine("Title(s) available under Romantic Comedy");

                    foreach (Title name in RomanticComedy.Titles)
                    {

                        Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time));
                    }

                }
                else if (choice2 == 2)
                {
                    Genre action = new Genre("Action");
                    Genre comedy = new Genre("Comedy");
                    Genre ActionComedy = action + comedy;

                    ActionComedy.Titles.Add(new Title("Rush Hour 3", 3, 91));

                    Console.WriteLine("Title(s) available under Action Comedy");

                    foreach (Title name in ActionComedy.Titles)
                    {

                        Console.WriteLine(string.Format("[Show: {0}, Time: {1} minutes]", name.titleName, name.time));
                    }
                }
            }
            else if (choice == 2)
            {
                SystemOperation startMenu = new SystemOperation();
                startMenu.Start();
            }
        }

        public void MultiGenreSearchRomance()

        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Would you like to narrow your search with another genre?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            Console.WriteLine("----------------");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Based on our movie selections these are the available genre option(s)");
                Console.WriteLine("1. Comedy");
                Console.WriteLine("2.Action");
                Console.WriteLine("-------------");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {
                    Genre romance = new Genre("Romance");
                    Genre comedy = new Genre("Comedy");
                    Genre RomanticComedy = romance + comedy;

                    RomanticComedy.Titles.Add(new Title("Frozen", 5, 102));
                    RomanticComedy.Titles.Add(new Title("Definitely Maybe", 4, 112));

                    Console.WriteLine("Title(s) available under Romantic Comedy");

                    foreach (Title name in RomanticComedy.Titles)
                    {

                        Console.WriteLine(string.Format("[Movie: {0}, Time: {1} minutes]", name.titleName, name.time));
                    }

                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Sorry, there are no movies under the genre Action Romance.");
                    Console.WriteLine("---------------------");
                    MultiGenreSearchAction();
                }
            }
            else if (choice == 2)
            {
                SystemOperation startMenu = new SystemOperation();
                startMenu.Start();
            }
        }
    }
    }
