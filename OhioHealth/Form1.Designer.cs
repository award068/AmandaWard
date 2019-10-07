using System.Windows.Forms;

namespace OhioHealth
{
    partial class Form1
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
            this.OKBtn = new System.Windows.Forms.Button();
            this.DateTimeStartTxtBox = new System.Windows.Forms.TextBox();
            this.Copyright = new System.Windows.Forms.TextBox();
            this.DateTimeEndTxtBox = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.BedTimeTxtBox = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.bedTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(524, 136);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKBtn.Size = new System.Drawing.Size(100, 28);
            this.OKBtn.TabIndex = 6;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // DateTimeStartTxtBox
            // 
            this.DateTimeStartTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DateTimeStartTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTimeStartTxtBox.Location = new System.Drawing.Point(39, 15);
            this.DateTimeStartTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeStartTxtBox.Name = "DateTimeStartTxtBox";
            this.DateTimeStartTxtBox.Size = new System.Drawing.Size(133, 15);
            this.DateTimeStartTxtBox.TabIndex = 1;
            this.DateTimeStartTxtBox.TabStop = false;
            this.DateTimeStartTxtBox.Text = "Date and Time Start:";
            // 
            // Copyright
            // 
            this.Copyright.BackColor = System.Drawing.SystemColors.Menu;
            this.Copyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Copyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Copyright.Location = new System.Drawing.Point(13, 149);
            this.Copyright.Margin = new System.Windows.Forms.Padding(4);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(125, 15);
            this.Copyright.TabIndex = 5;
            this.Copyright.TabStop = false;
            this.Copyright.Text = "© 2019 A.Ward";
            // 
            // DateTimeEndTxtBox
            // 
            this.DateTimeEndTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DateTimeEndTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTimeEndTxtBox.Location = new System.Drawing.Point(39, 91);
            this.DateTimeEndTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeEndTxtBox.Name = "DateTimeEndTxtBox";
            this.DateTimeEndTxtBox.Size = new System.Drawing.Size(133, 15);
            this.DateTimeEndTxtBox.TabIndex = 1;
            this.DateTimeEndTxtBox.TabStop = false;
            this.DateTimeEndTxtBox.Text = "Date and Time End:";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "ddddd, MMMM dd, yyyy, hh:mm tt";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(180, 12);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(267, 22);
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "ddddd, MMMM dd, yyyy, hh:mm tt";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(180, 91);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(267, 22);
            this.dtEnd.TabIndex = 4;
            // 
            // BedTimeTxtBox
            // 
            this.BedTimeTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.BedTimeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BedTimeTxtBox.Location = new System.Drawing.Point(39, 51);
            this.BedTimeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.BedTimeTxtBox.Name = "BedTimeTxtBox";
            this.BedTimeTxtBox.Size = new System.Drawing.Size(133, 15);
            this.BedTimeTxtBox.TabIndex = 1;
            this.BedTimeTxtBox.TabStop = false;
            this.BedTimeTxtBox.Text = "Bed Time:";
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "hh:mm tt";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(453, 12);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(171, 22);
            this.startTime.TabIndex = 2;
            // 
            // bedTime
            // 
            this.bedTime.CustomFormat = "hh:mm tt";
            this.bedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bedTime.Location = new System.Drawing.Point(180, 51);
            this.bedTime.Name = "bedTime";
            this.bedTime.ShowUpDown = true;
            this.bedTime.Size = new System.Drawing.Size(171, 22);
            this.bedTime.TabIndex = 3;
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "hh:mm tt";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(453, 91);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(171, 22);
            this.endTime.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 177);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.bedTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.DateTimeEndTxtBox);
            this.Controls.Add(this.BedTimeTxtBox);
            this.Controls.Add(this.DateTimeStartTxtBox);
            this.Controls.Add(this.OKBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "OhioHealth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox DateTimeStartTxtBox;
        private System.Windows.Forms.TextBox Copyright;
        private System.Windows.Forms.TextBox DateTimeEndTxtBox;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private TextBox BedTimeTxtBox;
        private DateTimePicker startTime;
        private DateTimePicker bedTime;
        private DateTimePicker endTime;
    }
}

