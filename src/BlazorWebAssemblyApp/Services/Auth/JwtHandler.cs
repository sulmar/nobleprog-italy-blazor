using System.Net.Http.Headers;

namespace BlazorWebAssemblyApp.Services.Auth;

public class JwtHandler : DelegatingHandler
{
    private readonly JwtAuthService _authService;

    public JwtHandler(JwtAuthService authService)
    {
        _authService = authService;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _authService.GetTokenAsync();

        if (!string.IsNullOrWhiteSpace(token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
