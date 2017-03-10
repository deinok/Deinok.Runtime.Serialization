using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Interface to Deserialize a TInput to TOutput
	/// </summary>
	/// <typeparam name="TInput">The Serialized Type</typeparam>
	/// <typeparam name="TOutput">The Deserialized Type</typeparam>
	public interface IDeserializer<TInput, TOutput> {

		/// <summary>
		/// Deserialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		TOutput Deserialize(TInput input);

	}

	/// <summary>
	/// Extension Methods for IDeserializer
	/// </summary>
	public static class IDeserializerExtension {

		/// <summary>
		/// Deserialize a TInput to a TOutput in a new thread
		/// </summary>
		/// <typeparam name="TInput">The Serialized Type</typeparam>
		/// <typeparam name="TOutput">The Deserialized Type</typeparam>
		/// <param name="deserializer">The Deserializer instance</param>
		/// <param name="input">The Input</param>
		/// <returns>The Output Task</returns>
		public static async Task<TOutput> DeserializeAsync<TInput, TOutput>(this IDeserializer<TInput, TOutput> deserializer, TInput input) {
			return await Task.Run(() => {
				return deserializer.Deserialize(input);
			});
		}

	}

}
