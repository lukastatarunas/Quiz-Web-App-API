using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Models
{
    public class Database
    {
        public static void InitializeUserTable(ApplicationDbContext db)
        {
            if (!db.Users.Any())
            {
                db.Users.Add(new User
                {
                    Name = "Bob",
                    Surname = "Doe",
                    Username = "bob",
                    Password = "bob",
                    Repeat = "bob"
                });
                db.Users.Add(new User
                {
                    Name = "Ann",
                    Surname = "Lee",
                    Username = "ann",
                    Password = "ann",
                    Repeat = "ann"
                });
                db.Users.Add(new User
                {
                    Name = "Sue",
                    Surname = "Douglas",
                    Username = "sue",
                    Password = "sue",
                    Repeat = "sue"
                });
                db.Users.Add(new User
                {
                    Name = "Tom",
                    Surname = "Brown",
                    Username = "tom",
                    Password = "tom",
                    Repeat = "tom"
                });
                db.Users.Add(new User
                {
                    Name = "Joe",
                    Surname = "Mason",
                    Username = "joe",
                    Password = "joe",
                    Repeat = "joe"
                });
                db.SaveChanges();
            }
        }

        public static void InitializeTest1ResultTable(ApplicationDbContext db)
        {
            if (!db.Test1Results.Any())
            {
                db.Test1Results.Add(new Test1Result
                {
                    Username = "bob",
                    Result = 20
                });
                db.Test1Results.Add(new Test1Result
                {
                    Username = "ann",
                    Result = 40
                });
                db.Test1Results.Add(new Test1Result
                {
                    Username = "sue",
                    Result = 60
                });
                db.Test1Results.Add(new Test1Result
                {
                    Username = "tom",
                    Result = 80
                });
                db.Test1Results.Add(new Test1Result
                {
                    Username = "joe",
                    Result = 100
                });
                db.SaveChanges();
            }
        }

        public static void InitializeTest2ResultTable(ApplicationDbContext db)
        {
            if (!db.Test2Results.Any())
            {
                db.Test2Results.Add(new Test2Result
                {
                    Username = "bob",
                    Result = 10
                });
                db.Test2Results.Add(new Test2Result
                {
                    Username = "ann",
                    Result = 30
                });
                db.Test2Results.Add(new Test2Result
                {
                    Username = "sue",
                    Result = 50
                });
                db.Test2Results.Add(new Test2Result
                {
                    Username = "tom",
                    Result = 70
                });
                db.Test2Results.Add(new Test2Result
                {
                    Username = "joe",
                    Result = 90
                });
                db.SaveChanges();
            }
        }

        public static void InitializeTest3ResultTable(ApplicationDbContext db)
        {
            if (!db.Test3Results.Any())
            {
                db.Test3Results.Add(new Test3Result
                {
                    Username = "bob",
                    Result = 0
                });
                db.Test3Results.Add(new Test3Result
                {
                    Username = "ann",
                    Result = 20
                });
                db.Test3Results.Add(new Test3Result
                {
                    Username = "sue",
                    Result = 40
                });
                db.Test3Results.Add(new Test3Result
                {
                    Username = "tom",
                    Result = 60
                });
                db.Test3Results.Add(new Test3Result
                {
                    Username = "joe",
                    Result = 80
                });
                db.SaveChanges();
            }
        }

        public static void InitializeTest4ResultTable(ApplicationDbContext db)
        {
            if (!db.Test4Results.Any())
            {
                db.Test4Results.Add(new Test4Result
                {
                    Username = "bob",
                    Result = 20
                });
                db.Test4Results.Add(new Test4Result
                {
                    Username = "ann",
                    Result = 40
                });
                db.Test4Results.Add(new Test4Result
                {
                    Username = "sue",
                    Result = 60
                });
                db.Test4Results.Add(new Test4Result
                {
                    Username = "tom",
                    Result = 80
                });
                db.Test4Results.Add(new Test4Result
                {
                    Username = "joe",
                    Result = 100
                });
                db.SaveChanges();
            }
        }

        public static void InitializeTest5ResultTable(ApplicationDbContext db)
        {
            if (!db.Test5Results.Any())
            {
                db.Test5Results.Add(new Test5Result
                {
                    Username = "bob",
                    Result = 20
                });
                db.Test5Results.Add(new Test5Result
                {
                    Username = "ann",
                    Result = 40
                });
                db.Test5Results.Add(new Test5Result
                {
                    Username = "sue",
                    Result = 60
                });
                db.Test5Results.Add(new Test5Result
                {
                    Username = "tom",
                    Result = 80
                });
                db.Test5Results.Add(new Test5Result
                {
                    Username = "joe",
                    Result = 100
                });
                db.SaveChanges();
            }
        }
    }
}
