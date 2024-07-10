namespace Arguments.Arguments
{
    public class NameInUseException : Exception
    {
        public NameInUseException(string message) : base(message)
        { }
    }
}
