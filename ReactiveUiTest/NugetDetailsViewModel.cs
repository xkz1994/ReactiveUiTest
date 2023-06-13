using NuGet.Protocol.Core.Types;
using ReactiveUI;
using System.Diagnostics;
using System.Reactive;

namespace ReactiveUiTest;

public class NugetDetailsViewModel
{
    public Uri IconUrl => _metadata.IconUrl ?? _defaultUrl;
    public string Description => _metadata.Description;
    public Uri ProjectUrl => _metadata.ProjectUrl;
    public string Title => _metadata.Title;

    public ReactiveCommand<Unit, Unit> OpenPage { get; }

    private readonly IPackageSearchMetadata _metadata;
    private readonly Uri _defaultUrl;

    public NugetDetailsViewModel(IPackageSearchMetadata metadata)
    {
        _metadata = metadata;
        _defaultUrl = new Uri("https://git.io/fAlfh");
        OpenPage = ReactiveCommand.Create(() =>
        {
            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = ProjectUrl.ToString()
            });
        });
    }
}