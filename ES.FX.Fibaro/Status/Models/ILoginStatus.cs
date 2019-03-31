namespace ES.FX.Fibaro.Status.Models
{
    public interface ILoginStatus
    {
        bool LoggedIn { get; set; }
        long UserId { get; set; }
        string Username { get; set; }
        string Type { get; set; }
        string AnalyticsUserIdHash { get; set; }
    }
}