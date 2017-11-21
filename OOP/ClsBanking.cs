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
        }
        
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
        }

    }
}
