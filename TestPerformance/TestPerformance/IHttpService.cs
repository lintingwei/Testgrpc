namespace TestPerformance;

public interface IHttpService
{
    Task<string> GetAsync();
}