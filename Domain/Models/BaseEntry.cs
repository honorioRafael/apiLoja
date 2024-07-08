namespace Domain.Models
{
    public class BaseEntry<TEntry>
        where TEntry : BaseEntry<TEntry>
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ChangeDate { get; set; }

        public TEntry LoadInternalData(long id, DateTime creationDate, DateTime? changeDate)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;

            return (TEntry)this;
        }

        public TEntry SetCreationDate()
        {
            CreationDate = DateTime.Now;
            return (TEntry)this;
        }

        public TEntry SetChangeDate()
        {
            ChangeDate = DateTime.Now;
            return (TEntry)this;
        }
    }
}
