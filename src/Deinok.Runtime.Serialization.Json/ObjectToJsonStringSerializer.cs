using Newtonsoft.Json;

namespace Deinok.Runtime.Serialization.Json {

	public class ObjectToJsonStringSerializer:BaseSerializer<object,string> {
		
		public override string Serialize(object input){
			return JsonConvert.SerializeObject(input);
		}


		public override object Deserialize(string input){
			return JsonConvert.DeserializeObject<object>(input);
		}

    }

}
