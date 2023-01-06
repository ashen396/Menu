/*
 * Created by SharpDevelop.
 * User: Ashen Renon
 * Date: 9/29/2021
 * Time: 02:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class View_Cart
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
			this.lv_cart = new System.Windows.Forms.ListView();
			this.ItemName = new System.Windows.Forms.ColumnHeader();
			this.ItemQuantity = new System.Windows.Forms.ColumnHeader();
			this.ItemPrice = new System.Windows.Forms.ColumnHeader();
			this.ItemTotal = new System.Windows.Forms.ColumnHeader();
			this.cart_close = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lv_cart
			// 
			this.lv_cart.AutoArrange = false;
			this.lv_cart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lv_cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ItemName,
									this.ItemQuantity,
									this.ItemPrice,
									this.ItemTotal});
			this.lv_cart.FullRowSelect = true;
			this.lv_cart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv_cart.HideSelection = false;
			this.lv_cart.Location = new System.Drawing.Point(14, 48);
			this.lv_cart.MultiSelect = false;
			this.lv_cart.Name = "lv_cart";
			this.lv_cart.ShowGroups = false;
			this.lv_cart.Size = new System.Drawing.Size(518, 257);
			this.lv_cart.TabIndex = 0;
			this.lv_cart.UseCompatibleStateImageBehavior = false;
			this.lv_cart.View = System.Windows.Forms.View.Details;
			// 
			// ItemName
			// 
			this.ItemName.Text = "Name";
			this.ItemName.Width = 275;
			// 
			// ItemQuantity
			// 
			this.ItemQuantity.Text = "Quantity";
			this.ItemQuantity.Width = 70;
			// 
			// ItemPrice
			// 
			this.ItemPrice.Text = "Price";
			this.ItemPrice.Width = 82;
			// 
			// ItemTotal
			// 
			this.ItemTotal.Text = "Total";
			this.ItemTotal.Width = 85;
			// 
			// cart_close
			// 
			this.cart_close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cart_close.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
			this.cart_close.Location = new System.Drawing.Point(489, 9);
			this.cart_close.Name = "cart_close";
			this.cart_close.Size = new System.Drawing.Size(45, 23);
			this.cart_close.TabIndex = 1;
			this.cart_close.Text = "X";
			this.cart_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cart_close.Click += new System.EventHandler(this.Cart_closeClick);
			// 
			// View_Cart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(546, 320);
			this.ControlBox = false;
			this.Controls.Add(this.cart_close);
			this.Controls.Add(this.lv_cart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "View_Cart";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View_Cart";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label cart_close;
		private System.Windows.Forms.ColumnHeader ItemTotal;
		private System.Windows.Forms.ColumnHeader ItemPrice;
		private System.Windows.Forms.ColumnHeader ItemQuantity;
		private System.Windows.Forms.ColumnHeader ItemName;
		private System.Windows.Forms.ListView lv_cart;
	}
}
