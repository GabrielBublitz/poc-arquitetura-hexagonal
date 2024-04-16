namespace Api.Adapters
{
    public interface IEmailAdapter
    {
        public Task SendEmail(string from, string to, string subject, string body);
    }
}
