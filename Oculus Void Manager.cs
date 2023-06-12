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

using Microsoft.Win32;
//TO-DO

/* Record GIFS ------------------------- ColorClick()
 * 
 * Implement Non-default specificity --- CurrentString()
 * 
 * File.Copy --------------------------- DoneBtn.Click()   
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace Oculus_Void_Manager
{
    public partial class Form1 : Form
    {
        public char Chosen = 'X';

        public string CheckIfPathExist()
        {
            string voidPath = @"\Support\oculus-dash\dash\assets\raw\textures\environment\the_void\";
            RegistryKey oculusKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Oculus VR, LLC\Oculus");
            string basePath = (string)oculusKey.GetValue("Base");

            if (Directory.Exists(basePath))
                basePath += voidPath;
            else
            {
                MessageBox.Show("Oculus Directory Not Found.");
                this.Close();
            }

            return basePath;
        }

        public string CurrentString()
        {
            RegistryKey oculusKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Oculus VR, LLC\Oculus");
            string basePath = (string)oculusKey.GetValue("Base");
            string path = basePath + @"\Support\oculus-dash\dash\assets\raw\textures\environment\the_void\";

            if (Directory.GetFiles(path, "*.old").Length == 0)
                return "Default (White Lines)";
            else
            {
                return "Non-Default";
            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "OVM";
            DefaultBtn.Checked = true;
            CurrentLbl.Text = CurrentString();   
            CheckIfPathExist();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void DefaultBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.Default_Image;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources._default;
            Chosen = 'A';
        }

        private void GreyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.karam;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources.greydot;
            Chosen = 'B';
        }

        private void BlackLineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.karam;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources.blackline;
            Chosen = 'C';
        }

        private void BlackDotsBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.karam;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources.blackdot;
            Chosen = 'D';
        }

        private void DoneBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string C = CheckIfPathExist() + @"\grid_plane_007.dds";
            string D = CheckIfPathExist() + @"\grid_plane_004.dds";
            string B = CheckIfPathExist() + @"\grid_plane_003.dds";
            string A = CheckIfPathExist() + @"\grid_plane_006.dds";//default
            switch (Chosen)
            {
                case 'A':
                    if (CurrentLbl.Text[0] == 'D')
                    
                    File.Copy(x, x, true);
                    break;
                case 'B':
                    File.Copy(x, x, true);
                    break;
                case 'C':
                    File.Copy(x, x, true);
                    break;
                case 'D':
                    File.Copy(x, x, true);
                    break;
                case 'X':
                    MessageBox.Show("Error: Selection Not Found.");
                    break;
            }
        }
    }
}
