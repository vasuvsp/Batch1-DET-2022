using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Batch1_DET_2022
{
    internal class Learning_Linq1
    {
        public static void Main()
        {
            //Projection_select();
            ////Ordering
            //orderby();
            //OrderByDescending();
            //Reverse();
            //ThenBy();
            //ThenByDescending();
            ////Partitioning
            //skip();
            //skipWhile();
            //Take();
            //TakeWhile();
            ////Aggreagation
            //Average();
            //Count();
            //Min();
            //Max();
            //Sum();
            ////set
            //Distinct();
            //Except();
            //Intersect();
            //Union();
            ////Element
            //ElementAt(); 
            //ElementAtOrDefault();

            ////Quantifiers
            //All();
            //Any();
            //Contains();
            //Names_Groupby();
            Names_Groupby_lenght();












        }
        public static void Projection_select()
        {   //1 Query Source 
            List<string> Names = new List<string>();
            Names.Add("vasu");
            Names.Add("jeevan");
            Names.Add("Bharath");

            //2 Query Creation 
            var namesQuery = Names.Select(x => x);

            //3 Query Execution
            foreach (string name in namesQuery)
            {
                Console.WriteLine(name);

            }

        }

        public static void orderby()
        {
            int[] Numbers = { 7, 8, 9, 10, 20, 22, 13, 26, 15, 16, 17, 18, };
            var result = Numbers.OrderBy(x => x);
            Console.WriteLine("Ordered Listr of Numbers:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        public static void OrderByDescending()
        {
            int[] Numbers1 = { 9, 12, 60, 20, 30, 6, 7, 8, 2, 61, 2 };
            var result1 = Numbers1.OrderByDescending(x => x);
            Console.WriteLine("Ordered descending  List of Numbers:");
            foreach (int number1 in result1)
                Console.Write(number1);

        }
        public static void Reverse()
        {
            int[] Numbers2 = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, };
            var result2 = Numbers2.Reverse();
            Console.WriteLine("Ordered Listr of Numbers:");
            foreach (int number2 in result2)
                Console.Write(number2);
        }
        public static void ThenBy()
        {
            string[] capitals = { "Benglauru", "Chennai", "Srinagar", "Kolkatha", "Delhi",
                          "Mumbai", "Kochi", "Hyderbad" };

            var result3 = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result3)

                Console.WriteLine(capitals);
        }
        public static void ThenByDescending()
        {
            var dates = new DateTime[] {
            new DateTime(2015, 3, 1),
            new DateTime(2014, 7, 1),
            new DateTime(2013, 5, 1),
            new DateTime(2015, 1, 1),
            new DateTime(2015, 7, 1)
            };

            var result4 = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result4)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }

        public static void skip()
        {
            string[] Names = { "vasu", "Jeevan", "Bharath", "Vishwaa", "Abhi" };

            var result = Names.Skip(2);

            Console.WriteLine("Skip the first 2Names");
            foreach (string Name in result)
                Console.WriteLine(Name);
        }
        public static void skipWhile()
        {
            string[] Names1 = { "vasu", "Jeevan", "Bharath", "Vishwaa", "Abhi" };

            var result1 = Names1.SkipWhile(x => x.Length == 3);

            Console.WriteLine("Skip the first 3Names");
            foreach (string Name1 in result1)
                Console.WriteLine(Name1);
        }
        public static void Take()
        {
            string[] Names2 = { "vasu", "Jeevan", "Bharath", "Vishwaa", "Abhi" };

            var result2 = Names2.Take(6);

            Console.WriteLine("Skip the first 3Names");
            foreach (string Name2 in result2)
                Console.WriteLine(Name2);
        }
        public static void TakeWhile()
        {
            int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result3 = numbers3.TakeWhile(n => n < 5);

            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number3 in result3)
                Console.WriteLine(number3);
        }

        public static void Average()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Debug.WriteLine("Average is:");
            Debug.WriteLine(result);
        }
        public static void Count()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

            var result = names.Count();

            Debug.WriteLine("Counting names gives:");
            Debug.WriteLine(result);
        }
        public static void Min()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }
        public static void Max()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Max();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }
        public static void Sum()
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }

        public static void Distinct()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        public static void Except()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        public static void Intersect()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        public static void Union()
        {


            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        public static void ElementAt()
        {
            string[] words = { "One", "Two", "Three" };

            var result = words.ElementAt(1);

            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);
        }
        public static void ElementAtOrDefault()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }

        public static void All()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        public static void Any()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        public static void Contains()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }

        public static void Names_Groupby()
        {
            List<string> Names = new List<string> { "Basket", "Blueberry", "Chimpanze", "Abacus", "banana", "Apple", "Cheese" };
            var nameGroups = Names.GroupBy(x => x[0]).Select
                (y => new { FirstLetter = y.Key, Words = y });
            foreach (var item in nameGroups)
            {
                Console.WriteLine("Words that start with the" +
                    "letter'{0}':", item.FirstLetter);
                foreach(var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
        public static void Names_Groupby_lenght()
        {
            List<string> Names = new List<string> { "Basket", "Blueberry", "Chimpanze", "Abacus",
                "banana", "Apple", "Cheese" };
            var nameGroups = Names.GroupBy(x => x.Length).Select
                (y => new { FirstLetter = y.Key, Words = y });
            foreach (var item in nameGroups)
            {
                Console.WriteLine("Words that start with the" +
                    "letter'{0}':", item.FirstLetter);
                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
