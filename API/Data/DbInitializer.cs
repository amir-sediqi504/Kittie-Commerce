using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
{
    public static void Initialize(KittieContext context)
    {
        if (context.Kittens.Any()) return;

       var kittens = new List<Kitten>
        {
            new Kitten
            {
                Name = "Fluffy",
                Age = 2,
                Description = "A fluffy and adorable kitten.",
                Price = 5000,
                PictureUrl = "/images/kittens/fluffy.jpg",
                Breed = "Persian",
                QuantityInStock = 10
            },
            new Kitten
            {
                Name = "Mittens",
                Age = 1,
                Description = "Mittens is a playful kitten with soft fur.",
                Price = 4500,
                PictureUrl = "/images/kittens/mittens.jpg",
                Breed = "Russian Blue",
                QuantityInStock = 8
            },
            new Kitten
            {
                Name = "Whiskers",
                Age = 3,
                Description = "Whiskers is an affectionate kitten who loves cuddles.",
                Price = 5500,
                PictureUrl = "/images/kittens/whiskers.jpg",
                Breed = "Siamese",
                QuantityInStock = 12
            },
            new Kitten
            {
                Name = "Snowball",
                Age = 2,
                Description = "Snowball is a fluffy white kitten with blue eyes.",
                Price = 6000,
                PictureUrl = "/images/kittens/snowball.jpg",
                Breed = "Maine Coon",
                QuantityInStock = 7
            },
            new Kitten
            {
                Name = "Tiger",
                Age = 1,
                Description = "Tiger is a playful and energetic orange tabby kitten.",
                Price = 4000,
                PictureUrl = "/images/kittens/tiger.jpg",
                Breed = "Tabby",
                QuantityInStock = 9
            },
            new Kitten
            {
                Name = "Luna",
                Age = 1,
                Description = "Luna is a curious and adventurous calico kitten.",
                Price = 4800,
                PictureUrl = "/images/kittens/luna.jpg",
                Breed = "Domestic Shorthair",
                QuantityInStock = 11
            }
        };

        foreach (var kitten in kittens)
        {
            context.Kittens.Add(kitten);
        }

        context.SaveChanges();
    }
}

}