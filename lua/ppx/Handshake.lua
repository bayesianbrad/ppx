-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: ppx

local flatbuffers = require('flatbuffers')

local Handshake = {} -- the module
local Handshake_mt = {} -- the class metatable

function Handshake.New()
    local o = {}
    setmetatable(o, {__index = Handshake_mt})
    return o
end
function Handshake.GetRootAsHandshake(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = Handshake.New()
    o:Init(buf, n + offset)
    return o
end
function Handshake_mt:Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end
function Handshake_mt:SystemName()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return self.view:String(o + self.view.pos)
    end
end
function Handshake.Start(builder) builder:StartObject(1) end
function Handshake.AddSystemName(builder, systemName) builder:PrependUOffsetTRelativeSlot(0, systemName, 0) end
function Handshake.End(builder) return builder:EndObject() end

return Handshake -- return the module