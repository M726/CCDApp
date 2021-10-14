using System.Runtime.InteropServices;

namespace CCDApp
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ImageProperty
    {
        [FieldOffset(0)] public int CameraID;
        [FieldOffset(4)] public int Row;
        [FieldOffset(8)] public int Column;
        [FieldOffset(12)] public int Bin;
        [FieldOffset(16)] public int XStart;
        [FieldOffset(20)] public int YStart;
        [FieldOffset(24)] public int ExposureTime;
        [FieldOffset(28)] public int RedGain;
        [FieldOffset(32)] public int GreenGain;
        [FieldOffset(36)] public int BlueGain;
        [FieldOffset(40)] public int TimeStamp;
        [FieldOffset(44)] public int TriggerOccurred;
        [FieldOffset(48)] public int TriggerEventCount;
        [FieldOffset(52)] public int UserMark;
        [FieldOffset(56)] public int FrameTime;
        [FieldOffset(60)] public int CCDFrequency;
        [FieldOffset(64)] public int ProcessFrameType;
        [FieldOffset(68)] public int tFilterAcceptForFile;
    }
}