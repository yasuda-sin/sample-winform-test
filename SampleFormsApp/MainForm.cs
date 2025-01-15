using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            warn.Text = string.Empty;
            if (!int.TryParse(txtX.Text, out int x)) warn.Text = "数値を入力してください";
            if (!int.TryParse(txtY.Text, out int y)) warn.Text = "数値を入力してください";

            txtXY.Text = Sum(x, y).ToString();
        }

        public int Sum(int x, int y)
        {
            return x - y;
        }
    }
}
