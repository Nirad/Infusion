﻿using System.IO;
using Infusion.IO;

namespace Infusion.Packets.Client
{
    internal sealed class SpeechRequest : MaterializedPacket
    {
        private Packet rawPacket;

        public override void Deserialize(Packet rawPacket)
        {
            this.rawPacket = rawPacket;
            var reader = new ArrayPacketReader(rawPacket.Payload);
            reader.ReadByte();
            reader.ReadUShort();
            Type = (SpeechType)reader.ReadByte();
            Color = reader.ReadUShort();
            Font = reader.ReadUShort();
            Language = reader.ReadString(4);
            if (((int)Type & 0xC0) != 0)
            {
                ushort rawBytes = reader.ReadUShort();
                int keywordCount = (rawBytes & 0x0FFF) >> 4;
                if (keywordCount > 0)
                {
                    reader.ReadByte();
                    keywordCount--;
                }
                while (keywordCount != 0)
                {
                    reader.ReadUShort();
                    keywordCount--;
                }

                Text = reader.ReadNullTerminatedString();
            }
            else
            {
                Text = reader.ReadNullTerminatedUnicodeString();
            }
        }

        public SpeechType Type { get; set; }

        public ushort Color { get; set; }

        public ushort Font { get; set; }

        public string Text { get; set; }

        public string Language { get; set; }

        public override Packet RawPacket
        {
            get
            {
                using (var stream = new MemoryStream())
                {
                    ushort textLength = (this.Text.Length < ushort.MaxValue) ? (ushort)this.Text.Length : ushort.MaxValue;
                    string text = (this.Text.Length < ushort.MaxValue) ? Text : Text.Substring(0, ushort.MaxValue);

                    var writer = new StreamPacketWriter(stream);
                    writer.WriteByte((byte)PacketDefinitions.SpeechRequest.Id);
                    writer.WriteUShort((ushort)(14 + textLength * 2));
                    writer.WriteByte((byte)Type);
                    writer.WriteUShort(Font);
                    writer.WriteUShort(Color);
                    writer.WriteNullTerminatedString(Language, 4);
                    writer.WriteUnicodeString(text);
                    writer.WriteByte(0x00);
                    writer.WriteByte(0x00);


                    return new Packet(PacketDefinitions.SpeechRequest.Id, stream.ToArray());
                }
            }
        }
    }
}
