// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::FlatBuffers;

public struct Message : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Message GetRootAsMessage(ByteBuffer _bb) { return GetRootAsMessage(_bb, new Message()); }
  public static Message GetRootAsMessage(ByteBuffer _bb, Message obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool MessageBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "PPXF"); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Message __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public MessageBody BodyType { get { int o = __p.__offset(4); return o != 0 ? (MessageBody)__p.bb.Get(o + __p.bb_pos) : MessageBody.NONE; } }
  public TTable? Body<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }

  public static Offset<Message> CreateMessage(FlatBufferBuilder builder,
      MessageBody body_type = MessageBody.NONE,
      int bodyOffset = 0) {
    builder.StartObject(2);
    Message.AddBody(builder, bodyOffset);
    Message.AddBodyType(builder, body_type);
    return Message.EndMessage(builder);
  }

  public static void StartMessage(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddBodyType(FlatBufferBuilder builder, MessageBody bodyType) { builder.AddByte(0, (byte)bodyType, 0); }
  public static void AddBody(FlatBufferBuilder builder, int bodyOffset) { builder.AddOffset(1, bodyOffset, 0); }
  public static Offset<Message> EndMessage(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Message>(o);
  }
  public static void FinishMessageBuffer(FlatBufferBuilder builder, Offset<Message> offset) { builder.Finish(offset.Value, "PPXF"); }
  public static void FinishSizePrefixedMessageBuffer(FlatBufferBuilder builder, Offset<Message> offset) { builder.FinishSizePrefixed(offset.Value, "PPXF"); }
};


}
