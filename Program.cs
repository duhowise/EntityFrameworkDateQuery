using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkDateQuery
{
    internal class Program
    {
        private static async System.Threading.Tasks.Task Main(string[] args)
        {
            using (var context = new DateQueryDbContext())
            {
                context.Database.Log = Console.WriteLine;
                var date = DateTime.Parse("01/08/2019 00:00:00.000");
                var userWhoSingedUp = await context.Users.Where(x => DbFunctions.TruncateTime(x.AddedDate) == date).ToListAsync();
                if (userWhoSingedUp.Any())
                {
                    foreach (var user in userWhoSingedUp)
                    {
                        Console.WriteLine(user.ToString());
                    }
                }
            }
            System.Console.ReadLine();
        }
    }
}