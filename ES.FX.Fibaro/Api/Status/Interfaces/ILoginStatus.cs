namespace ES.FX.Fibaro.Api.Status.Interfaces
{
    public interface ILoginStatus
    {
        bool LoggedIn { get; }
        long UserId { get; }
        string Username { get; }
        string Type { get; }
        string AnalyticsUserIdHash { get; }
    }
}