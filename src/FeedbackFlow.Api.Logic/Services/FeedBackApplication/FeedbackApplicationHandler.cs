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

    public async Task<IEnumerable<FeedbackApplicationResponseItem>> GetAll(CancellationToken token)
    {
        var dbdata = await _context.Set<FeedBackApplication>().ToListAsync(token);
        return dbdata.Select(x => new FeedbackApplicationResponseItem
        {
            Id = x.Id,
            Name = x.Name,
            DateEdit = x.DateEdit
        }).ToList();
    }

    public async Task<FeedbackApplicationResponseItem> Create(FeedbackApplicationCreateItem createItem, CancellationToken token)
    {
        var newApplication = new FeedBackApplication
        {
            Name = createItem.Name,
            DateEdit = DateTimeOffset.UtcNow
        };

        _context.Set<FeedBackApplication>().Add(newApplication);
        await _context.SaveChangesAsync(token);

        return new FeedbackApplicationResponseItem
        {
            Id = newApplication.Id,
            Name = newApplication.Name,
            DateEdit = newApplication.DateEdit
        };
    }
    public async Task<FeedbackApplicationResponseItem> Edit(Guid id, FeedbackApplicationEditItem editItem, CancellationToken token)
    {
        var dbdata = await _context.Set<FeedBackApplication>().FirstOrDefaultAsync(x => x.Id == id, token);
        if (dbdata == null)
        {
            throw new ArgumentException("Invalid ID");
        }

        dbdata.Name = editItem.Name;
        dbdata.DateEdit = DateTimeOffset.UtcNow;

        await _context.SaveChangesAsync(token);

        return new FeedbackApplicationResponseItem
        {
            Id = dbdata.Id,
            Name = dbdata.Name,
            DateEdit = dbdata.DateEdit
        };
    }

    public async Task Delete(Guid id, CancellationToken token)
    {
        var dbdata = await _context.Set<FeedBackApplication>().FirstOrDefaultAsync(x => x.Id == id, token);
        if (dbdata == null)
        {
            throw new ArgumentException("Invalid ID");
        }

        _context.Set<FeedBackApplication>().Remove(dbdata);
        await _context.SaveChangesAsync(token);
    }

    
}

