using ControllerLogic;
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
using System.Windows.Shapes;
using RokuDataObjects;

namespace Roku_Controller
{
    /// <summary>
    /// Interaction logic for KeyboardInputForm.xaml
    /// </summary>
    public partial class KeyboardInputForm : Window
    {
        private RokuManager _rokuManager;
        private string currentText = "";

        public KeyboardInputForm(RokuManager rokuManager)
        {
            InitializeComponent();
            _rokuManager = rokuManager;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtEntry.Text = "";
            txtEntry.Focus();
        }

        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                _rokuManager.PressButton(KeyCode.Enter);
            }
        }
        private void txtEntry_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Back)
            {
                _rokuManager.PressButton(KeyCode.Backspace);
            }
        }

        private void txtEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var txt = textBox.Text;
            if (txt.Length - currentText.Length > 1)
            {
                _ = _rokuManager.SendMultipleKeyPress(txt);
            }
            else if (txt.Length > currentText.Length)
            {
                _rokuManager.SendKeyPress(txt.Last());
            }
            currentText = textBox.Text;
        }
    }
}
