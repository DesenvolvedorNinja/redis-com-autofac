using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AutofacDemoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetTeste();

        [OperationContract]
        double GetSoma(double a, double b);

        [OperationContract]
        bool SetRedis(string key, string value);

        [OperationContract]
        string GetRedis(string key);
    }
}
