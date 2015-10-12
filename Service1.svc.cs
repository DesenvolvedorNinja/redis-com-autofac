using System;
using StackExchange.Redis;

namespace AutofacDemoWCF
{
    public class Service1 : IService1
    {
        private ICalculo _calculo;
        private IDatabase _database;

        public Service1(ICalculo calculo, IDatabase database)
        {
            this._calculo = calculo;
            this._database = database;
        }

        public string GetTeste() => "Desenvolvedor Ninja - Autofac com WCF";

        public double GetSoma(double a, double b) => _calculo.Calcular(a, b);

        public bool SetRedis(string key, string value) => _database.StringSet(key, value);

        public string GetRedis(string key) => _database.StringGet(key);
    }
}
