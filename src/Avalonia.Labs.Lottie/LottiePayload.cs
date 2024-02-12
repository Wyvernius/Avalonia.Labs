using Avalonia.Media;

namespace Avalonia.Labs.Lottie;

internal record struct LottiePayload(
    LottieCommand LottieCommand,
    SkiaSharp.Skottie.Animation? Animation = null,
    Stretch? Stretch = null,
    StretchDirection? StretchDirection = null,
    AnimationLoop? LottieLoop = null,
    double? StartLoop = null,
    double? EndLoop = null,
    int? RepeatCount = null);
