﻿using System.ComponentModel;

namespace RdtClient.Data.Enums;

public enum Provider
{
    [Description("RealDebrid")]
    RealDebrid,

    [Description("AllDebrid")]
    AllDebrid,

    [Description("Premiumize")]
    Premiumize,

    [Description("DebridLinkFr")]
    DebridLinkFr,

    [Description("TorBox")]
    TorBox
}