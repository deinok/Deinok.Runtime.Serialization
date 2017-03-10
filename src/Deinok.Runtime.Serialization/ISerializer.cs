using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Interface to Serialize a TInput to TOutput
	/// </summary>
	/// <typeparam name="TInput">The Deserialized Type</typeparam>
	/// <typeparam name="TOutput">The Serialized Type</typeparam>
    public interface ISerializer<TInput,TOutput> {

		/// <summary>
		/// Serialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		TOutput Serialize(TInput input);

    }

	/// <summary>
	/// Extension Methods for ISerializer
	/// </summary>
	public static class ISerializerExtension {

		/// <summary>
		/// Serialize a TInput to a TOutput in a new thread
		/// </summary>
		/// <typeparam name="TInput">The Deserialized Type</typeparam>
		/// <typeparam name="TOutput">The Serialized Type</typeparam>
		/// <param name="serializer">The Serializer instance</param>
		/// <param name="input">The Input</param>
		/// <returns>The Output Task</returns>
		public static async Task<TOutput> SerializeAsync<TInput, TOutput>(this ISerializer<TInput, TOutput> serializer, TInput input) {
			return await Task.Run(() => {
				return serializer.Serialize(input);
			});
		}

	}

}
