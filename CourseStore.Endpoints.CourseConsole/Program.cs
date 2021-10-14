using CourseStore.Infra.Data.Sql;
using System;
using System.Linq;

namespace CourseStore.Endpoints.CourseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandRepasitory.CheckEntityState();

            Console.WriteLine("__________");
            Console.ReadKey();
        }
    }
}
