using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class Struct17
    {
        public Struct17(BitReader reader)
        {
            num = reader.ReadUInt16();
            for(var i = 0; i < num; i++)
            {
                field0s.Add(reader.ReadUInt32());
            }
        }
        public UInt16 num;
        public List<UInt32> field0s = new List<UInt32>();
    }
}
