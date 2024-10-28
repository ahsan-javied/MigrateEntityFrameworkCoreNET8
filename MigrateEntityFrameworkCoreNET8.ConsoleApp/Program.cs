// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, from Ziggy Rafiq!");



using (var context = new DemoDbContext(new DbContextOptionsBuilder<DemoDbContext>()
    .UseSqlServer("our_connection_string_here").Options))
{
    // Use context to interact with the database
}

