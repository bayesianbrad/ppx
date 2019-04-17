// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::FlatBuffers;

public struct Weibull : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Weibull GetRootAsWeibull(ByteBuffer _bb) { return GetRootAsWeibull(_bb, new Weibull()); }
  public static Weibull GetRootAsWeibull(ByteBuffer _bb, Weibull obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Weibull __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Tensor? Scale { get { int o = __p.__offset(4); return o != 0 ? (Tensor?)(new Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Tensor? Concentration { get { int o = __p.__offset(6); return o != 0 ? (Tensor?)(new Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Weibull> CreateWeibull(FlatBufferBuilder builder,
      Offset<Tensor> scaleOffset = default(Offset<Tensor>),
      Offset<Tensor> concentrationOffset = default(Offset<Tensor>)) {
    builder.StartObject(2);
    Weibull.AddConcentration(builder, concentrationOffset);
    Weibull.AddScale(builder, scaleOffset);
    return Weibull.EndWeibull(builder);
  }

  public static void StartWeibull(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddScale(FlatBufferBuilder builder, Offset<Tensor> scaleOffset) { builder.AddOffset(0, scaleOffset.Value, 0); }
  public static void AddConcentration(FlatBufferBuilder builder, Offset<Tensor> concentrationOffset) { builder.AddOffset(1, concentrationOffset.Value, 0); }
  public static Offset<Weibull> EndWeibull(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Weibull>(o);
  }
};


}
