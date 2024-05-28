namespace Bluehill.TaskbarMethods;

/// <summary>
/// Used by the <see cref="Win7TaskbarMethods.SetTabProperties(IntPtr, STPFLAG)"/> method to specify tab properties.
/// </summary>
[Flags]
public enum STPFLAG {
    /// <summary>
    /// No specific property values are specified. The default behavior is used: the tab window provides a thumbnail and peek image, either live or static as appropriate.
    /// </summary>
    None = 0,

    /// <summary>
    /// Always use the thumbnail provided by the main application frame window rather than a thumbnail provided by the individual tab window. Do not combine this value with <see cref="UseAppThumbnailWhenActive"/>; doing so will result in an error.
    /// </summary>
    UseAppThumbnailAlways = 0x1,

    /// <summary>
    /// When the application tab is active and a live representation of its window is available, use the main application's frame window thumbnail. At other times, use the tab window thumbnail. Do not combine this value with <see cref="UseAppThumbnailAlways"/>; doing so will result in an error.
    /// </summary>
    UseAppThumbnailWhenActive = 0x2,

    /// <summary>
    /// Always use the peek image provided by the main application frame window rather than a peek image provided by the individual tab window. Do not combine this value with <see cref="UseAppPeekWhenActive"/>; doing so will result in an error.
    /// </summary>
    UseAppPeekAlways = 0x4,

    /// <summary>
    /// When the application tab is active and a live representation of its window is available, show the main application frame in the peek feature. At other times, use the tab window. Do not combine this value with <see cref="UseAppPeekAlways"/>; doing so will result in an error.
    /// </summary>
    UseAppPeekWhenActive = 0x8
}
