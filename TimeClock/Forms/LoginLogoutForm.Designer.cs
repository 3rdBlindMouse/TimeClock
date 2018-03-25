namespace TimeClock.Forms
{
    partial class LoginLogoutForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.staffLabel = new System.Windows.Forms.Label();
            this.StopWatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Crimson;
            this.LogoutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(452, 161);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(300, 220);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.GreenYellow;
            this.LoginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(152, 161);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(300, 220);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clock";
            // 
            // staffLabel
            // 
            this.staffLabel.AutoSize = true;
            this.staffLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLabel.Location = new System.Drawing.Point(144, 67);
            this.staffLabel.Name = "staffLabel";
            this.staffLabel.Size = new System.Drawing.Size(99, 44);
            this.staffLabel.TabIndex = 5;
            this.staffLabel.Text = "Name";
            // 
            // StopWatch
            // 
            this.StopWatch.AutoSize = true;
            this.StopWatch.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopWatch.Location = new System.Drawing.Point(148, 418);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Size = new System.Drawing.Size(166, 44);
            this.StopWatch.TabIndex = 6;
            this.StopWatch.Text = "StopWatch";
            // 
            // LoginLogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 542);
            this.Controls.Add(this.StopWatch);
            this.Controls.Add(this.staffLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginLogoutForm";
            this.Text = "LoginLogoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label staffLabel;
        private System.Windows.Forms.Label StopWatch;
    }
}