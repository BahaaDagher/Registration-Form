namespace RegistrationApp
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.HoppiesLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.MaleRad = new System.Windows.Forms.RadioButton();
            this.FemaleRad = new System.Windows.Forms.RadioButton();
            this.FootballCheck = new System.Windows.Forms.CheckBox();
            this.TennisCheck = new System.Windows.Forms.CheckBox();
            this.SwimmingCheck = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.NameError = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.Label();
            this.GenderError = new System.Windows.Forms.Label();
            this.HoppyError = new System.Windows.Forms.Label();
            this.ValidReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(74, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(74, 100);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(74, 165);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(52, 16);
            this.GenderLabel.TabIndex = 2;
            this.GenderLabel.Text = "Gender";
            // 
            // HoppiesLabel
            // 
            this.HoppiesLabel.AutoSize = true;
            this.HoppiesLabel.Location = new System.Drawing.Point(74, 234);
            this.HoppiesLabel.Name = "HoppiesLabel";
            this.HoppiesLabel.Size = new System.Drawing.Size(59, 16);
            this.HoppiesLabel.TabIndex = 3;
            this.HoppiesLabel.Text = "Hoppies";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(182, 41);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(132, 22);
            this.NameBox.TabIndex = 4;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(182, 94);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(132, 22);
            this.EmailBox.TabIndex = 5;
            // 
            // MaleRad
            // 
            this.MaleRad.AutoSize = true;
            this.MaleRad.Location = new System.Drawing.Point(182, 161);
            this.MaleRad.Name = "MaleRad";
            this.MaleRad.Size = new System.Drawing.Size(58, 20);
            this.MaleRad.TabIndex = 6;
            this.MaleRad.TabStop = true;
            this.MaleRad.Text = "Male";
            this.MaleRad.UseVisualStyleBackColor = true;
            // 
            // FemaleRad
            // 
            this.FemaleRad.AutoSize = true;
            this.FemaleRad.Location = new System.Drawing.Point(350, 163);
            this.FemaleRad.Name = "FemaleRad";
            this.FemaleRad.Size = new System.Drawing.Size(74, 20);
            this.FemaleRad.TabIndex = 7;
            this.FemaleRad.TabStop = true;
            this.FemaleRad.Text = "Female";
            this.FemaleRad.UseVisualStyleBackColor = true;
            // 
            // FootballCheck
            // 
            this.FootballCheck.AutoSize = true;
            this.FootballCheck.Location = new System.Drawing.Point(182, 233);
            this.FootballCheck.Name = "FootballCheck";
            this.FootballCheck.Size = new System.Drawing.Size(78, 20);
            this.FootballCheck.TabIndex = 8;
            this.FootballCheck.Text = "Football";
            this.FootballCheck.UseVisualStyleBackColor = true;
            // 
            // TennisCheck
            // 
            this.TennisCheck.AutoSize = true;
            this.TennisCheck.Location = new System.Drawing.Point(320, 234);
            this.TennisCheck.Name = "TennisCheck";
            this.TennisCheck.Size = new System.Drawing.Size(70, 20);
            this.TennisCheck.TabIndex = 9;
            this.TennisCheck.Text = "Tennis";
            this.TennisCheck.UseVisualStyleBackColor = true;
            // 
            // SwimmingCheck
            // 
            this.SwimmingCheck.AutoSize = true;
            this.SwimmingCheck.Location = new System.Drawing.Point(470, 234);
            this.SwimmingCheck.Name = "SwimmingCheck";
            this.SwimmingCheck.Size = new System.Drawing.Size(90, 20);
            this.SwimmingCheck.TabIndex = 10;
            this.SwimmingCheck.Text = "Swimming";
            this.SwimmingCheck.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(320, 316);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(130, 45);
            this.RegisterBtn.TabIndex = 11;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.ForeColor = System.Drawing.Color.Red;
            this.NameError.Location = new System.Drawing.Point(409, 47);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(249, 16);
            this.NameError.TabIndex = 12;
            this.NameError.Text = "Name must contain at least 15 charchters";
            this.NameError.Visible = false;
            // 
            // EmailError
            // 
            this.EmailError.AutoSize = true;
            this.EmailError.ForeColor = System.Drawing.Color.Red;
            this.EmailError.Location = new System.Drawing.Point(409, 97);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(135, 16);
            this.EmailError.TabIndex = 13;
            this.EmailError.Text = "Email must contain @";
            this.EmailError.Visible = false;
            // 
            // GenderError
            // 
            this.GenderError.AutoSize = true;
            this.GenderError.ForeColor = System.Drawing.Color.Red;
            this.GenderError.Location = new System.Drawing.Point(548, 165);
            this.GenderError.Name = "GenderError";
            this.GenderError.Size = new System.Drawing.Size(130, 16);
            this.GenderError.TabIndex = 14;
            this.GenderError.Text = "choose your gender ";
            this.GenderError.Visible = false;
            // 
            // HoppyError
            // 
            this.HoppyError.AutoSize = true;
            this.HoppyError.ForeColor = System.Drawing.Color.Red;
            this.HoppyError.Location = new System.Drawing.Point(599, 235);
            this.HoppyError.Name = "HoppyError";
            this.HoppyError.Size = new System.Drawing.Size(168, 16);
            this.HoppyError.TabIndex = 15;
            this.HoppyError.Text = "choose at least one hoppy ";
            this.HoppyError.Visible = false;
            // 
            // ValidReg
            // 
            this.ValidReg.AutoSize = true;
            this.ValidReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidReg.ForeColor = System.Drawing.Color.Green;
            this.ValidReg.Location = new System.Drawing.Point(226, 382);
            this.ValidReg.Name = "ValidReg";
            this.ValidReg.Size = new System.Drawing.Size(334, 25);
            this.ValidReg.TabIndex = 16;
            this.ValidReg.Text = "Thank you !! your registrattion is valid";
            this.ValidReg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValidReg);
            this.Controls.Add(this.HoppyError);
            this.Controls.Add(this.GenderError);
            this.Controls.Add(this.EmailError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.SwimmingCheck);
            this.Controls.Add(this.TennisCheck);
            this.Controls.Add(this.FootballCheck);
            this.Controls.Add(this.FemaleRad);
            this.Controls.Add(this.MaleRad);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.HoppiesLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label HoppiesLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.RadioButton MaleRad;
        private System.Windows.Forms.RadioButton FemaleRad;
        private System.Windows.Forms.CheckBox FootballCheck;
        private System.Windows.Forms.CheckBox TennisCheck;
        private System.Windows.Forms.CheckBox SwimmingCheck;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label GenderError;
        private System.Windows.Forms.Label HoppyError;
        private System.Windows.Forms.Label ValidReg;
    }
}

