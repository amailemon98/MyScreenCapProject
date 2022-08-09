using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Bitmap btnbase;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            btnbase = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using(Graphics g = Graphics.FromImage(btnbase))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                    0, 0,
                    btnbase.Size,
                    CopyPixelOperation.SourceCopy);
                PicBox1.Image = btnbase;
            }
        }

        private void BtnForSave_Click(object sender, EventArgs e)
        {
            if(btnbase != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "JPG File(*.jpg) | *.jpg";

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    btnbase.Save(sfd.FileName);
                }
            }
        }
    }
}
