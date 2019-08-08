using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task3.MT.DataAccess.Concrete.EntityFramework;
using Task3.MT.Entities.Concrete;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Task3.MT.DataAccess.SeedData
{
    public static class MtContextSeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                MTContext context = new MTContext();
                context.Database.Migrate();

                if (context.Categories.Any() || context.Transactions.Any())
                {
                    return;
                }
                AddCategories(context);
                AddTransactions(context);
            }        

        }

        private static void AddCategories(MTContext context)

        {
            context.AddRange(
            new Category {Name = "Salary", Icon= "<i class=\"fas fa-briefcase fa-2x\" style=\"color: blue\"></i>" },
            new Category {Name = "Car", Icon = "<i class=\"fas fa-car fa-2x\" style=\"color: red\"></i>" },
            new Category {Name = "Clothing", Icon = "<i class=\"fas fa-tshirt fa-2x\" style=\"color: green\"></i>" },
            new Category {Name = "Food", Icon = "<i class=\"fas fa-hamburger fa-2x\" style=\"color: orange\"></i>" },
            new Category {Name = "Leisure", Icon = "<i class=\"fas fa-cocktail fa-2x\" style=\"color: red\"></i>" },
            new Category {Name = "Living", Icon = "<i class=\"fas fa-home fa-2x\" style=\"color: black\"></i>" },
            new Category {Name = "Others", Icon = "<i class=\"fas fa-file fa-2x\" style=\"color: black\"></i>" }
            );
            context.SaveChanges();

        }

        private static void AddTransactions(MTContext context)

        {
            foreach (var item in context.Categories.ToList())
            {
                switch (item.Name)
                {
                    case "Salary":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 4000, Date = DateTime.Now, Description = "July", TransactionType = true });
                        context.SaveChanges();
                        break;
                    case "Car":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 300, Date = DateTime.Now, Description = "Repair", TransactionType = false });
                        context.SaveChanges();
                        break;
                    case "Food":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 120, Date = DateTime.Now, Description = "McDonalds", TransactionType = false });
                        context.SaveChanges();
                        break;
                    case "Living":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 1200, Date = DateTime.Now, Description = "Rent", TransactionType = false });
                        context.SaveChanges();
                        break;
                    case "Others":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 550, Date = DateTime.Now, Description = "Gift", TransactionType = false });
                        context.SaveChanges();
                        break;
                    case "Clothing":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 550, Date = DateTime.Now, Description = "New shoes", TransactionType = false });
                        context.SaveChanges();
                        break;
                    case "Leisure":
                        context.Add(new Transaction { CategoryId = item.Id, Amount = 220, Date = DateTime.Now, Description = "Lent Ahmet money", TransactionType = false });
                        context.SaveChanges();
                        break;
                    default:
                        break;
                }
            };
            //context.AddRange(

            //new Transaction { CategoryId = 9, Amount = 4000, Date = DateTime.Now, Description = "July", TransactionType = true },
            //new Transaction { CategoryId = 10, Amount = 300, Date = DateTime.Now, Description = "Repair", TransactionType = false },
            //new Transaction { CategoryId = 11, Amount = 550, Date = DateTime.Now, Description = "New shoes", TransactionType = false },
            //new Transaction { CategoryId = 12, Amount = 120, Date = DateTime.Now, Description = "McDonalds", TransactionType = false },
            //new Transaction { CategoryId = 13, Amount = 220, Date = DateTime.Now, Description = "Lent Ahmet money", TransactionType = false },
            //new Transaction { CategoryId = 14, Amount = 1200, Date = DateTime.Now, Description = "Rent", TransactionType = false },
            //new Transaction { CategoryId = 15, Amount = 550, Date = DateTime.Now, Description = "Gift", TransactionType = false }

            //);

            context.SaveChanges();

        }

    }

}
