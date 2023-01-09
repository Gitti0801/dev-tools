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

namespace SimpleDevTools
{
    public partial class AnalyticsForm : Form
    {

        List<String> successful;
        List<String> error404;
        List<String> errorOther;
        String username;
        int total;

        public AnalyticsForm(String username, List<String> successful, List<String> error404, List<String> errorOther)
        {
            int total = successful.Count + error404.Count + errorOther.Count;
            InitializeComponent();
            lblTotal.Text = "Total URLs Checked: " + total;
            lblSuccessful.Text = "Successful: " + successful.Count + " (" + successful.Count * 100 / total + "%)";
            lblError404.Text = "User Not Found 404: " + error404.Count + " (" + error404.Count * 100 / total + "%)";
            lblErrorOther.Text = "Other Error: " + errorOther.Count + " (" + errorOther.Count * 100 / total + "%)";

            this.successful = successful;
            this.error404 = error404;
            this.errorOther = errorOther;
            this.username = username;
            this.total = total;
        }

        private void btnSuccessful_Click(object sender, EventArgs e)
        {
            rtxtURL.Clear();
            foreach (String current in successful)
            {
                rtxtURL.AppendText(current);
                rtxtURL.AppendText("\r\n");
            }
        }

        private void btnError404_Click(object sender, EventArgs e)
        {
            rtxtURL.Clear();
            foreach (String current in error404)
            {
                rtxtURL.AppendText(current);
                rtxtURL.AppendText("\r\n");
            }
        }

        private void btnErrorOther_Click(object sender, EventArgs e)
        {
            rtxtURL.Clear();
            foreach (String current in errorOther)
            {
                rtxtURL.AppendText(current);
                rtxtURL.AppendText("\r\n");
            }
        }

        private void btnUsersearchExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog usersearchSaveFile = new SaveFileDialog();
            usersearchSaveFile.Filter = "txt files (*.txt)|*.txt";
            if (usersearchSaveFile.ShowDialog() == DialogResult.OK)
            {

                String.Join("\n", this.successful);

                String output = "UserSearch Analytics\n" +
                    "\n" +
                    "----------------------------------\n" +
                    "\n" +
                    $"Username: {username}\n" +
                    $"Total URLs checked: {total}\n" +
                    "Date: " + DateTime.Now + "\n" +
                    " \n" +
                    "----------------------------------\n" +
                    " \n" +
                    lblSuccessful.Text + "\n" +
                    "\n" +
                    String.Join("\n", successful) + "\n" +
                    "\n" +
                    "----------------------------------\n" +
                    "\n" +
                    lblError404.Text + "\n" +
                    "\n" +
                    String.Join("\n", error404) + "\n" +
                    "\n" +
                    "----------------------------------\n" +
                    "\n" +
                    lblErrorOther.Text + "\n" +
                    "\n" +
                    String.Join("\n", errorOther) + "\n" +
                    "";

                File.WriteAllText(usersearchSaveFile.FileName, output);
            }
        }
    }
}
