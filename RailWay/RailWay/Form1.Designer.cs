namespace RailWay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxListFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxListTo = new System.Windows.Forms.ComboBox();
            this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBoxLastTickets = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxListFrom);
            this.groupBox1.Controls.Add(this.comboBoxListTo);
            this.groupBox1.Controls.Add(this.dateTimeDeparture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requirements";
            // 
            // comboBoxListFrom
            // 
            this.comboBoxListFrom.FormattingEnabled = true;
            this.comboBoxListFrom.Location = new System.Drawing.Point(72, 64);
            this.comboBoxListFrom.Name = "comboBoxListFrom";
            this.comboBoxListFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListFrom.TabIndex = 1;
            // 
            // comboBoxListTo
            // 
            this.comboBoxListTo.FormattingEnabled = true;
            this.comboBoxListTo.Location = new System.Drawing.Point(72, 106);
            this.comboBoxListTo.Name = "comboBoxListTo";
            this.comboBoxListTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListTo.TabIndex = 2;
            // 
            // dateTimeDeparture
            // 
            this.dateTimeDeparture.Location = new System.Drawing.Point(10, 19);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDeparture.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(275, 112);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // listBoxLastTickets
            // 
            this.listBoxLastTickets.FormattingEnabled = true;
            this.listBoxLastTickets.Location = new System.Drawing.Point(6, 19);
            this.listBoxLastTickets.Name = "listBoxLastTickets";
            this.listBoxLastTickets.Size = new System.Drawing.Size(120, 95);
            this.listBoxLastTickets.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter your name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPassengerName);
            this.groupBox2.Controls.Add(this.listBoxLastTickets);
            this.groupBox2.Controls.Add(this.buttonSubmit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(30, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 127);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // textBoxPassengerName
            // 
            this.textBoxPassengerName.Location = new System.Drawing.Point(250, 19);
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassengerName.TabIndex = 10;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(275, 91);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxListFrom;
        private System.Windows.Forms.ComboBox comboBoxListTo;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DateTimePicker dateTimeDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLastTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPassengerName;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

