namespace Bluehill.TaskbarMethods;

/// <summary>
/// Used by the <see cref="ThumbButton"/> structure to specify which members of that structure contain valid data.
/// </summary>
[Flags]
public enum ThumbButtonMask {
    /// <summary>
    /// The <see cref="ThumbButton.iBitmap"/> member contains valid information.
    /// </summary>
    Bitmap = 0x1,

    /// <summary>
    /// The <see cref="ThumbButton.hIcon"/> member contains valid information.
    /// </summary>
    Icon = 0x2,

    /// <summary>
    /// The <see cref="ThumbButton.szTip"/> member contains valid information.
    /// </summary>
    Tooltip = 0x4,

    /// <summary>
    /// The <see cref="ThumbButton.dwFlags"/> member contains valid information.
    /// </summary>
    Flags = 0x8
}
