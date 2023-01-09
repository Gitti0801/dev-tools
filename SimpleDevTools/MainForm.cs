using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDevTools
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.ThemeColor;
            this.ForeColor = Properties.Settings.Default.ThemeForeColor;
            UpdateTranslatorFileList();
        }

        public void FilesMissing()
        {
            MessageBox.Show("Some files seem to be missing or corrupted. Do you wish to repair them? (Not Working yet)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region Settings
        private void btnSettingsColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Properties.Settings.Default.ThemeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThemeColor = this.BackColor;
            Properties.Settings.Default.ThemeForeColor = this.ForeColor;
            Properties.Settings.Default.Save();
        }

        private void btnSettingsResetChanges_Click(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.ThemeColor;
            this.ForeColor = Properties.Settings.Default.ThemeForeColor;
        }

        private void btnSettingsReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.BackColor = Properties.Settings.Default.ThemeColor;
            this.ForeColor = Properties.Settings.Default.ThemeForeColor;
        }

        private void btnSettingsForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Properties.Settings.Default.ThemeForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = colorDialog.Color;
            }
        }
        private void btnSettingsDevKey_Click(object sender, EventArgs e)
        {

        }

        #endregion Settings

        #region String Incremention
        public void generateStrings(int start, int end, int increment, String replacement)
        {
            rtxtOutputIncrement.Clear();

            if (increment > 0)
            {
                for (int i = start; i <= end; i += increment)
                {
                    String input = txtInputIncrement.Text;
                    rtxtOutputIncrement.AppendText(input.Replace(replacement, i.ToString()));
                    rtxtOutputIncrement.AppendText("\r\n");
                }
            }
            else
            {
                for (int i = start; i >= end; i += increment)
                {
                    String input = txtInputIncrement.Text;
                    rtxtOutputIncrement.AppendText(input.Replace(replacement, i.ToString()));
                    rtxtOutputIncrement.AppendText("\r\n");
                }
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool startingValueBool = int.TryParse(txtStartingValue.Text, out int startingValue);
            bool endingValueBool = int.TryParse(txtEndingValue.Text, out int endingValue);
            bool incrementBool = int.TryParse(txtIncrement.Text, out int increment);
            String replacement = txtCharToReplace.Text;

            if (startingValueBool && endingValueBool && incrementBool)
            {
                if (startingValue < endingValue)
                {
                    if (increment > 0)
                    {
                        generateStrings(startingValue, endingValue, increment, replacement);
                    }
                    else
                    {
                        MessageBox.Show("Error: Please input a positive increment.", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else if (startingValue > endingValue)
                {
                    if (increment < 0)
                    {
                        generateStrings(startingValue, endingValue, increment, replacement);
                    }
                    else
                    {
                        MessageBox.Show("Error: Please input a negative increment.", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Why would you do this tho?", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Error: Please only input numbers as starting value, ending value, or increment.", "ERROR", MessageBoxButtons.OK);
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtOutputIncrement.Text);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtOutputIncrement.Clear();
        }

        #endregion

        #region UserSearch

        int currentURL = 0;
        String[] results;
        List<String> successful;
        List<String> error404 = new List<String>();
        List<String> errorOther = new List<String>();

        public bool CheckForInternetConnection()
        {
            WebRequest request = WebRequest.Create("https://google.com");
            try
            {
                request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public void ChangeStatus(String status)
        {
            if (this.lblStatus.InvokeRequired)
            {
                this.lblStatus.BeginInvoke((MethodInvoker)delegate () { this.lblStatus.Text = "Status: " + status; ; });
            }
            else
            {
                this.lblStatus.Text = "Status: " + status; ;
            }
        }
        public void UpdateCounter(int done, int total)
        {
            if (this.lblCounter.InvokeRequired)
            {
                this.lblCounter.BeginInvoke((MethodInvoker)delegate () { this.lblCounter.Text = done + "/" + total + " Checked"; ; });
            }
            else
            {
                this.lblCounter.Text = done + "/" + total + " Checked"; ;
            }
        }
        public void UpdateWorkingCounter(int counter)
        {
            if (this.lblResults.InvokeRequired)
            {
                this.lblResults.BeginInvoke((MethodInvoker)delegate () { this.lblResults.Text = counter + " Working Results"; ; });
            }
            else
            {
                this.lblResults.Text = counter + " Working Results"; ;
            }
        }
        public void UpdateOutput(string output)
        {
            if (this.rtxtOutputUserSearch.InvokeRequired)
            {
                this.rtxtOutputUserSearch.BeginInvoke((MethodInvoker)delegate () { this.rtxtOutputUserSearch.AppendText(output); });
                this.rtxtOutputUserSearch.BeginInvoke((MethodInvoker)delegate () { this.rtxtOutputUserSearch.AppendText("\r\n"); });
            }
            else
            {
                this.rtxtOutputUserSearch.AppendText(output);
                this.rtxtOutputUserSearch.AppendText("\r\n");
            }
        }
        public void EvaluateResults()
        {
            if (this.btnCancel.InvokeRequired)
            {
                this.btnCancel.BeginInvoke((MethodInvoker)delegate () { this.btnCancel.Enabled = false; ; });
            }
            else
            {
                this.btnCancel.Enabled = false; ;
            }

            if (this.btnReset.InvokeRequired)
            {
                this.btnReset.BeginInvoke((MethodInvoker)delegate () { this.btnReset.Enabled = true; ; });
            }
            else
            {
                this.btnReset.Enabled = true; ;
            }

            if (this.btnOpenURL.InvokeRequired)
            {
                this.btnOpenURL.BeginInvoke((MethodInvoker)delegate () { this.btnOpenURL.Enabled = true; ; });
            }
            else
            {
                this.btnOpenURL.Enabled = true; ;
            }
            if (this.lblURL.InvokeRequired)
            {
                this.lblURL.BeginInvoke((MethodInvoker)delegate () { this.lblURL.Text = results[currentURL]; ; });
            }
            else
            {
                this.lblURL.Text = results[currentURL]; ;
            }
            if (this.btnStats.InvokeRequired)
            {
                this.btnStats.BeginInvoke((MethodInvoker)delegate () { this.btnStats.Enabled = true; ; });
            }
            else
            {
                this.btnStats.Enabled = true; ;
            }
        }
        public void Throw404(String url)
        {
            Console.WriteLine(url + ": User Not Found 404");
            error404.Add(url);
        }

        public List<String> RunUserSearch()
        {
            ChangeStatus("Running");
            int counter = 0;
            int results = 0;
            List<String> foundProfiles = new List<string>();
            String username = txtUsername.Text;
            String[] socialMedia = File.ReadAllLines("social_media_list.txt").Where(x => x.Contains("http") && !x.Contains("Example:")).ToArray();
            String[] error404Messages =
            {
                "Пользователь не зарегистрирован и не имеет профиля для просмотра.",
"This summoner is not registered at OP.GG. Please check spelling.",
"No user ID specified or user does not exist!",
"Error : User " + username + " not found.",
"No search results",
"The specified member cannot be found. Please enter a member's entire name.",
"No packages found.",
"Sorry, nobody on Reddit goes by that name.",
"This account doesn’t exist",
"۴۰۴",
"(centralauth-admin-nonexistent: " + username + ")",
username + ".wordpress.com doesn't exist",
"нет такого участника Konni48",
"Указанный пользователь не найден. Пожалуйста, введите другое имя.",
"This profile does not exist",
            };

            foreach (String current in socialMedia)
            {
                if (bwCheckURL.CancellationPending)
                {
                    ChangeStatus("Cancelled");
                    return foundProfiles;
                }

                if (!String.IsNullOrWhiteSpace(current))
                {
                    WebClient x = new WebClient();
                    string url = current.Replace("{}", username);

                    try
                    {
                        string source = x.DownloadString(url);
                        string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                        RegexOptions.IgnoreCase).Groups["Title"].Value;

                        if (!title.Contains("404") && title.IndexOf("Not Found", StringComparison.OrdinalIgnoreCase) <= 0 && title.IndexOf("Error", StringComparison.OrdinalIgnoreCase) <= 0)
                        {
                            if (source.IndexOf(username, StringComparison.OrdinalIgnoreCase) >= 0)
                            {

                                foreach (String error404Message in error404Messages)
                                {
                                    if (source.Contains(error404Message))
                                    {
                                        Throw404(url);
                                        break;
                                    }
                                }

                                if (!error404.Contains(url))
                                {
                                    foundProfiles.Add(url);
                                    results++;
                                    UpdateOutput(url);
                                    UpdateWorkingCounter(results);
                                }

                            }
                            else
                            {
                                Throw404(url);
                            }
                        }
                        else
                        {
                            Throw404(url);
                        }
                    }
                    catch (WebException e)
                    {
                        if (e.Message.Contains("404"))
                        {
                            Throw404(url);
                        }
                        else
                        {
                            Console.WriteLine(url + ": A problem occured (" + e.Message + ")");
                            errorOther.Add(url + " : " + e.Message);
                        }
                    }
                }

                counter++;
                UpdateCounter(counter, socialMedia.Length);
            }
            ChangeStatus("Done");
            return foundProfiles;
        }

        public String[] ListToArray(List<String> list)
        {
            //List to array
            String[] array = new string[list.Count];
            int i = 0;
            foreach (String current in list)
            {
                array[i] = current;
                i++;
            }
            return array;
        }

        private void btnEnterUserSearch_Click(object sender, EventArgs e)
        {
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("Please make sure you are connected to the internet.", "ERROR", MessageBoxButtons.OK);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username field is empty.", "ERROR", MessageBoxButtons.OK);
                return;
            }
            btnEnterUserSearch.Enabled = false;
            btnCancel.Enabled = true;
            bwCheckURL.RunWorkerAsync();
        }

        private void bwCheckURL_DoWork(object sender, DoWorkEventArgs e)
        {
            List<String> resultsList = RunUserSearch();
            if (resultsList == null)
            {
                return;
            }
            this.successful = resultsList;
            results = ListToArray(resultsList);
            EvaluateResults();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bwCheckURL.CancelAsync();
        }

        private void btnOpenURL_Click(object sender, EventArgs e)
        {
            Process.Start(results[currentURL]);
            if (currentURL <= results.Length - 2)
            {
                currentURL++;
                lblURL.Text = results[currentURL];
            }
            else
            {
                btnOpenURL.Enabled = false;
                lblURL.Text = "Done.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtxtOutputUserSearch.Clear();
            btnReset.Enabled = false;
            lblURL.Text = "URL WILL BE DISPLAYED HERE";
            ChangeStatus("Standby");
            lblCounter.Text = "0/??? Checked";
            lblResults.Text = "??? Working Results";
            btnOpenURL.Enabled = false;
            btnStats.Enabled = false;
            txtUsername.Clear();

            this.successful.Clear();
            this.error404.Clear();
            this.errorOther.Clear();

            btnEnterUserSearch.Enabled = true;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            AnalyticsForm form = new AnalyticsForm(txtUsername.Text, successful, error404, errorOther);
            form.Show();
        }

        #endregion

        #region Translator

        public void UpdateTranslatorFileList()
        {
            String path = "translator_lists";
            cbTranslatorType.Items.Clear();

            if (!Directory.Exists(path))
            {
                FilesMissing();
            }

            foreach (String current in Directory.GetFiles(path))
            {
                if (Path.GetExtension(current).Equals(".txt"))
                {
                    String fileName = Path.GetFileName(current);
                    fileName = fileName.Replace(".txt", "");
                    cbTranslatorType.Items.Add(fileName);
                }
            }
        }
        private void btnTranslatorImport_Click(object sender, EventArgs e)
        {
            cmsTranslatorImport.Show(btnTranslatorImport, new Point(0, btnTranslatorImport.Height));
        }
        private void btnTranslatorTranslate_Click(object sender, EventArgs e)
        {
            //Variables
            Dictionary<Char, String> list = new Dictionary<char, string>();
            List<Char> failedToTranslate = new List<char>();
            String input = rtxtTranslatorInput.Text;
            String output = null;
            String separator = null;

            if (!String.IsNullOrWhiteSpace(input))
            {
                if (cbTranslatorType.SelectedIndex != -1)
                {
                    Console.WriteLine("Loading dictionary...");
                    if (!File.Exists("translator_lists/" + cbTranslatorType.Text + ".txt"))
                    {
                        MessageBox.Show("The selected list does not exist anymore. Please press \"Update\" and check in the list folder.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    String[] fileContent = File.ReadAllLines("translator_lists/" + cbTranslatorType.Text + ".txt");

                    //Add elements from file to the dictionary
                    foreach (String current in fileContent)
                    {
                        String[] split = current.Split(new String[] { " = " }, StringSplitOptions.None);
                        if (split.Length == 2)
                        {
                            split[0] = split[0].Replace(" ", String.Empty);
                            split[1] = split[1].Replace(" ", String.Empty);
                            if (!split[0].Equals("[SEPARATOR]"))
                            {
                                try
                                {
                                    list.Add(Char.Parse(split[0]), split[1]);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine($"Couldn't add \"{split[0]} = {split[1]}\" to the dictionary.");
                                }
                            }
                            else
                            {
                                separator = split[1];
                            }
                        }
                    }
                    list.Add(' ', " ");
                    Console.WriteLine("Dictionary loaded.");

                    //Translation
                    foreach (Char current in input.ToCharArray())
                    {
                        if (list.ContainsKey(current))
                        {
                            output += list[current];
                            if (!Char.IsWhiteSpace(current))
                            {
                                output += separator;
                            }
                        }
                        else if (list.ContainsKey(Char.ToUpper(current)))
                        {
                            output += list[Char.ToUpper(current)];
                            if (!Char.IsWhiteSpace(current))
                            {
                                output += separator;
                            }
                        }
                        else
                        {
                            if (!failedToTranslate.Contains(current))
                            {
                                if (!Char.IsWhiteSpace(current) && !current.Equals('\n'))
                                {
                                    failedToTranslate.Add(current);
                                }
                            }
                        }
                    }

                    rtxtTranslatorOutput.Text = output;

                    //Handles all characters which have not been specified in the list
                    if (failedToTranslate.Count > 0)
                    {
                        if (MessageBox.Show("The program failed to find a translation for the following characters: '" + new String(failedToTranslate.ToArray()) + "'. Would you like to delete them?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            foreach (Char current in failedToTranslate)
                            {
                                if (output != null)
                                {
                                    output = output.Replace(current.ToString(), String.Empty);
                                }
                            }
                            rtxtTranslatorOutput.Text = output;
                        }
                    }
                }
            }
        }
        private void btnTranslatorOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("translator_lists");
        }

        private void btnTranslatorUpdate_Click(object sender, EventArgs e)
        {
            UpdateTranslatorFileList();
        }
        private void btnTranslatorExport_Click(object sender, EventArgs e)
        {
            cmsTranslatorExport.Show(btnTranslatorExport, new Point(0, btnTranslatorExport.Height));
        }
        private void btnTranslatorClear_Click(object sender, EventArgs e)
        {
            rtxtTranslatorInput.Clear();
            rtxtTranslatorOutput.Clear();
        }
        private void fromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtTranslatorInput.Text = Clipboard.GetText();
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog translatorOpenFile = new OpenFileDialog();
            translatorOpenFile.Filter = "txt files (*.txt)|*.txt";
            if (translatorOpenFile.ShowDialog() == DialogResult.OK)
            {
                rtxtTranslatorInput.Text = File.ReadAllText(translatorOpenFile.FileName);
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtTranslatorOutput.Text);
        }

        private void asFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog translatorSaveFile = new SaveFileDialog();
            translatorSaveFile.Filter = "txt files (*.txt)|*.txt";
            if (translatorSaveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(translatorSaveFile.FileName, rtxtTranslatorOutput.Text);
            }
        }

        #endregion

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
