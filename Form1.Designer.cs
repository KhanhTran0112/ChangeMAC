namespace ChangeMAC
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
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lbMAC = new System.Windows.Forms.Label();
            this.btnChangeMAC = new System.Windows.Forms.Button();
            this.btnGetMAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(80, 12);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(100, 20);
            this.txtMAC.TabIndex = 0;
            // 
            // lbMAC
            // 
            this.lbMAC.AutoSize = true;
            this.lbMAC.Location = new System.Drawing.Point(443, 15);
            this.lbMAC.Name = "lbMAC";
            this.lbMAC.Size = new System.Drawing.Size(35, 13);
            this.lbMAC.TabIndex = 1;
            this.lbMAC.Text = "label1";
            // 
            // btnChangeMAC
            // 
            this.btnChangeMAC.Location = new System.Drawing.Point(209, 10);
            this.btnChangeMAC.Name = "btnChangeMAC";
            this.btnChangeMAC.Size = new System.Drawing.Size(94, 23);
            this.btnChangeMAC.TabIndex = 2;
            this.btnChangeMAC.Text = "Change MAC";
            this.btnChangeMAC.UseVisualStyleBackColor = true;
            this.btnChangeMAC.Click += new System.EventHandler(this.btnChangeMAC_Click);
            // 
            // btnGetMAC
            // 
            this.btnGetMAC.Location = new System.Drawing.Point(328, 10);
            this.btnGetMAC.Name = "btnGetMAC";
            this.btnGetMAC.Size = new System.Drawing.Size(75, 23);
            this.btnGetMAC.TabIndex = 3;
            this.btnGetMAC.Text = "Get MAC";
            this.btnGetMAC.UseVisualStyleBackColor = true;
            this.btnGetMAC.Click += new System.EventHandler(this.btnGetMAC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetMAC);
            this.Controls.Add(this.btnChangeMAC);
            this.Controls.Add(this.lbMAC);
            this.Controls.Add(this.txtMAC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lbMAC;
        private System.Windows.Forms.Button btnChangeMAC;
        private System.Windows.Forms.Button btnGetMAC;
    }
}

