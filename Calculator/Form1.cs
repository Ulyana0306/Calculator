using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox1.MaxLength = 9;
        }
        ClassOperation NewClass = new ClassOperation();

        //Числа
        private void One_Click(object sender, EventArgs e)
        {

           NewClass.Reading("1", textBox1);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            NewClass.Reading("2", textBox1);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            NewClass.Reading("3", textBox1); 
        }

        private void Four_Click(object sender, EventArgs e)
        {
            NewClass.Reading("4", textBox1);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            NewClass.Reading("5", textBox1);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            NewClass.Reading("6", textBox1);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            NewClass.Reading("7", textBox1);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            NewClass.Reading("8", textBox1);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            NewClass.Reading("9", textBox1);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            NewClass.Reading("0", textBox1);
        }


        //функции
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            NewClass.PlusMinus(labelMinus);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           NewClass.Clear(textBox1, labelMinus);

        }//для очистки поля ввода
   
        private void Plus_Click(object sender, EventArgs e)
        {
            NewClass.Operation(textBox1, 0, labelMinus);
        }//для сложения

        private void Equals_Click(object sender, EventArgs e)
        {
            NewClass.Solution(textBox1, labelMinus);
        }//для равно

        private void Multiply_Click(object sender, EventArgs e)
        {
          NewClass.Operation(textBox1, 2, labelMinus);
        }//для умножения

        private void Divide_Click(object sender, EventArgs e)
        {
            NewClass.Operation(textBox1, 3, labelMinus);
        }//для деления

        private void Minus_Click(object sender, EventArgs e)
        {
            NewClass.Operation(textBox1, 1, labelMinus);
        }//для разности

        //кнопки управления
        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }//для кнопки закрыть

        private void Minim_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }//для кнопки свернуть
    }
}
