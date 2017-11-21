using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ClsBanking
    {
        //Field -Class Var.
        private decimal m_Balance;//類別變數
        public decimal Balance//儲存屬性
        {
            get
            {
                return m_Balance;
            }
            set
            {
                if(value >=0)
                {
                    m_Balance = value;
                }
            }
        }//--------------------------------------------------------------
        
        //ReadOnly Propety
        public int P1//唯讀屬性
        {
            get
            {
                //.............
                return 999;
            }
        }

        private int m_P2;
        public int P2//唯讀屬性
        {
            set { m_Balance = value; }
        }//---------------------------------------------------------------

        private int[] nums = {101, 44, 2, 3 };
        
        /// <summary>
        /// Indexer.........摘要說明
        /// </summary>
        /// <param name="i">i等於什麼</param>
        /// <returns>returm.....</returns>
        /// <exception cref="IndexOutOfRangeException">Index out of rang....</exception>
        public int this[int i]
        {
            get
            {
                if (i < 0 || i > nums.Length - 1)
                    throw new IndexOutOfRangeException("超標啦GG");
                return nums[i];
            }
        }

        public int this[string n]
        {
            get
            {
                int i = int.Parse(n);
                if(i < 0 || i > nums.Length - 1)
                    throw new IndexOutOfRangeException("超標啦GG");
                return nums[i];
            }            
        }

        public void Test()
        {
            A();
            B();
            C();

        }

        public void Test(int i)
        {


        }

        public void Test (int i, int j)
        {


        }
        public void Test(string n)
        {


        }

        public void A()
        {


        }

        public void B()
        {


        }

        public void C()
        {


        }
        //----------------------------------------------
        public string Name { set; get; }//姓名
            private string personId { set; get; }//身份ID
            public string PhoneNo { set; get; }//電話
        //---------------------------------------------

        public int P3 { get; set; }

        public int P4
        {
            get
            {
                return 999;
            }
            private set
            {

            }
        }
        
        public decimal Deposit (decimal money)
        {
            this.m_Balance += money;
            return this.m_Balance;
        }
        public decimal Withdraw (decimal money)
        {
            if(this.m_Balance -money <0)
            {
                throw new Exception("餘額不足");
            }
            this.m_Balance -= money;
            return this.m_Balance;
        }

    }
}
