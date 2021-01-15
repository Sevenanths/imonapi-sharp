// Decompiled with JetBrains decompiler
// Type: iMon.DisplayApi.iMonNativeApi
// Assembly: iMonDisplayApiSharp, Version=0.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 5BCC6FD6-DF32-4D0B-AC75-9117D3827DF2
// Assembly location: Z:\Beast\xbmc-on-imon\XbmcOnImonVFD-frodo.v1.0.4ddd\XbmcOnImonVFD\iMonDisplayApiSharp.dll

using System;
using System.Runtime.InteropServices;

namespace iMon.DisplayApi
{
  public static class iMonNativeApi
  {
    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_Init(
      IntPtr hwndNoti,
      uint uMsgNotification);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_Uninit();

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_IsInited();

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_IsPluginModeEnabled();

    [DllImport("iMONDisplay.dll", CharSet = CharSet.Auto)]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetVfdText(
      string line1,
      string line2);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetVfdEqData(
      ref iMonNativeApi.iMonDisplayEqualizerData pEqData);

    [DllImport("iMONDisplay.dll", CharSet = CharSet.Auto)]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdText(
      string line);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdEqData(
      ref iMonNativeApi.iMonDisplayEqualizerData pEqDataL,
      ref iMonNativeApi.iMonDisplayEqualizerData pEqDataR);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdAllIcons(
      bool bOn);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdOrangeIcon(
      byte btIconData1,
      byte btIconData2);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdMediaTypeIcon(
      byte btIconData);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdSpeakerIcon(
      byte btIconData1,
      byte btIconData2);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdVideoCodecIcon(
      byte btIconData);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdAudioCodecIcon(
      byte btIconData);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdAspectRatioIcon(
      byte btIconData);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdEtcIcon(
      byte btIconData);

    [DllImport("iMONDisplay.dll")]
    public static extern iMonNativeApi.iMonDisplayResult IMON_Display_SetLcdProgress(
      int nCurPos,
      int nTotal);

    public enum iMonDisplayType
    {
      None,
      VFD,
      LCD,
    }

    public enum iMonDisplayResult
    {
      Succeeded = 0,
      Failed = 1,
      OutOfMemory = 2,
      InvalidArguments = 3,
      NotInitialized = 4,
      InvalidPointer = 5,
      Initialized = 4096, // 0x00001000
      ApiNotInitialized = 4097, // 0x00001001
      InPluginMode = 4098, // 0x00001002
      NotInPluginMode = 4099, // 0x00001003
    }

    public enum iMonDisplayNotifyCode
    {
      PluginSuccess = 0,
      PluginFailed = 1,
      iMonRestarted = 2,
      iMonClosed = 3,
      HardwareConnected = 4,
      HardwareDisconnected = 5,
      LCDTextScrollDone = 4096, // 0x00001000
    }

    [Serializable]
    public struct iMonDisplayEqualizerData
    {
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] BandData;
    }

    public enum iMonDisplayInitResult
    {
      Succeeded = 0,
      PluginModeAlreadyInUse = 256, // 0x00000100
      HardwareNotConnected = 257, // 0x00000101
      HardwareNotSupported = 258, // 0x00000102
      PluginModeDisabled = 259, // 0x00000103
      iMonNotResponding = 260, // 0x00000104
      Unknown = 512, // 0x00000200
    }
  }
}
