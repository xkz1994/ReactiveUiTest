using ReactiveUI;
using System.Reactive.Disposables;

namespace ReactiveUiTest;

public partial class NugetDetailsView : UserControl, IViewFor<NugetDetailsViewModel>
{
    public NugetDetailsViewModel? ViewModel { get; set; }

    /// <inheritdoc/>
    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = value as NugetDetailsViewModel;
    }

    public NugetDetailsView()
    {
        InitializeComponent();

        this.WhenActivated(disposableRegistration =>
        {
            this.OneWayBind(ViewModel,
                    viewModel => viewModel.IconUrl,
                    view => view.iconImage.ImageLocation)
                .DisposeWith(disposableRegistration);

            this.OneWayBind(ViewModel,
                    viewModel => viewModel.Title,
                    view => view.titleRun.Text)
                .DisposeWith(disposableRegistration);

            this.OneWayBind(ViewModel,
                    viewModel => viewModel.Description,
                    view => view.descriptionRun.Text)
                .DisposeWith(disposableRegistration);

            this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenPage,
                    view => view.titleRun)
                .DisposeWith(disposableRegistration);
        });
    }
}