// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRenderPassCreationFeedbackInfoEXT")]
    public unsafe partial struct RenderPassCreationFeedbackInfoEXT
    {
        public RenderPassCreationFeedbackInfoEXT
        (
            uint? postMergeSubpassCount = null
        ) : this()
        {
            if (postMergeSubpassCount is not null)
            {
                PostMergeSubpassCount = postMergeSubpassCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "postMergeSubpassCount")]
        public uint PostMergeSubpassCount;
    }
}
