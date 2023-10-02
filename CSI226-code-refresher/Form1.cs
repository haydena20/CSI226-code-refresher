using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI226_code_refresher
{
    public partial class Form1 : Form
    {
        private List<Player> playerList = new List<Player> ();

        public Form1()
        {
            InitializeComponent();

            //Init list values
            playerList.Add(new Player("Hayden", 1));
            playerList.Add(new Player("Micajah", 2));
            playerList.Add(new Player("Dylan", 3));
            playerList.Add(new Player("Sadie", 4));
            playerList.Add(new Player("Kiran", 5));

            UpdateTable("ALL");
        }

        private void UpdateTable(string SortMethod)
        {
            listBox1.Items.Clear();
            switch (SortMethod)
            {
                case "ALL":
                    goto default;

                case "ODD":
                    foreach (var pl in playerList)
                    { 
                        if(pl.playerNumber % 2 != 0)
                            listBox1.Items.Add(pl);
                    }
                    break;

                case "LETTER":
                    if(textBox2.Text.Length != 0)
                        foreach (var pl in playerList)
                        {
                            foreach(var letter in pl.playerName)
                                if(char.ToLower(letter) == char.ToLower(textBox2.Text[0]))
                                {
                                    listBox1.Items.Add(pl);
                                    break;
                                }
                        }
                    break;

                default:
                    foreach (var pl in playerList)
                    { listBox1.Items.Add(pl); }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTable("ALL");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTable("ODD");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateTable("LETTER");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            if (textBox1.Text.Length == 0)
            {
                textBox1.BackColor = Color.Red;
                return;
            }

            numericUpDown1.BackColor = Color.White;
            foreach (var pl in playerList)
                if(numericUpDown1.Value == pl.playerNumber)
                {
                    numericUpDown1.BackColor = Color.Red;
                    return;
                }

            playerList.Add(new Player(textBox1.Text, (int)numericUpDown1.Value));
            UpdateTable("");
        }
    }
}
