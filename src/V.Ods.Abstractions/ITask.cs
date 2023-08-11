using Orleans;

namespace V.Ods.Abstractions;

public interface ITask : IGrainWithStringKey
{
    Task<bool> RunAsync();
}