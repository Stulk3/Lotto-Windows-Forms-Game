﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Lotto : Form
    {
        private Label[,] card1Labels;
        private Label[,] card2Labels;

        private LottoMaster lottoMaster = new LottoMaster();
        private PlayerData playerData = new PlayerData();
        private Card playerCard1= new Card();
        private Card playerCard2 = new Card();

        public Lotto()
        {
            InitializeComponent();
        }

        private void Loto_Load(object sender, EventArgs e)
        {
            card1Labels = new Label[3, 9] {
                {t11,t12,t13,t14,t15,t16,t17,t18,t19},
                {t21,t22,t23,t24,t25,t26,t27,t28,t29},
                {t31,t32,t33,t34,t35,t36,t37,t38,t39},
            };
            card2Labels = new Label[3, 9] {
                {d11,d12,d13,d14,d15,d16,d17,d18,d19},
                {d21,d22,d23,d24,d25,d26,d27,d28,d29},
                {d31,d32,d33,d34,d35,d36,d37,d38,d39},
            };
            UpdateUI();
        }
        private void UpdateUI()
        {
            UpdateCard1UI();
            UpdateCard2UI();
        }
        private void UpdateCard1UI()
        {
            int[,] card1numbers = playerCard1.GetNumbersArray();

            for(int i = 0;i < 8; i++)
            {
                if(card1numbers[0, i] != 0)
                card1Labels[0, i].Text = card1numbers[0, i].ToString();
            }

            for (int i = 0; i < 8; i++)
            {
                if (card1numbers[1, i] != 0)
                    card1Labels[1, i].Text = card1numbers[1, i].ToString();
            }

            for (int i = 0; i < 8; i++)
            {
                if (card1numbers[2, i] != 0)
                    card1Labels[2, i].Text = card1numbers[2, i].ToString();
            }
        }
        private void UpdateCard2UI()
        {
            int[,] card2numbers = playerCard2.GetNumbersArray();

            for (int i = 0; i < 8; i++)
            {
                if (card2numbers[0, i] != 0)
                    card2Labels[0, i].Text = card2numbers[0, i].ToString();
            }

            for (int i = 0; i < 8; i++)
            {
                if (card2numbers[1, i] != 0)
                    card2Labels[1, i].Text = card2numbers[1, i].ToString();
            }

            for (int i = 0; i < 8; i++)
            {
                if (card2numbers[2, i] != 0)
                    card2Labels[2, i].Text = card2numbers[2, i].ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
