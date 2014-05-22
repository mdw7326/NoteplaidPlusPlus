﻿// Noteplaid: Notepad for Hipsters.
// <copyright file="MainWindow.xaml.cs" company="corb.co and Adam McCarthy">
//     corb.co and Adam McCarthy. All rights reserved.
// </copyright>
// <author>Corban Mailloux</author>
namespace Noteplaid
{
    using Microsoft.Win32;
    using System;
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for NOTEPLAID!
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// Creates the main window, with plaid, of course.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Open a new text file into Noteplaid.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private void OpenCommand_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "Text Files (.txt)|*.txt";

            openFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog.ShowDialog() == true)
            {
                // Read the file as one string.
                using (StreamReader file = new StreamReader(openFileDialog.FileName)) {
                    MainTextBox.Text = file.ReadToEnd();
                }
            }
        }
        
        /// <summary>
        /// Check if the Open command can execute.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private void OpenCommand_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            // Open can always execute, for now.
            e.CanExecute = true;
        }
    }
}
