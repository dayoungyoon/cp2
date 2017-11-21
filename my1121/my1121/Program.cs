using System;
using System.Windows.Forms;

namespace XXX
{
    partial class MainForm : Form//Form을 라이브러리화 하기위해 xxx관련된것들을 모두 분리
    {
        public void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.Text = "Dayoung";
            this.ClientSize = new System.Drawing.Size(325, 568);
            this.Name = "MainForm";
            this.Click += new System.EventHandler(this.zzz);
            this.ResumeLayout(false);

        }

    }
    partial class MainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void xxx(object o, EventArgs e)
        {
            System.Console.WriteLine("Click!!");
        }
        public void zzz(object o, EventArgs e)
        {
            System.Console.WriteLine("message by zzz");
        }
        /*protected override void OnClick(EventArgs e)
        {
            System.Console.WriteLine("Hello,workd");
        }*/
        /*원래 온클릭함수가 이거여서 클릭이 실행되는데 위처럼 오버라이딩하면 
         * 클릭이 실행되지않고 헬로월드가 실행됨
        public void Onclick(EventArgs e)
        {
            if (Click != null)
                Click();
        }*/
    }
    class My
    {

        public static void Main()
        {
            Application.Run(new MainForm());
        }//마우스를 클릭하는순간 이벤트가 발생하고 운영체제가 발생한 이벤트를 MainForm의 객체의 이벤트 큐에 넣어줌
         //런함수는 메인폼의 이벤트큐를 확인하며 이벤트 발생이 알게 되면 어떤 이벤트인지 확인하고 
         //메인폼의 객체에게 그이벤트에 해당하는 것을 실행시켜줌 클릭이라고 하면 온클릭
    }/*가장간단한 폼프로그램
class My
{
    public static void Main()
    {
        Application.Run(new Form());
    }
}*/
}