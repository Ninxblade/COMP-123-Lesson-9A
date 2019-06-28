namespace COMP_123_Lesson_9A
{
    partial class Lesson9
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
            this.sevenButton = new System.Windows.Forms.Button();
            this.NumberButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.NumberButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sevenButton
            // 
            this.sevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sevenButton.Location = new System.Drawing.Point(49, 3);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(171, 82);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // NumberButtonTableLayoutPanel
            // 
            this.NumberButtonTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.NumberButtonTableLayoutPanel.ColumnCount = 3;
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.NumberButtonTableLayoutPanel.Controls.Add(this.zeroButton, 1, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.threeButton, 2, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.twoButton, 1, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.oneButton, 0, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.sixButton, 2, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.fiveButton, 1, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.fourButton, 0, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.nineButton, 2, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.eightButton, 1, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.sevenButton, 0, 0);
            this.NumberButtonTableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NumberButtonTableLayoutPanel.Location = new System.Drawing.Point(12, 176);
            this.NumberButtonTableLayoutPanel.Name = "NumberButtonTableLayoutPanel";
            this.NumberButtonTableLayoutPanel.RowCount = 4;
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.Size = new System.Drawing.Size(776, 355);
            this.NumberButtonTableLayoutPanel.TabIndex = 1;
            this.NumberButtonTableLayoutPanel.Click += new System.EventHandler(this.CalculatorNumber_Click);
            this.NumberButtonTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NumberButtonTableLayoutPanel_Paint);
            // 
            // eightButton
            // 
            this.eightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eightButton.Location = new System.Drawing.Point(319, 3);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(171, 82);
            this.eightButton.TabIndex = 1;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // nineButton
            // 
            this.nineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nineButton.Location = new System.Drawing.Point(572, 3);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(171, 82);
            this.nineButton.TabIndex = 2;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // fourButton
            // 
            this.fourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fourButton.Location = new System.Drawing.Point(49, 91);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(171, 82);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fiveButton.Location = new System.Drawing.Point(319, 91);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(171, 82);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // sixButton
            // 
            this.sixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sixButton.Location = new System.Drawing.Point(572, 91);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(171, 82);
            this.sixButton.TabIndex = 5;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // oneButton
            // 
            this.oneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oneButton.Location = new System.Drawing.Point(49, 179);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(171, 82);
            this.oneButton.TabIndex = 6;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // twoButton
            // 
            this.twoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.twoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.twoButton.Location = new System.Drawing.Point(319, 179);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(171, 82);
            this.twoButton.TabIndex = 7;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // threeButton
            // 
            this.threeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.threeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.threeButton.Location = new System.Drawing.Point(572, 179);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(171, 82);
            this.threeButton.TabIndex = 8;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.zeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zeroButton.Location = new System.Drawing.Point(319, 267);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(171, 85);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.White;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 24);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(766, 140);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Lesson9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 530);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.NumberButtonTableLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Lesson9";
            this.Text = "Lesson 9";
            this.Load += new System.EventHandler(this.Lesson9_Load);
            this.NumberButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.TableLayoutPanel NumberButtonTableLayoutPanel;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

