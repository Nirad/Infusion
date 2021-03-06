﻿using FluentAssertions;
using Infusion.Packets.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infusion.Tests.Packets.Server
{
    [TestClass]
    public class ConnectToGameServerPacketTests
    {
        [TestMethod]
        public void Can_get_GameServerIP()
        {
            var packet = new ConnectToGameServerPacket();
            packet.Deserialize(FakePackets.ConnectToGameServerPacket);

            packet.GameServerIp.Should().BeEquivalentTo(new byte[] {0x7F, 0x00, 0x00, 0x01});
        }

        [TestMethod]
        public void Can_set_GameServerIp()
        {
            var packet = new ConnectToGameServerPacket();
            packet.Deserialize(FakePackets.ConnectToGameServerPacket);
            var gameServerIp = new byte[] {0xFF, 0xFE, 0xFD, 0xFC};

            packet.GameServerIp = gameServerIp;

            gameServerIp.Should().BeEquivalentTo(packet.GameServerIp);
            gameServerIp.Should().BeSubsetOf(packet.RawPacket.Payload);
        }

        [TestMethod]
        public void Can_get_GameServerPort()
        {
            var packet = new ConnectToGameServerPacket();
            packet.Deserialize(FakePackets.ConnectToGameServerPacket);

            packet.GameServerPort.Should().Be(2593);
        }

        [TestMethod]
        public void Can_set_GameServerPort()
        {
            var packet = new ConnectToGameServerPacket();
            packet.Deserialize(FakePackets.ConnectToGameServerPacket);
            packet.GameServerPort = 0xAABB;

            packet.GameServerPort.Should().Be(0xAABB);
            new byte[] {0xAA, 0xBB}.Should().BeSubsetOf(packet.RawPacket.Payload);
        }
    }
}