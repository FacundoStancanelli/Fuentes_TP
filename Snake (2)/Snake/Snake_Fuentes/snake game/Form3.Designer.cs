namespace snake_game
{
    partial class Form3
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
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "PREGUNTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Bisque;
            this.A.Location = new System.Drawing.Point(178, 187);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(152, 91);
            this.A.TabIndex = 1;
            this.A.Text = "A) ";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Bisque;
            this.B.Location = new System.Drawing.Point(622, 187);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(150, 91);
            this.B.TabIndex = 2;
            this.B.Text = "B) ";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Bisque;
            this.C.Location = new System.Drawing.Point(169, 495);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(152, 98);
            this.C.TabIndex = 3;
            this.C.Text = "C) ";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.Bisque;
            this.D.Location = new System.Drawing.Point(622, 495);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(150, 98);
            this.D.TabIndex = 4;
            this.D.Text = "D) ";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snake_game.Properties.Resources.Kohelet_Fuentes;
            this.ClientSize = new System.Drawing.Size(1169, 605);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
    }
}