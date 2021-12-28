using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTest
{
    // All methods and classes are highly secure for accessibility so
    // that the user cannot access unnecessary commands for him.
    internal class Questions : Grades
    {
        private int a, b, c;
        // quest is 2 dimansional string there is out print quest and different answer
        private string[,] quest ={ {
"'What is The Smallest Country ?'\n1.U.K\n2.Bulgaria\n3.Vatican"
,"'Where are The Happiest People ?'\n1.China\n2.Finland\n3.Russia"
,"'Which is the most old Country in Europe ?'\n1.Germany\n2.Romania\n3.Bulgaria"
,"'What is the number 'pi' equal to ?'\n1.3.14\n2.4.13\n3.1.14"
,"'Which is Arabic Numbers ?'\n1.α. β. γ. δ. ε. ϛ. ζ. η. θ\n2.0,1,2,3,4,5,6,7,8,9\n3.I,II,III,IV,V,VI,VII,VIII,IX,Х"
,"'Which Continent has the most Countries ?'\n1.Africa\n2.Europe\n3.North America"
,"'Who is Leonardo Fibonacci ?'\n1.Mathematician\n2.Author\n3.Physicist"
, "'How many Countries are in the European Union ?'\n1.21\n2.27\n3.23"
,"'Which is the largest Mountain in the World ?'\n1.K2\n2.Everest\n3.Nanga Parbat"
,"'Which is the longest River in the World ?'\n1.Yangtze\n2.Amazon\n3.Nile"
},
        {
"'When was Netflix founded ?'\n1.2001\n2.2009\n3.1997"
,"'What was the most-watched series on Netflix in 2019 ?'\n1.BlackList\n2.Stranger Things\n3.New Amsterdam"
,"'When did they open the London underground ?'\n1.1863\n2.1720\n3.1893"
,"'What is the name of the coffee shop in the sitcom Friends ?'\n1.Coffe Shop\n2.Central Home\n3.Central Perk"
,"'Where was the first modern Olympic Games held ?'\n1.Athens\n2.Surbian\n3.Chine"
,"'Which driver has won the most Formula 1 championships ?'\n1.Nicholas Latifi\n2.Michael Schumacher\n3.Fernando Alonso"
,"'What was the clothing company Nike originally called ?'\n1.Black Ribbon Sports\n2.Red Ribbon Sports\n3.Blue Ribbon Sports"
, "'How many stripes are there on the US flag ?'\n1.13\n2.10\n3.17"
,"'How many days does it take for the Earth to orbit the Sun ?'\n1.365\n2.364\n3.Depends on the year"
,"'How many keys does a classic piano have ?'\n1.92\n2.88\n3.66"
},
 {
"'What type of animal is Baloo in The Jungle Book ?'\n1.A Bear\n2.A Tiger\n3.A Snake"
,"'What is Prince William's full name ?'\n1.William Arthur Philip Louis Windsor\n2.William James Cliff William Sussex\n3.William Philip Arthur Thomas Harrison"
,"'How many digits are in Pi ?'\n1.3 decimal\n2.9 million decimal\n3.62.8 trillion decimals"
,"'How many bones are in an elephants trunk ?'\n1.15\n2.5\n3.0"
,"'If you have cryophobia, what are you afraid of ?'\n1.Ice and Cold\n2.Hot and Warm\n3.Water and Rain"
,"'How many time zones are there in Russia ?'\n1.5\n2.3\n3.11"
,"'How many Grammy's did Billie Eilish win in 2020 ?'\n1.5\n2.9\n3.3"
, "'How many letter tiles are there in a game of Scrabble ?'\n1.100\n2.62\n3.32"
,"'Without using a calculator, what is 30% of 546 ?'\n1.144\n2.132\n3.164"
,"'What year did Vincent Van Gogh die ?'\n1.1885, on 3 January\n2.1890, on 29 July\n3.1880, on 11 Mey"
}       };
        



        protected Questions()
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }
        protected int A
        {
            get { return a; }
            set { a = value; }
        }
        protected int B
        {
            get { return b; }
            set { b = value; }
        }
        protected int C
        {
            get { return c; }
            set { c = value; }
        }
        protected string[,] Quest
        { 
            get { return quest; }
   
        }

        //We use this For in For to Print 2dimensional String
        //and there is ResultPoints who takes all Correct Answer and Give you Grades
        protected void PrintQuest(int level)
        {
            Console.Clear();
            // 3 Columns
            for (int i = level - 1; i < level; i++)
            {
                //10 rows
                for (int j = 0; j < 10; j++)
                {

                Console.WriteLine(Quest[i,j]);
                Console.Write("Please Enter Your Choice :");
                try
                {
                Choice = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadLine();
                }
                Console.Clear();
                Count++;
                ResultPoints(Choice, level);
                
                }
            }
        }
    }
}
