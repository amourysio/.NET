using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTest
{
    // All methods and classes are highly secure for accessibility so
    // that the user cannot access unnecessary commands for him.
    //Every Class has a Relationship with Another Class cuz we can Accessability last class with all Method from other CLass
    // Here you can find Menu and Automatic Menu Access
    // Here we made Relationship from all Class and Print Results There is one Method GameStart who User can Use

    internal class Quiz : Person
    {
        private int opt1;
        public Quiz()
        {
            this.opt1 = Opt1;
        }
        protected int Opt1
        {
            get { return this.opt1; }
            set { this.opt1 = value; }
        }
        //I Made This Method for Print All Menu and Choice and etc.. cuz there no need Main Method coding
        //There have simply Exeption without stop game just show error messege.
        public void GameStart()
        {
            FirstMenu();
            Console.ReadLine();
            do
            {
                Console.Clear();
                SecondMenu();
                
                try
                {
                Opt1 = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }
                switch (Opt1)
                {
                    case 1:
                        Console.Clear();
                        AddNickName();
                        PrintQuest(Opt1);
                        Opt1 = 4;
                        break;
                    case 2:
                        Console.Clear();
                        AddNickName();
                        PrintQuest(Opt1);
                        Opt1 = 4;
                        break;
                    case 3:
                        Console.Clear();
                        AddNickName();
                        PrintQuest(Opt1);
                        Opt1 = 4;
                        break;                        
                }
            }while(Opt1 != 4);
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("************** YOUR RESULT IS *************");
            Console.WriteLine("*******************************************");
            PrintNickName();
            Result(Correct);
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.Read();
            Console.Clear();
            LastMenu();
        }
        // All out print Menu
        protected void FirstMenu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("********** WELCOME TO QUIZ TEST ***********");
            Console.WriteLine("************** CLICK  ENTER ***************");
            Console.WriteLine("*******************************************");
            Console.Write("*******************************************");
        }
        protected void SecondMenu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("******* Choice Your Difficult Level *******");
            Console.WriteLine("*******************************************");
            Console.WriteLine("1.Beginner");
            Console.WriteLine("2.Intermediate");
            Console.WriteLine("3.Expert");
            Console.WriteLine("4.Exit From Game");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************** Good Luck :) ***************");
            Console.WriteLine("*******************************************");
            Console.Write("Please Choice A Number From The Menu :");
        }
        protected void LastMenu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************  Game Over  *****************");
            Console.WriteLine("*******************************************");
        }

    }
}
