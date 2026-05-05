using System.Windows;
using System.Windows.Controls;
using Day15.ViewModels;

namespace Day15.Views
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = DataContext as MainViewModel;
        }

        private void CbPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_viewModel == null) return;
            var item = cbPosition.SelectedItem as ComboBoxItem;
            if (item != null)
                _viewModel.ApplyPositionFilter(item.Content.ToString());
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
        private void ReportAll_Click(object sender, RoutedEventArgs e) => MessageBox.Show($"Всего сотрудников: {_viewModel?.Employees.Count ?? 0}", "Отчёт");
        private void About_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Автоматизация учета сотрудников\nВерсия 3.0\nMVVM + Асинхронность", "О программе");
    }
}