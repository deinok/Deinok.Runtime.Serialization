using Deinok.Runtime.Serialization.Generic;
using Newtonsoft.Json;

namespace Deinok.Runtime.Serialization.Json {

	public class JsonStringSerializer:BaseGenericSerializer<string> {
		
		public override string Serialize<TInput>(TInput input){
			return JsonConvert.SerializeObject(input);
		}


		public override TOutput Deserialize<TOutput>(string input){
			return JsonConvert.DeserializeObject<TOutput>(input);
		}

    }

}
