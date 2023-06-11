using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Oculus_Void_Manager
{
    //TO-DO
    //Display the 
    public partial class Form1 : Form
    {

        public string CheckIfFilesExist()
        {
            string voidPath = @"\Support\oculus-dash\dash\assets\raw\textures\environment\the_void";
            string darkGridDDS = voidPath + @"\grid_plane_007.dds";
            string darkDotDDS = voidPath + @"\grid_plane_004.dds";
            string greyDotsDDS = voidPath + @"\grid_plane_003.dds";
            string lightGridDDS = voidPath + @"\grid_plane_006.dds";
            RegistryKey oculusKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Oculus VR, LLC\Oculus");
            string basePath = (string)oculusKey.GetValue("Base");
            if (Directory.Exists(basePath))
            {
                basePath += voidPath;
            }
            else
            {
                MessageBox.Show("Oculus Directory Not Found.");
                this.Close();
            }

            return basePath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check whichever one is named 006
            DefaultBtn.Checked = true;
            CheckIfFilesExist();

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void TitleLbl_Click(object sender, EventArgs e)
        {
            
        }

    }
}
