namespace log_in_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtUserName.Text == "pointofsale_128" && txtPassword.Text == "pointofsale1234")
			{
				new Form2().Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("The User name or Password you entered is incorrect, try again");
				txtUserName.Clear();
				txtPassword.Clear();
				txtUserName.Focus();
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			txtUserName.Clear();
			txtPassword.Clear();
			txtUserName.Focus();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
