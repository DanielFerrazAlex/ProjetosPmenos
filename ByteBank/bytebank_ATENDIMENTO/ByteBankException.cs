using System.Runtime.Serialization;

[Serializable]
internal class ByteBankException : Exception
{
    public ByteBankException()
    {
    }

    public ByteBankException(string? message) : base(message)
    {
    }

    public ByteBankException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ByteBankException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}