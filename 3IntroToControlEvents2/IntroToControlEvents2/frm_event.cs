namespace IntroToControlEvents2
{
    public partial class frm_event : Form
    {
        public frm_event()
        {
            InitializeComponent();
        }
        private void frm_event_Load(object sender, EventArgs e)
        {
            // Event handling code
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, welcome to C# Windows-based Application. Click OK button to continue");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
