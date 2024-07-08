namespace Application.Arguments
{
    public abstract class BaseInputIdentityUpdate<TInputUpdate> where TInputUpdate : BaseInputUpdate<TInputUpdate>
    {
        public long Id { get; set; }
        public TInputUpdate InputUpdate { get; set; }

        public BaseInputIdentityUpdate(long id, TInputUpdate inputUpdate)
        {
            Id = id;
            InputUpdate = inputUpdate;
        }
    }
}

