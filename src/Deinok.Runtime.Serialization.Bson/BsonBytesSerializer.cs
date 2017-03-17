using System.IO;
using Deinok.Runtime.Serialization.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace Deinok.Runtime.Serialization.Bson {

	/// <summary>
	/// Serializes objects to a Bson byte[] 
	/// </summary>
	public class BsonBytesSerializer:BaseGenericSerializer<byte[]>{

		/// <summary>
		/// Serialize a object
		/// </summary>
		/// <typeparam name="TInput">The Deserialized Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Bson byte[]</returns>
		public override byte[] Serialize<TInput>(TInput input){
			using (var memoryStream = new MemoryStream()){
				using (var bsonWriter = new BsonWriter(memoryStream)){
					var jsonSerializer = new JsonSerializer();
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
		public override TOutput Deserialize<TOutput>(byte[] input){
			using (var memoryStream = new MemoryStream(input)){
				using (var bsonReader = new BsonReader(memoryStream)){
					var jsonSerializer = new JsonSerializer();
					return jsonSerializer.Deserialize<TOutput>(bsonReader);
				}
			}
		}

	}

}
