using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MelodysZooShop.Models;

namespace MelodysZooShop.Models
{
    public class AppDbContext :DbContext
    {
        public  DbSet<Category> Categories { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Gun dog." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Toy dog" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Terrier" });

            //seed pies

            modelBuilder.Entity<Dog>().HasData(new Dog
            {
                DogId = 1,
                Name = "Chihuaha",
                Price = 19000M,
                ShortDescription = "Our Cute Chihuaha puppies are ready!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl= "https://upload.wikimedia.org/wikipedia/commons/0/04/Puppy_and_kitten_shop_%286969733332%29.jpg",
                InStock = true,
                IsDogOfTheWeek = true,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/0/04/Puppy_and_kitten_shop_%286969733332%29.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dog>().HasData(new Dog
            {
                DogId = 2,
                Name = "Boo",
                Price = 40000M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://images.hdqwalls.com/wallpapers/boo-puppies-qhd.jpg",
                InStock = true,
                IsDogOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://images.hdqwalls.com/wallpapers/boo-puppies-qhd.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dog>().HasData(new Dog
            {
                DogId = 3,
                Name = "French Bulldog",
                Price = 35000,
                ShortDescription = "Yes.It's real  Plain pleasure.",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/25/Brindle_pied_frenchbulldog.jpg",
                InStock = true,
                IsDogOfTheWeek = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/2/25/Brindle_pied_frenchbulldog.jpg",
                AllergyInformation=""
            });

            modelBuilder.Entity<Dog>().HasData(new Dog
            {
                DogId = 4,
                Name = "Pomeranien Dog",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/25/Pomeranian-tb2.jpg",
                InStock = true,
                IsDogOfTheWeek = false,
                ImageThumbnailUrl= "https://upload.wikimedia.org/wikipedia/commons/2/25/Pomeranian-tb2.jpg",
                AllergyInformation = ""
            });

            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 5,
            //        Name = "Christmas Apple Dog",
            //        Price = 13.95M,
            //        ShortDescription = "Happy holidays with this pie!",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 3,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
            //        InStock = true,
            //        IsDogOfTheWeek = false,
            //        ImageThumbnailUrl =
            //            "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
            //        AllergyInformation = ""
            //    });

            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 6,
            //        Name = "Cranberry Dog",
            //        Price = 17.95M,
            //        ShortDescription = "A Christmas favorite",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 3,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
            //        InStock = true,
            //        IsDogOfTheWeek = false,
            //        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
            //        AllergyInformation = ""
            //    });

            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 7,
            //        Name = "Peach Dog",
            //        Price = 15.95M,
            //        ShortDescription = "Sweet as peach",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 1,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
            //        InStock = false,
            //        IsDogOfTheWeek = false,
            //        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
            //        AllergyInformation = ""
            //    });

            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 8,
            //        Name = "Pumpkin Dog",
            //        Price = 12.95M,
            //        ShortDescription = "Our Halloween favorite",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 3,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
            //        InStock = true,
            //        IsDogOfTheWeek = true,
            //        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
            //        AllergyInformation = ""
            //    });


            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 9,
            //        Name = "Rhubarb Dog",
            //        Price = 15.95M,
            //        ShortDescription = "My God, so sweet!",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 1,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
            //        InStock = true,
            //        IsDogOfTheWeek = true,
            //        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
            //        AllergyInformation = ""
            //    });

            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 10,
            //        Name = "Strawberry Dog",
            //        Price = 15.95M,
            //        ShortDescription = "Our delicious strawberry pie!",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 1,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
            //        InStock = true,
            //        IsDogOfTheWeek = false,
            //        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
            //        AllergyInformation = ""
            //    });

            //    modelBuilder.Entity<Dog>().HasData(new Dog
            //    {
            //        DogId = 11,
            //        Name = "Strawberry Cheese Cake",
            //        Price = 18.95M,
            //        ShortDescription = "You'll love it!",
            //        LongDescription =
            //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
            //        CategoryId = 2,
            //        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
            //        InStock = false,
            //        IsDogOfTheWeek = false,
            //        ImageThumbnailUrl =
            //            "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
        }  //        AllergyInformation = ""

        public DbSet<MelodysZooShop.Models.ShoppingCart> ShoppingCart { get; set; }
            //    });
           //}
    }   
}
