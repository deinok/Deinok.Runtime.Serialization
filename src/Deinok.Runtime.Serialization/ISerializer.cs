using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

    /// <summary>
    /// Interface to Serialize a TComplex to TSerialized
    /// </summary>
    /// <typeparam name="TComplex">The Deserialized Type</typeparam>
    /// <typeparam name="TSerialized">The Serialized Type</typeparam>
    public interface ISerializer<TComplex,TSerialized>:IOnlySerializer<TComplex,TSerialized>,IOnlyDeserializer<TComplex,TSerialized> {

    }

}
