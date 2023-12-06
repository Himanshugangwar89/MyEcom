

namespace MyEcom.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "The Big Sleep",
					Description = "The Big Sleep (1939) is a hardboiled crime novel by American-British writer Raymond Chandler, the first to feature the detective Philip Marlowe. It has been adapted for film twice, in 1946 and again in 1978. The story is set in Los Angeles.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/f9/RaymondChandler_TheBigSleep.jpg",
					Price = 8.99m
				},
		new Product
		{
			Id = 2,
			Title = "The Golden Notebook",
			Description = "The Golden Notebook is a 1962 novel by the British writer Doris Lessing. Like her two books that followed, it enters the realm of what Margaret Drabble in The Oxford Companion to English Literature called Lessing's inner space fiction [citation needed] her work that explores mental and societal breakdown. The novel contains anti-war and anti-Stalinist messages, an extended analysis of communism and the Communist Party in England from the 1930s to the 1950s, and an examination of the budding sexual revolution and women's liberation movements.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/71/The_Golden_Notebook.gif",
			Price = 8.99m
		},
		new Product
		{
			Id = 3,
			Title = "Lord of the Flies",
			Description = "Lord of the Flies is a 1954 novel by the Nobel laureate British author William Golding. The plot concerns a group of British boys who are stranded on an uninhabited island and their disastrous attempts to govern themselves. Themes include the tension between groupthink and individuality, between rational and emotional reactions, and between morality and immorality.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/LordOfTheFliesBookCover.jpg",
			Price = 8.99m
		},
		new Product
		{
			Id = 4,
			Title = "The Lord of the Rings",
			Description = "The Lord of the Rings is an epic[1] high fantasy novel[a] by the English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.[2]",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
			Price = 8.99m
		}
				);
		}
		public DbSet<Product> Products { get; set; } //= new DbSet<Product>();
    }
}
