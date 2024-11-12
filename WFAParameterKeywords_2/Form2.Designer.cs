namespace WFAParameterKeywords_2
{
    partial class Form2
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
            this.BtnAmerika = new System.Windows.Forms.Button();
            this.BtnIskocya = new System.Windows.Forms.Button();
            this.BtnIngiltere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAmerika
            // 
            this.BtnAmerika.Location = new System.Drawing.Point(75, 50);
            this.BtnAmerika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAmerika.Name = "BtnAmerika";
            this.BtnAmerika.Size = new System.Drawing.Size(104, 43);
            this.BtnAmerika.TabIndex = 0;
            this.BtnAmerika.Text = "Amerika";
            this.BtnAmerika.UseVisualStyleBackColor = true;
            this.BtnAmerika.Click += new System.EventHandler(this.BtnIngiltere_Click);
            // 
            // BtnIskocya
            // 
            this.BtnIskocya.Location = new System.Drawing.Point(75, 101);
            this.BtnIskocya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIskocya.Name = "BtnIskocya";
            this.BtnIskocya.Size = new System.Drawing.Size(104, 36);
            this.BtnIskocya.TabIndex = 1;
            this.BtnIskocya.Text = "Iskocya";
            this.BtnIskocya.UseVisualStyleBackColor = true;
            this.BtnIskocya.Click += new System.EventHandler(this.BtnIngiltere_Click);
            // 
            // BtnIngiltere
            // 
            this.BtnIngiltere.Location = new System.Drawing.Point(75, 145);
            this.BtnIngiltere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIngiltere.Name = "BtnIngiltere";
            this.BtnIngiltere.Size = new System.Drawing.Size(104, 36);
            this.BtnIngiltere.TabIndex = 1;
            this.BtnIngiltere.Text = "Ingiltere";
            this.BtnIngiltere.UseVisualStyleBackColor = true;
            this.BtnIngiltere.Click += new System.EventHandler(this.BtnIngiltere_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 298);
            this.Controls.Add(this.BtnIngiltere);
            this.Controls.Add(this.BtnIskocya);
            this.Controls.Add(this.BtnAmerika);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAmerika;
        private System.Windows.Forms.Button BtnIskocya;
        private System.Windows.Forms.Button BtnIngiltere;
    }
}