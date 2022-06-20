using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public static class AuthorInteract
    {
        private static readonly AuthorContext ctx = DBContextManager.GetAuthorContext();
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Author Interaction Menu!");
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
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Born: ");
            string born = Console.ReadLine();
            Console.WriteLine("Died: ");
            string died = Console.ReadLine();
            Console.WriteLine("Genres: ");
            string genres = Console.ReadLine();
            Author item = new Author(id, name, lname, born, died, genres);
            ctx.Create(item);
        }
        public static void Read()
        {
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Author item = ctx.Read(id);
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
        public static void ReadAll()
        {
            List<Author> items = (List<Author>)ctx.ReadAll();
            foreach (Author item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
        public static void Update()
        {
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("First Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Born: ");
            string born = Console.ReadLine();
            Console.WriteLine("Died: ");
            string died = Console.ReadLine();
            Console.WriteLine("Genres: ");
            string genres = Console.ReadLine();
            Author item = new Author(id, name, lname, born, died, genres);
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
