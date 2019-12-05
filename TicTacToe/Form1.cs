using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public char[,] status = new char[4, 4] {
 { ' ', ' ', ' ', ' ' },
 { ' ', ' ', ' ', ' ' },
 { ' ', ' ', ' ', ' ' },
 {  ' ', ' ', ' ', ' '  } 
        };

        public char turn = 'X';
        public Form1()
        {
            InitializeComponent();
        }

        void setBox(int x, int y, char value)
        {
            if (this.status[x, y] == ' ')
            {
                this.status[x, y] = value;
                this.setVisuals();
                this.shiftTurn();
            }
        }

        void shiftTurn()
        {
            if (this.turn == 'X') { this.turn = 'O'; } else { this.turn = 'X'; }
        }

        void setVisuals()
        {
            this.aa.Text = this.status[1, 1].ToString();
            this.ab.Text = this.status[1, 2].ToString();
            this.ac.Text = this.status[1, 3].ToString();

            this.ba.Text = this.status[2, 1].ToString();
            this.bb.Text = this.status[2, 2].ToString();
            this.bc.Text = this.status[2, 3].ToString();

            this.ca.Text = this.status[3, 1].ToString();
            this.cb.Text = this.status[3, 2].ToString();
            this.cc.Text = this.status[3, 3].ToString();

            this.checkWin();
        }

        private void aa_Click(object sender, EventArgs e)
        {
            if (this.status[1, 1] == ' ')
            {
                this.setBox(1, 1, this.turn);
                this.computersTurn();
            }
        }

        private void ab_Click(object sender, EventArgs e)
        {
            if (this.status[1, 2] == ' ')
            {
                this.setBox(1, 2, this.turn);
                this.computersTurn();
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            if (this.status[1, 3] == ' ')
            {
                this.setBox(1, 3, this.turn);
                this.computersTurn();
            }
        }

        private void ba_Click(object sender, EventArgs e)
        {
            if (this.status[2, 1] == ' ')
            {
                this.setBox(2, 1, this.turn);
                this.computersTurn();
            }
        }

        private void bb_Click(object sender, EventArgs e)
        {
            if (this.status[2, 2] == ' ')
            {
                this.setBox(2, 2, this.turn);
                this.computersTurn();
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {
            if (this.status[2, 3] == ' ')
            {
                this.setBox(2, 3, this.turn);
                this.computersTurn();
            }
        }

        private void ca_Click(object sender, EventArgs e)
        {
            if (this.status[3, 1] == ' ')
            {
                this.setBox(3, 1, this.turn);
                this.computersTurn();
            }
        }

        private void cb_Click(object sender, EventArgs e)
        {
            if (this.status[3, 2] == ' ')
            {
                this.setBox(3, 2, this.turn);
                this.computersTurn();
            }
        }

        private void cc_Click(object sender, EventArgs e)
        {
            if (this.status[3, 3] == ' ')
            {
                this.setBox(3, 3, this.turn);
                this.computersTurn();
            }
        }

        void computersTurn()
        {
            if ((this.status[1, 1] == ' ' && this.status[1, 2] == ' ') || (this.status[1, 2] == ' ' && this.status[1, 3] == ' ') || (this.status[1, 1] == ' ' && this.status[1, 3] == ' '))
            {
                if (this.status[1, 1] == ' ') { this.setBox(1, 1, this.turn); }
                else if (this.status[1, 2] == ' ') { this.setBox(1, 2, this.turn); }
                else if (this.status[1, 3] == ' ') { this.setBox(1, 3, this.turn); }
            }
            else if ((this.status[2, 1] == ' ' && this.status[2, 2] == ' ') || (this.status[2, 2] == ' ' && this.status[2, 3] == ' ') || (this.status[2, 1] == ' ' && this.status[2, 3] == ' '))
            {
                if (this.status[2, 1] == ' ') { this.setBox(2, 1, this.turn); }
                else if (this.status[2, 2] == ' ') { this.setBox(2, 2, this.turn); }
                else if (this.status[2, 3] == ' ') { this.setBox(2, 3, this.turn); }
            }
            else if ((this.status[3, 1] == ' ' && this.status[3, 2] == ' ') || (this.status[3, 2] == ' ' && this.status[3, 3] == ' ') || (this.status[3, 1] == ' ' && this.status[3, 3] == ' '))
            {
                if (this.status[3, 1] == ' ') { this.setBox(3, 1, this.turn); }
                else if (this.status[3, 2] == ' ') { this.setBox(3, 2, this.turn); }
                else if (this.status[3, 3] == ' ') { this.setBox(3, 3, this.turn); }
            }
            else if ((this.status[1, 1] == ' ' && this.status[2, 1] == ' ') || (this.status[2, 1] == ' ' && this.status[3, 1] == ' ') || (this.status[1, 1] == ' ' && this.status[3, 1] == ' '))
            {
                if (this.status[1, 1] == ' ') { this.setBox(1, 1, this.turn); }
                else if (this.status[2, 1] == ' ') { this.setBox(2, 1, this.turn); }
                else if (this.status[3, 1] == ' ') { this.setBox(3, 1, this.turn); }
            }
            else if ((this.status[1, 2] == ' ' && this.status[2, 2] == ' ') || (this.status[2, 2] == ' ' && this.status[3, 2] == ' ') || (this.status[1, 2] == ' ' && this.status[3, 2] == ' '))
            {
                if (this.status[1, 2] == ' ') { this.setBox(1, 2, this.turn); }
                else if (this.status[2, 2] == ' ') { this.setBox(2, 2, this.turn); }
                else if (this.status[3, 2] == ' ') { this.setBox(3, 2, this.turn); }
            }
            else if ((this.status[1, 3] == ' ' && this.status[2, 3] == ' ') || (this.status[2, 3] == ' ' && this.status[3, 3] == ' ') || (this.status[1, 3] == ' ' && this.status[3, 3] == ' '))
            {
                if (this.status[1, 3] == ' ') { this.setBox(1, 3, this.turn); }
                else if (this.status[2, 3] == ' ') { this.setBox(2, 3, this.turn); }
                else if (this.status[3, 3] == ' ') { this.setBox(3, 3, this.turn); }
            }
            else if ((this.status[1, 1] == ' ' && this.status[2, 2] == ' ') || (this.status[2, 2] == ' ' && this.status[3, 3] == ' ') || (this.status[1, 1] == ' ' && this.status[3, 3] == ' '))
            {
                if (this.status[1, 1] == ' ') { this.setBox(1, 1, this.turn); }
                else if (this.status[2, 2] == ' ') { this.setBox(2, 2, this.turn); }
                else if (this.status[3, 3] == ' ') { this.setBox(3, 3, this.turn); }
            }
            else if ((this.status[1, 3] == ' ' && this.status[2, 2] == ' ') || (this.status[2, 2] == ' ' && this.status[3, 1] == ' ') || (this.status[1, 3] == ' ' && this.status[3, 1] == ' '))
            {
                if (this.status[1, 3] == ' ') { this.setBox(1, 3, this.turn); }
                else if (this.status[2, 2] == ' ') { this.setBox(2, 2, this.turn); }
                else if (this.status[3, 1] == ' ') { this.setBox(3, 1, this.turn); }
            }
            else
            {
                if (this.status[1, 1] == ' ') { this.setBox(1, 1, this.turn); }
                else if (this.status[1, 2] == ' ') { this.setBox(1, 2, this.turn); }
                else if (this.status[1, 3] == ' ') { this.setBox(1, 3, this.turn); }
                else if (this.status[2, 1] == ' ') { this.setBox(2, 1, this.turn); }
                else if (this.status[2, 2] == ' ') { this.setBox(2, 2, this.turn); }
                else if (this.status[2, 3] == ' ') { this.setBox(2, 3, this.turn); }
                else if (this.status[3, 1] == ' ') { this.setBox(3, 1, this.turn); }
                else if (this.status[3, 2] == ' ') { this.setBox(3, 2, this.turn); }
                else if (this.status[3, 3] == ' ') { this.setBox(3, 3, this.turn); }
            }
        }

        void checkWin()
        {
            if (this.status[1, 1] != ' ' && this.status[1, 1] == this.status[1, 2] && this.status[1, 2] == this.status[1, 3]) { MessageBox.Show(this.status[1, 1] + " wins."); this.resetGame(); }
            if (this.status[2, 1] != ' ' && this.status[2, 1] == this.status[2, 2] && this.status[2, 2] == this.status[2, 3]) { MessageBox.Show(this.status[2, 1] + " wins."); this.resetGame(); }
            if (this.status[3, 1] != ' ' && this.status[3, 1] == this.status[3, 2] && this.status[3, 2] == this.status[3, 3]) { MessageBox.Show(this.status[3, 1] + " wins."); this.resetGame(); }

            if (this.status[1, 1] != ' ' && this.status[1, 1] == this.status[2, 1] && this.status[2, 1] == this.status[3, 1]) { MessageBox.Show(this.status[1, 1] + " wins."); this.resetGame(); }
            if (this.status[1, 2] != ' ' && this.status[1, 2] == this.status[2, 2] && this.status[2, 2] == this.status[3, 2]) { MessageBox.Show(this.status[1, 2] + " wins."); this.resetGame(); }
            if (this.status[1, 3] != ' ' && this.status[1, 3] == this.status[2, 3] && this.status[2, 3] == this.status[3, 3]) { MessageBox.Show(this.status[1, 3] + " wins."); this.resetGame(); }

            if (this.status[1, 1] != ' ' && this.status[1, 1] == this.status[2, 2] && this.status[2, 2] == this.status[3, 3]) { MessageBox.Show(this.status[1, 1] + " wins."); this.resetGame(); }
            if (this.status[1, 3] != ' ' && this.status[1, 3] == this.status[2, 2] && this.status[2, 2] == this.status[3, 1]) { MessageBox.Show(this.status[1, 3] + " wins."); this.resetGame(); }
        }
        void resetGame()
        {
            this.status = new char[4, 4] {
 { ' ', ' ', ' ', ' ' },
 { ' ', ' ', ' ', ' ' },
 { ' ', ' ', ' ', ' ' },
 {  ' ', ' ', ' ', ' '  } 
        };
            this.setVisuals();
        }
    }
}