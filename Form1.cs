namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg = txtInput.Text;
            lstOutput.Items.Add(typed_msg);
            txtInput.Clear();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
