using Orleans;
using V.Ods.Abstractions.Models;

namespace V.Ods.Abstractions;

public interface IScheduler : IGrainWithStringKey
{
    Task<bool> AddJob(JobModel job);

    Task<bool> AddTask();

    Task<bool> AddTask<T>(T param);

    Task<int> GetActivationScale(string id);
}