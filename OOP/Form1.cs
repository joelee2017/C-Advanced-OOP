using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsBanking x;
        private void button1_Click(object sender, EventArgs e)
        {
            x = new ClsBanking();
            MessageBox.Show("x.Balance = "+ x.Balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get Balance
            this.label1.Text = x.Balance.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set Balance
            x.Balance = decimal.Parse(this.textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //x.Balance; 回傳本機名稱。
            MessageBox.Show(SystemInformation.ComputerName);



            //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
            //錯誤  CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 其為唯讀 OOP F:\MSIT11730305\C#Advanced\OOP\OOP\Form1.cs	44	使用中

            //            SystemInformation.ComputerName = "xxxx";

            string s = SystemInformation.ComputerName;

            //x.P1 =888; 無此宣告

            MessageBox.Show("x.P1 = " + x.P1);
        }
    }
}
