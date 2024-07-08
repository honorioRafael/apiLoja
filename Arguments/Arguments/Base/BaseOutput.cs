namespace Arguments.Arguments
{
    public abstract class BaseOutput<TOutput> where TOutput : BaseOutput<TOutput>
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ChangeDate { get; set; }

        public virtual TOutput LoadInternalData(long id, DateTime creationDate, DateTime? changeDate)
        {
            Id = id;
            CreationDate = creationDate;
            ChangeDate = changeDate;

            return (TOutput)this;
        }
    }
}
