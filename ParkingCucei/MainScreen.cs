﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCucei
{
    public partial class MainScreen : Form
    {
        string currentUser = "";
        public MainScreen(string userName)
        {
            InitializeComponent();
            currentUser = userName;
            lblWelcome.Text = currentUser;
        }

        
    }
}