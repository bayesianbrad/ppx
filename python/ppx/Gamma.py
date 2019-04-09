# automatically generated by the FlatBuffers compiler, do not modify

# namespace: ppx

import flatbuffers

class Gamma(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsGamma(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = Gamma()
        x.Init(buf, n + offset)
        return x

    # Gamma
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # Gamma
    def Concentration(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Indirect(o + self._tab.Pos)
            from .Tensor import Tensor
            obj = Tensor()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # Gamma
    def Rate(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            x = self._tab.Indirect(o + self._tab.Pos)
            from .Tensor import Tensor
            obj = Tensor()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

def GammaStart(builder): builder.StartObject(2)
def GammaAddConcentration(builder, concentration): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(concentration), 0)
def GammaAddRate(builder, rate): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(rate), 0)
def GammaEnd(builder): return builder.EndObject()
