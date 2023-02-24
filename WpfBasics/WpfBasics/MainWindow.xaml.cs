using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.DescriptionTextBox.Text);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = false;
            this.AssemblyCheckBox.IsChecked = false;
            this.PlasmaCheckBox.IsChecked = false;
            this.LaserCheckBox.IsChecked = false;
            this.PurchaseCheckBox.IsChecked = false;
            this.LatheCheckBox.IsChecked = false;
            this.DrillCheckBox.IsChecked = false;
            this.FoldCheckBox.IsChecked = false;
            this.RollCheckBox.IsChecked = false;
            this.SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextBox.Text += (string)((CheckBox)sender).Content;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.LengthTextBox.Text =
                this.LengthTextBox.Text.Replace((string)((CheckBox)sender).Content, string.Empty);
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteTextBox == null) return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteTextBox.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropdown, null);
        }

        private void SupplierNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassTextBox.Text = this.SupplierNameTextBox.Text;
        }
    }
}
