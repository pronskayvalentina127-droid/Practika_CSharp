using System.Windows;
namespace EmployeeApp
{
    public partial class EditDialog : Window
    {
        public string FullName { get; private set; }
        public string Position { get; private set; }

        public EditDialog()
        {
            InitializeComponent();
        }
        public EditDialog(string fullName, string position)
        {
            InitializeComponent();
            txtFullName.Text = fullName;
            cbPosition.Text = position;
        }
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(cbPosition.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            FullName = txtFullName.Text.Trim();
            Position = cbPosition.Text.Trim();
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