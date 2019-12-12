/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 12/4/2019
 * Time: 11:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoMinn
{
	partial class MainForm
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
			this.paldomin = new System.Windows.Forms.Panel();
			this.lbkq = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbomo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbsomin = new System.Windows.Forms.Label();
			this.reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// paldomin
			// 
			this.paldomin.Location = new System.Drawing.Point(18, 18);
			this.paldomin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.paldomin.Name = "paldomin";
			this.paldomin.Size = new System.Drawing.Size(532, 488);
			this.paldomin.TabIndex = 0;
			// 
			// lbkq
			// 
			this.lbkq.Location = new System.Drawing.Point(624, 385);
			this.lbkq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbkq.Name = "lbkq";
			this.lbkq.Size = new System.Drawing.Size(150, 105);
			this.lbkq.TabIndex = 1;
			this.lbkq.Text = "Kết quả";
			this.lbkq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(560, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Số Ô Đã Mở:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbomo
			// 
			this.lbomo.Location = new System.Drawing.Point(704, 14);
			this.lbomo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbomo.Name = "lbomo";
			this.lbomo.Size = new System.Drawing.Size(106, 35);
			this.lbomo.TabIndex = 3;
			this.lbomo.Text = "0";
			this.lbomo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(560, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 35);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tổng Số Mìn:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbsomin
			// 
			this.lbsomin.Location = new System.Drawing.Point(704, 49);
			this.lbsomin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbsomin.Name = "lbsomin";
			this.lbsomin.Size = new System.Drawing.Size(106, 35);
			this.lbsomin.TabIndex = 5;
			this.lbsomin.Text = "0";
			this.lbsomin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(653, 326);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(80, 46);
			this.reset.TabIndex = 6;
			this.reset.Text = "reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 525);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.lbsomin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbomo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbkq);
			this.Controls.Add(this.paldomin);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "DoMinn";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Label lbsomin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbomo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbkq;
		private System.Windows.Forms.Panel paldomin;
	}
}