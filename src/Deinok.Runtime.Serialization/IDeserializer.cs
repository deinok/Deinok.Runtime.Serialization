using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Interface to Deserialize a TInput to TOutput
	/// </summary>
	/// <typeparam name="TInput">The Input Type</typeparam>
	/// <typeparam name="TOutput">The Output Type</typeparam>
	public interface IDeserializer<TInput, TOutput> {

		/// <summary>
		/// Deserialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input Type</param>
		/// <returns>The Output Type</returns>
		TOutput Deserialize(TInput input);

	}

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
		public static async Task<TOutput> DeserializeAsync<TInput, TOutput>(this IDeserializer<TInput, TOutput> deserializer, TInput input) {
			return await Task.Run(() => deserializer.Deserialize(input));
		}

	}

}
