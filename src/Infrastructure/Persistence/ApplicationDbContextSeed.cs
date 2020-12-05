using TAP_TEST.Domain.Entities;
using TAP_TEST.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace TAP_TEST.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
            {
                await userManager.CreateAsync(defaultUser, "Administrator1!");
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.TodoLists.Any())
            {
                context.TodoLists.Add(new TodoList
                {
                    Title = "Shopping",
                    Items =
                    {
                        new TodoItem { Title = "Apples", Done = true },
                        new TodoItem { Title = "Milk", Done = true },
                        new TodoItem { Title = "Bread", Done = true },
                        new TodoItem { Title = "Toilet paper" },
                        new TodoItem { Title = "Pasta" },
                        new TodoItem { Title = "Tissues" },
                        new TodoItem { Title = "Tuna" },
                        new TodoItem { Title = "Water" }
                    }
                });
            }

            if (!context.CardPrefixes.Any())
            {
                context.CardPrefixes.Add(new CardPrefix { Prefix = "489385", CardType = "VISA", BankAlias = "PERMATA" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "489781", CardType = "VISA", BankAlias = "BUKOPIN" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "490283", CardType = "VISA", BankAlias = "MANDIRI" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "490295", CardType = "VISA", BankAlias = "DANAMON" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "490296", CardType = "VISA", BankAlias = "DANAMON" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "490702", CardType = "VISA", BankAlias = "BALI" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "493497", CardType = "VISA", BankAlias = "STANDARD" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "493828", CardType = "VISA", BankAlias = "BII" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "493829", CardType = "VISA", BankAlias = "BII" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "498853", CardType = "VISA", BankAlias = "PERMATA" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "510217", CardType = "MASTERCARD", BankAlias = "PANIN" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "510249", CardType = "MASTERCARD", BankAlias = "PANIN" });
                context.CardPrefixes.Add(new CardPrefix { Prefix = "510458", CardType = "MASTERCARD", BankAlias = "BRI" });
            }

            await context.SaveChangesAsync();
        }
    }
}
