namespace PokeStarter
{
    internal class PokeApiService
    {
        private readonly HttpClient _apiClient;

        public PokeApiService(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }
    }
}
