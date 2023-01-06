using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	public partial class View_Cart : Form
	{
		public View_Cart()
		{
			InitializeComponent();
		}
		
		public void set_data(string name, string price, decimal quantity, int total, int x){
			lv_cart.Items.Add(name);
			lv_cart.Items[x].SubItems.Add(quantity.ToString());
			lv_cart.Items[x].SubItems.Add(price);
			lv_cart.Items[x].SubItems.Add((total * quantity).ToString());
		}
		
		
		void Cart_closeClick(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
