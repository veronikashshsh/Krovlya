namespace Krovlya
{
    partial class MetalRoofData
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
            this.pictureBoxComp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumOfComp = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelInputs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxComp
            // 
            this.pictureBoxComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxComp.Location = new System.Drawing.Point(61, 92);
            this.pictureBoxComp.Name = "pictureBoxComp";
            this.pictureBoxComp.Size = new System.Drawing.Size(906, 634);
            this.pictureBoxComp.TabIndex = 0;
            this.pictureBoxComp.TabStop = false;
            this.pictureBoxComp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(945, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть дані";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1218, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Розмір, м";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNumOfComp
            // 
            this.labelNumOfComp.AutoSize = true;
            this.labelNumOfComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumOfComp.Location = new System.Drawing.Point(25, 24);
            this.labelNumOfComp.Name = "labelNumOfComp";
            this.labelNumOfComp.Size = new System.Drawing.Size(22, 32);
            this.labelNumOfComp.TabIndex = 11;
            this.labelNumOfComp.Text = "/";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1336, 760);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(123, 40);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Далі";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 760);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 40);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelInputs
            // 
            this.panelInputs.Location = new System.Drawing.Point(987, 136);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(471, 416);
            this.panelInputs.TabIndex = 14;
            // 
            // MetalRoofData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1483, 812);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelNumOfComp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxComp);
            this.Name = "MetalRoofData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MetalRoofData_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumOfComp;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelInputs;
    }
}