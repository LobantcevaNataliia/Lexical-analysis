using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AnAlgLab1
{
    class LexAnalyzer
    {

        static string currDir = Environment.CurrentDirectory.ToString();
        public string lexChain = "";
        private char[] program;
        public Dictionary<string, string> lexTable = new Dictionary<string, string>();
        public Dictionary<string, string> lexClass = new Dictionary<string, string>();
        int currRow = 2, currCol = 1;

        public LexAnalyzer(char[] program)
        {
            this.program = program;
            using (StreamReader sr = new StreamReader(currDir + @"\t.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string [] s = str.Split(new char[] { '\n', ' ', '\t' });
                    lexClass.Add(s[0], s[1]);
                }
            }
        }

        public List<Error> Analyze()
        {
            List<Error> errors = new List<Error>();

            for (int i = 0; i < program.Length; i++)
            {
                if (IsLetter(program[i]))
                {
                    string currWord = null;
                    
                    while (IsLetter(program[i]) || char.IsDigit(program[i]))
                    {
                        currWord += program[i];
                        i++; currCol++;
                    }
                    i--;

                    if (lexClass.ContainsKey(currWord))
                        AddLex(currWord, lexClass[currWord]);
                    else
                        AddLex(currWord, "ID");
                }
                else if (char.IsNumber(program[i]))
                {
                    string currNum = null;
                    
                    while (char.IsNumber(program[i]))
                    {
                        currNum += program[i];
                        i++; currCol++;
                    }
                    i--;
                    AddLex(currNum, "INT");
                }
                else if (program[i] == '\n' || program[i] == ' ')
                {
                    lexChain += program[i].ToString();
                    currCol++;

                    if (program[i] == '\n')
                    {
                        currCol = 1; currRow++;
                    }
                }
                else if (program[i] == '\'')
                {
                    string strconst = program[i].ToString();
                    i++; currCol++;
                    while (program[i] != '\'')
                    {
                        i++; currCol++;
                        if (i == program.Length)
                        {
                            errors.Add(new Error("String const error", currRow, currCol));
                            break;
                        }
                        strconst += program[i].ToString();
                    }
                    AddLex(strconst + '\'', "STRCONST");               
                }
                else if (program[i] == '{')
                {
                    while (program[i] != '}')
                    {
                        i++; currCol++;
                        if (i == program.Length)
                        {
                            errors.Add(new Error("Comment error", currRow, currCol));
                            break;
                        }
                    }
                }
                else
                {
                    if (lexClass.ContainsKey(program[i].ToString()))
                    {
                        if (lexClass.ContainsKey(program[i].ToString() + program[i + 1].ToString()))
                        {
                            AddLex(program[i].ToString() + program[i + 1].ToString(), lexClass[program[i].ToString() + program[i + 1].ToString()]);
                            i++; currCol++;
                        }
                        else
                            AddLex(program[i].ToString(), lexClass[program[i].ToString()]);
                    }
                    else
                    {
                        errors.Add(new Error("Undefined symbol", currRow, currCol));
                        currCol++;
                    }
                }
            }
            return errors;
        }
        
        public bool IsLetter(char letter)
        {
            return (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
        }

        public void AddLex(string key, string lexClass)
        {
            lexChain += lexClass.ToString() + " ";

            if (!lexTable.ContainsKey(key))
            {
                lexTable.Add(key, lexClass);
            }
        }
    }
}

