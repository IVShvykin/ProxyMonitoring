namespace Common.Database.Connection
{
    public interface IConnection
    {
        string GetKcmEcmConnectionString();
        string GetProxyMonitoringConnectionString();
    }
}
