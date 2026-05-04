using System.Windows;
using System.Windows.Controls;

namespace EmployeeApp
{
    public partial class EditDialog : Window
    {
        public string FullName { get; private set; }
        public string Position { get; private set; }

        public EditDialog()
        {
            InitializeComponent();
            Title = "Добавление сотрудника";
        }

        public EditDialog(string fullName, string position)
        {
            InitializeComponent();
            Title = "Редактирование сотрудника";
            txtFullName.Text = fullName;
            cbPosition.Text = position;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО", "Ошибка");
                return;
            }

            if (cbPosition.SelectedItem == null)
            {
                MessageBox.Show("Выберите должность", "Ошибка");
                return;
            }

            FullName = txtFullName.Text.Trim();
            Position = (cbPosition.SelectedItem as ComboBoxItem).Content.ToString();
            DialogResult = true;
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}