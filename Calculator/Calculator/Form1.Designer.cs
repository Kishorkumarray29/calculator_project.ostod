namespace Calculator
{
    partial class Form1
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
            txttotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnEquual = new Button();
            btn0 = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txttotal
            // 
            txttotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txttotal.Location = new Point(73, 47);
            txttotal.Margin = new Padding(6, 5, 6, 5);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(1005, 154);
            txttotal.TabIndex = 0;
            txttotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonShadow;
            btn1.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(73, 251);
            btn1.Margin = new Padding(6, 5, 6, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(157, 158);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.AppWorkspace;
            btn2.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(296, 251);
            btn2.Margin = new Padding(6, 5, 6, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(157, 158);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.AppWorkspace;
            btn3.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(504, 251);
            btn3.Margin = new Padding(6, 5, 6, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(157, 158);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(73, 445);
            btn4.Margin = new Padding(6, 5, 6, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(157, 158);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(296, 445);
            btn5.Margin = new Padding(6, 5, 6, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(157, 158);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(504, 445);
            btn6.Margin = new Padding(6, 5, 6, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(157, 158);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(73, 647);
            btn7.Margin = new Padding(6, 5, 6, 5);
            btn7.Name = "btn7";
            btn7.Size = new Size(157, 158);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(296, 647);
            btn8.Margin = new Padding(6, 5, 6, 5);
            btn8.Name = "btn8";
            btn8.Size = new Size(157, 158);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(504, 647);
            btn9.Margin = new Padding(6, 5, 6, 5);
            btn9.Name = "btn9";
            btn9.Size = new Size(157, 158);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.AppWorkspace;
            btnPlus.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(710, 251);
            btnPlus.Margin = new Padding(6, 5, 6, 5);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(157, 158);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(710, 445);
            btnMinus.Margin = new Padding(6, 5, 6, 5);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(157, 158);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += button11_Click;
            // 
            // btnEquual
            // 
            btnEquual.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquual.Location = new Point(710, 647);
            btnEquual.Margin = new Padding(6, 5, 6, 5);
            btnEquual.Name = "btnEquual";
            btnEquual.Size = new Size(157, 158);
            btnEquual.TabIndex = 12;
            btnEquual.Text = "=";
            btnEquual.UseVisualStyleBackColor = true;
            btnEquual.Click += btnEquual_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Coral;
            btn0.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(73, 848);
            btn0.Margin = new Padding(6, 5, 6, 5);
            btn0.Name = "btn0";
            btn0.Size = new Size(1005, 159);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = SystemColors.AppWorkspace;
            btnMul.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMul.Location = new Point(921, 251);
            btnMul.Margin = new Padding(6, 5, 6, 5);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(157, 158);
            btnMul.TabIndex = 14;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += button1_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.AppWorkspace;
            btnDiv.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(921, 445);
            btnDiv.Margin = new Padding(6, 5, 6, 5);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(157, 158);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += button2_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(921, 647);
            btnClear.Margin = new Padding(6, 5, 6, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 158);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(32F, 71F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 1039);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btn0);
            Controls.Add(btnEquual);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txttotal);
            Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnEquual;
        private Button btn0;
        private Button btnMul;
        private Button btnDiv;
        private Button btnClear;
    }
}
