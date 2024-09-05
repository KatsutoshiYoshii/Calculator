namespace FrmCalculator
{
    partial class FrmCalculator
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
            groupBox1 = new GroupBox();
            bEqual = new Button();
            bPlus = new Button();
            bMinus = new Button();
            bMultiply = new Button();
            bDivision = new Button();
            bClear = new Button();
            bDecimalPoint = new Button();
            bZero = new Button();
            bSign = new Button();
            bNine = new Button();
            bEight = new Button();
            bSeven = new Button();
            bSix = new Button();
            bFive = new Button();
            bFour = new Button();
            bThree = new Button();
            bTwo = new Button();
            bOne = new Button();
            groupBox2 = new GroupBox();
            lblDisplay = new Label();
            txtLog = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDisplay);
            groupBox1.Controls.Add(bEqual);
            groupBox1.Controls.Add(bPlus);
            groupBox1.Controls.Add(bMinus);
            groupBox1.Controls.Add(bMultiply);
            groupBox1.Controls.Add(bDivision);
            groupBox1.Controls.Add(bClear);
            groupBox1.Controls.Add(bDecimalPoint);
            groupBox1.Controls.Add(bZero);
            groupBox1.Controls.Add(bSign);
            groupBox1.Controls.Add(bNine);
            groupBox1.Controls.Add(bEight);
            groupBox1.Controls.Add(bSeven);
            groupBox1.Controls.Add(bSix);
            groupBox1.Controls.Add(bFive);
            groupBox1.Controls.Add(bFour);
            groupBox1.Controls.Add(bThree);
            groupBox1.Controls.Add(bTwo);
            groupBox1.Controls.Add(bOne);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 389);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "電卓";
            // 
            // bEqual
            // 
            bEqual.BackColor = SystemColors.MenuHighlight;
            bEqual.FlatStyle = FlatStyle.Popup;
            bEqual.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bEqual.Location = new Point(296, 333);
            bEqual.Name = "bEqual";
            bEqual.Size = new Size(88, 49);
            bEqual.TabIndex = 19;
            bEqual.Text = "=";
            bEqual.UseVisualStyleBackColor = false;
            bEqual.Click += bEqual_Click;
            // 
            // bPlus
            // 
            bPlus.FlatStyle = FlatStyle.Popup;
            bPlus.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bPlus.Location = new Point(296, 278);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(88, 49);
            bPlus.TabIndex = 18;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = true;
            bPlus.Click += bPlus_Click;
            // 
            // bMinus
            // 
            bMinus.FlatStyle = FlatStyle.Popup;
            bMinus.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bMinus.Location = new Point(296, 223);
            bMinus.Name = "bMinus";
            bMinus.Size = new Size(88, 49);
            bMinus.TabIndex = 17;
            bMinus.Text = "-";
            bMinus.UseVisualStyleBackColor = true;
            bMinus.Click += bMinus_Click;
            // 
            // bMultiply
            // 
            bMultiply.FlatStyle = FlatStyle.Popup;
            bMultiply.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bMultiply.Location = new Point(296, 168);
            bMultiply.Name = "bMultiply";
            bMultiply.Size = new Size(88, 49);
            bMultiply.TabIndex = 16;
            bMultiply.Text = "×";
            bMultiply.UseVisualStyleBackColor = true;
            bMultiply.Click += bMultiply_Click;
            // 
            // bDivision
            // 
            bDivision.FlatStyle = FlatStyle.Popup;
            bDivision.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bDivision.Location = new Point(296, 113);
            bDivision.Name = "bDivision";
            bDivision.Size = new Size(88, 49);
            bDivision.TabIndex = 15;
            bDivision.Text = "÷";
            bDivision.UseVisualStyleBackColor = true;
            bDivision.Click += bDivision_Click;
            // 
            // bClear
            // 
            bClear.FlatStyle = FlatStyle.Popup;
            bClear.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bClear.Location = new Point(14, 113);
            bClear.Name = "bClear";
            bClear.Size = new Size(88, 49);
            bClear.TabIndex = 13;
            bClear.Text = "C";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bDecimalPoint
            // 
            bDecimalPoint.FlatStyle = FlatStyle.Popup;
            bDecimalPoint.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bDecimalPoint.Location = new Point(202, 333);
            bDecimalPoint.Name = "bDecimalPoint";
            bDecimalPoint.Size = new Size(88, 49);
            bDecimalPoint.TabIndex = 11;
            bDecimalPoint.Text = ".";
            bDecimalPoint.UseVisualStyleBackColor = true;
            bDecimalPoint.Click += bDecimalPoint_Click;
            // 
            // bZero
            // 
            bZero.FlatStyle = FlatStyle.Popup;
            bZero.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bZero.Location = new Point(108, 333);
            bZero.Name = "bZero";
            bZero.Size = new Size(88, 49);
            bZero.TabIndex = 10;
            bZero.Text = "0";
            bZero.UseVisualStyleBackColor = true;
            bZero.Click += bZero_Click;
            // 
            // bSign
            // 
            bSign.FlatStyle = FlatStyle.Popup;
            bSign.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bSign.Location = new Point(14, 333);
            bSign.Name = "bSign";
            bSign.Size = new Size(88, 49);
            bSign.TabIndex = 9;
            bSign.Text = "+/-";
            bSign.UseVisualStyleBackColor = true;
            bSign.Click += bSign_Click;
            // 
            // bNine
            // 
            bNine.FlatStyle = FlatStyle.Popup;
            bNine.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bNine.Location = new Point(202, 168);
            bNine.Name = "bNine";
            bNine.Size = new Size(88, 49);
            bNine.TabIndex = 8;
            bNine.Text = "9";
            bNine.UseVisualStyleBackColor = true;
            bNine.Click += bNine_Click;
            // 
            // bEight
            // 
            bEight.FlatStyle = FlatStyle.Popup;
            bEight.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bEight.Location = new Point(108, 168);
            bEight.Name = "bEight";
            bEight.Size = new Size(88, 49);
            bEight.TabIndex = 7;
            bEight.Text = "8";
            bEight.UseVisualStyleBackColor = true;
            bEight.Click += bEight_Click;
            // 
            // bSeven
            // 
            bSeven.FlatStyle = FlatStyle.Popup;
            bSeven.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bSeven.Location = new Point(14, 168);
            bSeven.Name = "bSeven";
            bSeven.Size = new Size(88, 49);
            bSeven.TabIndex = 6;
            bSeven.Text = "7";
            bSeven.UseVisualStyleBackColor = true;
            bSeven.Click += bSeven_Click;
            // 
            // bSix
            // 
            bSix.FlatStyle = FlatStyle.Popup;
            bSix.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bSix.Location = new Point(202, 223);
            bSix.Name = "bSix";
            bSix.Size = new Size(88, 49);
            bSix.TabIndex = 5;
            bSix.Text = "6";
            bSix.UseVisualStyleBackColor = true;
            bSix.Click += bSix_Click;
            // 
            // bFive
            // 
            bFive.FlatStyle = FlatStyle.Popup;
            bFive.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bFive.Location = new Point(108, 223);
            bFive.Name = "bFive";
            bFive.Size = new Size(88, 49);
            bFive.TabIndex = 4;
            bFive.Text = "5";
            bFive.UseVisualStyleBackColor = true;
            bFive.Click += bFive_Click;
            // 
            // bFour
            // 
            bFour.FlatStyle = FlatStyle.Popup;
            bFour.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bFour.Location = new Point(14, 223);
            bFour.Name = "bFour";
            bFour.Size = new Size(88, 49);
            bFour.TabIndex = 3;
            bFour.Text = "4";
            bFour.UseVisualStyleBackColor = true;
            bFour.Click += bFour_Click;
            // 
            // bThree
            // 
            bThree.FlatStyle = FlatStyle.Popup;
            bThree.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bThree.Location = new Point(202, 278);
            bThree.Name = "bThree";
            bThree.Size = new Size(88, 49);
            bThree.TabIndex = 2;
            bThree.Text = "3";
            bThree.UseVisualStyleBackColor = true;
            bThree.Click += bThree_Click;
            // 
            // bTwo
            // 
            bTwo.FlatStyle = FlatStyle.Popup;
            bTwo.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bTwo.Location = new Point(108, 278);
            bTwo.Name = "bTwo";
            bTwo.Size = new Size(88, 49);
            bTwo.TabIndex = 1;
            bTwo.Text = "2";
            bTwo.UseVisualStyleBackColor = true;
            bTwo.Click += bTwo_Click;
            // 
            // bOne
            // 
            bOne.FlatStyle = FlatStyle.Popup;
            bOne.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            bOne.Location = new Point(14, 278);
            bOne.Name = "bOne";
            bOne.Size = new Size(88, 49);
            bOne.TabIndex = 0;
            bOne.Text = "1";
            bOne.UseVisualStyleBackColor = true;
            bOne.Click += bOne_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLog);
            groupBox2.Location = new Point(413, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 389);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "履歴";
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDisplay.Location = new Point(25, 53);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(37, 40);
            lblDisplay.TabIndex = 20;
            lblDisplay.Text = "=";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(6, 22);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(281, 363);
            txtLog.TabIndex = 0;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 409);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCalculator";
            Text = "電卓";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button bOne;
        private GroupBox groupBox2;
        private Button bEqual;
        private Button bPlus;
        private Button bMinus;
        private Button bMultiply;
        private Button bDivision;
        private Button bClear;
        private Button bDecimalPoint;
        private Button bZero;
        private Button bSign;
        private Button bNine;
        private Button bEight;
        private Button bSeven;
        private Button bSix;
        private Button bFive;
        private Button bFour;
        private Button bThree;
        private Button bTwo;
        private Label lblDisplay;
        private TextBox txtLog;
    }
}
