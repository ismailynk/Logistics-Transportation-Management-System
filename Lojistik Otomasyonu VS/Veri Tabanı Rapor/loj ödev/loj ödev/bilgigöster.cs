using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace loj_ödev
{
    public partial class bilgigöster : Form
    {
        public bilgigöster()
        {
            InitializeComponent();
        }

        private void bilgigöster_Load(object sender, EventArgs e)
        {

        }
        public void setdata (String s,String tablename){
            baglan op = new baglan();
            op.griddoldurek(s, dataGridView1, tablename);

        }
        
    }
}
