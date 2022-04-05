using CourseTask.Exceptions;
using System;

namespace CourseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Course course = new Course();

            Group group1 = new Group();
            group1.Type = GroupType.Design;

            Group group2 = new Group();
            group2.Type = GroupType.Programming;

            Group group3 = new Group();
            group3.Type = GroupType.ThreeD;

            Group group4 = new Group();
            group4.Type = GroupType.Programming;



            Console.WriteLine("Group novleri:");
            foreach (var item in Enum.GetValues(typeof(GroupType)))
            {
                Console.WriteLine((byte)item + " - "+item);
            }

            Console.WriteLine("Secim edin:");
            string typeStr = Console.ReadLine();


            byte typeByte;
            while (!byte.TryParse(typeStr, out typeByte))
            {
                Console.WriteLine("Eded daxil edin!!");
                typeStr = Console.ReadLine();
            }

            while (!Enum.IsDefined(typeof(GroupType),typeByte))
            {
                Console.WriteLine("Dogru secim edin!");
                typeStr = Console.ReadLine();
                while (!byte.TryParse(typeStr, out typeByte))
                {
                    Console.WriteLine("Eded daxil edin!!");
                    typeStr = Console.ReadLine();
                }
                typeByte = Convert.ToByte(typeStr);
            }

            GroupType selectedType = (GroupType)typeByte;


            Group group5 = new Group();
            group5.Type = selectedType;

            var groupInfo = group5.ToString();
            Console.WriteLine("group5: "+group5);

            Console.WriteLine("5ci qrup novu: "+group5.Type);

            Group group6 = new Group();
            group6.Type = GroupType.Programming;

            try
            {
                course.AddGroup(group1);
                course.AddGroup(group2);
                course.AddGroup(group3);
                course.AddGroup(group4);
                course.AddGroup(group5);
                course.AddGroup(group6);
            }
            catch (CourseLimitOverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
          

            foreach (var item in course.GetAllGroupsByType(GroupType.Design))
            {
                Console.WriteLine(item.No);
            }
        }


    }
}
