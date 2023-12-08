

using System.Xml.Linq;
using System;

namespace MyEcom.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					Id = 1,
					Name = "Books",
					Url = "books"
				},
				new Category
				{
				Id = 2,
					Name = "Movies",
					Url = "movies"
				},
				new Category

			    {
				Id = 3,
					Name = "Video Games",
					Url = "video-games"
				}

		);
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "The Big Sleep",
					Description = "The Big Sleep (1939) is a hardboiled crime novel by American-British writer Raymond Chandler, the first to feature the detective Philip Marlowe. It has been adapted for film twice, in 1946 and again in 1978. The story is set in Los Angeles.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/f9/RaymondChandler_TheBigSleep.jpg",
					Price = 8.99m,
					CategoryId=1
				},
		new Product
		{
			Id = 2,
			Title = "The Golden Notebook",
			Description = "The Golden Notebook is a 1962 novel by the British writer Doris Lessing. Like her two books that followed, it enters the realm of what Margaret Drabble in The Oxford Companion to English Literature called Lessing's inner space fiction [citation needed] her work that explores mental and societal breakdown. The novel contains anti-war and anti-Stalinist messages, an extended analysis of communism and the Communist Party in England from the 1930s to the 1950s, and an examination of the budding sexual revolution and women's liberation movements.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/71/The_Golden_Notebook.gif",
			Price = 8.99m,
			CategoryId=1
		},
		new Product
		{
			Id = 3,
			Title = "Lord of the Flies",
			Description = "Lord of the Flies is a 1954 novel by the Nobel laureate British author William Golding. The plot concerns a group of British boys who are stranded on an uninhabited island and their disastrous attempts to govern themselves. Themes include the tension between groupthink and individuality, between rational and emotional reactions, and between morality and immorality.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/LordOfTheFliesBookCover.jpg",
			Price = 8.99m,
			CategoryId=1
		},
		new Product
		{
			Id = 4,
			Title = "The Lord of the Rings",
			Description = "The Lord of the Rings is an epic[1] high fantasy novel[a] by the English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.[2]",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
			Price = 8.99m,
			CategoryId=1
		},
		new Product
		{
			Id = 5,
			CategoryId = 2,
			Title = "The Matrix",
			Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
		},
		new Product
					{
						Id = 6,
						CategoryId = 2,
						Title = "Back to the Future",
						Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
						//Featured = true
					},
					new Product
					{
						Id =7,
						CategoryId = 2,
						Title = "Toy Story",
						Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

					},
					new Product
					{
						Id = 8,
						CategoryId = 3,
						Title = "Half-Life 2",
						Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

					},
					new Product
					{
						Id = 9,
						CategoryId = 3,
						Title = "Diablo II",
						Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
					},
					new Product
					{
						Id = 10,
						CategoryId = 3,
						Title = "Day of the Tentacle",
						Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
						//Featured = true
					},
					new Product
					{
						Id = 11,
						CategoryId = 3,
						Title = "Xbox",
						Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
					},
					new Product
					{
						Id = 12,
						CategoryId = 3,
						Title = "Super Nintendo Entertainment System",
						Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
						ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
					}
				);
		}
		public DbSet<Product> Products { get; set; } 
		public DbSet<Category> Categories { get; set; }
    }
}
