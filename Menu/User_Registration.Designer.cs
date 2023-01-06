/*
 * Created by SharpDevelop.
 * User: Ashen Renon
 * Date: 9/27/2021
 * Time: 09:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class User_Registration
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_firstname = new System.Windows.Forms.TextBox();
			this.tb_lastname = new System.Windows.Forms.TextBox();
			this.dt_dob = new System.Windows.Forms.DateTimePicker();
			this.cmb_gender = new System.Windows.Forms.ComboBox();
			this.mtb_mobileno = new System.Windows.Forms.MaskedTextBox();
			this.tb_username = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.btn_register = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(377, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label2.Location = new System.Drawing.Point(22, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "FIRST NAME";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label3.Location = new System.Drawing.Point(22, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "LAST NAME";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label4.Location = new System.Drawing.Point(44, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "DOB";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label5.Location = new System.Drawing.Point(22, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "MOBILE NO";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label6.Location = new System.Drawing.Point(32, 143);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "GENDER";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label7.Location = new System.Drawing.Point(22, 219);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "USERNAME";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
			this.label8.Location = new System.Drawing.Point(22, 257);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "PASSWORD";
			// 
			// tb_firstname
			// 
			this.tb_firstname.Location = new System.Drawing.Point(151, 29);
			this.tb_firstname.Name = "tb_firstname";
			this.tb_firstname.Size = new System.Drawing.Size(204, 20);
			this.tb_firstname.TabIndex = 8;
			// 
			// tb_lastname
			// 
			this.tb_lastname.Location = new System.Drawing.Point(151, 67);
			this.tb_lastname.Name = "tb_lastname";
			this.tb_lastname.Size = new System.Drawing.Size(204, 20);
			this.tb_lastname.TabIndex = 9;
			// 
			// dt_dob
			// 
			this.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dt_dob.Location = new System.Drawing.Point(151, 105);
			this.dt_dob.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
			this.dt_dob.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.dt_dob.Name = "dt_dob";
			this.dt_dob.Size = new System.Drawing.Size(204, 20);
			this.dt_dob.TabIndex = 10;
			this.dt_dob.Value = new System.DateTime(2021, 9, 27, 0, 0, 0, 0);
			// 
			// cmb_gender
			// 
			this.cmb_gender.FormattingEnabled = true;
			this.cmb_gender.Items.AddRange(new object[] {
									"MALE",
									"FEMALE"});
			this.cmb_gender.Location = new System.Drawing.Point(151, 144);
			this.cmb_gender.Name = "cmb_gender";
			this.cmb_gender.Size = new System.Drawing.Size(204, 21);
			this.cmb_gender.TabIndex = 11;
			this.cmb_gender.Text = "MALE";
			// 
			// mtb_mobileno
			// 
			this.mtb_mobileno.Location = new System.Drawing.Point(151, 181);
			this.mtb_mobileno.Mask = "000000000";
			this.mtb_mobileno.Name = "mtb_mobileno";
			this.mtb_mobileno.PromptChar = '#';
			this.mtb_mobileno.Size = new System.Drawing.Size(204, 20);
			this.mtb_mobileno.TabIndex = 12;
			// 
			// tb_username
			// 
			this.tb_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tb_username.Location = new System.Drawing.Point(151, 220);
			this.tb_username.MaxLength = 10;
			this.tb_username.Name = "tb_username";
			this.tb_username.Size = new System.Drawing.Size(204, 20);
			this.tb_username.TabIndex = 13;
			this.tb_username.Leave += new System.EventHandler(this.Tb_usernameLeave);
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(151, 258);
			this.tb_password.MaxLength = 20;
			this.tb_password.Name = "tb_password";
			this.tb_password.Size = new System.Drawing.Size(204, 20);
			this.tb_password.TabIndex = 14;
			this.tb_password.UseSystemPasswordChar = true;
			// 
			// btn_register
			// 
			this.btn_register.Location = new System.Drawing.Point(280, 284);
			this.btn_register.Name = "btn_register";
			this.btn_register.Size = new System.Drawing.Size(75, 23);
			this.btn_register.TabIndex = 15;
			this.btn_register.Text = "REGISTER";
			this.btn_register.UseVisualStyleBackColor = true;
			this.btn_register.Click += new System.EventHandler(this.Btn_registerClick);
			// 
			// User_Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(414, 314);
			this.ControlBox = false;
			this.Controls.Add(this.btn_register);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.tb_username);
			this.Controls.Add(this.mtb_mobileno);
			this.Controls.Add(this.cmb_gender);
			this.Controls.Add(this.dt_dob);
			this.Controls.Add(this.tb_lastname);
			this.Controls.Add(this.tb_firstname);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "User_Registration";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "User_Registration";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_register;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.TextBox tb_username;
		private System.Windows.Forms.MaskedTextBox mtb_mobileno;
		private System.Windows.Forms.ComboBox cmb_gender;
		private System.Windows.Forms.DateTimePicker dt_dob;
		private System.Windows.Forms.TextBox tb_lastname;
		private System.Windows.Forms.TextBox tb_firstname;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
