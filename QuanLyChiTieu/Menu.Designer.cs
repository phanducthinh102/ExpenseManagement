namespace QuanLyChiTieu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIncome
            // 
            this.btnIncome.BackgroundImage = global::QuanLyChiTieu.Properties.Resources.Untitled4;
            this.btnIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncome.Location = new System.Drawing.Point(-3, 261);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(356, 92);
            this.btnIncome.TabIndex = 4;
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.BackgroundImage = global::QuanLyChiTieu.Properties.Resources.Untitled3;
            this.btnBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBudget.Location = new System.Drawing.Point(-3, 174);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(356, 92);
            this.btnBudget.TabIndex = 3;
            this.btnBudget.UseVisualStyleBackColor = true;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackgroundImage = global::QuanLyChiTieu.Properties.Resources.Untitled2;
            this.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistic.Location = new System.Drawing.Point(-3, 85);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(356, 92);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpenses.BackgroundImage")));
            this.btnExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpenses.Location = new System.Drawing.Point(-3, -3);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(356, 92);
            this.btnExpenses.TabIndex = 0;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::QuanLyChiTieu.Properties.Resources.Close_delete_remove_exit_cross_x_button_error;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(325, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QuanLyChiTieu.Properties.Resources.Close_delete_remove_exit_cross_x_button_error;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(325, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(348, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.btnStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}