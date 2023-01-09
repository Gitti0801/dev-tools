
namespace SimpleDevTools
{
    partial class AnalyticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtURL = new System.Windows.Forms.RichTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSuccessful = new System.Windows.Forms.Label();
            this.btnSuccessful = new System.Windows.Forms.Button();
            this.btnError404 = new System.Windows.Forms.Button();
            this.lblError404 = new System.Windows.Forms.Label();
            this.btnErrorOther = new System.Windows.Forms.Button();
            this.lblErrorOther = new System.Windows.Forms.Label();
            this.btnUsersearchExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtURL
            // 
            this.rtxtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtURL.Location = new System.Drawing.Point(362, 12);
            this.rtxtURL.Name = "rtxtURL";
            this.rtxtURL.ReadOnly = true;
            this.rtxtURL.Size = new System.Drawing.Size(426, 426);
            this.rtxtURL.TabIndex = 0;
            this.rtxtURL.Text = "";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total URLs Checked:";
            // 
            // lblSuccessful
            // 
            this.lblSuccessful.AutoSize = true;
            this.lblSuccessful.Location = new System.Drawing.Point(13, 59);
            this.lblSuccessful.Name = "lblSuccessful";
            this.lblSuccessful.Size = new System.Drawing.Size(80, 17);
            this.lblSuccessful.TabIndex = 2;
            this.lblSuccessful.Text = "Successful:";
            // 
            // btnSuccessful
            // 
            this.btnSuccessful.Location = new System.Drawing.Point(16, 80);
            this.btnSuccessful.Name = "btnSuccessful";
            this.btnSuccessful.Size = new System.Drawing.Size(77, 23);
            this.btnSuccessful.TabIndex = 3;
            this.btnSuccessful.Text = "Show";
            this.btnSuccessful.UseVisualStyleBackColor = true;
            this.btnSuccessful.Click += new System.EventHandler(this.btnSuccessful_Click);
            // 
            // btnError404
            // 
            this.btnError404.Location = new System.Drawing.Point(16, 127);
            this.btnError404.Name = "btnError404";
            this.btnError404.Size = new System.Drawing.Size(77, 23);
            this.btnError404.TabIndex = 5;
            this.btnError404.Text = "Show";
            this.btnError404.UseVisualStyleBackColor = true;
            this.btnError404.Click += new System.EventHandler(this.btnError404_Click);
            // 
            // lblError404
            // 
            this.lblError404.AutoSize = true;
            this.lblError404.Location = new System.Drawing.Point(13, 106);
            this.lblError404.Name = "lblError404";
            this.lblError404.Size = new System.Drawing.Size(140, 17);
            this.lblError404.TabIndex = 4;
            this.lblError404.Text = "User Not Found 404:";
            // 
            // btnErrorOther
            // 
            this.btnErrorOther.Location = new System.Drawing.Point(16, 174);
            this.btnErrorOther.Name = "btnErrorOther";
            this.btnErrorOther.Size = new System.Drawing.Size(77, 23);
            this.btnErrorOther.TabIndex = 7;
            this.btnErrorOther.Text = "Show";
            this.btnErrorOther.UseVisualStyleBackColor = true;
            this.btnErrorOther.Click += new System.EventHandler(this.btnErrorOther_Click);
            // 
            // lblErrorOther
            // 
            this.lblErrorOther.AutoSize = true;
            this.lblErrorOther.Location = new System.Drawing.Point(13, 153);
            this.lblErrorOther.Name = "lblErrorOther";
            this.lblErrorOther.Size = new System.Drawing.Size(84, 17);
            this.lblErrorOther.TabIndex = 6;
            this.lblErrorOther.Text = "Other Error:";
            // 
            // btnUsersearchExport
            // 
            this.btnUsersearchExport.Location = new System.Drawing.Point(12, 390);
            this.btnUsersearchExport.Name = "btnUsersearchExport";
            this.btnUsersearchExport.Size = new System.Drawing.Size(344, 48);
            this.btnUsersearchExport.TabIndex = 8;
            this.btnUsersearchExport.Text = "Export to file";
            this.btnUsersearchExport.UseVisualStyleBackColor = true;
            this.btnUsersearchExport.Click += new System.EventHandler(this.btnUsersearchExport_Click);
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsersearchExport);
            this.Controls.Add(this.btnErrorOther);
            this.Controls.Add(this.lblErrorOther);
            this.Controls.Add(this.btnError404);
            this.Controls.Add(this.lblError404);
            this.Controls.Add(this.btnSuccessful);
            this.Controls.Add(this.lblSuccessful);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rtxtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AnalyticsForm";
            this.Text = "UserSearch - Analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtURL;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSuccessful;
        private System.Windows.Forms.Button btnSuccessful;
        private System.Windows.Forms.Button btnError404;
        private System.Windows.Forms.Label lblError404;
        private System.Windows.Forms.Button btnErrorOther;
        private System.Windows.Forms.Label lblErrorOther;
        private System.Windows.Forms.Button btnUsersearchExport;
    }
}