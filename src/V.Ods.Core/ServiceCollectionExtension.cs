using Npgsql;
using SqlKata.Compilers;
using SqlKata.Execution;
using V.Ods.Core.Daos;

namespace V.Ods.Core;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddOds(this IServiceCollection services, string connectionString)
    {
        services.AddTransient(_ => new QueryFactory(new NpgsqlConnection(connectionString), new PostgresCompiler()))
            .AddTransient<JobDao>();
        return services;
    }
}