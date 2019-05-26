using System;
using Microsoft.Extensions.Logging;

namespace ES.FX.Fibaro
{
    public class HomeCenterClientFactory : IHomeCenterClientFactory
    {
        private readonly ILoggerFactory _loggerFactory;

        public HomeCenterClientFactory(ILoggerFactory loggerFactory = null)
        {
            _loggerFactory = loggerFactory;
        }

        public IHomeCenterClient CreateClient(string connectionString)
        {
            return CreateClient(new HomeCenterConnectionStringBuilder(connectionString));
        }

        public IHomeCenterClient CreateClient(string endpoint, string username, string password)
        {
            return CreateClient(new HomeCenterConnectionStringBuilder
            {
                Endpoint = endpoint,
                Username = username,
                Password = password
            });
        }

        public IHomeCenterClient CreateClient(HomeCenterConnectionStringBuilder connectionStringBuilder)
        {
            if (connectionStringBuilder == null) throw new ArgumentNullException(nameof(connectionStringBuilder));
            return new HomeCenterClient(connectionStringBuilder, _loggerFactory);
        }
    }
}