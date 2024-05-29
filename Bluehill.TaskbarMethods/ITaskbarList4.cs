using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[ComImport]
[Guid("c43dc798-95d1-4bea-9030-bb99e2983a1a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskbarList4 : ITaskbarList3 {
    // ITaskbarList
    new void HrInit();
    new void AddTab(IntPtr hwnd);
    new void DeleteTab(IntPtr hwnd);
    new void ActivateTab(IntPtr hwnd);
    new void SetActiveAlt(IntPtr hwnd);

    // ITaskbarList2
    new void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

    // ITaskbarList3
    new void SetProgressValue(IntPtr hwnd, ulong ullCompleted, ulong ullTotal);
    new void SetProgressState(IntPtr hwnd, TaskbarState tbpFlags);
    new void RegisterTab(IntPtr hwndTab, IntPtr hwndMDI);
    new void UnregisterTab(IntPtr hwndTab);
    new void SetTabOrder(IntPtr hwndTab, IntPtr hwndInsertBefore);
    new void SetTabActive(IntPtr hwndTab, IntPtr hwndMDI, uint dwReserved);
    new void ThumbBarAddButtons(IntPtr hwnd, uint cButtons, [MarshalAs(UnmanagedType.LPArray)] ThumbButton[] pButtons);
    new void ThumbBarUpdateButtons(IntPtr hwnd, uint cButtons, [MarshalAs(UnmanagedType.LPArray)] ThumbButton[] pButtons);
    new void ThumbBarSetImageList(IntPtr hwnd, IntPtr himl);
    new void SetOverlayIcon(IntPtr hwnd, IntPtr hIcon, [MarshalAs(UnmanagedType.LPWStr)] string pszDescription);
    new void SetThumbnailTooltip(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszTip);
    new void SetThumbnailClip(IntPtr hwnd, in Rect prcClip);

    // ITaskbarList4
    void SetTabProperties(IntPtr hwndTab, TabProperties stpFlags);
}
