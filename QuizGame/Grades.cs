using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTest
{
    // All methods and classes are highly secure for accessibility so
    // that the user cannot access unnecessary commands for him.
    // In This Class we give to Player Grades and He can choice a difficult
    internal class Grades
    {
        private int correct;
        private int choice;
        private int count;
        protected Grades()
        {
            this.correct = Correct;
            this.choice = Choice;
            this.count = Count;
        }
        protected int Correct
        {
          get { return correct; }
          set { correct = value; }
        }
        protected int Choice
        {
            get { return choice; }
            set { choice = value; }
        }
        protected int Count
        {
            get { return count; }
            set { count = value; }
        }

        // This Method Calculate Result and Give Grade
        protected void Result(int result)
        {
            if (result > 80)
            {
                Console.WriteLine(result + "%' Correct Answer");
                Console.WriteLine("You Grade is - Exellent ! Grade : 6");
            }
            else if (result > 55)
            {
                Console.WriteLine(result + "%' Correct Answer");
                Console.WriteLine("You Grade is - Very Good ! Grade : 5");
            }
            else if (result > 45)
            {
                Console.WriteLine( result + "%' Correct Answer");
                Console.WriteLine("You Grade is - Good ! Grade : 4");
            }
            else if (result > 35)
            {
                Console.WriteLine(result + "%' Correct Answer");
                Console.WriteLine("You Grade is - Low ! Grade : 3 ");
            }
            else
            {
               
                Console.WriteLine(result + "%' Correct Answer");
                Console.WriteLine( "You Grade is - Bad ! Grade : 2 ");
            }
        }
        // ResultPoint there Choice a difficult of gameplay and give you
        // for every correct answer a points
        protected void ResultPoints(int choice, int difficult)
        {
            if(difficult ==1)
            {

            
            while (count < 10)
            {
                if (count == 1)
                {
                    if (choice == 3)
                    {
                        correct += 10;
                        Console.WriteLine("Correct !");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }
                else if (count == 2)
                {
                    if (choice == 2)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }
                else if (count == 3)
                {
                    if (choice == 3)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }
                else if (count == 4)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }
                else if (count == 5)
                {
                    if (choice == 2)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }

                else if (count == 6)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }

                else if (count == 7)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }
                else if (count == 8)
                {


                    if (choice == 2)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }

                else if (count == 9)
                {
                    if (choice == 2)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                    }
                    break;
                }
                else if (count == 10)
                {
                    if (choice == 3)
                    {
                        Console.WriteLine("Correct !");
                        correct += 10;
                        Console.WriteLine("Click Any Botton");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect :(");
                        Console.WriteLine("Click Any Botton");
                    }
                    break;
                }
            }
            }
            
            else if (difficult == 2)
            {
                while (count < 11)
                {
                    if (count == 1)
                    {
                        if (choice == 3)
                        {
                            correct += 10;
                            Console.WriteLine("Correct !");

                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 2)
                    {
                        if (choice == 2)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 3)
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 4)
                    {
                        if (choice == 3)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 5)
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }

                    else if (count == 6)
                    {
                        if (choice == 2)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }

                    else if (count == 7)
                    {
                        if (choice == 3)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 8)
                    {


                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }

                    else if (count == 9)
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 10)
                    {
                        if (choice == 2)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                            Console.WriteLine("Click Any Botton");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                            Console.WriteLine("Click Any Botton");
                        }
                        break;
                    }
                }
            }
            else if (difficult == 3)
            {
                while (count < 10)
                {
                    if (count == 1)
                    {
                        if (choice == 1)
                        {
                            correct += 10;
                            Console.WriteLine("Correct !");

                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 2)
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 3)
                    {
                        if (choice == 3)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 4)
                    {
                        if (choice == 3)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 5)
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }

                    else if (count == 6)
                    {
                        if (choice == 3)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }

                    else if (count == 7)
                    {
                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 8)
                    {


                        if (choice == 1)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }

                    else if (count == 9)
                    {
                        if (choice == 3)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                        }
                        break;
                    }
                    else if (count == 10)
                    {
                        if (choice == 2)
                        {
                            Console.WriteLine("Correct !");
                            correct += 10;
                            Console.WriteLine("Click Any Botton");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect :(");
                            Console.WriteLine("Click Any Botton");
                        }
                        break;
                    }
                }
            }








        }

        




    }
}
