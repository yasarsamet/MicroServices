using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Basket.Services
{
    public class RedisService
    {
        public readonly string _host;
        public readonly int _port;

        private ConnectionMultiplexer _connectionMultiplexer;
        public RedisService(int port, string host)
        {
            _port = port;
            _host = host;
        }
        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");
        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(db);
    }
}
