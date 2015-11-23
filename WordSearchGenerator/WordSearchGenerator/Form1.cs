using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Step 1 :read from word list
 * step2 : choose 15 random words from teh list of least 5 letters or more
 * step3 : on form load it will load the words to the listbox then create puzzle
 * step 4: when a word is found and a user clicks on each letter it should 
 * change color and stay that color and cross off the word on the list with a line through it
 * once the puzzle is done it shoudl choose new words and make a new puzzle
 * 
 * the word list is located at the url which should ne either left there OR added to resources so 
 * the user cant cheat and open the file
 * 
 * 
 * the words should be longer then 5 but no longer then 12 letters
 * 
 * you may have to run a test to see how many words would match that as to have 100 different puzzles would need 1500 words
 * 
 * 
 * */


namespace WordSearchGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loader = new Random();
        }
        private Random loader;
        private WordBank bank;
        private char[,] grid;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!listBox1.Items.Contains((string)textBox1.Text.Trim()))
                {
                    listBox1.Items.Add(textBox1.Text.Trim());
                    textBox1.Clear();
                }
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndices.Count > 0)
            //{
            //    for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            //    {
            //        listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No items selected!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                //string[] words;
                //if (listBox1.SelectedItems.Count > 0 && listBox1.SelectedItems.Count<=15)
                //{
                //    words = new string[listBox1.SelectedItems.Count];
                //        for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                //            words[i] = (string)listBox1.SelectedItems[i];
                //}
                //else
                //{
                //    words = new string[listBox1.Items.Count];
                //    for (int i = 0; i < words.Length; i++)
                //        words[i] = (string)listBox1.Items[i];
                //}

                string[] words = new string[listBox1.Items.Count];

                for (int i = 0; i < words.Length; i++)
                    words[i] = (string)listBox1.Items[i];

                this.bank = new WordBank(words, true , 15);
                lstWordsInGrid.Items.Clear();
                foreach (var items in bank.SelectedWords)
                    lstWordsInGrid.Items.Add(items);
                this.grid = this.bank.Generate();
                wordSearch1.DrawBank(grid);
            }
            else
            {
                MessageBox.Show("Please add words to the word bank!", "No word", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnAnswers_Click(object sender, EventArgs e)
        {
            //if (btnAnswers.Text == "Show Answers")
            //{          
            //    if (bank == null)
            //    {
            //        MessageBox.Show("No generated word search yet!", "Generate first!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //    else
            //    {
            //        wordSearch1.DrawAnswers(this.bank);
            //        btnAnswers.Text = "Hide Answers";
            //    }
            //}
            //else
            //{
            //    if (bank == null)
            //    {
            //        MessageBox.Show("No generated word search yet!", "Generate first!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //    else
            //    {
            //        wordSearch1.DrawBank(this.grid);
            //        btnAnswers.Text = "Show Answers";
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (listBox1.Items.Count == 0)
            //{
            //    MessageBox.Show("No words to save!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //string source = string.Empty;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    source += (string)listBox1.Items[i];
            //    if (i != listBox1.Items.Count - 1)
            //        source += ",";
            //}
            //string rnd = Path.GetRandomFileName();
            //File.WriteAllText(@"C:\Users\Austin Green\Desktop\WordSearchs\" + rnd, source);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string username = Environment.UserName;
            //string[] files = Directory.GetFiles(@"C:\Users\"  + username + @"\Desktop\WordSearchs\");
            var datapath = ConfigurationManager.AppSettings.Get("datapath");
            string[] files = Directory.GetFiles(datapath);
            if (files.Length == 0)
            {
                MessageBox.Show("No files to load in Folder!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            string filename = files[loader.Next(0, files.Length)];
            string source = File.ReadAllText(filename);
            string[] words = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);//.Split(',');
            listBox1.Items.Clear();
            listBox1.Items.AddRange(words);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            listBox1.Height = this.Height - 275;
            wordSearch1.Width = this.Width - 174;
            wordSearch1.Height = this.Height - 63;
            wordSearch1.ResizeUpdate();
        }
    }
}
