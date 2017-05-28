using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization.Generic {

	/// <summary>
	/// A Generic Serializer
	/// </summary>
	/// <typeparam name="TOutput">The Output Type</typeparam>
	public interface IGenericSerializer<TOutput> {

		/// <summary>
		/// Serializes a TInput to TOutput
		/// </summary>
		/// <typeparam name="TInput">The Input Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		TOutput Serialize<TInput>(TInput input);

        /// <summary>
        /// Deserialize a TInput to a TOutput
        /// </summary>
        /// <typeparam name="TInput">The Input Type</typeparam>
        /// <param name="outputType">The Input</param>
        /// <returns>The Output</returns>
        TInput Deserialize<TInput>(TOutput outputType);

    }

    /// <summary>
    /// Extension Methods for IGenericSerializer
    /// </summary>
    public static class IGenericSerializerExtension {

        /// <summary>
        /// Serialize a TInput to a TOutput in a new thread
        /// </summary>
        /// <typeparam name="TInput">The Deserialized Type</typeparam>
        /// <typeparam name="TOutput">The Serialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="inputType">The Input</param>
        /// <returns>The Output Task</returns>
        public static async Task<TOutput> SerializeAsync<TInput, TOutput>(this IGenericSerializer<TOutput> serializer, TInput inputType) {
            return await Task.Run(() => {
                return serializer.Serialize(inputType);
            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Deserialize a TInput to a TOutput in a new thread
        /// </summary>
        /// <typeparam name="TInput">The Serialized Type</typeparam>
        /// <typeparam name="TOutput">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="outputType">The Input</param>
        /// <returns>The Output Task</returns>
        public static async Task<TInput> DeserializeAsync<TOutput, TInput>(this IGenericSerializer<TOutput> serializer, TOutput outputType) {
            return await Task.Run(() => {
                return serializer.Deserialize<TInput>(outputType);
            }).ConfigureAwait(false);
        }

    }

}
