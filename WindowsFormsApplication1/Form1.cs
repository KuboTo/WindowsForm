using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //事件的本质就是一种方法
            //MessageBox.Show("窗体加载完成");

            this.Text = "天降之物";
            //MainForm;.Text = "修改Text属性";

            Button myButton = new Button();
            myButton.Text = "伊卡洛斯";
            this.Controls.Add(myButton);


        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("单击事件");//运行时，在窗口单击即可显示对应操作

            //form1单击事件，显示form2
            Form2 myForm2 = new Form2();
            myForm2.Show();
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("双击击事件");//运行时，在窗口双击即可显示对应操作
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("我要关闭窗口咯！！！");//关闭窗口时会出现提示
        }

        private void MainForm_MouseHover(object sender, EventArgs e)
        {
            this.Text = "鼠标悬停显示操作";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //在这个方法里面所有的设置都是通过单击button才能实现的

            this.Text = "伊卡洛斯";//单击button获修改窗体Text不会修改button的Text

            button1.Text = "伊卡洛斯";//单价button修改button的Text

            //form1单击事件，显示form2
            Form2 myForm2 = new Form2();
            myForm2.Show();
            
            this.Hide();//点开form2的时候隐藏本form

        }

        
    }
}
