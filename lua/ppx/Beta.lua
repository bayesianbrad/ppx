-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: ppx

local flatbuffers = require('flatbuffers')

local Beta = {} -- the module
local Beta_mt = {} -- the class metatable

function Beta.New()
    local o = {}
    setmetatable(o, {__index = Beta_mt})
    return o
end
function Beta.GetRootAsBeta(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = Beta.New()
    o:Init(buf, n + offset)
    return o
end
function Beta_mt:Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end
function Beta_mt:Low()
    local o = self.view:Offset(4)
    if o ~= 0 then
        local x = self.view:Indirect(o + self.view.pos)
        local obj = require('ppx.Tensor').New()
        obj:Init(self.view.bytes, x)
        return obj
    end
end
function Beta_mt:High()
    local o = self.view:Offset(6)
    if o ~= 0 then
        local x = self.view:Indirect(o + self.view.pos)
        local obj = require('ppx.Tensor').New()
        obj:Init(self.view.bytes, x)
        return obj
    end
end
function Beta.Start(builder) builder:StartObject(2) end
function Beta.AddLow(builder, low) builder:PrependUOffsetTRelativeSlot(0, low, 0) end
function Beta.AddHigh(builder, high) builder:PrependUOffsetTRelativeSlot(1, high, 0) end
function Beta.End(builder) return builder:EndObject() end

return Beta -- return the module