/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 12/4/2019
 * Time: 11:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DoMinn
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Button [,] btnmin = new Button[10,10];
		int control = 0;
		
		int [ , ] a = new int[10,10];
		int somin = 10;
		int so_o_mo = 0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			newgame();
		}
		
		void newgame(){
			int width = 30 ;
			int i = 0 ;
			int j = 0 ;
			for ( i = 0 ; i < 10 ; i ++ )
				for ( j = 0 ; j  < 10 ; j ++)
			{
				btnmin[ i , j ] = new Button();
				btnmin[ i , j ].Width = width;
				btnmin[ i , j ].Height = width;
				btnmin[ i , j ].Location = new  Point( i * width , j * width );
				btnmin[ i , j ].Text = "";
				btnmin[ i , j ].Click += new EventHandler(bammin);
				paldomin.Controls.Add(btnmin[ i , j ]);
				a[i,j] = 0;
			}
			int dem = 0 ;
			while ( dem < somin )
			{
				Random rnd = new Random();
				i = rnd.Next(10);
				j = rnd.Next(10);
				if(a[i,j] == 0 )
				{					// 
					a[i,j] = 1 ;
					dem++;
				}
			}
			lbsomin.Text = somin.ToString();
		}
		private void bammin(object sender, EventArgs e)
		{
			if (control == 0)
			{
				int x = 0;
				int y = 0;
				x = ((Button)sender).Location.X;
				y = ((Button)sender).Location.Y;
				int width = 30 ;
				int i = 0;
				int j = 0;
				i = x / width;
				j = y / width;
				if ( a[i,j] == 0) // k min
				{
					mo_o(i,j);
				}else{ // co min
					((Button)sender).Text = "☠";
					((Button)sender).BackColor = Color.Red;
					control = -1;
					show();
				}
			}
			if ( control == 1)
				lbkq.Text = "WIN";
			else
				if ( control == -1 )
					lbkq.Text = "FAILURE";
		}
		private void	mo_o(int i , int j)
		{
			if ( a[i,j] == 0) // k min
				{
					if(btnmin[i,j].Text == "")
					{
						so_o_mo++;
						lbomo.Text = so_o_mo.ToString();
						if (sominxungquanh(i,j) == 0 ){
							btnmin[i,j].Text = " ";
					}
						else	{
							btnmin[i,j].Text = sominxungquanh(i,j).ToString();
					}
						
						btnmin[i,j].BackColor = Color.Beige;
						if(sominxungquanh(i,j) == 0 )
							mo_o_lancan(i,j);
					}
				}
		}
		private void mo_o_lancan(int i , int j)
		{
			if ( i - 1 >= 0 ) // kt o tren
			{
				mo_o(i - 1 , j);
			}
			////////////////////////////////////////////////////////////////////////////
			if ( j - 1 >= 0 ) // kt o trai
			{
				mo_o(i , j - 1);
			}
			/////////////////////////////////////////////////////////////////////////////
			if ( i + 1 < 10 ) // kt o duoi
			{
				mo_o(i+1 , j);
			}
			///////////////////////////////////////////////////////////////////////////
			if ( j + 1 < 10  ) // kt o ben phai
			{ 
				mo_o(i , j +1);
			}
		}
		private int sominxungquanh(int i , int j)
		{
			int kq = 0;
			//cong dong thu nhat
			//tuong tuong ma tran
			//***
			//*0*
			//***
			if ( i > 0)
			{
				if ( j > 0)
				{
					kq += a [ i-1 , j-1 ];
				kq += a [ i - 1 , j ];
				}
				if ( j < 9)
				{
					kq += a[i -1, j+1];
				}
			}
			//cong dong thu 2
			if (j > 0)
			{
				kq += a[ i , j-1 ];
				
			}
			if (j < 9)
			{
				kq += a[ i , j + 1 ];
			}
			//cong dong thu 3
			if (j < 9)
			{
				if ( j > 0 )
				{
					kq += a[ i + 1 , j - 1 ];
				kq += a[i + 1 , j];
				}
				if ( j < 9)
				{
					kq += a[ i + 1, j + 1 ];
				}
			}
			return kq;
		}
		
		void ResetClick(object sender, EventArgs e)
		{
			this.Hide();			
			MainForm fm = new MainForm();
			fm.Show();
		}
		
		void show(){
			for(int i= 0; i < 10; i++){
				for(int j = 0; j < 10; j++){
					if(a[i,j] == 0){
						
					}
					else{
						btnmin[i,j].Text = "☠";
						btnmin[i,j].BackColor = Color.Red;
						
					}
				}
			}
		}
		
		
		
	}
}