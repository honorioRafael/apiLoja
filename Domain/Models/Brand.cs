namespace Domain.Models
{
    public class Brand : BaseEntry<Brand>
    {
        public string Name { get; set; }
        public Brand()
        {

        }

        public Brand(string name)
        {
            Name = name;
        }
        
        //public Brand(long id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        /*public static implicit operator BrandOutput(Brand brand)
        {
            return brand == null ? default : new BrandOutput(brand.Name).LoadInternalData(brand.Id, brand.CreationDate, brand.ChangeDate);
        }*/
    }
}
