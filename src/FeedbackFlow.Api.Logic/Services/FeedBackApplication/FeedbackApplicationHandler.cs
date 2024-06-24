using FeddbackFlow.Data.EfModels;
using FeedbackFlow.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FeedbackFlow.Api.Logic;

/// <inheritdoc/>
public class FeedbackApplicationHandler : IFeedbackApplicationHandler
{
    private readonly FeedbackFlowContext _context;

    public FeedbackApplicationHandler(FeedbackFlowContext context)
    {
        _context = context;
    }

    public async Task<FeedbackApplicationResponseItem> GetById(Guid id, CancellationToken token)
    {
        var dbdata = await _context.Set<FeedBackApplication>().FirstOrDefaultAsync(x => x.Id == id, token);
        if (dbdata == null)
        {
            throw new ArgumentException("bad id");
        }
        return new FeedbackApplicationResponseItem
        {
            Id = dbdata.Id,
            Name = dbdata.Name,
            DateEdit = dbdata.DateEdit
        };
    }
}
