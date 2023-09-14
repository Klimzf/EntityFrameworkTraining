using System;

namespace EntityFrameworkTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park",
                };
                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song() {Name = "In the end", GroupId = group2.Id},
                    new Song() {Name = "Numb", GroupId = group2.Id},
                    new Song() {Name = "Mutter", GroupId = group.Id}
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();
                

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
                Console.ReadLine();
            }
        }
    }
}