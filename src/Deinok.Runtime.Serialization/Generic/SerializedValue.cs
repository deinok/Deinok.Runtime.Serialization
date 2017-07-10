using System;

namespace Deinok.Runtime.Serialization.Generic {

	public interface ISerializedValue<T> {
		SerializedType Type { get; }
		T Value { get; set; }
	}

	public abstract class SerializedValue<T> : ISerializedValue<T> {
		public abstract SerializedType Type { get; }
		public T Value { get; set; }
	}

	public class SerializedStringValue : SerializedValue<string> {
		public override SerializedType Type { get; } = SerializedType.String;
	}

	public class SerializedIntegerValue : SerializedValue<int> {
		public override SerializedType Type { get; } = SerializedType.Integer;
	}

	public class SerializedFloatValue : SerializedValue<float> {
		public override SerializedType Type { get; } = SerializedType.Float;
	}

	public class SerializedBoolValue : SerializedValue<bool> {
		public override SerializedType Type { get; } = SerializedType.Bool;
	}

	public class SerializedEnumValue : SerializedValue<Enum> {
		public override SerializedType Type { get; } = SerializedType.Enum;
	}

	public class SerializedObjectValue : SerializedValue<Object> {
		public override SerializedType Type { get; } = SerializedType.Object;
	}

	public class SerializedArrayValue : SerializedValue<Array> {
		public override SerializedType Type { get; } = SerializedType.Array;
	}

}
