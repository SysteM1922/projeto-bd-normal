namespace Projeto_Final
{
    partial class pagInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Revisor_Button = new System.Windows.Forms.Button();
            this.Client_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Revisor_Button
            // 
            this.Revisor_Button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Revisor_Button.Location = new System.Drawing.Point(110, 235);
            this.Revisor_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Revisor_Button.Name = "Revisor_Button";
            this.Revisor_Button.Size = new System.Drawing.Size(267, 99);
            this.Revisor_Button.TabIndex = 0;
            this.Revisor_Button.Text = "Funcionário";
            this.Revisor_Button.UseVisualStyleBackColor = true;
            this.Revisor_Button.Click += new System.EventHandler(this.Revisor_Button_Click);
            // 
            // Client_Button
            // 
            this.Client_Button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_Button.Location = new System.Drawing.Point(110, 83);
            this.Client_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Client_Button.Name = "Client_Button";
            this.Client_Button.Size = new System.Drawing.Size(267, 104);
            this.Client_Button.TabIndex = 1;
            this.Client_Button.Text = "Cliente";
            this.Client_Button.UseVisualStyleBackColor = true;
            this.Client_Button.Click += new System.EventHandler(this.Client_Button_Click);
            // 
            // pagInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 411);
            this.Controls.Add(this.Client_Button);
            this.Controls.Add(this.Revisor_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "pagInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Revisor_Button;
        private System.Windows.Forms.Button Client_Button;
    }
}
