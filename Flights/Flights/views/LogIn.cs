using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flights.controllers;
using Flights.Service;

namespace Flights
{
    public partial class LogIn : Form
    {
        private LogInController logInController;
        public LogIn(LogInController logInController)
        {
            InitializeComponent();
            this.logInController = logInController;

        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            logInController.signUp();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameField.Text;
                string password = passwordField.Text;
                logInController.logIn(username, password);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}