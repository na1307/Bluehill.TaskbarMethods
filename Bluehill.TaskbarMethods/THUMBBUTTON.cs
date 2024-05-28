using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
[CLSCompliant(false)]
public struct THUMBBUTTON {
    public THUMBBUTTONMASK dwMask;
    public uint iId;
    public uint iBitmap;
    public IntPtr hIcon;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szTip;
    public THUMBBUTTONFLAGS dwFlags;
}
