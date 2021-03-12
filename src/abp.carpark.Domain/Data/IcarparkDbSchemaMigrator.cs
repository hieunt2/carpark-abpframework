using System.Threading.Tasks;

namespace abp.carpark.Data
{
    public interface IcarparkDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
