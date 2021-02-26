using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace notepad
{
    public partial class form : System.Windows.Forms.Form
    {
        /// <summary>
        /// Форматирование кода на c#.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formating_Click(object sender, EventArgs e)
        {
            FastColoredTextBox fctb = new FastColoredTextBox();
            fctb.Text = ((RichTextBox)tabControl.SelectedTab.Controls[0]).Text;
            fctb.ForeColor = Color.DimGray;
            tabControl.SelectedTab.Controls.Add(fctb);
            fctb.Dock = DockStyle.Fill;
            fctb.AutoIndentNeeded += new EventHandler<AutoIndentEventArgs>(fctb_AutoIndentNeeded);
            for (int i = 0; i < fctb.LinesCount; i++)
            {
                fctb.DoAutoIndent(i);
            }
            ((RichTextBox)tabControl.SelectedTab.Controls[0]).Text = fctb.Text;
            tabControl.SelectedTab.Controls.Remove(Controls[1]);
        }
        /// <summary>
        /// Дополнительный метод для форматирование кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fctb_AutoIndentNeeded(object sender, AutoIndentEventArgs e)
        {
            if (e.LineText.Trim() == "{")
                e.ShiftNextLines = e.TabLength;
            else if (e.LineText.Trim() == "}")
            {
                e.Shift = -e.TabLength;
                e.ShiftNextLines = -e.TabLength;
            }
        }
        /// <summary>
        /// Изменить компилятор.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeCompil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the most common path to compiler: C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe");
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                Properties.Settings1.Default.compile = ofd.FileName;
        }
        /// <summary>
        /// Компилировать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void compile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Properties.Settings1.Default.compile))
            {
                var ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                    Properties.Settings1.Default.compile = ofd.FileName;
            }
            try
            {
                SaveTimer(tabControl.SelectedTab, e);

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                Process compil = new Process();
                compil.StartInfo = new ProcessStartInfo(Properties.Settings1.Default.compile, tabControl.SelectedTab.Name);
                compil.StartInfo.UseShellExecute = false;
                compil.StartInfo.RedirectStandardInput = true;
                compil.StartInfo.RedirectStandardOutput = true;
                compil.StartInfo.RedirectStandardError = true;
                compil.StartInfo.CreateNoWindow = true;
                compil.StartInfo.StandardErrorEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
                compil.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
                compil.Start();
                compil.WaitForExit();
                var errors = compil.ExitCode;
                string error = compil.StandardError.ReadToEnd();
                string output = compil.StandardOutput.ReadToEnd();
                compil.Close();
                if (errors == 0)
                    MessageBox.Show("Successfull! Your .exe next to the this program .exe file.",
                        "Compile info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Exit code: " + errors.ToString() + Environment.NewLine +
                        error + output, "Compile info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //поменять эксепшн
            catch (ArgumentException)
            {
                MessageBox.Show("You can't compile this file! (maybe you should choose another compiler in settings)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
