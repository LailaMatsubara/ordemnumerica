using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        float n1, n2, n3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtn1.Text); 
            n2 = float.Parse(txtn2.Text);
            n3 = float.Parse(txtn3.Text); 
            if (n1 > n2) 
            { 
                if (n1 > n3) 
                { 
                    if (n2 > n3) 
                    { 
                        MessageBox.Show($"Os números em ordem crescente são: {n3}, {n2}, {n1}.", "Ordem crescente", MessageBoxButtons.OK); 
                    } 
                    else 
                    { 
                        MessageBox.Show($"Os números em ordem crescente são: {n2},{n3},{n1}.", "Ordem crescente", MessageBoxButtons.OK); 
                    } 
                } 
                else 
                { 
                    MessageBox.Show($"Os números em ordem crescente são: {n2}, {n1}, {n3}.", "Ordem crescente", MessageBoxButtons.OK); 
                } 
            } 
            else 
            { 
                if (n2 > n3) 
                { 
                    if (n1 > n3) 
                    { 
                        MessageBox.Show($"Os números em ordem crescente são: {n3}, {n1}, {n2}.", "Ordem crescente", MessageBoxButtons.OK); 
                    } 
                    else 
                    { 
                        MessageBox.Show($"Os números em ordem crescente são: {n1}, {n3}, {n2}.", "Ordem crescente", MessageBoxButtons.OK); 
                    } 
                } 
                else 
                { 
                    MessageBox.Show($"Os números em ordem crescente são: {n1}, {n2}, {n3}.", "Ordem crescente", MessageBoxButtons.OK); 
                } 
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear(); 
            txtn2.Clear(); 
            txtn3.Clear();
        }
    }
}
