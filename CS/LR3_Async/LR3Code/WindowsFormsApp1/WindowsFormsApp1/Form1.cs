using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSum(int a, int b);
        public Form1()
        {
            InitializeComponent();
            helpProvider1.SetShowHelp(this.txbA, true);
            helpProvider1.SetHelpString(this.txbA, "For input integer A");
            helpProvider1.SetShowHelp(this.txbB, true);
            helpProvider1.SetHelpString(this.txbB, "For input integer B");
            helpProvider1.SetShowHelp(this.btnRun, true);
            helpProvider1.SetHelpString(this.btnRun, "Sum");
            helpProvider1.SetShowHelp(this.btnWork, true);
            helpProvider1.SetHelpString(this.btnWork, "Start work");
        }
        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnRun_Click(object sender, System.EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");

                txbA.Text = txbB.Text = "";
                return;
            }
            var summdelegate = new AsyncSum(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            var summdelegate = (AsyncSum)ar.AsyncState;
            str = String.Format("Sum {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Result");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imitation of work");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txbA, "For input integer A");
            toolTip1.SetToolTip(this.txbB, "For input integer B");
            toolTip1.SetToolTip(this.btnRun, "Sum");
            toolTip1.SetToolTip(this.btnWork, "Start work");
        }
    }
}
