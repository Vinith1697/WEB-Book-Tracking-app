using BookTrackingApplication.Models;
using System.Linq;

namespace BookTrackingApplication.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookTrackingApplicationContext context)
        {
            context.Database.EnsureCreated();

            var Categories = new Category[]
            {
                new Category{TypeCode="Fict",Name="Fiction"},
                new Category{TypeCode="NFict",Name="Non-Fiction"},

            };
            foreach (Category c in Categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            // Look for any CategoryTypies.
            if (context.CategoryTypies.Any())
            {
                return;   // DB has been seeded
            }

            var CategoryTypies = new CategoryType[]
            {

new CategoryType{NameToken="RN",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Romance Novel"},
                new CategoryType{NameToken="F",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Fantasy"},
                new CategoryType{NameToken="SF",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Science Fiction"},
                new CategoryType{NameToken="H",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Horror"},
                new CategoryType{NameToken="T",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Thriller"},
                new CategoryType{NameToken="B",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="Biography"},
                new CategoryType{NameToken="M",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Mystery"},
                new CategoryType{NameToken="P",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Poetry"},
                new CategoryType{NameToken="SH",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="Self Help Books"},
                new CategoryType{NameToken="MM",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="Memoirs"},
                new CategoryType{NameToken="HM",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="Humor"},
                new CategoryType{NameToken="GN",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="Graphic Novel"},
                new CategoryType{NameToken="ADV",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Adventure"},
                new CategoryType{NameToken="LT",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Literary Fiction"},
                new CategoryType{NameToken="CL",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Children's Literature"},
                new CategoryType{NameToken="SS",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "Fict").TypeCode,
                    Description="Short Stories"},
                new CategoryType{NameToken="TC",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="True Crime"},
                new CategoryType{NameToken="TRL",CategoryTypeCode=context.Categories.FirstOrDefault(x => x.TypeCode == "NFict").TypeCode,
                    Description="Travel Literature"}

            };
            foreach (CategoryType ct in CategoryTypies)
            {
                context.CategoryTypies.Add(ct);
            }
            context.SaveChanges();

            var Books = new Book[]
            {
               new Book{ISBN="8765",Title="Famous Five",Author="Enid Blyton",CategoryTypeNameToken =context.CategoryTypies.FirstOrDefault(x => x.NameToken == "ADV").NameToken},
              new Book{ISBN="8764",Title="Percy Jackson", Author="Rick Riordan",CategoryTypeNameToken=context.CategoryTypies.FirstOrDefault(x => x.NameToken == "F").NameToken },
              new Book{ISBN="8763",Title="Rich Dad Poor Dad",Author="Robert Kiyosaki",CategoryTypeNameToken=context.CategoryTypies.FirstOrDefault(x => x.NameToken == "SH").NameToken},
              new Book{ISBN="8762",Title="The Alchemist",Author="Paulo Coelho",CategoryTypeNameToken=context.CategoryTypies.FirstOrDefault(x => x.NameToken == "ADV").NameToken}
            };
            foreach (Book b in Books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
        }
    }
}
