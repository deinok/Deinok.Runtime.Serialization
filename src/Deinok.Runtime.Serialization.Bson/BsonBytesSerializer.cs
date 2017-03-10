using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.IO;

namespace Deinok.Runtime.Serialization.Bson {

	public class BsonBytesSerializer{

		/// <summary>
		/// Serialize a object
		/// </summary>
		/// <typeparam name="TInput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Bson byte[]</returns>
		public byte[] Serialize<TInput>(TInput input){
			using (MemoryStream memoryStream = new MemoryStream()){
				using (BsonWriter bsonWriter = new BsonWriter(memoryStream)){
					JsonSerializer jsonSerializer = new JsonSerializer();
					jsonSerializer.Serialize(bsonWriter, input);
					return memoryStream.ToArray();
				}
			}
		}

		/// <summary>
		/// Deserialize a Bson byte[]
		/// </summary>
		/// <typeparam name="TOutput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public TOutput Deserialize<TOutput>(byte[] input){
			using (MemoryStream memoryStream = new MemoryStream(input)){
				using (BsonReader bsonReader = new BsonReader(memoryStream)){
					JsonSerializer jsonSerializer = new JsonSerializer();
					return jsonSerializer.Deserialize<TOutput>(bsonReader);
				}
			}
		}

	}

}
