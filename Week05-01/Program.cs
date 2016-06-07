using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_01
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        // public static List<Card> Deck = new List<Card>();
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            //create instance of the Student class
            Student tommy = new Student("Tommy", 20, "S123456789");
            tommy.SaysHello();

            Console.WriteLine();

            tommy.Studies();

            tommy.Courses.Add(new Course("COMP123", "Programming 2"));
            tommy.Courses.Add(new Course("COMP125", "Client-Side Web Development"));
            tommy.Courses.Add(new Course("COMP397", "web game programming"));

            //Console.WriteLine(tommy.Courses);
            tommy.ShowCourses();

            Console.WriteLine();

            // create instance of the Teacher class
            Teacher tom = new Teacher("Tom", 47, "T123456789");

            tom.SaysHello();

            Console.WriteLine();

            tom.Teaches();

            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("mary");
            names.Add("ruthvik");

            int count = 0;
            foreach (string name in names)
            {
                Console.WriteLine(name);
                count++;
            }

            List<Card> Deck = new List<Card>();
            CreateDeck(Deck)
        }



        public static void CreateDeck(string hello)
        {

        }
    }


}
