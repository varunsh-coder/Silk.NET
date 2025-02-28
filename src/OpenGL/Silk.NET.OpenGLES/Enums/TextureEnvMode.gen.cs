// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureEnvMode")]
    public enum TextureEnvMode : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_ADD")]
        Add = 0x104,
        [NativeName("Name", "GL_BLEND")]
        Blend = 0xBE2,
        [System.Obsolete]
        [NativeName("Name", "GL_MODULATE")]
        Modulate = 0x2100,
        [System.Obsolete]
        [NativeName("Name", "GL_DECAL")]
        Decal = 0x2101,
        [NativeName("Name", "GL_REPLACE_EXT")]
        ReplaceExt = 0x8062,
        [NativeName("Name", "GL_TEXTURE_ENV_BIAS_SGIX")]
        TextureEnvBiasSgix = 0x80BE,
    }
}
