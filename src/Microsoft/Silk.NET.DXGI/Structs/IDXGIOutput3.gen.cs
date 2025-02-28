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

namespace Silk.NET.DXGI
{
    [Guid("8a6bb301-7e7e-41f4-a8e0-5b32f7f99b18")]
    [NativeName("Name", "IDXGIOutput3")]
    public unsafe partial struct IDXGIOutput3
    {
        public static readonly Guid Guid = new("8a6bb301-7e7e-41f4-a8e0-5b32f7f99b18");

        public static implicit operator IDXGIOutput2(IDXGIOutput3 val)
            => Unsafe.As<IDXGIOutput3, IDXGIOutput2>(ref val);

        public static implicit operator IDXGIOutput1(IDXGIOutput3 val)
            => Unsafe.As<IDXGIOutput3, IDXGIOutput1>(ref val);

        public static implicit operator IDXGIOutput(IDXGIOutput3 val)
            => Unsafe.As<IDXGIOutput3, IDXGIOutput>(ref val);

        public static implicit operator IDXGIObject(IDXGIOutput3 val)
            => Unsafe.As<IDXGIOutput3, IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutput3 val)
            => Unsafe.As<IDXGIOutput3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIOutput3
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(OutputDesc* pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, OutputDesc*, int>)LpVtbl[7])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref OutputDesc pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutputDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, OutputDesc*, int>)LpVtbl[7])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForVBlank()
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, int>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TakeOwnership(Silk.NET.Core.Native.IUnknown* pDevice, int Exclusive)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevice, Exclusive);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TakeOwnership(ref Silk.NET.Core.Native.IUnknown pDevice, int Exclusive)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevicePtr, Exclusive);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseOwnership()
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, void>)LpVtbl[12])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControlCapabilities(GammaControlCapabilities* pGammaCaps)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControlCapabilities(ref GammaControlCapabilities pGammaCaps)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGammaControl(GammaControl* pArray)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, GammaControl*, int>)LpVtbl[14])(@this, pArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGammaControl(ref GammaControl pArray)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, GammaControl*, int>)LpVtbl[14])(@this, pArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControl(GammaControl* pArray)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, GammaControl*, int>)LpVtbl[15])(@this, pArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControl(ref GammaControl pArray)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, GammaControl*, int>)LpVtbl[15])(@this, pArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplaySurface(ref IDXGISurface pScanoutSurface)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestination);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData(ref IDXGISurface pDestination)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface* pDestinationPtr = &pDestination)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestinationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, FrameStatistics*, int>)LpVtbl[18])(@this, pStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FrameStatistics pStats)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FrameStatistics* pStatsPtr = &pStats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, FrameStatistics*, int>)LpVtbl[18])(@this, pStatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc1 pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc1* pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc1 pDesc)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestination);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData1(ref IDXGIResource pDestination)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pDestinationPtr = &pDestination)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestinationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplication);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SupportsOverlays()
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, int>)LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                fixed (uint* pFlagsPtr = &pFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
                }
            }
            return ret;
        }

    }
}
