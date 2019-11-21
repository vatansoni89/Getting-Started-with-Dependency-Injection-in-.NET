using PeopleViewer.Presentation;
using System.Windows;

namespace PeopleViewer.View
{
    public partial class PeopleViewerWindow : Window
    {
        private PeopleViewModel viewModel;

        public PeopleViewerWindow(PeopleViewModel peopleViewModel)
        {
            InitializeComponent();
            viewModel = peopleViewModel;
            this.DataContext = viewModel;
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RefreshPeople();
            ShowRepositoryType();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearPeople();
            ClearRepositoryType();
        }

        private void ShowRepositoryType()
        {
            RepositoryTypeTextBlock.Text = viewModel.DataReaderType;
        }

        private void ClearRepositoryType()
        {
            RepositoryTypeTextBlock.Text = string.Empty;
        }
    }
}