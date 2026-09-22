namespace Assignment4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Data.auth.ContainsKey(txtUserName.Text) && Data.auth[txtUserName.Text] == txtPw.Text)
            {
                MessageBox.Show($"Login Successful! Welcome {txtUserName.Text}");
                AddForm addForm = new AddForm();
                addForm.ShowDialog();
                this.Hide();
                this.Close();
                
            } else
            {
                MessageBox.Show("Information does not match.");
            }
        }
    }
}
