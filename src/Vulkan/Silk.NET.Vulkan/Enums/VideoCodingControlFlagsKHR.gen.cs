// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoCodingControlFlagsKHR")]
    public enum VideoCodingControlFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DefaultKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_DEFAULT_KHR")]
        VideoCodingControlDefaultKhr = 0,
        [Obsolete("Deprecated in favour of \"ResetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR")]
        VideoCodingControlResetBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_DEFAULT_KHR")]
        DefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR")]
        ResetBitKhr = 1,
    }
}
