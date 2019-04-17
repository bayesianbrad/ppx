// automatically generated by the FlatBuffers compiler, do not modify

package ppx;

import java.nio.*;
import java.lang.*;
import java.util.*;
import com.google.flatbuffers.*;

@SuppressWarnings("unused")
public final class Weibull extends Table {
  public static Weibull getRootAsWeibull(ByteBuffer _bb) { return getRootAsWeibull(_bb, new Weibull()); }
  public static Weibull getRootAsWeibull(ByteBuffer _bb, Weibull obj) { _bb.order(ByteOrder.LITTLE_ENDIAN); return (obj.__assign(_bb.getInt(_bb.position()) + _bb.position(), _bb)); }
  public void __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; }
  public Weibull __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Tensor scale() { return scale(new Tensor()); }
  public Tensor scale(Tensor obj) { int o = __offset(4); return o != 0 ? obj.__assign(__indirect(o + bb_pos), bb) : null; }
  public Tensor concentration() { return concentration(new Tensor()); }
  public Tensor concentration(Tensor obj) { int o = __offset(6); return o != 0 ? obj.__assign(__indirect(o + bb_pos), bb) : null; }

  public static int createWeibull(FlatBufferBuilder builder,
      int scaleOffset,
      int concentrationOffset) {
    builder.startObject(2);
    Weibull.addConcentration(builder, concentrationOffset);
    Weibull.addScale(builder, scaleOffset);
    return Weibull.endWeibull(builder);
  }

  public static void startWeibull(FlatBufferBuilder builder) { builder.startObject(2); }
  public static void addScale(FlatBufferBuilder builder, int scaleOffset) { builder.addOffset(0, scaleOffset, 0); }
  public static void addConcentration(FlatBufferBuilder builder, int concentrationOffset) { builder.addOffset(1, concentrationOffset, 0); }
  public static int endWeibull(FlatBufferBuilder builder) {
    int o = builder.endObject();
    return o;
  }
}

