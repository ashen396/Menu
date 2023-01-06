using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Menu
{
	public partial class User_Registration : Form
	{
		SqlConnection con;
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
		public User_Registration()
		{
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Tb_usernameLeave(object sender, EventArgs e)
		{
			string username="";
			con = new SqlConnection("Data Source=DESKTOP-D9LR60L\\SQLEXPRESS;Initial Catalog=Keells100;User id=user2;Password=123");
			SqlCommand command = new SqlCommand("SELECT Username FROM Customers WHERE Username = '" + tb_username.Text + "';",con);
			con.Open();
			command.ExecuteNonQuery();
			
			SqlDataReader reader = command.ExecuteReader();
			while(reader.Read()){
				username = reader["Username"].ToString();
			}
			
			if(username == tb_username.Text){
				MessageBox.Show("USERNAME EXISTS");
				tb_username.Clear();
				tb_username.Select();
			}
			con.Close();
		}
		
		void Btn_registerClick(object sender, EventArgs e)
		{
			if(tb_firstname.Text.Length != 0 && tb_lastname.Text.Length != 0 && mtb_mobileno.Text.Length != 0 && tb_username.Text.Length != 0 && tb_password.Text.Length != 0){
				con.Open();
				SqlCommand insert_command = new SqlCommand("INSERT INTO Customers(First_Name,Last_Name,DOB,Gender,Mobile,Username,UserPassword) VALUES ('" 
				                                           + tb_firstname.Text + "','" + tb_lastname.Text + "','" + dt_dob.Value + "','" + cmb_gender.Text + "','" + mtb_mobileno.Text
				                                           + "','" + tb_username.Text + "','" + tb_password.Text + "');",con);
				int command_result = insert_command.ExecuteNonQuery();
				con.Close();
				
				if(command_result == 1){
					MessageBox.Show("SUCCESSFULLY CREATE.PLEASE LOGIN");
					tb_firstname.Clear();
					tb_lastname.Clear();
					tb_username.Clear();
					tb_password.Clear();
					mtb_mobileno.Clear();
					this.Close();
				}else{
					MessageBox.Show("ACCOUNT CREATION FAILED");
				}
			}else{
				MessageBox.Show("FIELDS CANNOT BE EMPTY");
			}
			con.Close();
		}
	}
}
