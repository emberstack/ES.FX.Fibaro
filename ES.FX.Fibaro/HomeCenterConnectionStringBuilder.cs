using ES.FX.Data.Common;

namespace ES.FX.Fibaro
{
    public class HomeCenterConnectionStringBuilder : ConnectionStringBuilder
    {
        public HomeCenterConnectionStringBuilder(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public HomeCenterConnectionStringBuilder()
        {
        }


        public string Endpoint
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string Username
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string Password
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string Version
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }
    }
}