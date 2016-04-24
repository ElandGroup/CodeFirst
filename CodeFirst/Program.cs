using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Context;
using CodeFirst.Domain;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NewContext())
            {
                Console.WriteLine("请输入Name：");
                var name= Console.ReadLine();

                var newType = new NewType { Name=name};
                db.NewTypes.Add(newType);
                db.SaveChanges();

                Console.WriteLine("Save successfully");
                Console.Read();

            }
        }
    }
}
