using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abp.carpark.Data
{
    /* This is used if database provider does't define
     * IcarparkDbSchemaMigrator implementation.
     */
    public class NullcarparkDbSchemaMigrator : IcarparkDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}