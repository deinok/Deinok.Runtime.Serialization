using System;

namespace Deinok.Runtime.Serialization.Generic {

	public interface ISerializedMember<T>:ISerializedValue<T>  {
		string Name { get; set; }
	}
	
	public abstract class SerializedMember<T> : ISerializedMember<T> {
		public string Name { get; set; }
		public abstract SerializedType Type { get; }
		public T Value { get; set ; }
	}

	public class SerializedStringMember:SerializedMember<string> {
		public override SerializedType Type { get; } = SerializedType.String;
	}

	public class SerializedIntegerMember : SerializedMember<int> {
		public override SerializedType Type { get; } = SerializedType.Integer;
	}

	public class SerializedFloatMember : SerializedMember<float> {
		public override SerializedType Type { get; } = SerializedType.Float;
	}

	public class SerializedBoolMember : SerializedMember<bool> {
		public override SerializedType Type { get; } = SerializedType.Bool;
	}

	public class SerializedEnumMember : SerializedMember<Enum> {
		public override SerializedType Type { get; } = SerializedType.Enum;
	}

	public class SerializedObjectMember : SerializedMember<Object> {
		public override SerializedType Type { get; } = SerializedType.Object;
	}

	public class SerializedArrayMember : SerializedMember<Array> {
		public override SerializedType Type { get; } = SerializedType.Array;
	}

}
