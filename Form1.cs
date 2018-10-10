using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncWinFormsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Call the method that runs asynchronously.
            string result = await WaitAsynchronouslyAsync();

            // Display the result.
            textBox1.Text += result;
        }

        //The following method runs asynchronously.The UI thread is not
        //blocked during the delay.You can move or resize the Form1 window 
        //while Task.Delay is running.
        public async Task<string> WaitAsynchronouslyAsync()
        {
            await Task.Delay(10000);
            return "Finished";
        }
    }
}
