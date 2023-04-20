﻿using GitHub.JPMikkers.DHCP;
using System;

namespace ManagedDHCPService;

[Serializable()]
public class OptionConfigurationBootFileName : OptionConfiguration
{
    public string Name;

    public OptionConfigurationBootFileName()
    {
        Name = "";
    }

    protected override IDHCPOption ConstructDHCPOption()
    {
        return new DHCPOptionBootFileName(Name);
    }
}