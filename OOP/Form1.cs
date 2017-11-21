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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.northWindDataSet1.Products);
        }
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

        private void button5_Click(object sender, EventArgs e)
        {
            x.P2 = 100;//P2只能接收值

//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0154 屬性或索引子 'ClsBanking.P2' 無法用在此內容中，因為它缺少 get 存取子。	OOP F:\MSIT11730305\C#Advanced\OOP\OOP\Form1.cs	60	使用中

            //int number = x.P2; // 不能把值給別人
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = this.northWindDataSet1.Products;
            //DataTable table = null;
            DataTable table = this.northWindDataSet1.Products;
                        

            //DataRow dr = new DataRow();該類別不支援 讀寫
            DataRow dr = table.Rows[0];
            MessageBox.Show(dr[0].ToString());//此時table值還是null 無法執行
            MessageBox.Show(table.Rows[0][0].ToString());

            MessageBox.Show(this.northWindDataSet1.Products[0].ProductID.ToString());

            //直接使用db回傳table，資料

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Point> list = new List<Point>();
            //集合POINT X,Y
            list.Add(new Point(100, 200));
            list.Add(new Point(200, 200));
            list.Add(new Point(300, 100));

            MessageBox.Show(list[1].X + "," + list[1].Y);//秀出 200，200

            this.dataGridView2.DataSource = list;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //x 需先建立實體宣告
            //MessageBox.Show(x[0].ToString());
            
            try
            {
                MessageBox.Show(x[10].ToString());//超出陣列長度
            }
            catch(IndexOutOfRangeException ex)//傳到類別ClsBanking 回傳throw
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
