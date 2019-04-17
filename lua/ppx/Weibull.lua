-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: ppx

local flatbuffers = require('flatbuffers')

local Weibull = {} -- the module
local Weibull_mt = {} -- the class metatable

function Weibull.New()
    local o = {}
    setmetatable(o, {__index = Weibull_mt})
    return o
end
function Weibull.GetRootAsWeibull(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = Weibull.New()
    o:Init(buf, n + offset)
    return o
end
function Weibull_mt:Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end
function Weibull_mt:Scale()
    local o = self.view:Offset(4)
    if o ~= 0 then
        local x = self.view:Indirect(o + self.view.pos)
        local obj = require('ppx.Tensor').New()
        obj:Init(self.view.bytes, x)
        return obj
    end
end
function Weibull_mt:Concentration()
    local o = self.view:Offset(6)
    if o ~= 0 then
        local x = self.view:Indirect(o + self.view.pos)
        local obj = require('ppx.Tensor').New()
        obj:Init(self.view.bytes, x)
        return obj
    end
end
function Weibull.Start(builder) builder:StartObject(2) end
function Weibull.AddScale(builder, scale) builder:PrependUOffsetTRelativeSlot(0, scale, 0) end
function Weibull.AddConcentration(builder, concentration) builder:PrependUOffsetTRelativeSlot(1, concentration, 0) end
function Weibull.End(builder) return builder:EndObject() end

return Weibull -- return the module