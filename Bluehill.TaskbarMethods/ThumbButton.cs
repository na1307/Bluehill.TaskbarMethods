using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

/// <summary>
/// Used by methods of the ITaskbarList3 interface to define buttons used in a toolbar embedded in a window's thumbnail representation.
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
[CLSCompliant(false)]
public struct ThumbButton {
    /// <summary>
    /// A combination of <see cref="ThumbButtonMask"/> values that specify which members of this structure contain valid data; other members are ignored, with the exception of iId, which is always required.
    /// </summary>
    public ThumbButtonMask dwMask;

    /// <summary>
    /// The application-defined identifier of the button, unique within the toolbar.
    /// </summary>
    public uint iId;

    /// <summary>
    /// The zero-based index of the button image within the image list set through <see cref="Win7TaskbarMethods.ThumbBarSetImageList(IntPtr, IntPtr)"/>.
    /// </summary>
    public uint iBitmap;

    /// <summary>
    /// The handle of an icon to use as the button image.
    /// </summary>
    public IntPtr hIcon;

    /// <summary>
    /// A wide character array that contains the text of the button's tooltip, displayed when the mouse pointer hovers over the button.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szTip;

    /// <summary>
    /// A combination of <see cref="ThumbButtonStates"/> values that control specific states and behaviors of the button.
    /// </summary>
    public ThumbButtonStates dwFlags;
}
