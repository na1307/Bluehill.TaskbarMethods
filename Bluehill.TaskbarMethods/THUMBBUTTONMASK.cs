namespace Bluehill.TaskbarMethods;

/// <summary>
/// Used by the <see cref="THUMBBUTTON"/> structure to specify which members of that structure contain valid data.
/// </summary>
public enum THUMBBUTTONMASK {
    /// <summary>
    /// The <see cref="THUMBBUTTON.iBitmap"/> member contains valid information.
    /// </summary>
    Bitmap = 0x1,

    /// <summary>
    /// The <see cref="THUMBBUTTON.hIcon"/> member contains valid information.
    /// </summary>
    Icon = 0x2,

    /// <summary>
    /// The <see cref="THUMBBUTTON.szTip"/> member contains valid information.
    /// </summary>
    Tooltip = 0x4,

    /// <summary>
    /// The <see cref="THUMBBUTTON.dwFlags"/> member contains valid information.
    /// </summary>
    Flags = 0x8
}
