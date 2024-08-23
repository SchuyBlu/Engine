# Engine

Incredibly simple game engine project, to be built alongside my computer graphics class.

## Building & Testing

The build dependencies are fairly straightforward. [MonoGame](https://monogame.net/) is required to run, as well as [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0). After cloning the repository, run:

```
dotnet build; dotnet run --project ./src/Engine.csproj
```

This should work independant of platform. To test just run `dotnet test`.