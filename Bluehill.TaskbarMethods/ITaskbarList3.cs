using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[ComImport]
[Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskbarList3 : ITaskbarList2 {
    [PreserveSig]
    void SetProgressValue(IntPtr hwnd, ulong ullCompleted, ulong ullTotal);
    [PreserveSig]
    void SetProgressState(IntPtr hwnd, TaskbarStates tbpFlags);
    [PreserveSig]
    void RegisterTab(IntPtr hwndTab, IntPtr hwndMDI);
    [PreserveSig]
    void UnregisterTab(IntPtr hwndTab);
    [PreserveSig]
    void SetTabOrder(IntPtr hwndTab, IntPtr hwndInsertBefore);
    [PreserveSig]
    void SetTabActive(IntPtr hwndTab, IntPtr hwndMDI, uint dwReserved = 0);
    [PreserveSig]
    void ThumbBarAddButtons(IntPtr hwnd, uint cButtons, [MarshalAs(UnmanagedType.LPArray)] THUMBBUTTON[] pButtons);
    [PreserveSig]
    void ThumbBarUpdateButtons(IntPtr hwnd, uint cButtons, [MarshalAs(UnmanagedType.LPArray)] THUMBBUTTON[] pButtons);
    [PreserveSig]
    void ThumbBarSetImageList(IntPtr hwnd, IntPtr himl);
    [PreserveSig]
    void SetOverlayIcon(IntPtr hwnd, IntPtr hIcon, [MarshalAs(UnmanagedType.LPWStr)] string pszDescription);
    [PreserveSig]
    void SetThumbnailTooltip(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszTip);
    [PreserveSig]
    void SetThumbnailClip(IntPtr hwnd, in RECT prcClip);
}
