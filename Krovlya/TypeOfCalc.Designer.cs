namespace Krovlya
{
    partial class TypeOfCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonElementOfRoof = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(486, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обрати тип розрахунку";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonElementOfRoof
            // 
            this.buttonElementOfRoof.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonElementOfRoof.Location = new System.Drawing.Point(356, 365);
            this.buttonElementOfRoof.Name = "buttonElementOfRoof";
            this.buttonElementOfRoof.Size = new System.Drawing.Size(316, 75);
            this.buttonElementOfRoof.TabIndex = 1;
            this.buttonElementOfRoof.Text = "Елемент кровлі";
            this.buttonElementOfRoof.UseVisualStyleBackColor = true;
            this.buttonElementOfRoof.Click += new System.EventHandler(this.buttonElementOfRoof_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(722, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Кровля-план";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TypeOfCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1430, 873);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonElementOfRoof);
            this.Controls.Add(this.label1);
            this.Name = "TypeOfCalc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonElementOfRoof;
        private System.Windows.Forms.Button button2;
    }
}