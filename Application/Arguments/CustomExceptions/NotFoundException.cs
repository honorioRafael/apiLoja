namespace Application.Arguments
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message = "ID não localizado.") : base(message)
        {
        }
    }
}
