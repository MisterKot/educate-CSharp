using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point moveStart; // точка для перемещения

        public Form1()
        {
            InitializeComponent();
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
        }

        private void time_Update(object sender, EventArgs e) //обновляет часы
        {
            textBox1.Text = Convert.ToString(DateTime.Now);
            if ((DateTime.Now.Hour >= 0) & (DateTime.Now.Hour < 6)) radioButton2.Checked = true; //ночь
            else radioButton1.Checked = true;                                                   //день
        }

        private void button1_Click(object sender, EventArgs e) //STOP
        {
            MessageBox.Show("END GAME");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //START
        {
            if (radioButton1.Checked == true) day_Working();
            else night_Working();
            
        }

        private async void day_Working() //асинхронный метод
        {
            pictureBox2.Image = Properties.Resources.yellow;
            pictureBox3.Image = Properties.Resources.green;
            while (radioButton1.Checked == true) //день
            {
                pictureBox1.Image = Properties.Resources.redActive;
                await Task.Delay(40000);
                pictureBox2.Image = Properties.Resources.yellowActive;
                await Task.Delay(5000);
                pictureBox1.Image = Properties.Resources.red;
                pictureBox2.Image = Properties.Resources.yellow;
                pictureBox3.Image = Properties.Resources.greenActive;
                await Task.Delay(40000);
                pictureBox3.Image = Properties.Resources.green;
                for (int i = 0; i < 6; i++)
                {                    
                    pictureBox3.Image = Properties.Resources.greenActive;
                    await Task.Delay(600);
                    pictureBox3.Image = Properties.Resources.green;
                    await Task.Delay(600);
                }
                pictureBox2.Image = Properties.Resources.yellowActive;
                await Task.Delay(5000);
                pictureBox2.Image = Properties.Resources.yellow;
            }

            night_Working();
        }    

        private async void night_Working()
        {
            pictureBox1.Image = Properties.Resources.red;
            pictureBox3.Image = Properties.Resources.green;
            while (radioButton2.Checked == true) //ночь
            {
                pictureBox2.Image = Properties.Resources.yellowActive;
                await Task.Delay(600);
                pictureBox2.Image = Properties.Resources.yellow;
                await Task.Delay(600);                
            }

            day_Working();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }

    }
}
