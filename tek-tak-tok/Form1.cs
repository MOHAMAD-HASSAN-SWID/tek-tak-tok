using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tek_tak_tok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(255, 255, 255, 255);

            Pen p = new Pen(c);
            p.Width = 10;

            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(p, 900, 100, 900, 550);

            e.Graphics.DrawLine(p, 750, 100, 750, 550);

            e.Graphics.DrawLine(p, 600, 250, 1050, 250);

            e.Graphics.DrawLine(p, 600, 400, 1050, 400);
        }

        int end_game = 0;

        private void buttons(Color c, FlatStyle fs,string s,bool f)
        {
            button_x_o_1_1.BackColor =   c;
            button_x_o_1_1.FlatStyle =  fs;
            button_x_o_1_1.Text =       s;
            button_x_o_1_1.Enabled =    f;
            button_x_o_1_1.ForeColor = Color.Fuchsia;
            button_x_o_1_1.Tag = 11;

            button_x_o_1_2.BackColor =  c;
            button_x_o_1_2.FlatStyle = fs;
            button_x_o_1_2.Text =     s;
            button_x_o_1_2.Enabled =  f;
            button_x_o_1_2.ForeColor = Color.Fuchsia;
            button_x_o_1_2.Tag = 12;

            button_x_o_1_3.BackColor =      c;
            button_x_o_1_3.FlatStyle = fs;
            button_x_o_1_3.Text =      s;
            button_x_o_1_3.Enabled = f;
            button_x_o_1_3.ForeColor = Color.Fuchsia;
            button_x_o_1_3.Tag = 13;

            button_x_o_2_1.BackColor =     c;
            button_x_o_2_1.FlatStyle = fs;
            button_x_o_2_1.Text =      s;
            button_x_o_2_1.Enabled = f;
            button_x_o_2_1.ForeColor = Color.Fuchsia;
            button_x_o_2_1.Tag = 21;

            button_x_o_2_2.BackColor =       c;
            button_x_o_2_2.FlatStyle =  fs;
            button_x_o_2_2.Text =       s;
            button_x_o_2_2.Enabled = f;
            button_x_o_2_2.ForeColor = Color.Fuchsia;
            button_x_o_2_2.Tag = 22;

            button_x_o_2_3.BackColor =      c;
            button_x_o_2_3.FlatStyle =  fs;
            button_x_o_2_3.Text =       s;
            button_x_o_2_3.Enabled = f;
            button_x_o_2_3.ForeColor = Color.Fuchsia;
            button_x_o_2_3.Tag = 23;

            button_x_o_3_1.BackColor =      c;
            button_x_o_3_1.FlatStyle = fs;
            button_x_o_3_1.Text =      s;
            button_x_o_3_1.Enabled = f;
            button_x_o_3_1.ForeColor = Color.Fuchsia;
            button_x_o_3_1.Tag = 31;

            button_x_o_3_2.BackColor =      c;
            button_x_o_3_2.FlatStyle = fs;
            button_x_o_3_2.Text =      s;
            button_x_o_3_2.Enabled = f;
            button_x_o_3_2.ForeColor = Color.Fuchsia;
            button_x_o_3_2.Tag = 32;

            button_x_o_3_3.BackColor =      c;
            button_x_o_3_3.FlatStyle = fs;
            button_x_o_3_3.Text =      s;
            button_x_o_3_3.Enabled = f;
            button_x_o_3_3.ForeColor = Color.Fuchsia;
            button_x_o_3_3.Tag = 33;
        }

        private void checking()
        {
           
            if (
                (Convert.ToByte (button_x_o_1_1.Tag) + Convert.ToByte(button_x_o_1_2.Tag) +  Convert.ToByte( button_x_o_1_3.Tag) == 3  || Convert.ToByte(button_x_o_1_1.Tag) + Convert.ToByte(button_x_o_1_2.Tag) + Convert.ToByte(button_x_o_1_3.Tag) == 6)
                || (Convert.ToByte(button_x_o_2_1.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_2_3.Tag) == 3 || Convert.ToByte(button_x_o_2_1.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_2_3.Tag) == 6)
                || (Convert.ToByte(button_x_o_3_1.Tag) + Convert.ToByte(button_x_o_3_2.Tag) + Convert.ToByte(button_x_o_3_3.Tag) == 3 || Convert.ToByte(button_x_o_3_1.Tag) + Convert.ToByte(button_x_o_3_2.Tag) + Convert.ToByte(button_x_o_3_3.Tag) == 6)
                || (Convert.ToByte(button_x_o_1_1.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_3_3.Tag) == 3 || Convert.ToByte(button_x_o_1_1.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_3_3.Tag) == 6)
                || (Convert.ToByte(button_x_o_3_1.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_1_3.Tag) == 3 || Convert.ToByte(button_x_o_3_1.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_1_3.Tag) == 6)
                || (Convert.ToByte(button_x_o_1_1.Tag) + Convert.ToByte(button_x_o_2_1.Tag) + Convert.ToByte(button_x_o_3_1.Tag) == 3 || Convert.ToByte(button_x_o_1_1.Tag) + Convert.ToByte(button_x_o_2_1.Tag) + Convert.ToByte(button_x_o_3_1.Tag) == 6)
                || (Convert.ToByte(button_x_o_1_3.Tag) + Convert.ToByte(button_x_o_2_3.Tag) + Convert.ToByte(button_x_o_3_3.Tag) == 3 || Convert.ToByte(button_x_o_1_3.Tag) + Convert.ToByte(button_x_o_2_3.Tag) + Convert.ToByte(button_x_o_3_3.Tag) == 6)
                || (Convert.ToByte(button_x_o_1_2.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_3_2.Tag) == 3 || Convert.ToByte(button_x_o_1_2.Tag) + Convert.ToByte(button_x_o_2_2.Tag) + Convert.ToByte(button_x_o_3_2.Tag) == 6)
               )
            {
                if (label_player.Text == "player1")
                {
                    label_winer_name.Text = "player2";
                    MessageBox.Show("player2", "the winner");
                }
                    
                else
                {
                    label_winer_name.Text = "player1";
                    MessageBox.Show("player1", "the winner");
                }

                buttons(Color.HotPink, FlatStyle.Flat, "E", false);
            }

            if (end_game == 9)
            {
                buttons(Color.HotPink, FlatStyle.Flat, "E", false);
                label_winer_name.Text = "NO WINNER";
                MessageBox.Show("NO WINNER", "the winner");
            }
        }

        private void chingbutton(Button b)
        {
            if (b.Text == "?")
            {
                 end_game++;
                if (label_player.Text == "player1")
                {
                  b.Text = "X";
                  b.ForeColor = System.Drawing.Color.Gold;
                  label_player.Text = "player2";
                  b.Tag = 1;
                }

                else
                {
                  b.Text = "O";
                  b.ForeColor = System.Drawing.Color.Gold;
                  label_player.Text = "player1";
                  b.Tag = 2;
                }
                checking();
            }
        }

       private void button_reset_gaime_Click(object sender, EventArgs e)
        {
            end_game = 0;
            label_player.Text = "player1";
            label_winer_name.Text = "prossing";
            buttons(Color.Black, FlatStyle.Popup, "?", true);
        }

        private void button_x_o_Click(object sender, EventArgs e)
        {
            chingbutton((Button)sender);
        }
    }
}
