// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PointParameterNameARB")]
    public enum PointParameterNameARB : int
    {
        [Obsolete("Deprecated in favour of \"SizeMinExt\"")]
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        PointSizeMinExt = 0x8126,
        [Obsolete("Deprecated in favour of \"SizeMaxExt\"")]
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        PointSizeMaxExt = 0x8127,
        [Obsolete("Deprecated in favour of \"FadeThresholdSize\"")]
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE")]
        PointFadeThresholdSize = 0x8128,
        [Obsolete("Deprecated in favour of \"FadeThresholdSizeExt\"")]
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        PointFadeThresholdSizeExt = 0x8128,
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        SizeMinExt = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        SizeMaxExt = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE")]
        FadeThresholdSize = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        FadeThresholdSizeExt = 0x8128,
    }
}
