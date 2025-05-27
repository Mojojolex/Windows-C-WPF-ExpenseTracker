using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows;

namespace ExpenseTracker
{
    public partial class MainWindow : Window
    {
        private const string connectionString = "Data Source=expenses.db;Version=3;";

        public MainWindow()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Expenses (Id INTEGER PRIMARY KEY, Date TEXT, Description TEXT, Amount REAL)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var date = ExpenseDatePicker.SelectedDate?.ToString("yyyy-MM-dd");
            var description = DescriptionTextBox.Text;
            var amount = Convert.ToDecimal(AmountTextBox.Text);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Expenses (Date, Description, Amount) VALUES (@date, @description, @amount)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.ExecuteNonQuery();
                }
            }

            // Clear inputs
            DescriptionTextBox.Clear();
            AmountTextBox.Clear();
            ExpenseDatePicker.SelectedDate = null;
        }

        private void ViewSummaryButton_Click(object sender, RoutedEventArgs e)
        {
            // Fetch and display summary logic here
        }

        private void DescriptionTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Hide placeholder if user focuses on the TextBox
            // Assuming you have a reference to the placeholder TextBlock
        }

        private void DescriptionTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Show placeholder if TextBox is empty
        }
    }
}