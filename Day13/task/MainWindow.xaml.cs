using System.Collections.ObjectModel;
using System.Windows;
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
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Employees = new ObservableCollection<Employee>();

            Employees.Add(new Employee { Id = _nextId++, FullName = "Иванов Иван Иванович", Position = "Разработчик" });
            Employees.Add(new Employee { Id = _nextId++, FullName = "Петров Петр Петрович", Position = "Менеджер" });

            AddCommand = new RelayCommand(_ => Add()); // всегда
            EditCommand = new RelayCommand(_ => Edit(), _ => SelectedEmployee != null); // только если выбран сотрудник
            DeleteCommand = new RelayCommand(_ => Delete(), _ => SelectedEmployee != null);
        }
        private void Add()
        {
            var dialog = new EditDialog();
            if (dialog.ShowDialog() == true)
            {
                Employees.Add(new Employee { Id = _nextId++, FullName = dialog.FullName, Position = dialog.Position });
            }
        }
        private void Edit()
        {
            var dialog = new EditDialog(SelectedEmployee.FullName, SelectedEmployee.Position);
            if (dialog.ShowDialog() == true)
            {
                SelectedEmployee.FullName = dialog.FullName;
                SelectedEmployee.Position = dialog.Position;
                var index = Employees.IndexOf(SelectedEmployee);
                Employees[index] = SelectedEmployee;
            }
        }
        private void Delete()
        {
            if (MessageBox.Show($"Удалить {SelectedEmployee.FullName}?", "Подтверждение",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Employees.Remove(SelectedEmployee);
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
    }
}