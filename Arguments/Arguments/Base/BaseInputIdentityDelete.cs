namespace Arguments.Arguments
{
    public abstract class BaseInputIdentityDelete<TInpuIdentityDelete> where TInpuIdentityDelete : BaseInputIdentityDelete<TInpuIdentityDelete>
    {
        public long Id { get; set; }

        public BaseInputIdentityDelete(long id)
        {
            Id = id;
        }

        public BaseInputIdentityDelete()
        {
            
        }
    }
}
