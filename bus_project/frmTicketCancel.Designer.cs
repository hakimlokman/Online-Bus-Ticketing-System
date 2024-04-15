namespace bus_project
{
    partial class frmTicketCancel
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
            this.comSupId = new System.Windows.Forms.ComboBox();
            this.comBusId = new System.Windows.Forms.ComboBox();
            this.comTo = new System.Windows.Forms.ComboBox();
            this.comFrom = new System.Windows.Forms.ComboBox();
            this.comBusType = new System.Windows.Forms.ComboBox();
            this.comSeatNo = new System.Windows.Forms.ComboBox();
            this.radOthers = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.timeReportingTime = new System.Windows.Forms.DateTimePicker();
            this.dateJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.txtSeatFare = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtPassengerId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comSupId
            // 
            this.comSupId.FormattingEnabled = true;
            this.comSupId.Location = new System.Drawing.Point(646, 389);
            this.comSupId.Name = "comSupId";
            this.comSupId.Size = new System.Drawing.Size(185, 29);
            this.comSupId.TabIndex = 47;
            // 
            // comBusId
            // 
            this.comBusId.FormattingEnabled = true;
            this.comBusId.Location = new System.Drawing.Point(202, 404);
            this.comBusId.Name = "comBusId";
            this.comBusId.Size = new System.Drawing.Size(185, 29);
            this.comBusId.TabIndex = 46;
            // 
            // comTo
            // 
            this.comTo.FormattingEnabled = true;
            this.comTo.Location = new System.Drawing.Point(725, 139);
            this.comTo.Name = "comTo";
            this.comTo.Size = new System.Drawing.Size(84, 29);
            this.comTo.TabIndex = 44;
            // 
            // comFrom
            // 
            this.comFrom.FormattingEnabled = true;
            this.comFrom.Location = new System.Drawing.Point(567, 139);
            this.comFrom.Name = "comFrom";
            this.comFrom.Size = new System.Drawing.Size(84, 29);
            this.comFrom.TabIndex = 45;
            // 
            // comBusType
            // 
            this.comBusType.FormattingEnabled = true;
            this.comBusType.Location = new System.Drawing.Point(567, 87);
            this.comBusType.Name = "comBusType";
            this.comBusType.Size = new System.Drawing.Size(185, 29);
            this.comBusType.TabIndex = 39;
            // 
            // comSeatNo
            // 
            this.comSeatNo.FormattingEnabled = true;
            this.comSeatNo.Location = new System.Drawing.Point(202, 364);
            this.comSeatNo.Name = "comSeatNo";
            this.comSeatNo.Size = new System.Drawing.Size(185, 29);
            this.comSeatNo.TabIndex = 42;
            // 
            // radOthers
            // 
            this.radOthers.AutoSize = true;
            this.radOthers.Location = new System.Drawing.Point(384, 265);
            this.radOthers.Name = "radOthers";
            this.radOthers.Size = new System.Drawing.Size(80, 25);
            this.radOthers.TabIndex = 38;
            this.radOthers.TabStop = true;
            this.radOthers.Text = "Others";
            this.radOthers.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(275, 265);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(85, 25);
            this.radFemale.TabIndex = 37;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(202, 267);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(67, 25);
            this.radMale.TabIndex = 36;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // timeReportingTime
            // 
            this.timeReportingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeReportingTime.Location = new System.Drawing.Point(646, 304);
            this.timeReportingTime.Name = "timeReportingTime";
            this.timeReportingTime.Size = new System.Drawing.Size(187, 27);
            this.timeReportingTime.TabIndex = 41;
            // 
            // dateJourneyDate
            // 
            this.dateJourneyDate.CustomFormat = "";
            this.dateJourneyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJourneyDate.Location = new System.Drawing.Point(204, 316);
            this.dateJourneyDate.Name = "dateJourneyDate";
            this.dateJourneyDate.Size = new System.Drawing.Size(185, 27);
            this.dateJourneyDate.TabIndex = 40;
            // 
            // txtSeatFare
            // 
            this.txtSeatFare.Location = new System.Drawing.Point(646, 351);
            this.txtSeatFare.Name = "txtSeatFare";
            this.txtSeatFare.Size = new System.Drawing.Size(187, 27);
            this.txtSeatFare.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(202, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 27);
            this.txtEmail.TabIndex = 35;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(202, 178);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(187, 27);
            this.txtMobile.TabIndex = 34;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(202, 136);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(187, 27);
            this.txtPassengerName.TabIndex = 31;
            // 
            // txtPassengerId
            // 
            this.txtPassengerId.Location = new System.Drawing.Point(204, 92);
            this.txtPassengerId.Name = "txtPassengerId";
            this.txtPassengerId.Size = new System.Drawing.Size(109, 27);
            this.txtPassengerId.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(509, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Superviser Id :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Seat Fare :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Reporting Time :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(683, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 21);
            this.label15.TabIndex = 25;
            this.label15.Text = "To :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "From:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Bus Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Bus Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Seat No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Journey Date :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(108, 269);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(78, 21);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mobile :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Passenger Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Passenger Id :";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMsg.Location = new System.Drawing.Point(313, 24);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(251, 38);
            this.lblMsg.TabIndex = 18;
            this.lblMsg.Text = "Ticket Booking ";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(393, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 48);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cancelled";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmTicketCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 514);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comSupId);
            this.Controls.Add(this.comBusId);
            this.Controls.Add(this.comTo);
            this.Controls.Add(this.comFrom);
            this.Controls.Add(this.comBusType);
            this.Controls.Add(this.comSeatNo);
            this.Controls.Add(this.radOthers);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.timeReportingTime);
            this.Controls.Add(this.dateJourneyDate);
            this.Controls.Add(this.txtSeatFare);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.txtPassengerId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmTicketCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTicketCancel";
            this.Load += new System.EventHandler(this.frmTicketCancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comSupId;
        private System.Windows.Forms.ComboBox comBusId;
        private System.Windows.Forms.ComboBox comTo;
        private System.Windows.Forms.ComboBox comFrom;
        private System.Windows.Forms.ComboBox comBusType;
        private System.Windows.Forms.ComboBox comSeatNo;
        private System.Windows.Forms.RadioButton radOthers;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.DateTimePicker timeReportingTime;
        private System.Windows.Forms.DateTimePicker dateJourneyDate;
        private System.Windows.Forms.TextBox txtSeatFare;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtPassengerId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
    }
}