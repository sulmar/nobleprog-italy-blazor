# Blazor Libraries: Practical Recommendations

This short guide helps you decide when to include extra libraries in Blazor projects used in this training repository.

## 1) MudBlazor (UI components)

Official website: [MudBlazor](https://mudblazor.com/)

### When it is a good fit

- You want fast delivery of consistent UI (forms, dialogs, tables, navigation).
- You prefer ready-made components over building everything from scratch.
- You need a unified design system across multiple pages.

### When it may be unnecessary

- The app has very simple UI and default Blazor components are enough.
- You need full visual control and very custom component internals.
- Team prefers minimal external UI dependencies.

### Minimal start

```bash
dotnet add package MudBlazor
```

Then configure services and imports in your app startup and shared Razor imports (for example `Program.cs` and `_Imports.razor`).

## 2) bUnit (component testing)

Official website: [bUnit](https://bunit.dev)

### When it is a good fit

- You want fast feedback for Razor component behavior.
- You need stable tests for rendering, events, and parameters.
- You want to verify UI logic without full browser E2E setup.

### When it may be unnecessary

- You only test backend/business logic and do not test UI components.
- You rely mainly on end-to-end tests and keep UI very small.
- The project is an early prototype with no test budget yet.

### Minimal start

```bash
dotnet new xunit -o BlazorApp.Tests
cd BlazorApp.Tests
dotnet add package bunit
```

Then create component tests that render components, trigger events, and assert output.

Minimal `Counter` example:

```csharp
using Bunit;
using Xunit;

public class CounterTests : TestContext
{
    [Fact]
    public void CounterShouldIncrementWhenClicked()
    {
        // Arrange
        var cut = Render(@<Counter />);

        // Act
        cut.Find("button").Click();

        // Assert
        cut.Find("p").MarkupMatches(@<p>Current count: 1</p>);
    }
}
```

## 3) Recommendations for this training repository

- Use **MudBlazor** if exercises focus on richer UI composition, reusable layout patterns, and faster feature building.
- Use **bUnit** once components contain conditional rendering, user interaction, or non-trivial parameter/state logic.
- Keep adoption incremental: start with one feature/module, then expand after the team is comfortable.
- Treat both libraries as practical accelerators, not mandatory defaults for every lesson.
