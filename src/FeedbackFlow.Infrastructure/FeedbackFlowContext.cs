//using Microsoft.EntityFrameworkCore;

//namespace FeedbackFlow.Infrastructure;

///// <summary>
///// Контекст для работы с БД
///// </summary>
//public class FeedbackFlowContext : DbContext
//{
//    /// <inheritdoc />
//    public FeedbackFlowContext(DbContextOptions<FeedbackFlowContext> options) : base(options)
//    {
//    }

//    #region Overrides of DbContext

//    /// <inheritdoc />
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        base.OnModelCreating(modelBuilder);

//        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleTableConfiguration).Assembly);
//    }

//    #endregion
//}
using FeddbackFlow.Data.EfModels;
using Microsoft.EntityFrameworkCore;

namespace FeedbackFlow.Infrastructure
{
    public class FeedbackFlowContext : DbContext
    {
        public FeedbackFlowContext(DbContextOptions<FeedbackFlowContext> options)
            : base(options)
        {
        }

        //public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FeedBackApplicationConfiguration).Assembly);

        }
    }
}
