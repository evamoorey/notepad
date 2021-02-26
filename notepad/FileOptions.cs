using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;

namespace notepad
{
    public partial class form : System.Windows.Forms.Form
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public form()
        {
            InitializeComponent();
            
            if (Properties.Settings1.Default.theme == "dark")
                darkTheme.PerformClick();
            else if (Properties.Settings1.Default.theme == "pink")
                experimentalTheme.PerformClick();
            DataBase();
            SetTimer();
            switch (Properties.Settings1.Default.autoSave)
            {
                case " ": offAutoSave.PerformClick(); break;
                case "1": everyMin.PerformClick(); break;
                case "5": every5Minutes.PerformClick(); break;
                case "15": every15Minutes.PerformClick(); break;
                case "30": every30Minutes.PerformClick(); break;
            }
            
            
        }
        /// <summary>
        /// Создание новой вкладки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.TabPages.Count < 20)
                {
                    TabPage tabPage = new TabPage();
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.ForeColor = Color.DimGray;
                    tabPage.Controls.Add(richTextBox);
                    tabPage.Text = "Page: " + (tabControl.TabCount + 1).ToString();
                    tabPage.Tag = "Page: " + (tabControl.TabCount + 1).ToString();
                    tabPage.Name = " ";
                    richTextBox.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(tabPage);
                    richTextBox.ContextMenuStrip = contextMenuStrip;
                }
                else
                    MessageBox.Show("You have reached the max number of tabs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }

        /// <summary>
        /// Получение имени файла из полного пути.
        /// </summary>
        /// <param name="path">Полный путь к файлу.</param>
        /// <returns>Имя файла.</returns>
        private static string FileName(string path)
        {
            string result = null;
            int i = path.Length - 1;
            while (path[i] != Path.DirectorySeparatorChar)
                i--;
            for (int j = i + 1; j < path.Length; ++j)
                result += path[j];
            return result;
        }
        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="path"></param>
        private void Open(string path)
        {
            try
            {
                if (tabControl.TabPages.Count < 20)
                {
                    TabPage tabPage = new TabPage();
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.ForeColor = Color.DimGray;
                    tabPage.Controls.Add(richTextBox);
                    tabPage.Tag = "Page: " + (tabControl.TabCount + 1).ToString();
                    richTextBox.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(tabPage);
                    try
                    {
                        if (path[path.Length - 1] == 't' || path[path.Length - 1] == 's')
                            richTextBox.Text = File.ReadAllText(path);
                        else
                            richTextBox.LoadFile(path);
                        tabPage.Name = path;
                        tabPage.Text = FileName(path);
                        richTextBox.ContextMenuStrip = contextMenuStrip;
                    }
                    catch (Exception)
                    {
                        tabControl.TabPages.Remove(tabPage);
                    }
                }
                else
                    MessageBox.Show("You have reached the max number of tabs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        /// <summary>
        /// Открытие базы данных и запуск старых вкладок.
        /// </summary>
        private void DataBase()
        {
            try
            {
                string[] path = Properties.Settings1.Default.tabs.Split(" con ");
                foreach (var item in path)
                {
                    Open(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("I don't know what you do to catch this exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Открытие файла по нажатию кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.TabPages.Count < 20)
                {
                    TabPage tabPage = new TabPage();
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.ForeColor = Color.DimGray;
                    tabPage.Controls.Add(richTextBox);
                    tabPage.Tag = "Page: " + (tabControl.TabCount + 1).ToString();
                    richTextBox.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(tabPage);
                    try
                    {
                        var ofd = new OpenFileDialog();
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            if (ofd.FileName[ofd.FileName.Length - 1] == 't' || ofd.FileName[ofd.FileName.Length - 1] == 's')
                                richTextBox.Text = File.ReadAllText(ofd.FileName);
                            else
                                richTextBox.LoadFile(ofd.FileName);
                            tabPage.Name = ofd.FileName;
                        }
                        tabPage.Text = FileName(ofd.FileName);
                        richTextBox.ContextMenuStrip = contextMenuStrip;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You can't open this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControl.TabPages.Remove(tabPage);
                    }
                }
                else
                    MessageBox.Show("You have reached the max number of tabs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        /// <summary>
        /// Закрытие вкладки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                foreach (TabPage item in tabControl.TabPages)
                {
                    if (File.Exists(item.Name))
                    {
                        RichTextBox text = new RichTextBox();

                        if (item.Name[item.Name.Length - 1] == 't' && item.Controls[0].Text != File.ReadAllText(item.Name))
                            flag = true;
                        else if (item.Name[item.Name.Length - 1] == 's' && item.Controls[0].Text != File.ReadAllText(item.Name))
                            flag = true;
                        else if (item.Name[item.Name.Length - 1] == 'f')
                        {
                            text.LoadFile(item.Name);
                            if (!(((RichTextBox)item.Controls[0]).Rtf.Equals(text.Rtf)))
                                flag = true;
                        }

                    }
                    else
                        flag = true;
                }
                if (flag)
                {
                    Save(sender, e);
                }
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have any pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Сохранение файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.TabCount != 0 && File.Exists(tabControl.SelectedTab.Name))
                {
                    try
                    {
                        if (tabControl.SelectedTab.Name[tabControl.SelectedTab.Name.Length - 1] == 't' ||
                            tabControl.SelectedTab.Name[tabControl.SelectedTab.Name.Length - 1] == 's')
                            File.WriteAllText(tabControl.SelectedTab.Name, tabControl.SelectedTab.Controls[0].Text);
                        else
                            ((RichTextBox)tabControl.SelectedTab.Controls[0]).SaveFile(tabControl.SelectedTab.Name);
                    }
                    catch
                    {
                        MessageBox.Show("Can't save file!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    saveAs_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with your file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Сохранение файла с выбором формата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAs_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount != 0)
            {
                try
                {
                    SaveFileDialog savedialog = new SaveFileDialog();
                    savedialog.Title = $"Save text on {tabControl.SelectedTab.Text} as...";
                    savedialog.OverwritePrompt = true;
                    savedialog.CheckPathExists = true;
                    savedialog.Filter = "Text Files(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|Program Files(*.cs)|*.cs";
                    savedialog.ShowHelp = true;
                    if (savedialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            if (savedialog.FilterIndex == 2 || savedialog.FilterIndex == 3)
                                File.WriteAllText(savedialog.FileName, tabControl.SelectedTab.Controls[0].Text);
                            else
                                ((RichTextBox)tabControl.SelectedTab.Controls[0]).SaveFile(savedialog.FileName);
                            tabControl.SelectedTab.Name = savedialog.FileName;
                            tabControl.SelectedTab.Text = FileName(savedialog.FileName);
                        }
                        catch
                        {
                            MessageBox.Show("Can't save file!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with your file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        /// <summary>
        /// Создание базы данных открытых вкладок на момент закрытия приложения.
        /// </summary>
        private void CreateDataBase()
        {
            string dataBase = "";
            foreach (TabPage item in tabControl.TabPages)
            {
                dataBase += item.Name + " con ";
            }
            Properties.Settings1.Default.tabs = dataBase;
        }
        /// <summary>
        /// Действия при закрытии формы(сохранение, создание дефолтных настроек, база данных)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl.TabCount != 0)
            {
                try
                {
                    bool flag = false;
                    flag = Check(flag);
                    if (flag)
                    {
                        var result = MessageBox.Show("Do you want save your pages?", "Form closing", MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            CreateDataBase();
                            Properties.Settings1.Default.Save();
                            e.Cancel = false;
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            CreateDataBase();
                            Properties.Settings1.Default.Save();
                            e.Cancel = true;
                        }
                        else if (result == DialogResult.Yes)
                        {
                            foreach (var item in tabControl.TabPages)
                                SaveTimer(item, e);
                            CreateDataBase();
                            Properties.Settings1.Default.Save();
                        }
                    }
                    else
                    {
                        CreateDataBase();
                        Properties.Settings1.Default.Save();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with your files!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CreateDataBase();
                Properties.Settings1.Default.Save();
            }
        }
        /// <summary>
        /// Проверка был ли изменён файл.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        private bool Check(bool flag)
        {
            foreach (TabPage item in tabControl.TabPages)
            {
                if (File.Exists(item.Name))
                {
                    if (item.Name[item.Name.Length - 1] == 't' && item.Controls[0].Text != File.ReadAllText(item.Name))
                        flag = true;
                    else if (item.Name[item.Name.Length - 1] == 's' && item.Controls[0].Text != File.ReadAllText(item.Name))
                        flag = true;
                    else if (item.Name[item.Name.Length - 1] != 's' && item.Name[item.Name.Length - 1] != 't')
                    {
                        RichTextBox text = new RichTextBox();
                        text.LoadFile(item.Name);
                        if (!(((RichTextBox)item.Controls[0]).Rtf.Equals(text.Rtf)))
                            flag = true;
                    }

                }
                else
                    flag = true;
            }

            return flag;
        }
        /// <summary>
        /// Задать общий формат текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontMain_Click(object sender, EventArgs e)
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
                    ((RichTextBox)tabControl.SelectedTab.Controls[0]).Font = fontDialog.Font;
                    ((RichTextBox)tabControl.SelectedTab.Controls[0]).ForeColor = fontDialog.Color;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have any pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Сохранить все вкладки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAll_Click(object sender, EventArgs e)
        {
            Save(sender, e);
        }
        /// <summary>
        /// Открыть в новом окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openNewWin_Click(object sender, EventArgs e)
        {
            form f = new form();
            f.newPage_Click(sender, e);
            f.Show();
        }
        /// <summary>
        /// Сочетания клавиш.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                save_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                newPage_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                saveAll_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.Q)
            {
                Close();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.W)
            {
                openNewWin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            KeyDownNew(sender, e);
        }
        /// <summary>
        /// Откат к предыдущей версии файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollback_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount != 0 && Yes())
            {
                try
                {
                    List<string> data = Directory.GetFiles(dir).ToList();
                    for (int i = data.Count - 1; i >= 0; i--)
                    {
                        if (NormalName(data[i]) == FileName(tabControl.SelectedTab.Name))
                        {
                            Extract(data, tabControl.SelectedTab, i);
                            File.Delete(data[i]);
                            break;
                        }
                    }

                }
                catch (Exception) { }
            }

        }
        /// <summary>
        /// Получение имени файла из скрытой папки.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private string NormalName(string v)
        {
            string answer = "";
            bool flag = true;
            foreach (var item in v)
            {
                if (!flag)
                    answer += item;
                else if (item == ')')
                    flag = false;
            }
            return answer;
        }
        /// <summary>
        /// Требуется ли откат?
        /// </summary>
        /// <returns></returns>
        private bool Yes()
        {
            var result = MessageBox.Show("Do you want ro restore previous version?\nYou will lose current data!",
                "Form closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return false;
            else
                return true;
        }
        /// <summary>
        /// метод для извлечения последней сохраненной версии 
        /// и записи в richtextbox
        /// </summary>
        /// <param name="data"></param>
        /// <param name="item"></param>
        /// <param name="i"></param>
        private void Extract(List<string> data, TabPage item, int i)
        {
            if (data[i].Contains(".txt") || data[i].Contains(".cs"))
                ((RichTextBox)tabControl.SelectedTab.Controls[0]).Text = File.ReadAllText(data[i]);
            else
                ((RichTextBox)tabControl.SelectedTab.Controls[0]).LoadFile(data[i]);
        }
        /// <summary>
        /// Информация о блокноте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Реализован весь основной функционал \nДополнительный функционал\n" +
                "1. Возможность отката к предыдущей версии (rollback). \n2. Undo/redo \n3. " +
                "Сохранение и открытие исходных кодов C#.\n4. Форматирование кода (Ctrl + K). \n" +
                "5. Компиляция исходного кода. ");
        }

    }
}
