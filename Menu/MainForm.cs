using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Menu
{
	public partial class MainForm : Form
	{
		Point lastlocation;
		bool mousedown,change=false;
		int price, total_price, item_count=0;
		bool logged_in = false;
		SqlConnection con;
		View_Cart vc;
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
		public MainForm()
		{
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
			this.BackColor = Color.FromArgb(255,40,40,40);
			lbl_login.BackColor = Color.FromArgb(255,40,40,40);
			lbl_username.BackColor = Color.FromArgb(255,40,40,40);
			tb_username.BackColor = Color.FromArgb(255,80,80,80);
			lbl_password.BackColor = Color.FromArgb(255,40,40,40);
			tb_password.BackColor = Color.FromArgb(255,80,80,80);
			
			try{
				con = new SqlConnection("Data Source=DESKTOP-D9LR60L\\SQLEXPRESS;Initial Catalog=Keells100;User id=user2;Password=123");
				con.Open();
				con.Close();
			}catch(SqlException sqle){
				MessageBox.Show(sqle.ToString());
			}
			
		}
		
		void profile_loginClick(object sender, EventArgs e){
			if(tb_username.Text != "" && tb_password.Text != ""){
				string password = "",first_name = "", last_name = "";
				con.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE Username = '" + tb_username.Text + "';",con);
				command.ExecuteNonQuery();
					
				SqlDataReader data = command.ExecuteReader();
				while(data.Read()){
					first_name = data["First_Name"].ToString();
					last_name = data["Last_Name"].ToString();
					password = data["UserPassword"].ToString();
				}
				con.Close();
			
				if(password == tb_password.Text){
					MessageBox.Show("SUCCESSFULLY LOGGED IN");
					logged_in = true;
					lbl_profile_name.Text = first_name.ToUpper() + " " + last_name.ToUpper();
					panel_profile.Show();
					mtb_del_time.Text = DateTime.Now.AddMinutes(45.0).ToShortTimeString().ToString();
					if(DateTime.Now.ToString("tt") == "AM"){
						cmb_am_pm.SelectedIndex = 0;
					}else{
						cmb_am_pm.SelectedIndex = 1;
					}
					vc = new View_Cart();
				}else{
					MessageBox.Show("USERNAME/PASSWORD INCORRECT");
				}
			}else{
				MessageBox.Show("USERNAME/PASSWORD CANNOT BE EMPTY");
			}
		}
		
		void profile_registerClick(object sender, EventArgs e){
			User_Registration user_registration = new User_Registration();
			user_registration.ShowDialog();
		}
		
		void Pb_topbarMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			mousedown = true;
			lastlocation = e.Location;
		}
		
		void Pb_topbarMouseMove(object sender, MouseEventArgs e)
		{
			if(mousedown){
				this.Location = new Point((this.Location.X - lastlocation.X) + e.X, (this.Location.Y - lastlocation.Y) + e.Y);
				this.Update();
			}
			                          
		}
		
		void Pb_topbarMouseUp(object sender, MouseEventArgs e)
		{
			mousedown = false;
		}
		
		void Pb_beverageClick(object sender, EventArgs e)
		{
			panel_profile.Visible = false;
			if(logged_in == false){
				btn_beverage_confirm.BackColor = SystemColors.GrayText;
				btn_beverage_confirm.Enabled = false;
				lbl_login_msg.Visible = true;
			}
			if(logged_in == true){
				btn_beverage_confirm.BackColor = SystemColors.MenuHighlight;
				btn_beverage_confirm.Enabled = true;
				lbl_login_msg.Visible = false;
			}
			panel_beverages.Visible = true;
		}
		
		void lbl_beverage_backClick(object sender, EventArgs e)
		{
			panel_beverages.Visible = false;
			if(logged_in == true){
				panel_profile.Visible = true;
			}
		}
		
		void avacadoClick(object sender, EventArgs e)
		{
			lbl_beverage_name.Text = "AVACADO JUICE";
			lbl_beverage_price.Text = "150";
			price = 150;
			panel_beverages.Visible = true;
		}
		
		void appleClick(object sender, EventArgs e)
		{
			lbl_beverage_name.Text = "APPLE JUICE";
			lbl_beverage_price.Text = "300";
			price = 300;
			panel_beverages.Visible = true;
		}
		
		void mangoClick(object sender, EventArgs e)
		{
			lbl_beverage_name.Text = "MANGO JUICE";
			lbl_beverage_price.Text = "550";
			price = 550;
			panel_beverages.Visible = true;
		}
		
		void orangeClick(object sender, EventArgs e)
		{
			lbl_beverage_name.Text = "ORANGE JUICE";
			lbl_beverage_price.Text = "220";
			price = 220;
			panel_beverages.Visible = true;
		}
		
		void Btn_beverage_confirmClick(object sender, EventArgs e)
		{
			lbl_beverage_tot_price.Text = (price * num_beverage.Value).ToString();
			total_price = total_price + (price * Convert.ToInt16(num_beverage.Value));
			lbl_tot_price.Text = total_price.ToString();
			lbl_tot_price.Visible = true;
			lbl_tot_rs.Visible = true;
			lbl_view_cart.Visible = true;
			vc.set_data(lbl_beverage_name.Text, lbl_beverage_price.Text, num_beverage.Value, price, item_count);
			item_count++;
		}
		
		void Btn_changeClick(object sender, EventArgs e)
		{
			if(change == false){
				lbl_location.Visible = false;
				tb_location.Visible = true;
				tb_location.Text = lbl_location.Text;
				btn_change.Text = "DONE";
				tb_location.Select();
				change = true;
			}else{
				lbl_location.Visible = true;
				tb_location.Visible = false;
				lbl_location.Text = tb_location.Text;
				btn_change.Text = "CHANGE";
				change = false;
			}
		}
		
		void Lbl_view_cartClick(object sender, EventArgs e)
		{
			vc.Show();
		}
		
		void Pb_dessertClick(object sender, System.EventArgs e)
		{
			panel_profile.Visible = false;
			if(logged_in == false){
				btn_dessert_confirm.BackColor = SystemColors.GrayText;
				btn_dessert_confirm.Enabled = false;
				lbl_login_msg_dessert.Visible = true;
			}
			if(logged_in == true){
				btn_dessert_confirm.BackColor = SystemColors.MenuHighlight;
				btn_dessert_confirm.Enabled = true;
				lbl_login_msg_dessert.Visible = false;
			}
			panel_desserts.Visible = true;
		}
		
		void Lbl_dessert_backClick(object sender, System.EventArgs e)
		{
			panel_desserts.Visible = false;
			if(logged_in == true){
				panel_profile.Visible = true;
			}
		}
	}
}
