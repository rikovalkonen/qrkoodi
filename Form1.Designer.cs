namespace Backend
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.tpaitaButton = new System.Windows.Forms.RadioButton();
            this.huppariButton = new System.Windows.Forms.RadioButton();
            this.kengatButton = new System.Windows.Forms.RadioButton();
            this.housutButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrtshirtbutton = new System.Windows.Forms.RadioButton();
            this.qrhoodiebutton = new System.Windows.Forms.RadioButton();
            this.qrshoesbutton = new System.Windows.Forms.RadioButton();
            this.qrpantsbutton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generate product codes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create codes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(80, 366);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(100, 20);
            this.amountbox.TabIndex = 3;
            this.amountbox.TextChanged += new System.EventHandler(this.amountbox_TextChanged);
            // 
            // tpaitaButton
            // 
            this.tpaitaButton.AutoSize = true;
            this.tpaitaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpaitaButton.Location = new System.Drawing.Point(95, 240);
            this.tpaitaButton.Name = "tpaitaButton";
            this.tpaitaButton.Size = new System.Drawing.Size(61, 19);
            this.tpaitaButton.TabIndex = 4;
            this.tpaitaButton.TabStop = true;
            this.tpaitaButton.Text = "T-Shirt";
            this.tpaitaButton.UseVisualStyleBackColor = true;
            // 
            // huppariButton
            // 
            this.huppariButton.AutoSize = true;
            this.huppariButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huppariButton.Location = new System.Drawing.Point(95, 264);
            this.huppariButton.Name = "huppariButton";
            this.huppariButton.Size = new System.Drawing.Size(65, 19);
            this.huppariButton.TabIndex = 5;
            this.huppariButton.TabStop = true;
            this.huppariButton.Text = "Hoodie";
            this.huppariButton.UseVisualStyleBackColor = true;
            // 
            // kengatButton
            // 
            this.kengatButton.AutoSize = true;
            this.kengatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kengatButton.Location = new System.Drawing.Point(95, 288);
            this.kengatButton.Name = "kengatButton";
            this.kengatButton.Size = new System.Drawing.Size(60, 19);
            this.kengatButton.TabIndex = 6;
            this.kengatButton.TabStop = true;
            this.kengatButton.Text = "Shoes";
            this.kengatButton.UseVisualStyleBackColor = true;
            // 
            // housutButton
            // 
            this.housutButton.AutoSize = true;
            this.housutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housutButton.Location = new System.Drawing.Point(95, 312);
            this.housutButton.Name = "housutButton";
            this.housutButton.Size = new System.Drawing.Size(56, 19);
            this.housutButton.TabIndex = 7;
            this.housutButton.TabStop = true;
            this.housutButton.Text = "Pants";
            this.housutButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Test configuration";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(218, 655);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Progress level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Generate QR-Codes";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(584, 378);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter the date.  yyyy/mm/dd ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Create QR-Codes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Date:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generatorToolStripMenuItem
            // 
            this.generatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.generatorToolStripMenuItem.Name = "generatorToolStripMenuItem";
            this.generatorToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.generatorToolStripMenuItem.Text = "Generator";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // qrtshirtbutton
            // 
            this.qrtshirtbutton.AutoSize = true;
            this.qrtshirtbutton.Location = new System.Drawing.Point(584, 265);
            this.qrtshirtbutton.Name = "qrtshirtbutton";
            this.qrtshirtbutton.Size = new System.Drawing.Size(56, 17);
            this.qrtshirtbutton.TabIndex = 21;
            this.qrtshirtbutton.TabStop = true;
            this.qrtshirtbutton.Text = "T-Shirt";
            this.qrtshirtbutton.UseVisualStyleBackColor = true;
            // 
            // qrhoodiebutton
            // 
            this.qrhoodiebutton.AutoSize = true;
            this.qrhoodiebutton.Location = new System.Drawing.Point(584, 288);
            this.qrhoodiebutton.Name = "qrhoodiebutton";
            this.qrhoodiebutton.Size = new System.Drawing.Size(59, 17);
            this.qrhoodiebutton.TabIndex = 22;
            this.qrhoodiebutton.TabStop = true;
            this.qrhoodiebutton.Text = "Hoodie";
            this.qrhoodiebutton.UseVisualStyleBackColor = true;
            // 
            // qrshoesbutton
            // 
            this.qrshoesbutton.AutoSize = true;
            this.qrshoesbutton.Location = new System.Drawing.Point(584, 311);
            this.qrshoesbutton.Name = "qrshoesbutton";
            this.qrshoesbutton.Size = new System.Drawing.Size(55, 17);
            this.qrshoesbutton.TabIndex = 24;
            this.qrshoesbutton.TabStop = true;
            this.qrshoesbutton.Text = "Shoes";
            this.qrshoesbutton.UseVisualStyleBackColor = true;
            // 
            // qrpantsbutton
            // 
            this.qrpantsbutton.AutoSize = true;
            this.qrpantsbutton.Location = new System.Drawing.Point(584, 334);
            this.qrpantsbutton.Name = "qrpantsbutton";
            this.qrpantsbutton.Size = new System.Drawing.Size(52, 17);
            this.qrpantsbutton.TabIndex = 25;
            this.qrpantsbutton.TabStop = true;
            this.qrpantsbutton.Text = "Pants";
            this.qrpantsbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 724);
            this.Controls.Add(this.qrpantsbutton);
            this.Controls.Add(this.qrshoesbutton);
            this.Controls.Add(this.qrhoodiebutton);
            this.Controls.Add(this.qrtshirtbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.housutButton);
            this.Controls.Add(this.kengatButton);
            this.Controls.Add(this.huppariButton);
            this.Controls.Add(this.tpaitaButton);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "QR generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.RadioButton tpaitaButton;
        private System.Windows.Forms.RadioButton huppariButton;
        private System.Windows.Forms.RadioButton kengatButton;
        private System.Windows.Forms.RadioButton housutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton qrtshirtbutton;
        private System.Windows.Forms.RadioButton qrhoodiebutton;
        private System.Windows.Forms.RadioButton qrshoesbutton;
        private System.Windows.Forms.RadioButton qrpantsbutton;
    }
}

