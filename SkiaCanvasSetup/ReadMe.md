**Basic SKCanvas setup in .NET MAUI**

Demonstrates unhandled exception when updating from 2.88.2 to 2.88.3 in Windows (.net 7.0 only)

This has been fixed - see https://github.com/mono/SkiaSharp/issues/2271

Insert the following into you csproj file to fix 2.88.3;

```
  <ItemGroup>
    <FrameworkReference Update="Microsoft.Windows.SDK.NET.Ref" RuntimeFrameworkVersion="10.0.19041.27" TargetingPackVersion="10.0.19041.27" />
  </ItemGroup>
  ```
