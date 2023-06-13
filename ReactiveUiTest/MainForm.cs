using ReactiveUI;
using System.Reactive.Disposables;

namespace ReactiveUiTest;

public partial class MainForm : Form, IViewFor<MainFormViewModel>
{
    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = value as MainFormViewModel;
    }

    public MainFormViewModel? ViewModel { get; set; }

    public MainForm()
    {
        InitializeComponent();
        ViewModel = new MainFormViewModel();

        this.WhenActivated(disposableRegistration =>
        {
            this.OneWayBind(ViewModel,
                    viewModel => viewModel.IsAvailable,
                    view => view.searchResultsListBox.Visible)
                .DisposeWith(disposableRegistration);

            this.OneWayBind(ViewModel,
                    viewModel => viewModel.SearchResults,
                    view => view.searchResultsListBox.Controls,
                    vmToViewConverterOverride: new ListBoxItemConverter())
                .DisposeWith(disposableRegistration);

            this.Bind(ViewModel,
                    viewModel => viewModel.SearchTerm,
                    view => view.searchTextBox.Text)
                .DisposeWith(disposableRegistration);
        });
    }
}