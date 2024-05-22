namespace log_in_Form
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			pictureBox2 = new PictureBox();
			panel1 = new Panel();
			panel2 = new Panel();
			pictureBox3 = new PictureBox();
			button1 = new Button();
			label2 = new Label();
			label3 = new Label();
			txtUserName = new TextBox();
			txtPassword = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.point_of_sale_logo_v1;
			pictureBox1.Location = new Point(74, 21);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(150, 114);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.HotTrack;
			label1.Location = new Point(83, 138);
			label1.Name = "label1";
			label1.Size = new Size(141, 45);
			label1.TabIndex = 1;
			label1.Text = "LOG IN";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources._9815472;
			pictureBox2.Location = new Point(28, 210);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(25, 25);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(0, 117, 214);
			panel1.Location = new Point(28, 241);
			panel1.Name = "panel1";
			panel1.Size = new Size(236, 1);
			panel1.TabIndex = 3;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(0, 117, 214);
			panel2.Location = new Point(28, 328);
			panel2.Name = "panel2";
			panel2.Size = new Size(236, 1);
			panel2.TabIndex = 5;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(28, 297);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(25, 25);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 4;
			pictureBox3.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(0, 117, 214);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(28, 368);
			button1.Name = "button1";
			button1.Size = new Size(236, 33);
			button1.TabIndex = 6;
			button1.Text = "LOG IN";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(0, 117, 214);
			label2.Location = new Point(162, 342);
			label2.Name = "label2";
			label2.Size = new Size(102, 23);
			label2.TabIndex = 7;
			label2.Text = "Clear Fields";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.FromArgb(0, 117, 214);
			label3.Location = new Point(126, 407);
			label3.Name = "label3";
			label3.Size = new Size(40, 23);
			label3.TabIndex = 8;
			label3.Text = "Exit";
			label3.Click += label3_Click;
			// 
			// txtUserName
			// 
			txtUserName.BorderStyle = BorderStyle.None;
			txtUserName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtUserName.ForeColor = Color.FromArgb(0, 117, 214);
			txtUserName.Location = new Point(63, 211);
			txtUserName.Multiline = true;
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(201, 24);
			txtUserName.TabIndex = 9;
			// 
			// txtPassword
			// 
			txtPassword.BorderStyle = BorderStyle.None;
			txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtPassword.ForeColor = Color.FromArgb(0, 117, 214);
			txtPassword.Location = new Point(59, 297);
			txtPassword.Multiline = true;
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(201, 24);
			txtPassword.TabIndex = 10;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(290, 439);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(panel2);
			Controls.Add(pictureBox3);
			Controls.Add(panel1);
			Controls.Add(pictureBox2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private PictureBox pictureBox2;
		private Panel panel1;
		private Panel panel2;
		private PictureBox pictureBox3;
		private Button button1;
		private Label label2;
		private Label label3;
		private TextBox txtUserName;
		private TextBox txtPassword;
	}
}
