using HtmlAgilityPack;
using Orleans;
using V.Ods.Core.Daos;

namespace V.Ods.Core.Grains;

public class CrawlerJob : AbstractJob<string>
{
    private JobDao jobDao;

    public CrawlerJob(JobDao jobDao)
    {
        this.jobDao = jobDao;
    }

    public override string Id
    {
        get => this.GetPrimaryKeyString().Split("-")[0];
    }

    public override async Task<string> GetGrainIdentity(string param)
    {
        return $"{this.Id}-{param.GetHashCode() % (await this.GetScale()) + 1}";
    }

    public override Task<List<string>> GetInitParams() => Task.FromResult(this.jobDao.GetInitParams(this.Id));

    public override Task Run(string param)
    {
        var web = new HtmlWeb();
        var doc = web.Load(param);
    }
}