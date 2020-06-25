using System.Data;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Dapper
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
