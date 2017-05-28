using Deinok.Runtime.Serialization.Generic;
using Newtonsoft.Json;

namespace Deinok.Runtime.Serialization.Json {

	/// <summary>
	/// Serializes objects to a Json String 
	/// </summary>
	public class JsonStringSerializer:IGenericSerializer<string> {
		
		/// <summary>
		/// Serialize a object
		/// </summary>
		/// <typeparam name="TInput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Json String</returns>
		public string Serialize<TInput>(TInput input){
			return JsonConvert.SerializeObject(input);
		}

		/// <summary>
		/// Deserialize a Json String
		/// </summary>
		/// <typeparam name="TOutput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public TOutput Deserialize<TOutput>(string input){
			return JsonConvert.DeserializeObject<TOutput>(input);
		}

    }

}
