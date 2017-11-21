using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my1115
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            Graphics gildong = this.CreateGraphics();//화가
            gildong.DrawString("Click!",Font, new SolidBrush(Color.Blue),10,10);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(new Pen(color: Color.Red), e.X, e.Y, 50, 50);
        }
    }
}
