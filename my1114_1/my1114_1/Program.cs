
using hgd;
using System;
using System.Windows.Forms;
namespace hgd
{   partial class MainForm
    {
        public void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(313, 532);
            this.Name = "MainForm";
            this.Click += new System.EventHandler(this.xxx);
            this.ResumeLayout(false);

        }
    }
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        public void xxx(object o, EventArgs s)
        {
            System.Console.WriteLine("message by xxx");
        }
        protected override void OnClick(EventArgs e)
        {
            
            System.Console.WriteLine("클릭!");
            base.OnClick(e);/*여러분이 zzz를 만들고 클릭 델리게이트에 연결해줘도..*/

        }
    }
    

                                                                                                                                                                                    
    class My
    {
        static void Main(string[] args)
        {
            
            Application.Run(new MainForm());
            
        }
    }

}
