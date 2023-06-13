using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol.Core.Types;
using ReactiveUI;
using System.Reactive.Linq;

namespace ReactiveUiTest;

public class MainFormViewModel : ReactiveObject
{
    private string _searchTerm = "";

    public string SearchTerm
    {
        get => _searchTerm;
        set => this.RaiseAndSetIfChanged(ref _searchTerm, value);
    }

    private readonly ObservableAsPropertyHelper<IEnumerable<NugetDetailsViewModel>?> _searchResults;
    public IEnumerable<NugetDetailsViewModel>? SearchResults => _searchResults.Value;

    private readonly ObservableAsPropertyHelper<bool> _isAvailable;
    public bool IsAvailable => _isAvailable.Value;

    private async Task<IEnumerable<NugetDetailsViewModel>> SearchNuGetPackages(string? term, CancellationToken token)
    {
        /*
         * // 创建一个延迟初始化的字符串
         *       Lazy<string> lazyString = new Lazy<string>(() =>
         *       {
         *           Console.WriteLine("Initializing string...");
         *           return "Hello, World!";
         *       });
         *
         *       // 访问延迟初始化的字符串
         *       Console.WriteLine(lazyString.Value); // 初始化字符串并输出
         *
         *       // 再次访问延迟初始化的字符串，不会重新初始化
         *       Console.WriteLine(lazyString.Value); // 直接输出已初始化的字符串
         */
        // 配置NuGet客户端设置
        var providers = new List<Lazy<INuGetResourceProvider>>();
        providers.AddRange(Repository.Provider.GetCoreV3()); // Add v3 API support

        var package = new PackageSource("https://api.nuget.org/v3/index.json");
        var source = new SourceRepository(package, providers);
        // 创建资源提供程序
        var resource = await source.GetResourceAsync<PackageSearchResource>(token).ConfigureAwait(false);
        // 创建搜索查询
        var filter = new SearchFilter(false);

        // 执行搜索
        var metadata = await resource.SearchAsync(term, filter, 0, 10, NullLogger.Instance, token).ConfigureAwait(false);
        return metadata.Select(x => new NugetDetailsViewModel(x));
    }

    public MainFormViewModel()
    {
        _searchResults = this
            .WhenAnyValue(x => x.SearchTerm)
            .Throttle(TimeSpan.FromMilliseconds(800)) // 用于限制事件流的频率，以便在指定的时间间隔内只接收最新的事件。这对于处理高频率事件流或限制用户界面上的响应非常有用
            .Select(term => term?.Trim())
            .DistinctUntilChanged()
            .Where(term => string.IsNullOrWhiteSpace(term) == false)
            .SelectMany(SearchNuGetPackages)
            .ObserveOn(RxApp.MainThreadScheduler)
            .ToProperty(this, x => x.SearchResults);

        _searchResults.ThrownExceptions.Subscribe(error =>
        {
            /* Handle errors here */
        });

        _isAvailable = this
            .WhenAnyValue(x => x.SearchResults)
            .Select(searchResults => searchResults is not null)
            .ToProperty(this, x => x.IsAvailable);
    }
}