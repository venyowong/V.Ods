using Orleans;
using V.Ods.Abstractions;
using V.Ods.Core.Daos;

namespace V.Ods.Core.Grains;

public abstract class AbstractJob<T> : Grain, IJob<T>
{
    public abstract string Id{get;}

    public abstract Task<List<T>> GetInitParams();

    public abstract Task<string> GetGrainIdentity(T param);

    public abstract Task Run(T param);

    protected async Task<int> GetScale()
    {
        var scheduler = GrainFactory.GetGrain<IScheduler>("0");
        return await scheduler.GetActivationScale(this.Id);
    }
}