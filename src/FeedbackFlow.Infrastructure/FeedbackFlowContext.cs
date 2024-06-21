using Microsoft.EntityFrameworkCore;

namespace FeedbackFlow.Infrastructure;

/// <summary>
/// Контекст для работы с БД
/// </summary>
public class FeedbackFlowContext : DbContext
{
    /// <inheritdoc />
    public FeedbackFlowContext(DbContextOptions<FeedbackFlowContext> options) : base(options)
    {
    }

    #region Overrides of DbContext

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleTableConfiguration).Assembly);
    }

    #endregion
}
