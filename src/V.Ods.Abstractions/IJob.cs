using Orleans;
using Orleans.Concurrency;

namespace V.Ods.Abstractions;

public interface IJob<T> : IGrainWithStringKey
{
    Task<List<T>> GetInitParams();

    Task<string> GetGrainIdentity(T param);

    [OneWay]
    Task Run(T param);
}