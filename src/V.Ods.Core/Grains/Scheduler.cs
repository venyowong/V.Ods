using Orleans;
using V.Ods.Abstractions;
using V.Ods.Abstractions.Models;

namespace V.Ods.Core.Grains;

public class Scheduler : Grain, IScheduler
{
    public Task<bool> AddJob(JobModel job)
    {
        // todo: 判断参数是否正确
        // todo: 判断是否重名
        // todo: 插入 job
        // todo: 插入 job 初始参数
    }

    public Task<bool> AddTask()
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddTask<T>(T param)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetActivationScale(string id)
    {
        throw new NotImplementedException();
    }
}