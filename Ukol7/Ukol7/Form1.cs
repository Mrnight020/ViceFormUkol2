using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ColorDialog colorDialog = new ColorDialog();
        Button buttonZpet = new Button();
        Button buttonKonec = new Button();
        FontDialog fontDialog = new FontDialog();
        Form form2 = new Form();

        private void button1_Click(object sender, EventArgs e)
        {
            // button4
            // 
            buttonZpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonZpet.Location = new System.Drawing.Point(40, 26);
            buttonZpet.Name = "buttonZpet";
            buttonZpet.Size = new System.Drawing.Size(99, 56);
            buttonZpet.TabIndex = 10;
            buttonZpet.Text = "Zpět";
            buttonZpet.UseVisualStyleBackColor = true;
            buttonZpet.DialogResult = DialogResult.OK;
            // 
            // button5
            // 
            buttonKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonKonec.Location = new System.Drawing.Point(167, 26);
            buttonKonec.Name = "buttonKonec";
            buttonKonec.Size = new System.Drawing.Size(99, 56);
            buttonKonec.TabIndex = 11;
            buttonKonec.Text = "Konec";
            buttonKonec.UseVisualStyleBackColor = true;
            buttonKonec.DialogResult = DialogResult.Cancel;

            form2.Size = new Size((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            form2.BackColor = colorDialog.Color;
            form2.Font = fontDialog.Font;
            if(checkBox1.Checked)
            {
                form2.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                form2.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            form2.Controls.Add(buttonZpet);
            form2.Controls.Add(buttonKonec);

            this.Hide();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                form2.Hide();                  
            }
            else
            {
                this.Close();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
                button3.BackColor = colorDialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (fontDialog.ShowDialog() == DialogResult.OK)
                button2.Font = fontDialog.Font;
        }
    }
}
