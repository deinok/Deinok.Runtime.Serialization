using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

    /// <summary>
    /// Interface to Serialize a TComplex to TSerialized
    /// </summary>
    /// <typeparam name="TSerialized">The Serialized Type</typeparam>
    public interface IGenericSerializer<TSerialized> {

        /// <summary>
        /// Serializes a TComplex to TSerialized
        /// </summary>
        /// <typeparam name="TComplex">The Complex Type</typeparam>
        /// <param name="input">The TComplex Input</param>
        /// <returns>The TSerialized Output</returns>
        TSerialized Serialize<TComplex>(TComplex input);

        /// <summary>
        /// Deserialize a TSerialized to a TComplex
        /// </summary>
        /// <typeparam name="TComplex">The TComplex Type</typeparam>
        /// <param name="input">The TSerialized Input</param>
        /// <returns>The TComplex Output</returns>
        TComplex Deserialize<TComplex>(TSerialized input);

    }

    /// <summary>
    /// Extension Methods for IGenericSerializer
    /// </summary>
    public static class IGenericSerializerExtension {

        /// <summary>
        /// Serialize a TComplex to a TOutput async
        /// </summary>
        /// <typeparam name="TComplex">The Deserialized Type</typeparam>
        /// <typeparam name="TSerialized">The Serialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="input">The TComplex Input</param>
        /// <returns>The TSerialized Task</returns>
        public static async Task<TSerialized> SerializeAsync<TComplex, TSerialized>(this IGenericSerializer<TSerialized> serializer, TComplex input) {
            return await Task.Run(() => {
                return serializer.Serialize<TComplex>(input);
            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Deserialize a TSerialized to a TComplex async
        /// </summary>
        /// <typeparam name="TSerialized">The Serialized Type</typeparam>
        /// <typeparam name="TComplex">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="input">The TSerialized Input</param>
        /// <returns>The TComplex Output Task</returns>
        public static async Task<TComplex> DeserializeAsync<TComplex, TSerialized>(this IGenericSerializer<TSerialized> serializer, TSerialized input) {
            return await Task.Run(() => {
                return serializer.Deserialize<TComplex>(input);
            }).ConfigureAwait(false);
        }

    }

}
