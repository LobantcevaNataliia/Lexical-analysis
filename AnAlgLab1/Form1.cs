using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace AnAlgLab1
{
    public partial class Form1 : Form
    {
        LexAnalyzer lexAnalyzer;
        List<string> prog = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            string str;
            prog.Clear();
            richTextBoxProgram.Clear();
            richTextBoxLex.Clear();
            richTextBoxErr.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine();
                    prog.Add(str);
                }
                for (int i = 0; i < prog.Count; i++)
                    richTextBoxProgram.AppendText(prog[i].ToString() + "\n");
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            char[] charsRead = richTextBoxProgram.Text.ToCharArray();
            lexAnalyzer = new LexAnalyzer(charsRead);
            List<Error> err = lexAnalyzer.Analyze();

            richTextBoxErr.Clear();
            if (err.Count != 0)
            {  
                foreach (Error error in err)
                { 
                    
                    richTextBoxErr.AppendText(error.rowErr + ":" + error.colErr + "         " + error.masErr + '\n');
                }
            }
            else
                richTextBoxErr.AppendText("No LA errors");

            richTextBoxLex.Text = lexAnalyzer.lexChain;
            dataGridViewLex.Rows.Clear();
            
            foreach(KeyValuePair<string, string> lexema in lexAnalyzer.lexTable)
                dataGridViewLex.Rows.Add(lexema.Key, lexema.Value);
                
        }
    }
}

