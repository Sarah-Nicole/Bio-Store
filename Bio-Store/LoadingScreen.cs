using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bio_Store
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue; 
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            progressBarTimer.Start(); 
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;

            progressBar.Value = loadingBarValue;
            lblProgressValue.Text = loadingBarValue.ToString() + "%"; 

            if (loadingBarValue >= progressBar.Maximum)
            {
                progressBarTimer.Stop(); 
            }

        }
    }
}
