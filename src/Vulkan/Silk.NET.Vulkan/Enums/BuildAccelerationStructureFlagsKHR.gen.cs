// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBuildAccelerationStructureFlagsKHR")]
    public enum BuildAccelerationStructureFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AllowUpdateBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR")]
        BuildAccelerationStructureAllowUpdateBitKhr = 1,
        [Obsolete("Deprecated in favour of \"AllowCompactionBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR")]
        BuildAccelerationStructureAllowCompactionBitKhr = 2,
        [Obsolete("Deprecated in favour of \"PreferFastTraceBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR")]
        BuildAccelerationStructurePreferFastTraceBitKhr = 4,
        [Obsolete("Deprecated in favour of \"PreferFastBuildBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR")]
        BuildAccelerationStructurePreferFastBuildBitKhr = 8,
        [Obsolete("Deprecated in favour of \"LowMemoryBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR")]
        BuildAccelerationStructureLowMemoryBitKhr = 16,
        [Obsolete("Deprecated in favour of \"MotionBitNV\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV")]
        BuildAccelerationStructureMotionBitNV = 32,
        [Obsolete("Deprecated in favour of \"Reserved6BitNV\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_RESERVED_6_BIT_NV")]
        BuildAccelerationStructureReserved6BitNV = 64,
        [Obsolete("Deprecated in favour of \"Reserved7BitNV\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_RESERVED_7_BIT_NV")]
        BuildAccelerationStructureReserved7BitNV = 128,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR")]
        AllowUpdateBitKhr = 1,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR")]
        AllowCompactionBitKhr = 2,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR")]
        PreferFastTraceBitKhr = 4,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR")]
        PreferFastBuildBitKhr = 8,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR")]
        LowMemoryBitKhr = 16,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV")]
        MotionBitNV = 32,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_RESERVED_6_BIT_NV")]
        Reserved6BitNV = 64,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_RESERVED_7_BIT_NV")]
        Reserved7BitNV = 128,
    }
}
