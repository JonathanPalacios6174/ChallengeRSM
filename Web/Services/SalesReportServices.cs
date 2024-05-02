namespace Web.Services
{
    public class SalesReportServices
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public SalesReportServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetSalesReport()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:44306/");

                var response = await httpClient.GetAsync("api/SalesReport");
                response.EnsureSuccessStatusCode(); // Esto lanzará una excepción si no se recibe un estado de éxito (200-299)

                var content = await response.Content.ReadAsStringAsync();
                return content; // Devuelve el contenido de la respuesta
            }
            catch (HttpRequestException ex)
            {
                // Maneja los errores de solicitud HTTP
                throw new Exception($"Error de solicitud HTTP: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Maneja otros errores
                throw new Exception($"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
