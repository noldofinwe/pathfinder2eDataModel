using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    [ServiceContract]
    public interface IPathfinderApi
    {
        [OperationContract]
        [WebGet(UriTemplate = "ancestry")]
        Ancestry[] GetAncestry();

        [OperationContract]
        [WebGet(UriTemplate = "feat")]
        Feat[] GetFeats();

        [OperationContract]
        [WebGet(UriTemplate = "createCharacter?name={name}")]
        Character CreateCharacter(string name);

        [OperationContract]
        [WebGet(UriTemplate = "addAncestry?name={name}&ancestry={ancestry}")]
        Character SetAncestry(string name, string ancestry);

    }
}
