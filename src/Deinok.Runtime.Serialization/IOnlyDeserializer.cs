using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

    /// <summary>
    /// Interface to Deserialize a TSerialized to TComplex
    /// </summary>
    /// <typeparam name="TComplex">The Deserialized Type</typeparam>
    /// <typeparam name="TSerialized">The Serialized Type</typeparam>
    public interface IOnlyDeserializer<TComplex,TSerialized> {

        /// <summary>
        /// Deserialize a TSerialized to a TComplex
        /// </summary>
        /// <param name="input">The TSerialized Input</param>
        /// <returns>The TComplex Output</returns>
        TComplex Deserialize(TSerialized input);

    }

    /// <summary>
    /// Extension Methods for IOnlyDeserializer
    /// </summary>
    public static class IOnlyDeserializerExtension {

        /// <summary>
        /// Deserialize a TSerialized to a TComplex async
        /// </summary>
        /// <typeparam name="TComplex">The Serialized Type</typeparam>
        /// <typeparam name="TSerialized">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="input">The TSerialized Input</param>
        /// <returns>The TComplex Task</returns>
        public static async Task<TComplex> DeserializeAsync<TComplex, TSerialized>(this ISerializer<TComplex, TSerialized> serializer, TSerialized input) {
            return await Task.Run(() => {
                return serializer.Deserialize(input);
            }).ConfigureAwait(false);
        }

    }

}
