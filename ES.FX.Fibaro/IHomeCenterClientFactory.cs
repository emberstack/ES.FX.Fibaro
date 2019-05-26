namespace ES.FX.Fibaro
{
    public interface IHomeCenterClientFactory
    {
        IHomeCenterClient CreateClient(string connectionString);
        IHomeCenterClient CreateClient(string endpoint, string username, string password);
        IHomeCenterClient CreateClient(HomeCenterConnectionStringBuilder connectionStringBuilder);
    }
}