using Arguments.Arguments;

namespace Domain.Models
{
    public class Category : BaseEntry<Category>
    {
        public string Name { get; set; }

        public Category()
        { }

        public Category(string name)
        {
            Name = name;
        }

        public static implicit operator CategoryOutput(Category category)
        {
            return category == null ? default : new CategoryOutput() { Name = category.Name }.LoadInternalData(category.Id, category.CreationDate, category.ChangeDate);
        }
    }
}
