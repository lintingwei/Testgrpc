namespace TestPerformance;

public class HttpService: IHttpService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<string> GetAsync()
    {
        var httpClient = _httpClientFactory.CreateClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5079/Add?number1=10&number2=33");
        var response = await httpClient.SendAsync(request);
        return await response.Content.ReadAsStringAsync();
    }
}