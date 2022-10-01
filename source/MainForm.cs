using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SystemOfWeaponts
{
    public partial class MainForm : Form
    {
        private Weaponts weaponts;
        private Answers answers;
        private List<ComboBox> combos = new List<ComboBox>();
        private int[] selected = new int[10];
        public MainForm()
        {
            InitializeComponent();
            weaponts = new Weaponts();
            answers = new Answers();
            SetUp();
        }

        public void SetUp()
        {
            combos.Add(comboBox1);
            combos.Add(comboBox2);
            combos.Add(comboBox3);
            combos.Add(comboBox4);
            combos.Add(comboBox5);
            combos.Add(comboBox6);
            combos.Add(comboBox7);
            combos.Add(comboBox8);
            combos.Add(comboBox9);
            combos.Add(comboBox10);

            for (int i = 0; i < answers.answers.Count; i++)
            {
                combos[answers.answers[i].QuestID - 1].Items.Add(answers.answers[i].Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex + 0;
            selected[0] = index;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex + 5;
            selected[1] = index;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox3.SelectedIndex + 9;
            selected[2] = index;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex + 12;
            selected[3] = index;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox5.SelectedIndex + 14;
            selected[4] = index;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox6.SelectedIndex + 16;
            selected[5] = index; ;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox7.SelectedIndex + 18;
            selected[6] = index;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox8.SelectedIndex + 20;
            selected[7] = index; ;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox9.SelectedIndex + 24;
            selected[8] = index;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox10.SelectedIndex + 26;
            selected[9] = index;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < selected.Length; i++)
            {
                answers.answers[selected[i]].Enter(weaponts);
            }

            string result = "";

            foreach (var item in weaponts.weaps)
            {
                result += item.ToString() + Environment.NewLine;
            }

            MessageBox.Show(result, "Результат");

           this.Close();
        }
    }
}
