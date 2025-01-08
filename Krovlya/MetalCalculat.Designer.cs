namespace Krovlya
{
    partial class MetalCalculat
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAmountMetal = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGeneralPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1235, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(25, 722);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 40);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(586, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Розрахунки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площа ";
            // 
            // labelAmountMetal
            // 
            this.labelAmountMetal.AutoSize = true;
            this.labelAmountMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountMetal.Location = new System.Drawing.Point(306, 149);
            this.labelAmountMetal.Name = "labelAmountMetal";
            this.labelAmountMetal.Size = new System.Drawing.Size(20, 29);
            this.labelAmountMetal.TabIndex = 4;
            this.labelAmountMetal.Text = "/";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(306, 205);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(20, 29);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(85, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кількість листів";
            // 
            // labelGeneralPrice
            // 
            this.labelGeneralPrice.AutoSize = true;
            this.labelGeneralPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGeneralPrice.Location = new System.Drawing.Point(306, 261);
            this.labelGeneralPrice.Name = "labelGeneralPrice";
            this.labelGeneralPrice.Size = new System.Drawing.Size(20, 29);
            this.labelGeneralPrice.TabIndex = 8;
            this.labelGeneralPrice.Text = "/";
            this.labelGeneralPrice.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Загальна ціна металу";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelGood
            // 
            this.labelGood.AutoSize = true;
            this.labelGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGood.Location = new System.Drawing.Point(291, 90);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(186, 26);
            this.labelGood.TabIndex = 9;
            this.labelGood.Text = "Металочерепиця";
            // 
            // MetalCalculat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1390, 774);
            this.Controls.Add(this.labelGood);
            this.Controls.Add(this.labelGeneralPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAmountMetal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button1);
            this.Name = "MetalCalculat";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAmountMetal;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGeneralPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGood;
    }
}