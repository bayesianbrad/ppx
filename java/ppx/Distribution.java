// automatically generated by the FlatBuffers compiler, do not modify

package ppx;

public final class Distribution {
  private Distribution() { }
  public static final byte NONE = 0;
  public static final byte Normal = 1;
  public static final byte Uniform = 2;
  public static final byte Categorical = 3;
  public static final byte Poisson = 4;

  public static final String[] names = { "NONE", "Normal", "Uniform", "Categorical", "Poisson", };

  public static String name(int e) { return names[e]; }
}

