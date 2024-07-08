namespace Arguments.Arguments
{
    public class BrandOutput : BaseOutput<BrandOutput>
    {
        public string Name { get; set; }

        public BrandOutput() { }

        public BrandOutput(string name)
        {
            Name = name;
        }
    }
}
