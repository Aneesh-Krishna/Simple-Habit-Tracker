namespace Habit_Tracker
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
            this.txtHabitName = new System.Windows.Forms.TextBox();
            this.btnAddHabit = new System.Windows.Forms.Button();
            this.lstHabits = new System.Windows.Forms.ListBox();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHabitName
            // 
            this.txtHabitName.Location = new System.Drawing.Point(183, 26);
            this.txtHabitName.Name = "txtHabitName";
            this.txtHabitName.Size = new System.Drawing.Size(299, 22);
            this.txtHabitName.TabIndex = 0;
            this.txtHabitName.Text = "Habit Name";
            this.txtHabitName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddHabit
            // 
            this.btnAddHabit.Location = new System.Drawing.Point(493, 25);
            this.btnAddHabit.Name = "btnAddHabit";
            this.btnAddHabit.Size = new System.Drawing.Size(141, 23);
            this.btnAddHabit.TabIndex = 1;
            this.btnAddHabit.Text = "Add";
            this.btnAddHabit.UseVisualStyleBackColor = true;
            this.btnAddHabit.Click += new System.EventHandler(this.btnAddHabit_Click);
            // 
            // lstHabits
            // 
            this.lstHabits.FormattingEnabled = true;
            this.lstHabits.ItemHeight = 16;
            this.lstHabits.Location = new System.Drawing.Point(183, 64);
            this.lstHabits.Name = "lstHabits";
            this.lstHabits.Size = new System.Drawing.Size(451, 292);
            this.lstHabits.TabIndex = 2;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(183, 375);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(93, 20);
            this.chkCompleted.TabIndex = 3;
            this.chkCompleted.Text = "Check Box";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(308, 372);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(75, 23);
            this.btnMarkCompleted.TabIndex = 4;
            this.btnMarkCompleted.Text = "Mark";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(412, 375);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(125, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.lstHabits);
            this.Controls.Add(this.btnAddHabit);
            this.Controls.Add(this.txtHabitName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHabitName;
        private System.Windows.Forms.Button btnAddHabit;
        private System.Windows.Forms.ListBox lstHabits;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Label lblStatus;
    }
}

