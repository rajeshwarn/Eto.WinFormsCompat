﻿using System.Windows.Forms;

namespace WinFormsCompatDemo.Designer
{
    public partial class MainForm : Form
    {
        #region Public Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        private void button1_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}