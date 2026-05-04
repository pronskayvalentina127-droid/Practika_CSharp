using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EmployeeApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public Employee SelectedEmployee { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private int _nextId = 1;
        private ObservableCollection<Employee> _allEmployees;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Employees = new ObservableCollection<Employee>();
            _allEmployees = new ObservableCollection<Employee>();

            Employees.Add(new Employee { Id = _nextId++, FullName = "Иванов Иван Иванович", Position = "Разработчик" });
            Employees.Add(new Employee { Id = _nextId++, FullName = "Петров Петр Петрович", Position = "Менеджер" });
            Employees.Add(new Employee { Id = _nextId++, FullName = "Сидорова Анна Сергеевна", Position = "Аналитик" });

            foreach (var e in Employees)
                _allEmployees.Add(e);

            AddCommand = new RelayCommand(_ => Add());
            EditCommand = new RelayCommand(_ => Edit(), _ => SelectedEmployee != null);
            DeleteCommand = new RelayCommand(_ => Delete(), _ => SelectedEmployee != null);
        }

        private void Add()
        {
            var dialog = new EditDialog();
            if (dialog.ShowDialog() == true)
            {
                var emp = new Employee { Id = _nextId++, FullName = dialog.FullName, Position = dialog.Position };
                Employees.Add(emp);
                _allEmployees.Add(emp);
            }
        }

        private void Edit()
        {
            if (SelectedEmployee == null) return;
            var dialog = new EditDialog(SelectedEmployee.FullName, SelectedEmployee.Position);
            if (dialog.ShowDialog() == true)
            {
                SelectedEmployee.FullName = dialog.FullName;
                SelectedEmployee.Position = dialog.Position;
            }
        }

        private void Delete()
        {
            if (SelectedEmployee == null) return;
            if (MessageBox.Show($"Удалить {SelectedEmployee.FullName}?", "Подтверждение",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Employees.Remove(SelectedEmployee);
                _allEmployees.Remove(SelectedEmployee);
            }
        }

        private void CbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_allEmployees == null) return;

            string filter = (cbFilter.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (string.IsNullOrEmpty(filter)) return;

            Employees.Clear();

            if (filter == "Все")
            {
                foreach (var emp in _allEmployees)
                    Employees.Add(emp);
            }
            else
            {
                foreach (var emp in _allEmployees.Where(x => x.Position == filter))
                    Employees.Add(emp);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();

        private void ReportAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Всего сотрудников: {Employees.Count}", "Отчёт",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ReportByPosition_Click(object sender, RoutedEventArgs e)
        {
            var developers = Employees.Count(x => x.Position == "Разработчик");
            var managers = Employees.Count(x => x.Position == "Менеджер");
            var analysts = Employees.Count(x => x.Position == "Аналитик");
            MessageBox.Show($"Разработчики: {developers}\nМенеджеры: {managers}\nАналитики: {analysts}",
                "Отчёт по должностям", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автоматизация учета сотрудников\nВерсия 2.0",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}