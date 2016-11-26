namespace DemoCalc
{
    partial class EquaSol
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
            this.txtBox_inB = new System.Windows.Forms.TextBox();
            this.txtBox_inC = new System.Windows.Forms.TextBox();
            this.txtBox_inA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Linear = new System.Windows.Forms.Button();
            this.bt_Quadratic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Solve = new System.Windows.Forms.Button();
            this.txtBox_Equa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_inB
            // 
            this.txtBox_inB.Location = new System.Drawing.Point(114, 156);
            this.txtBox_inB.Name = "txtBox_inB";
            this.txtBox_inB.Size = new System.Drawing.Size(172, 20);
            this.txtBox_inB.TabIndex = 1;
            // 
            // txtBox_inC
            // 
            this.txtBox_inC.Enabled = false;
            this.txtBox_inC.Location = new System.Drawing.Point(114, 182);
            this.txtBox_inC.Name = "txtBox_inC";
            this.txtBox_inC.Size = new System.Drawing.Size(172, 20);
            this.txtBox_inC.TabIndex = 2;
            // 
            // txtBox_inA
            // 
            this.txtBox_inA.Location = new System.Drawing.Point(114, 130);
            this.txtBox_inA.Name = "txtBox_inA";
            this.txtBox_inA.Size = new System.Drawing.Size(172, 20);
            this.txtBox_inA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // bt_Linear
            // 
            this.bt_Linear.Location = new System.Drawing.Point(45, 69);
            this.bt_Linear.Name = "bt_Linear";
            this.bt_Linear.Size = new System.Drawing.Size(96, 30);
            this.bt_Linear.TabIndex = 3;
            this.bt_Linear.Text = "Bậc 1";
            this.bt_Linear.UseVisualStyleBackColor = true;
            this.bt_Linear.Click += new System.EventHandler(this.bt_Linear_Click);
            // 
            // bt_Quadratic
            // 
            this.bt_Quadratic.Location = new System.Drawing.Point(188, 69);
            this.bt_Quadratic.Name = "bt_Quadratic";
            this.bt_Quadratic.Size = new System.Drawing.Size(98, 30);
            this.bt_Quadratic.TabIndex = 4;
            this.bt_Quadratic.Text = "Bậc 2";
            this.bt_Quadratic.UseVisualStyleBackColor = true;
            this.bt_Quadratic.Click += new System.EventHandler(this.bt_Quadratic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập c";
            // 
            // bt_Solve
            // 
            this.bt_Solve.Location = new System.Drawing.Point(45, 249);
            this.bt_Solve.Name = "bt_Solve";
            this.bt_Solve.Size = new System.Drawing.Size(241, 41);
            this.bt_Solve.TabIndex = 3;
            this.bt_Solve.Text = "Giải!";
            this.bt_Solve.UseVisualStyleBackColor = true;
            this.bt_Solve.Click += new System.EventHandler(this.bt_Solve_Click);
            // 
            // txtBox_Equa
            // 
            this.txtBox_Equa.Enabled = false;
            this.txtBox_Equa.Location = new System.Drawing.Point(114, 208);
            this.txtBox_Equa.Name = "txtBox_Equa";
            this.txtBox_Equa.Size = new System.Drawing.Size(172, 20);
            this.txtBox_Equa.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phương trình";
            // 
            // EquaSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 317);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Solve);
            this.Controls.Add(this.bt_Quadratic);
            this.Controls.Add(this.bt_Linear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_inA);
            this.Controls.Add(this.txtBox_Equa);
            this.Controls.Add(this.txtBox_inC);
            this.Controls.Add(this.txtBox_inB);
            this.Name = "EquaSol";
            this.Text = "EquaSol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_inB;
        private System.Windows.Forms.TextBox txtBox_inC;
        private System.Windows.Forms.TextBox txtBox_inA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Linear;
        private System.Windows.Forms.Button bt_Quadratic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Solve;
        private System.Windows.Forms.TextBox txtBox_Equa;
        private System.Windows.Forms.Label label5;
    }
}