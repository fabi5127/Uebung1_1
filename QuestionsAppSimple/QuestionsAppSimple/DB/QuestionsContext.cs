using Microsoft.EntityFrameworkCore;

namespace QuestionsAppSimple.DB;

public class QuestionsContext : DbContext
{
    public QuestionsContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Question> Questions { get; set; }
}

public class Question
{
    public string Content { get; set; }
    public int Votes { get; set; }
    public int Id { get; set; }
}