// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::FlatBuffers;

public struct Uniform : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Uniform GetRootAsUniform(ByteBuffer _bb) { return GetRootAsUniform(_bb, new Uniform()); }
  public static Uniform GetRootAsUniform(ByteBuffer _bb, Uniform obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Uniform __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Tensor? Low { get { int o = __p.__offset(4); return o != 0 ? (Tensor?)(new Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Tensor? High { get { int o = __p.__offset(6); return o != 0 ? (Tensor?)(new Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Uniform> CreateUniform(FlatBufferBuilder builder,
      Offset<Tensor> lowOffset = default(Offset<Tensor>),
      Offset<Tensor> highOffset = default(Offset<Tensor>)) {
    builder.StartObject(2);
    Uniform.AddHigh(builder, highOffset);
    Uniform.AddLow(builder, lowOffset);
    return Uniform.EndUniform(builder);
  }

  public static void StartUniform(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddLow(FlatBufferBuilder builder, Offset<Tensor> lowOffset) { builder.AddOffset(0, lowOffset.Value, 0); }
  public static void AddHigh(FlatBufferBuilder builder, Offset<Tensor> highOffset) { builder.AddOffset(1, highOffset.Value, 0); }
  public static Offset<Uniform> EndUniform(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Uniform>(o);
  }
};


}
