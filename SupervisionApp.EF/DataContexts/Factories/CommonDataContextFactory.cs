namespace SupervisionApp.EF.DataContexts.Factories
{
    public class CommonDataContextFactory : DataContextFactory<CommonDataContext>
    {
        public CommonDataContextFactory(string connectionString) : base(connectionString)
        {

        }
    }
}
