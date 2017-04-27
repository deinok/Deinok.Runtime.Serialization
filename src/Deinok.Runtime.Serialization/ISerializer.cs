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
		/// <param name="inputType">The Input</param>
		/// <returns>The Output</returns>
		TOutput Serialize(TInput inputType);

        /// <summary>
        /// Deserialize a TInput to a TOutput
        /// </summary>
        /// <param name="outputType">The Input</param>
        /// <returns>The Input</returns>
        TInput Deserialize(TOutput outputType);

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
		/// <param name="inputType">The Input</param>
		/// <returns>The Output Task</returns>
		public static async Task<TOutput> SerializeAsync<TInput, TOutput>(this ISerializer<TInput, TOutput> serializer, TInput inputType) {
			return await Task.Run(() => {
				return serializer.Serialize(inputType);
			});
		}

        /// <summary>
        /// Deserialize a TInput to a TOutput in a new thread
        /// </summary>
        /// <typeparam name="TInput">The Serialized Type</typeparam>
        /// <typeparam name="TOutput">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="outputType">The Input</param>
        /// <returns>The Output Task</returns>
        public static async Task<TInput> DeserializeAsync<TOutput, TInput>(this ISerializer<TInput, TOutput> serializer, TOutput outputType) {
            return await Task.Run(() => {
                return serializer.Deserialize(outputType);
            });
        }

    }

}
