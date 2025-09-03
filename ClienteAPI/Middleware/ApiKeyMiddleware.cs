namespace ClienteAPI.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string API_KEY_HEADER = "X-API-Key";
        private const string VALID_API_KEY = "mi-api-key-secreta-123"; // Cambia esto

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Verificar si la API KEY está presente
            if (!context.Request.Headers.TryGetValue(API_KEY_HEADER, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key no proporcionada");
                return;
            }

            // Verificar si la API KEY es válida
            if (!VALID_API_KEY.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key no válida");
                return;
            }

            // Si es válida, continuar con la petición
            await _next(context);
        }
    }
}