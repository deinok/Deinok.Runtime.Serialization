using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Extension Methods for IDeserializer
	/// </summary>
	public static class IDeserializerExtension {

		/// <summary>
		/// Deserializes the input async
		/// </summary>
		/// <typeparam name="TInput">The Input Type</typeparam>
		/// <typeparam name="TOutput">The Output Type</typeparam>
		/// <param name="deserializer">The Deserializer instance</param>
		/// <param name="input">The Input</param>
		/// <returns>The Output Task</returns>
		public static async Task<TOutput> DeserializeAsync<TInput, TOutput>(this IDeserializer<TInput, TOutput> deserializer, TInput input){
			return await Task.Run<TOutput>(() => deserializer.Deserialize(input));
		}

	}

}
