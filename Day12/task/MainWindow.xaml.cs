using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtFullName.Text) && CmbPosition.SelectedItem != null)
            {
                var pos = (CmbPosition.SelectedItem as ComboBoxItem).Content.ToString();
                employees.Add(new Employee(TxtFullName.Text, pos));
                ClearFields();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesGrid.SelectedItem is Employee selected)
            {
                selected.FullName = TxtFullName.Text;
                selected.Position = (CmbPosition.SelectedItem as ComboBoxItem).Content.ToString();
                EmployeesGrid.Items.Refresh(); // обновляем отображение
            }
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesGrid.SelectedItem is Employee selected)
            {
                employees.Remove(selected);
                ClearFields();
            }
        }
        private void Filter_Changed(object sender, RoutedEventArgs e)
        {
            // проверка, список инициализирован и sender — это RadioButton
            if (employees == null || !(sender is RadioButton rb)) return;

            //оператор ?. чтобы избежать ошибки, если Tag пустой
            string filter = rb.Tag?.ToString();

            if (string.IsNullOrEmpty(filter)) return;

            if (filter == "All")
                EmployeesGrid.ItemsSource = employees;
            else
                EmployeesGrid.ItemsSource = employees.Where(emp => emp.Position == filter).ToList();
        }
        private void EmployeesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //при выборе строки в таблице
        {
            if (EmployeesGrid.SelectedItem is Employee selected)
            {
                TxtFullName.Text = selected.FullName;
                foreach (ComboBoxItem item in CmbPosition.Items)
                {
                    if (item.Content.ToString() == selected.Position)
                    {
                        CmbPosition.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private void ClearFields()
        {
            TxtFullName.Clear();
            CmbPosition.SelectedIndex = -1;
        }
    }
}
