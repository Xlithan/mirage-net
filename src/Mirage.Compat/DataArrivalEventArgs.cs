namespace Mirage.Compat;

public sealed class DataArrivalEventArgs(byte[] bytes) : EventArgs
{
    public byte[] Bytes { get; } = bytes;
}