namespace Application.Arguments
{
    public class BrandOutput : BaseOutput<BrandOutput>
    {
        public string Name { get; set; }

        public BrandOutput() { }

        public BrandOutput(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
