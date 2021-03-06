﻿using AppGet.HostSystem;
using AppGet.Manifest.Hash;
using FluentAssertions;
using NUnit.Framework;

namespace AppGet.Tests.HostSystem
{
    public class MachineIdFixture : TestBase<MachineId>
    {
        [Test]
        [Explicit]
        public void get_machine_guid()
        {
            Mocker.Use<ICalculateHash>(new Sha256());

            var guid = Subject.MachineKey.Value;

            guid.Should().NotBeEmpty();
            guid.Should().NotContain("=");
        }
    }
}
