using RestSharp;

namespace SetlistFmApi.Deserialization
{
    public interface ICustomXmlDeserializer
    {
        object Deserialize(IRestResponse response);
    }
}
