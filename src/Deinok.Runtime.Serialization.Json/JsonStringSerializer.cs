using Newtonsoft.Json;

namespace Deinok.Runtime.Serialization.Json {

    /// <summary>
    /// Serializes objects to a Json String 
    /// </summary>
    public class JsonStringSerializer:IGenericSerializer<string> {

        private JsonSerializerSettings jsonSerializerSettings=null;

        public JsonStringSerializer() { }
        public JsonStringSerializer(JsonSerializerSettings jsonSerializerSettings) {
            this.jsonSerializerSettings = jsonSerializerSettings;
        }

		/// <summary>
		/// Serialize a object
		/// </summary>
		/// <typeparam name="TInput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Json String</returns>
		public string Serialize<TInput>(TInput input){
            return this.jsonSerializerSettings!=null 
                ? JsonConvert.SerializeObject(input, this.jsonSerializerSettings) 
                : JsonConvert.SerializeObject(input);
		}

		/// <summary>
		/// Deserialize a Json String
		/// </summary>
		/// <typeparam name="TOutput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public TOutput Deserialize<TOutput>(string input){
            return this.jsonSerializerSettings != null
                ? JsonConvert.DeserializeObject<TOutput>(input, this.jsonSerializerSettings)
                : JsonConvert.DeserializeObject<TOutput>(input);
        }

    }

}
