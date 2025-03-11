using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects_HT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            library lib = new library();

            while (true)
            {
                Console.WriteLine("\t------------------");
                Console.WriteLine("\t||     MENU     ||");
                Console.WriteLine("\t------------------");
                Console.WriteLine("Please Select Option (1-2)\n1. Library Managment\n2. School Managment or Press 0 to Exit:");
                int sel;
                try
                {
                    sel = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Please enter a number.");
                    continue;
                }
                if (sel == 0)
                {
                    Console.WriteLine("Exited!");
                    break;
                }
                switch (sel)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Option 1 selected.");
                        Console.WriteLine("Enter How many Books Do You want to Enter: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < num; i++)
                        {
                            book newBook = new book();
                            Console.WriteLine("Enter the Title of Book:");
                            newBook.Title = Console.ReadLine();
                            Console.WriteLine("Enter the Author of Book:");
                            newBook.Auther = Console.ReadLine();
                            Console.WriteLine("Enter the Genre of Book:");
                            newBook.Genre = Console.ReadLine();
                            Console.WriteLine("Enter the Publication Year of Book:");
                            newBook.PubYear = Convert.ToInt32(Console.ReadLine());
                            lib.Add(newBook);
                        }

                        lib.list();

                        Console.WriteLine("Enter the Title, Genre, or Author of the book to Search: ");
                        string name = Console.ReadLine();
                        lib.Search(name);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Option 2 selected.");
                        Console.WriteLine("Enter how many students you want to enter: ");

                        int num1 = Convert.ToInt32(Console.ReadLine());
                        School s1 = new School("Kips School", "D-Ground", num1);

                        Teacher t1 = new Teacher(1180, "Ali", "English");
                        Teacher t2 = new Teacher(1198, "Talha", "OOP");

                        int[] ID = new int[num1];
                        string[] name2 = new string[num1];

                        for (int i = 0; i < num1; i++)
                        {
                            Console.WriteLine("Enter the ID of Student:");
                            ID[i] = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the Name of Student:");
                            name2[i] = Console.ReadLine();
                        }

                        Student[] newstu = new Student[num1];

                        for (int i = 0; i < num1; i++)
                        {
                            newstu[i] = new Student(ID[i], name2[i]);
                            s1.AddStu(newstu[i]);
                        }
                        Console.WriteLine($"Enter The Grades for Sir{t1.getTname()}");
                        for (int i = 0; i < num1; i++)
                        {
                            Console.WriteLine($"Enter the grade of {newstu[i].getname()}:");
                            int grade = Convert.ToInt32(Console.ReadLine());

                            t1.AssignGrade(newstu[i], grade);
                        }
                        Console.WriteLine($"Enter The Grades for Sir{t2.getTname()}");
                        for (int i = 0; i < num1; i++)
                        {
                            Console.WriteLine($"Enter the grade of {newstu[i].getname()}:");
                            int grade = Convert.ToInt32(Console.ReadLine());

                            t2.AssignGrade(newstu[i], grade);
                        }

                        Console.WriteLine("All students have been added and graded successfully.");
                        Console.WriteLine("Press any Key to See the Average Marks of Each Student: ");
                        Console.ReadLine();
                        Console.WriteLine("The Average of All the Students is: ");
                        for (int i = 0; i < num1; i++)
                        {
                            Console.WriteLine($"The Average of Student {i + 1} is {newstu[i].CalAvg()}");
                        }
                        Console.WriteLine("Press any Key to See Info of School");
                        Console.ReadLine();
                        Console.WriteLine($"The Name of School is: {s1.getSchName()} and The Location of School is {s1.getLocation()}");
                        Console.WriteLine("Press any Key to See Info of All Students");
                        Console.ReadLine();
                        Console.WriteLine("The Data of All The Students is: ");
                        s1.display();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input! Please enter a number between 0-2.");
                        break;
                }
            }
        }
    }
}