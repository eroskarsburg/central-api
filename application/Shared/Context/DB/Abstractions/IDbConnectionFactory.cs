namespace application.Shared.Context.DB.Abstractions
{
    public interface IDbConnectionFactory
    {
        DbContext GetContext(string appSettingsSection);
    }
}
