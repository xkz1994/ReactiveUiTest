using ReactiveUI;
using ReactiveUI.Winforms;
using System.Collections;

namespace ReactiveUiTest;

public class ListBoxItemConverter : IBindingTypeConverter
{
    /// <summary>
    /// 验证
    /// </summary>
    public int GetAffinityForObjects(Type fromType, Type toType)
    {
        if (toType != typeof(Control.ControlCollection))
            return 0;

        return fromType.GetInterface(nameof(IEnumerable)) == null ? 0 : 10;
    }

    /// <summary>
    /// 转换
    /// </summary>
    public bool TryConvert(object? from, Type toType, object? conversionHint, out object? result)
    {
        if (from is not IEnumerable enumerable)
        {
            result = null;
            return false;
        }

        var viewModelControlHosts =
            (from object? viewModel in enumerable
             select new ViewModelControlHost { ViewModel = viewModel, Dock = DockStyle.Top, Height = 100 })
            .ToList();

        result = viewModelControlHosts;
        return true;
    }
}