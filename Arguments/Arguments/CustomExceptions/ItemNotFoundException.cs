namespace Arguments.Arguments
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message = "Não foi localizado nenhum item com esse ID.") : base(message)
        { }
    }
}
