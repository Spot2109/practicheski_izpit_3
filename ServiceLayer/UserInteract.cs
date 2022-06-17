using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class PersonInteract
    {
        private static readonly UserContext ctx = DBContextManager.GetUserContext();
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the User Interaction Menu!");
                Console.WriteLine("Choose option:");
                Console.WriteLine("1) Create\n2) Read\n3) ReadAll\n4) Update\n5) Delete");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        ReadAll();
                        break;
                    case 4:
                        Update();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        Console.WriteLine("No such option");
                        Start();
                        break;
                }
            }
        }
        public static void Create()
        {
            //Change 
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Date Expire: ");
            string dateexpire = Console.ReadLine();
            User item = new User(id, name, lname, dateexpire);
            ctx.Create(item);
        }
        public static void Read()
        {
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            User item = ctx.Read(id);
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
        public static void ReadAll()
        {
            List<User> items = (List<User>)ctx.ReadAll();
            foreach (User item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
        public static void Update()
        {
            //Change
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("DaTE Expire: ");
            string dateexpire = Console.ReadLine();
            User item = new User(id, fname, lname, dateexpire);
            ctx.Update(item);
        }
        public static void Delete()
        {
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            ctx.Delete(id);
        }

    }
}
