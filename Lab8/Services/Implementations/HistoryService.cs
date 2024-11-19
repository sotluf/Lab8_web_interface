using Lab8.Models;

namespace Lab8.Services.Implementations;

internal class HistoryService() :
    ModelService<History>([
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 1", Description = "Description 1", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 2", Description = "Description 2", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 3", Description = "Description 3", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 4", Description = "Description 4", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 5", Description = "Description 5", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 6", Description = "Description 6", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 7", Description = "Description 7", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 8", Description = "Description 8", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 9", Description = "Description 9", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 10", Description = "Description 10", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 11", Description = "Description 11", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 12", Description = "Description 12", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 13", Description = "Description 13", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 14", Description = "Description 14", CreatedAt = DateTimeOffset.Now
        },
        new History
        {
            Id = Guid.NewGuid(), Title = "Event 15", Description = "Description 15", CreatedAt = DateTimeOffset.Now
        }
    ]),
    IHistoryService;
