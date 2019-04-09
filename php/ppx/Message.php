<?php
// automatically generated by the FlatBuffers compiler, do not modify

namespace ppx;

use \Google\FlatBuffers\Struct;
use \Google\FlatBuffers\Table;
use \Google\FlatBuffers\ByteBuffer;
use \Google\FlatBuffers\FlatBufferBuilder;

class Message extends Table
{
    /**
     * @param ByteBuffer $bb
     * @return Message
     */
    public static function getRootAsMessage(ByteBuffer $bb)
    {
        $obj = new Message();
        return ($obj->init($bb->getInt($bb->getPosition()) + $bb->getPosition(), $bb));
    }

    public static function MessageIdentifier()
    {
        return "PPXF";
    }

    public static function MessageBufferHasIdentifier(ByteBuffer $buf)
    {
        return self::__has_identifier($buf, self::MessageIdentifier());
    }

    /**
     * @param int $_i offset
     * @param ByteBuffer $_bb
     * @return Message
     **/
    public function init($_i, ByteBuffer $_bb)
    {
        $this->bb_pos = $_i;
        $this->bb = $_bb;
        return $this;
    }

    /**
     * @return byte
     */
    public function getBodyType()
    {
        $o = $this->__offset(4);
        return $o != 0 ? $this->bb->getByte($o + $this->bb_pos) : \ppx\MessageBody::NONE;
    }

    /**
     * @returnint
     */
    public function getBody($obj)
    {
        $o = $this->__offset(6);
        return $o != 0 ? $this->__union($obj, $o) : null;
    }

    /**
     * @param FlatBufferBuilder $builder
     * @return void
     */
    public static function startMessage(FlatBufferBuilder $builder)
    {
        $builder->StartObject(2);
    }

    /**
     * @param FlatBufferBuilder $builder
     * @return Message
     */
    public static function createMessage(FlatBufferBuilder $builder, $body_type, $body)
    {
        $builder->startObject(2);
        self::addBodyType($builder, $body_type);
        self::addBody($builder, $body);
        $o = $builder->endObject();
        return $o;
    }

    /**
     * @param FlatBufferBuilder $builder
     * @param byte
     * @return void
     */
    public static function addBodyType(FlatBufferBuilder $builder, $bodyType)
    {
        $builder->addByteX(0, $bodyType, 0);
    }

    public static function addBody(FlatBufferBuilder $builder, $offset)
    {
        $builder->addOffsetX(1, $offset, 0);
    }

    /**
     * @param FlatBufferBuilder $builder
     * @return int table offset
     */
    public static function endMessage(FlatBufferBuilder $builder)
    {
        $o = $builder->endObject();
        return $o;
    }

    public static function finishMessageBuffer(FlatBufferBuilder $builder, $offset)
    {
        $builder->finish($offset, "PPXF");
    }
}
