namespace Domain.Adapters.DataBse
{
    public interface IDBContext : IDisposable
    {
        void Commit();

        void RollBack();

        void NewTransaction();
    }
}
