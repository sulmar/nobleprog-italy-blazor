# ✅ Blazor Component Lifecycle Methods

| Method               | Description                                                                                   | Example Usage                                                                |
|----------------------|-----------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------|
| `OnInitialized`      | Lifecycle method called when the component is initialized.                                    | `protected override void OnInitialized() { ... }`                             |
| `OnInitializedAsync` | Asynchronous version of `OnInitialized`, called when the component is initialized.            | `protected override async Task OnInitializedAsync() { ... }`                  |
| `OnParametersSet`    | Lifecycle method called after the component’s parameters have been set.                       | `protected override void OnParametersSet() { ... }`                           |
| `OnParametersSetAsync` | Asynchronous version of `OnParametersSet`.                                                   | `protected override async Task OnParametersSetAsync() { ... }`                |
| `OnAfterRender`      | Lifecycle method called after the component has finished rendering.                           | `protected override void OnAfterRender(bool firstRender) { ... }`             |
| `OnAfterRenderAsync` | Asynchronous version of `OnAfterRender`, called after rendering is completed.                 | `protected override async Task OnAfterRenderAsync(bool firstRender) { ... }`  |
| `Dispose`            | Lifecycle method called when the component is being disposed.                                 | `protected override void Dispose(bool disposing) { ... }`                     |
| `DisposeAsync`       | Asynchronous version of `Dispose`, called when the component is being disposed, allowing async cleanup. | `public async ValueTask DisposeAsync() { await _service.DisposeAsync(); }`   |

## 📄 Example Component

```razor
@implements IAsyncDisposable

<h3>Lifecycle Demo Component</h3>

<p>Current time: @CurrentTime</p>
<button @onclick="Refresh">Refresh Time</button>

@code {
    private string CurrentTime { get; set; } = string.Empty;
    private bool _disposed;

    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized called");
        CurrentTime = DateTime.Now.ToString("T");
    }

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("OnInitializedAsync called");
        await Task.Delay(100); // Simulate async work
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("OnParametersSet called");
    }

    protected override async Task OnParametersSetAsync()
    {
        Console.WriteLine("OnParametersSetAsync called");
        await Task.Delay(50); // Simulate async work
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine($"OnAfterRender called. First render: {firstRender}");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine($"OnAfterRenderAsync called. First render: {firstRender}");
        await Task.Delay(50); // Simulate async work
    }

    private void Refresh()
    {
        CurrentTime = DateTime.Now.ToString("T");
        StateHasChanged();
    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Console.WriteLine("Dispose called");
                // Dispose managed resources here
            }
            _disposed = true;
        }
        base.Dispose(disposing);
    }

    public async ValueTask DisposeAsync()
    {
        if (!_disposed)
        {
            Console.WriteLine("DisposeAsync called");
            // Dispose async resources here
            await Task.Delay(100);
            _disposed = true;
        }
    }
}
```