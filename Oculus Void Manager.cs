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
 *      Say they select black dots while Default
 *      Name default to .old
 *      name black dots to .006
 *      
 *      Select default from black dots
 *      Name
 */

namespace Oculus_Void_Manager
{
    public partial class Form1 : Form
    {
        public string Chosen = "InitalizedValue";

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

            ////////////
            string newString = basePath + @"\grid_plane_006.dds";
            Bitmap B = new Bitmap(newString);
            Color x = B.GetPixel(500, 500);
            label1.ForeColor = x;
            ////////////
            
            return basePath;
        }

        public string GetCurrentString()
        {
            RegistryKey oculusKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Oculus VR, LLC\Oculus");
            string basePath = (string)oculusKey.GetValue("Base");
            string path = basePath + @"\Support\oculus-dash\dash\assets\raw\textures\environment\the_void\";

            if (Directory.GetFiles(path, "*.old").Length == 0)
                return "Default (White Lines)";
            else
            {
                /*Bitmap B = new Bitmap(path + @"\grid_plane_006.dds");
                Color x = B.GetPixel(500, 500);*/
                return "Non-Default";
            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "OVM";
            DefaultBtn.Checked = true;
            CurrentLbl.Text = GetCurrentString();   
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
            Chosen = "Default (White Lines)";
        }

        private void GreyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.karam;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources.greydot;
            Chosen = "Grey Dots";
        }

        private void BlackLineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.karam;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources.blackline;
            Chosen = "Black Lines";
        }

        private void BlackDotsBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentImage.Image = Oculus_Void_Manager.Properties.Resources.karam;
            gifBox.Image = Oculus_Void_Manager.Properties.Resources.blackdot;
            Chosen = "Black Dots";
        }

        private void DoneBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string C = CheckIfPathExist() + @"\grid_plane_007.dds";
            string D = CheckIfPathExist() + @"\grid_plane_004.dds";
            string B = CheckIfPathExist() + @"\grid_plane_003.dds";
            string A = CheckIfPathExist() + @"\grid_plane_006.dds";//default
/*
            if(CurrentLbl.Text == Chosen)
            {
                MessageBox.Show(Chosen + " is already selected.");
                this.Close();
            }
            else
            {
                switch (Chosen)
                {
                    case "Default (White Lines)":
                        //Check if chosen is already selected
                        if (CurrentLbl.Text[0] == 'D')
                            MessageBox.Show("Default is already selected");
                    
                        File.Copy(x, x, true);
                        break;
                    case "Grey Dots":
                        break;
                    case "Black Lines":
                        break;
                    case "Black Dots":
                        break;
                    case "InitializedValue":
                        MessageBox.Show("Error: Selection Not Found.");
                        break;
                } 
            }*/
            
        }
    }
}
