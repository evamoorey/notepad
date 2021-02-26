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

namespace notepad
{
    public partial class form : System.Windows.Forms.Form
    {
        /// <summary>
        /// Сочетания клавиш для мыши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyDownNew(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                formattt_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                selectText_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                copy_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                paste_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                cut_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.Z)
            {
                undo_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            KeyDownNewNew(sender, e);

        }
        /// <summary>
        /// Сочетания клавиш.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyDownNewNew(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.Z)
            {
                redo_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.K && e.KeyCode == Keys.D)
            {
                formating_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        /// <summary>
        /// Форматирование выбранного текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formattt_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.TabCount == 0)
                {
                    newPage_Click(sender, e);
                    tabControl.SelectTab(0);
                }
                fontDialog.ShowColor = true;
                fontDialog.Font = tabControl.SelectedTab.Font;
                fontDialog.Color = tabControl.SelectedTab.ForeColor;
                if (fontDialog.ShowDialog() != DialogResult.Cancel)
                {
                    ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionFont = fontDialog.Font;
                    ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionColor = fontDialog.Color;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have any pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Выбрать всё.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectText_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount != 0)
                ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectAll();
        }
        /// <summary>
        /// Копирование выделенного текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copy_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount != 0)
                ((RichTextBox)tabControl.SelectedTab.Controls[0]).Copy();
        }
        /// <summary>
        /// Вырезать выделенный текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cut_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount != 0)
                ((RichTextBox)tabControl.SelectedTab.Controls[0]).Cut();
        }
        /// <summary>
        /// Вставить из буфера обмена.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paste_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount != 0)
                ((RichTextBox)tabControl.SelectedTab.Controls[0]).Paste();
        }
    }
}


