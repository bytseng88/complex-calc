namespace Complex_Calculator
{
    partial class CalcForm
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.numALabel = new System.Windows.Forms.Label();
            this.numARealTBox = new System.Windows.Forms.TextBox();
            this.plusLabel1 = new System.Windows.Forms.Label();
            this.numAImgTBox = new System.Windows.Forms.TextBox();
            this.iLabel1 = new System.Windows.Forms.Label();
            this.iLabel2 = new System.Windows.Forms.Label();
            this.numBImgTBox = new System.Windows.Forms.TextBox();
            this.plusLabel2 = new System.Windows.Forms.Label();
            this.numBRealTBox = new System.Windows.Forms.TextBox();
            this.numBLabel = new System.Windows.Forms.Label();
            this.operatorPanel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.memBBtn = new System.Windows.Forms.Button();
            this.memABtn = new System.Windows.Forms.Button();
            this.invBtn = new System.Windows.Forms.Button();
            this.negBtn = new System.Windows.Forms.Button();
            this.absBtn = new System.Windows.Forms.Button();
            this.conjBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.inputPanel.SuspendLayout();
            this.operatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(36, 29);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(523, 63);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.iLabel2);
            this.inputPanel.Controls.Add(this.numBImgTBox);
            this.inputPanel.Controls.Add(this.plusLabel2);
            this.inputPanel.Controls.Add(this.numBRealTBox);
            this.inputPanel.Controls.Add(this.numBLabel);
            this.inputPanel.Controls.Add(this.iLabel1);
            this.inputPanel.Controls.Add(this.numAImgTBox);
            this.inputPanel.Controls.Add(this.plusLabel1);
            this.inputPanel.Controls.Add(this.numARealTBox);
            this.inputPanel.Controls.Add(this.numALabel);
            this.inputPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPanel.Location = new System.Drawing.Point(36, 124);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(523, 115);
            this.inputPanel.TabIndex = 1;
            // 
            // numALabel
            // 
            this.numALabel.AutoSize = true;
            this.numALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numALabel.Location = new System.Drawing.Point(31, 20);
            this.numALabel.Name = "numALabel";
            this.numALabel.Size = new System.Drawing.Size(46, 25);
            this.numALabel.TabIndex = 0;
            this.numALabel.Text = "A =";
            // 
            // numARealTBox
            // 
            this.numARealTBox.Location = new System.Drawing.Point(92, 17);
            this.numARealTBox.Name = "numARealTBox";
            this.numARealTBox.Size = new System.Drawing.Size(172, 30);
            this.numARealTBox.TabIndex = 1;
            // 
            // plusLabel1
            // 
            this.plusLabel1.AutoSize = true;
            this.plusLabel1.Location = new System.Drawing.Point(270, 20);
            this.plusLabel1.Name = "plusLabel1";
            this.plusLabel1.Size = new System.Drawing.Size(24, 25);
            this.plusLabel1.TabIndex = 2;
            this.plusLabel1.Text = "+";
            // 
            // numAImgTBox
            // 
            this.numAImgTBox.Location = new System.Drawing.Point(300, 17);
            this.numAImgTBox.Name = "numAImgTBox";
            this.numAImgTBox.Size = new System.Drawing.Size(172, 30);
            this.numAImgTBox.TabIndex = 3;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLabel1.Location = new System.Drawing.Point(478, 20);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(17, 25);
            this.iLabel1.TabIndex = 4;
            this.iLabel1.Text = "i";
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLabel2.Location = new System.Drawing.Point(478, 65);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(17, 25);
            this.iLabel2.TabIndex = 9;
            this.iLabel2.Text = "i";
            // 
            // numBImgTBox
            // 
            this.numBImgTBox.Location = new System.Drawing.Point(300, 62);
            this.numBImgTBox.Name = "numBImgTBox";
            this.numBImgTBox.Size = new System.Drawing.Size(172, 30);
            this.numBImgTBox.TabIndex = 8;
            // 
            // plusLabel2
            // 
            this.plusLabel2.AutoSize = true;
            this.plusLabel2.Location = new System.Drawing.Point(270, 65);
            this.plusLabel2.Name = "plusLabel2";
            this.plusLabel2.Size = new System.Drawing.Size(24, 25);
            this.plusLabel2.TabIndex = 7;
            this.plusLabel2.Text = "+";
            // 
            // numBRealTBox
            // 
            this.numBRealTBox.Location = new System.Drawing.Point(92, 62);
            this.numBRealTBox.Name = "numBRealTBox";
            this.numBRealTBox.Size = new System.Drawing.Size(172, 30);
            this.numBRealTBox.TabIndex = 6;
            // 
            // numBLabel
            // 
            this.numBLabel.AutoSize = true;
            this.numBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBLabel.Location = new System.Drawing.Point(31, 65);
            this.numBLabel.Name = "numBLabel";
            this.numBLabel.Size = new System.Drawing.Size(45, 25);
            this.numBLabel.TabIndex = 5;
            this.numBLabel.Text = "B =";
            // 
            // operatorPanel
            // 
            this.operatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operatorPanel.Controls.Add(this.clearBtn);
            this.operatorPanel.Controls.Add(this.absBtn);
            this.operatorPanel.Controls.Add(this.conjBtn);
            this.operatorPanel.Controls.Add(this.memBBtn);
            this.operatorPanel.Controls.Add(this.memABtn);
            this.operatorPanel.Controls.Add(this.invBtn);
            this.operatorPanel.Controls.Add(this.negBtn);
            this.operatorPanel.Controls.Add(this.divBtn);
            this.operatorPanel.Controls.Add(this.multBtn);
            this.operatorPanel.Controls.Add(this.subBtn);
            this.operatorPanel.Controls.Add(this.addBtn);
            this.operatorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorPanel.Location = new System.Drawing.Point(36, 266);
            this.operatorPanel.Name = "operatorPanel";
            this.operatorPanel.Size = new System.Drawing.Size(522, 221);
            this.operatorPanel.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(22, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 55);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "A + B";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(149, 12);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(101, 55);
            this.subBtn.TabIndex = 1;
            this.subBtn.Text = "A - B";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(407, 12);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(101, 55);
            this.divBtn.TabIndex = 3;
            this.divBtn.Text = "A / B";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.Location = new System.Drawing.Point(275, 12);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(101, 55);
            this.multBtn.TabIndex = 2;
            this.multBtn.Text = "A * B";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // memBBtn
            // 
            this.memBBtn.Location = new System.Drawing.Point(407, 82);
            this.memBBtn.Name = "memBBtn";
            this.memBBtn.Size = new System.Drawing.Size(101, 55);
            this.memBBtn.TabIndex = 7;
            this.memBBtn.Text = "Mem B";
            this.memBBtn.UseVisualStyleBackColor = true;
            this.memBBtn.Click += new System.EventHandler(this.memBBtn_Click);
            // 
            // memABtn
            // 
            this.memABtn.Location = new System.Drawing.Point(275, 82);
            this.memABtn.Name = "memABtn";
            this.memABtn.Size = new System.Drawing.Size(101, 55);
            this.memABtn.TabIndex = 6;
            this.memABtn.Text = "Mem A";
            this.memABtn.UseVisualStyleBackColor = true;
            this.memABtn.Click += new System.EventHandler(this.memABtn_Click);
            // 
            // invBtn
            // 
            this.invBtn.Location = new System.Drawing.Point(149, 82);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(101, 55);
            this.invBtn.TabIndex = 5;
            this.invBtn.Text = "Inv(A)";
            this.invBtn.UseVisualStyleBackColor = true;
            this.invBtn.Click += new System.EventHandler(this.invBtn_Click);
            // 
            // negBtn
            // 
            this.negBtn.Location = new System.Drawing.Point(22, 82);
            this.negBtn.Name = "negBtn";
            this.negBtn.Size = new System.Drawing.Size(101, 55);
            this.negBtn.TabIndex = 4;
            this.negBtn.Text = "-A";
            this.negBtn.UseVisualStyleBackColor = true;
            this.negBtn.Click += new System.EventHandler(this.negBtn_Click);
            // 
            // absBtn
            // 
            this.absBtn.Location = new System.Drawing.Point(149, 152);
            this.absBtn.Name = "absBtn";
            this.absBtn.Size = new System.Drawing.Size(101, 55);
            this.absBtn.TabIndex = 9;
            this.absBtn.Text = "|A|";
            this.absBtn.UseVisualStyleBackColor = true;
            this.absBtn.Click += new System.EventHandler(this.absBtn_Click);
            // 
            // conjBtn
            // 
            this.conjBtn.Location = new System.Drawing.Point(22, 152);
            this.conjBtn.Name = "conjBtn";
            this.conjBtn.Size = new System.Drawing.Size(101, 55);
            this.conjBtn.TabIndex = 8;
            this.conjBtn.Text = "Con(A)";
            this.conjBtn.UseVisualStyleBackColor = true;
            this.conjBtn.Click += new System.EventHandler(this.conjBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(278, 155);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(229, 51);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 499);
            this.Controls.Add(this.operatorPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.resultLabel);
            this.Name = "CalcForm";
            this.Text = "Complex Number Calculator";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.operatorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label iLabel1;
        private System.Windows.Forms.TextBox numAImgTBox;
        private System.Windows.Forms.Label plusLabel1;
        private System.Windows.Forms.TextBox numARealTBox;
        private System.Windows.Forms.Label numALabel;
        private System.Windows.Forms.Label iLabel2;
        private System.Windows.Forms.TextBox numBImgTBox;
        private System.Windows.Forms.Label plusLabel2;
        private System.Windows.Forms.TextBox numBRealTBox;
        private System.Windows.Forms.Label numBLabel;
        private System.Windows.Forms.Panel operatorPanel;
        private System.Windows.Forms.Button memBBtn;
        private System.Windows.Forms.Button memABtn;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button negBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button absBtn;
        private System.Windows.Forms.Button conjBtn;
    }
}

