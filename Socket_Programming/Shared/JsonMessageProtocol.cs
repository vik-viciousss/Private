using Newtonsoft.Json.Linq;

namespace Shared
{
    public class JsonMessageProtocol : Protocol<JObject>
    {
        protected override JObject Decode(byte[] message)
        {
            throw new System.NotImplementedException();
        }

        protected override byte[] EncodeBody<T>(T message)
        {
            throw new System.NotImplementedException();
        }
    }
}
