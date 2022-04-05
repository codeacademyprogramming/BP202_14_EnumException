using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(45);

            string str = Console.ReadLine();
            int[] nums = null;
            try
            {
                Console.WriteLine(nums.Length);
                byte num = byte.Parse(str);

                Console.WriteLine(num);

                double sum = 10 / num;

                Console.WriteLine(sum);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sifira bolme yoxdur!");
            } 
            catch (FormatException ex)
            {
                Console.WriteLine("message: "+ex.Message);
                Console.WriteLine("Daxil etdiyiniz deyer byte-a cevrile bilmir!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bilinmedik bitr xeta");
            }
            //finally
            //{
            //    Console.WriteLine("Yoxlanis bitdi");
            //}
            
            Console.WriteLine("Finish");
            Console.WriteLine("Finish1");
            Console.WriteLine("Finish2");
            Console.WriteLine("Finish4");
            Console.WriteLine("Finish5");



        }

       
    }
}
