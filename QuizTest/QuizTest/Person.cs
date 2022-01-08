using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTest
{
    // All methods and classes are highly secure for accessibility so
    // that the user cannot access unnecessary commands for him.
    //Person Class With Add Nick Name and Print Method
    internal class Person : Questions
    {
        private string nickName;
        protected Person()
        {
           this.nickName = NickName;
        }
        protected string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        //There is Add NichName Method
        protected void AddNickName()
        {
            Console.Write("Please Enter Nick Name :");
            NickName = Console.ReadLine();
            Console.Clear();
        }
        //There Print NickName
        protected void PrintNickName()
        {
            Console.WriteLine("Player :" + NickName);
        }

    }
}
