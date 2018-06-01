using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;

namespace BFInterpreter
{
    public partial class Form1 : Form
    {
        String inputs;
        String code;
        List<int> vars;
        List<int> tape;
        bool logSteps;
        bool infiniteLoop;
        public Form1()
        {
            InitializeComponent();
            textBoxInputs.Enabled = true;
            infiniteLoop = true;
            logSteps = false;
            inputs = "";
            code = "";
            vars = new List<int>();
            tape = new List<int>();
            for (int i = 0; i < 1000; ++i) tape.Add(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brainfuck interpreter for Windows, version 1.0. Created by Edvin Teskeredžić. 2018, all rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit? All unsaved changes will be lost.", "Confirm Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonQuit_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            if (richTextBoxInput.Text != "")
            {
                res = MessageBox.Show("Creating a new file will erase your current work. Continue?", "Confirm Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No) return;
            }
            richTextBoxInput.Text = "";
            richTextBoxOutput.Text = "";
            richTextBoxLog.Text = "";
            textBoxInputs.Text = "";
            inputs = "";
            code = "";
            vars = new List<int>();
            tape = new List<int>();
            for (int i = 0; i < 1000; ++i) tape.Add(0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            if (richTextBoxInput.Text != "")
            {
                res = MessageBox.Show("Opening a new file will erase your current work. Continue?", "Confirm Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No) return;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bfi files (*.bfi)|*.bfi|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                String numberOfVars = sr.ReadLine();
                int n = Convert.ToInt32(numberOfVars);
                inputs = "";
                code = "";
                vars = new List<int>();
                tape = new List<int>();
                for (int i = 0; i < 1000; ++i) tape.Add(0);
                for (int i = 0; i < n; i++)
                {
                    string str = sr.ReadLine();
                    inputs += str;
                    vars.Add(Convert.ToInt32(str));
                    if(i != n-1) inputs += ",";
                }
                String s = sr.ReadToEnd();
                textBoxInputs.Text = inputs;
                richTextBoxInput.Text = s;
                code = s;

                sr.Close();
            }
        }

        // possible protection against infinite loops - unusued since some programs run a long time in BF
        private bool Infinite()
        {
            System.Threading.Thread.Sleep(10000);
            if (infiniteLoop == true)
            {
                MessageBox.Show("Execution took too long (> 10 seconds)! Possible infinite loop detected. Stopping interpretation!", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Invoke(new Action(() => this.Close()));
            }
            return true;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            code = richTextBoxInput.Text;
            infiniteLoop = true;
            try
            {
                int brackets = 0, counter = 0, pos = 0;
                foreach (char c in code)
                {
                    if (c == '[') brackets++;
                    else if (c == ']') brackets--;
                    if (brackets > 0) pos = counter;
                    if (brackets < 0) throw new Exception("Excess ] bracket on position " + counter.ToString() + ". Please fix your errors and try again!");
                    counter++;
                }
                if (brackets != 0) throw new Exception("Extra [ bracket on position " + pos.ToString() + ". Please fix your errors and try again!");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            for (int i = 0; i < tape.Count; i++) tape[i] = 0;
            if (textBoxInputs.Text != "")
            {
                string[] s = textBoxInputs.Text.Split(',');
                vars = new List<int>();
                if (s.Count() != 0)
                    foreach (string st in s) vars.Add(Convert.ToInt32(st));
            }
            // begin translating BF code
          
            richTextBoxOutput.Text = "";
            richTextBoxLog.Text = "";
            int currentpos = 0, opno = 0, inputno = 0;
            String sout = "";
            bool charmode = true;
            String log = "";

            try
            { 
                for (int i = 0; i < code.Length; i++)
                {
                    if (currentpos < 0) throw new Exception("Invalid tape index!");
                    if (opno > 10000) logSteps = false;
                    if (code[i] == '>')
                    {
                        currentpos++;
                        if(logSteps)
                         log += opno.ToString() + ": Increment data pointer from pos " + (currentpos - 1).ToString() + " to " + currentpos.ToString() + "\n";
                    }
                    else if (code[i] == '<')
                    {
                        currentpos--;
                        if (logSteps)
                        log += opno.ToString() + ": Decrement data pointer from pos " + (currentpos + 1).ToString() + " to " + currentpos.ToString() + "\n";
                    }
                    else if (code[i] == '+')
                    {

                        tape[currentpos]++;
                        if (logSteps)
                            log += opno.ToString() + ": Increment value at current position " + currentpos.ToString() + " by 1 from " + (tape[currentpos] - 1).ToString() + " to " + tape[currentpos].ToString() + "\n";
                            if (tape[currentpos] > 127)
                        {
                            tape[currentpos] = -128;
                            opno++;
                            if (logSteps)
                            log += opno.ToString() + ": Overflow detected: Setting value to zero." + "\n";
                        }
                    }
                    else if (code[i] == '-')
                    {

                        tape[currentpos]--;
                        if (logSteps)
                            log += opno.ToString() + ": Decrement value at current position " + currentpos.ToString() + " by 1 from " + (tape[currentpos] + 1).ToString() + " to " + tape[currentpos].ToString() + "\n";
                            if (tape[currentpos] < -128)
                        {
                            tape[currentpos] = 127;
                            opno++;
                            if (logSteps)
                                log += opno.ToString() + ": Underflow detected: Setting value to zero." + "\n";
                        }
                    }
                    else if (code[i] == '.')
                    {
                        if (tape[currentpos] < 0 && charmode) throw new Exception("Illegal value to be read as char! (have you forgotten to turn on int mode?)");
                        if (logSteps)
                            log += opno.ToString() + ": Print value at current position " + currentpos.ToString() + "\n";
                        if (charmode)
                            sout += Convert.ToChar(tape[currentpos]);
                        else
                            sout += tape[currentpos];
                    }
                    else if (code[i] == '[' && tape[currentpos] == 0)
                    {
                        int br = 0;
                        while (true)
                        {
                            i++;
                            if (code[i] == '[') br++;
                            if (code[i] == ']' && br != 0) br--;
                            else if (code[i] == ']' && br == 0) break;
                            else if (i == code.Length) break;
                        }
                    }
                    else if (code[i] == ']' && tape[currentpos] != 0)
                    {
                        int br = 0;
                        while (true)
                        {
                            i--;
                            if (code[i] == ']') br++;
                            if (code[i] == '[' && br != 0) br--;
                            else if (code[i] == '[' && br == 0) break;
                            else if (i == -1) break;
                        }
                    }
                    else if (code[i] == ',')
                    {
                        if (inputno >= vars.Count) throw new Exception("Invalid number of specified inputs!");
                        if (vars[inputno] == -1)
                        {
                            charmode = !charmode;
                            continue;
                        }
                        tape[currentpos] = vars[inputno];
                        inputno++;
                        if (logSteps)
                        log += opno.ToString() + ": Enter value " + vars[inputno].ToString() + " into " + currentpos.ToString() + "\n";
                    }
                    else continue;
                    opno++;
                }
            }            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "CRITICAL ERROR - INTERPRETATION STOPPED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBoxOutput.Text = sout;
            richTextBoxLog.Text = log;
            infiniteLoop = false;
            richTextBoxLog.Text += "\nSuccess !\nTotal # of operations: " + opno;
  
        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            labelPosition.Text = "Current position: " + richTextBoxInput.SelectionStart;
            code = richTextBoxInput.Text;
        }

        private void richTextBoxInput_CursorChanged(object sender, EventArgs e)
        {
            labelPosition.Text = "Current position: " + richTextBoxInput.SelectionStart;
        }

        private void richTextBoxInput_SelectionChanged(object sender, EventArgs e)
        {
            labelPosition.Text = "Current position: " + richTextBoxInput.SelectionStart;
        }

        private void saveCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Brainfuck Interpreter file|*.bfi";
            sfd.Title = "Save your Brainfuck code";
            sfd.DefaultExt = "bfi";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string name = sfd.FileName;
                string s = "";
                s += vars.Count.ToString();
                s += "\n";
                foreach (int a in vars) s += a.ToString() + "\n";
                s += code;
                File.WriteAllText(name, s);
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (checkBoxLog.Checked == true) buttonRun_Click(sender, e);
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "help.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void checkBoxLog_CheckedChanged(object sender, EventArgs e)
        {
            logSteps = !logSteps;
        }
    }
}
