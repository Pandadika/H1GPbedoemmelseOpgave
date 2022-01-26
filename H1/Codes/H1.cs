using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Codes
{
    internal class H1 : IHovedForloeb
    {
        public static readonly DateTime Start = new(2022, 1, 17);
        public static readonly DateTime Slut = new(2022, 2, 19);

        public object[,] skole {get; private set; } 

        public H1() //Initialisering
        {
            skole = new object[3,4]; // string string List array

            
            List<Student> eleverProg = new List<Student>() {
                new Student(1, 38900425, "Albert", "Arnesen"),
                new Student(2, 07583504, "Bente", "Bertilsen"),
                new Student(3, 10942421, "Charlie", "XCX")
            };
            List<Student> eleverData = new List<Student>() {
                new Student(4, 69775024, "Dorit", "Daller"),
                new Student(5, 02652858, "Emma", "Emmerich"),
                new Student(6, 41753042, "Fare", "Farquat")
            };
            List<Student> eleverStudie = new List<Student>() {
                new Student(7, 38661535, "Gemma", "Github"),
                new Student(8, 74241907, "Henrietta", "Henriksen"),
                new Student(9, 03039048, "Ida", "Idun")
            };


            int[] ugeNrProg = new[] { 3, 4 };
            int[] ugeNrData = new[] { 5 };
            int[] ugeNrStudie = new[] { 6 };

            skole[0, 0] = "Grundliggende Programmering";
            skole[0, 1] = "Niels";
            skole[0, 2] = eleverProg;
            skole[0, 3] = ugeNrProg;

            skole[1, 0] = "Database Programmering";
            skole[1, 1] = "Henrik";
            skole[1, 2] = eleverData;
            skole[1, 3] = ugeNrData;

            skole[2, 0] = "Studie Teknik";
            skole[2, 1] = "John";
            skole[2, 2] = eleverStudie;
            skole[2, 3] = ugeNrStudie;


        }

        public List<string> Search(string input, SearchCriteria criteria) // retunere en 1-dimension List med navne
        {
            input = input.Trim().ToLower();
            List<string> found = new List<string>();
            switch (criteria)
            {
                case SearchCriteria.Fag:
                    for (int i = 0; i <= 2; i++)
                    {
                        if (input == ((string)skole[i, 0]).ToLower())
                        {
                            found.Add("Lærer: " + (string)skole[i, 1] + ". Elever: ");
                            foreach (var item in ((List<Student>)skole[i,2]))
                            {
                                found.Add(item.ForNavn + " " + item.EfterNavn +", ");
                            }
                            DbOutput dbOutput = new(found);
                            return dbOutput.Output();
                        }
                    }
                    break;
                case SearchCriteria.Laere:
                    for (int i = 0; i <= 2; i++)
                    {
                        if (input == ((string)skole[i, 1]).ToLower())
                        {
                            found.Add("Fag: " + (string)skole[i, 0] + ". Elever: ");
                            foreach (var item in ((List<Student>)skole[i, 2]))
                            {
                                found.Add(item.ForNavn + " " + item.EfterNavn + ", ");
                            }
                            DbOutput dbOutput = new(found);
                            return dbOutput.Output();
                        }
                    }
                    break;
                case SearchCriteria.Elev:
                    for (int i = 0; i <= 2; i++)
                    {
                        foreach (var item in (List<Student>)skole[i, 2])
                        {
                            if (input == item.ForNavn.ToLower() || input == item.EfterNavn.ToLower())
                            {
                                found.Add("Fag: " + (string)skole[i, 0] + ". Lære: " + (string)skole[i, 1]);
                                DbOutput dbOutput = new(found);
                                return dbOutput.Output();
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            found.Add("Søgning gav intet resultat");
            return found;
        }



    }
}
