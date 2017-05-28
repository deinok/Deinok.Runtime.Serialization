using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

    /// <summary>
    /// A Generic Serializer
    /// </summary>
    /// <typeparam name="TSerialized">The Serialized Type</typeparam>
    public interface IGenericSerializer<TSerialized> {

        /// <summary>
        /// Serializes a TComplex to TSerialized
        /// </summary>
        /// <typeparam name="TComplex">The Complex Type</typeparam>
        /// <param name="input">The TComplex Input</param>
        /// <returns>The Output</returns>
        TSerialized Serialize<TComplex>(TComplex input);

        /// <summary>
        /// Deserialize a TSerialized to a TComplex
        /// </summary>
        /// <typeparam name="TComplex">The TComplex Type</typeparam>
        /// <param name="outputType">The TSerialized Input</param>
        /// <returns>The TComplex</returns>
        TComplex Deserialize<TComplex>(TSerialized outputType);

    }

    /// <summary>
    /// Extension Methods for IGenericSerializer
    /// </summary>
    public static class IGenericSerializerExtension {

        /// <summary>
        /// Serialize a TInput to a TOutput in a new thread
        /// </summary>
        /// <typeparam name="TComplex">The Deserialized Type</typeparam>
        /// <typeparam name="TSerialized">The Serialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="inputType">The Input</param>
        /// <returns>The Output Task</returns>
        public static async Task<TSerialized> SerializeAsync<TComplex, TSerialized>(this IGenericSerializer<TSerialized> serializer, TComplex inputType) {
            return await Task.Run(() => {
                return serializer.Serialize<TComplex>(inputType);
            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Deserialize a TInput to a TOutput in a new thread
        /// </summary>
        /// <typeparam name="TSerialized">The Serialized Type</typeparam>
        /// <typeparam name="TComplex">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="outputType">The Input</param>
        /// <returns>The Output Task</returns>
        public static async Task<TComplex> DeserializeAsync<TSerialized, TComplex>(this IGenericSerializer<TSerialized> serializer, TSerialized outputType) {
            return await Task.Run(() => {
                return serializer.Deserialize<TComplex>(outputType);
            }).ConfigureAwait(false);
        }

    }

}
