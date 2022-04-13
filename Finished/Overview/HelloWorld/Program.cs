using System;

// The namespace makes it easier to organize our application and 
// avoid name collisions with other code

// namespacelar ilovamizni tartibga solishni osonlashtiradi va 
// boshqa kodlar bilan nomlar to'qnashuvining oldini oladi
namespace HelloWorld
{
    // In .NET our program is contained within its own class
    class Program
    {
        // (main) Asosiy funktsiya bizning ilovamizga kirish nuqtasidir
        static void Main(string[] args)
        {
            Console.WriteLine("Salom Dunyo !");
            Console.WriteLine("Ismingiz nima ?");

            //string o'zgaruvchisini yaratish va foyldalanuvchidan ma'lumot qabul qilish
            
            string str = Console.ReadLine();
            Console.WriteLine("Salom " + str);
        }
    }
}