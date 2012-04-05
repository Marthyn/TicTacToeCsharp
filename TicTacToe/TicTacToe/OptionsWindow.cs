using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class OptionsWindow : Form
    {
        private MainWindow mainWindow;
        public OptionsWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Player p1 = mainWindow.getPlayer(1);
            Player p2 = mainWindow.getPlayer(2);
            if (p1 != null)
            {
                name_p1.Text = p1.getName();
            }
            if (p2 != null)
            {
                name_p2.Text = p2.getName();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (name_p1.Text != "" && name_p2.Text != "" && name_p1.Text.Length < 17 && name_p2.Text.Length < 17)
            {
                mainWindow.setPlayers(name_p1.Text, ai_p1.Checked, name_p2.Text, ai_p2.Checked);
                this.Close();
            }
            else
            {
                MessageBox.Show("Either one or both names are empty or longer than 16 signs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
