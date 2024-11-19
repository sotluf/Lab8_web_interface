using Lab8.Models;

namespace Lab8.Services.Implementations;

internal class ModelService<T>(IEnumerable<T> data) : IModelService<T> where T : Model
{
    private readonly List<T> _data = [..data];


    public Task<IEnumerable<T>> GetAllAsync()
    {
        return Task.FromResult(_data.AsEnumerable());
    }


    public Task<T?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(_data.FirstOrDefault(m => m.Id == id));
    }


    public Task<T> CreateAsync(T model)
    {
        _data.Add(model = model with
        {
            Id = Guid.NewGuid()
        });
        return Task.FromResult(model);
    }


    public Task<bool> UpdateAsync(T model)
    {
        var index = _data.FindIndex(m => m.Id == model.Id);
        if (index == -1)
        {
            return Task.FromResult(false);
        }

        _data[index] = model;
        return Task.FromResult(true);
    }


    public Task<bool> DeleteAsync(Guid id)
    {
        var index = _data.FindIndex(hd => hd.Id == id);
        if (index == -1)
        {
            return Task.FromResult(false);
        }

        _data.RemoveAt(index);
        return Task.FromResult(true);
    }
}
