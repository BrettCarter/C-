namespace CS3280Homework2
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
            this.rollDice = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.userGuess = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.played = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timesLandedOn1 = new System.Windows.Forms.Label();
            this.timesLandedOn2 = new System.Windows.Forms.Label();
            this.timesLandedOn3 = new System.Windows.Forms.Label();
            this.timesLandedOn4 = new System.Windows.Forms.Label();
            this.timesLandedOn5 = new System.Windows.Forms.Label();
            this.timesLandedOn6 = new System.Windows.Forms.Label();
            this.timesPlayerGuessed6 = new System.Windows.Forms.Label();
            this.timesPlayerGuessed5 = new System.Windows.Forms.Label();
            this.timesPlayerGuessed4 = new System.Windows.Forms.Label();
            this.timesPlayerGuessed3 = new System.Windows.Forms.Label();
            this.timesPlayerGuessed2 = new System.Windows.Forms.Label();
            this.timesPlayerGuessed1 = new System.Windows.Forms.Label();
            this.Percent6 = new System.Windows.Forms.Label();
            this.Percent5 = new System.Windows.Forms.Label();
            this.Percent4 = new System.Windows.Forms.Label();
            this.Percent3 = new System.Windows.Forms.Label();
            this.Percent2 = new System.Windows.Forms.Label();
            this.Percent1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(46, 157);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(75, 23);
            this.rollDice.TabIndex = 0;
            this.rollDice.Text = "Roll Dice";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(33, 54);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(99, 97);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // userGuess
            // 
            this.userGuess.Location = new System.Drawing.Point(65, 28);
            this.userGuess.MaxLength = 1;
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(35, 20);
            this.userGuess.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(11, 190);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(14, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What side will the dice land on?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Times Played:";
            // 
            // played
            // 
            this.played.AutoSize = true;
            this.played.Location = new System.Drawing.Point(318, 12);
            this.played.Name = "played";
            this.played.Size = new System.Drawing.Size(13, 13);
            this.played.TabIndex = 6;
            this.played.Text = "0";
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Location = new System.Drawing.Point(318, 25);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(13, 13);
            this.right.TabIndex = 18;
            this.right.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Times Right:";
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Location = new System.Drawing.Point(318, 38);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(13, 13);
            this.wrong.TabIndex = 20;
            this.wrong.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Times Wrong:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(150, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(323, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Times player guessed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(280, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Percent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(195, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Times landed on";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "1";
            // 
            // timesLandedOn1
            // 
            this.timesLandedOn1.AutoSize = true;
            this.timesLandedOn1.Location = new System.Drawing.Point(232, 103);
            this.timesLandedOn1.Name = "timesLandedOn1";
            this.timesLandedOn1.Size = new System.Drawing.Size(13, 13);
            this.timesLandedOn1.TabIndex = 35;
            this.timesLandedOn1.Text = "0";
            // 
            // timesLandedOn2
            // 
            this.timesLandedOn2.AutoSize = true;
            this.timesLandedOn2.Location = new System.Drawing.Point(232, 116);
            this.timesLandedOn2.Name = "timesLandedOn2";
            this.timesLandedOn2.Size = new System.Drawing.Size(13, 13);
            this.timesLandedOn2.TabIndex = 36;
            this.timesLandedOn2.Text = "0";
            // 
            // timesLandedOn3
            // 
            this.timesLandedOn3.AutoSize = true;
            this.timesLandedOn3.Location = new System.Drawing.Point(232, 129);
            this.timesLandedOn3.Name = "timesLandedOn3";
            this.timesLandedOn3.Size = new System.Drawing.Size(13, 13);
            this.timesLandedOn3.TabIndex = 37;
            this.timesLandedOn3.Text = "0";
            // 
            // timesLandedOn4
            // 
            this.timesLandedOn4.AutoSize = true;
            this.timesLandedOn4.Location = new System.Drawing.Point(232, 142);
            this.timesLandedOn4.Name = "timesLandedOn4";
            this.timesLandedOn4.Size = new System.Drawing.Size(13, 13);
            this.timesLandedOn4.TabIndex = 38;
            this.timesLandedOn4.Text = "0";
            // 
            // timesLandedOn5
            // 
            this.timesLandedOn5.AutoSize = true;
            this.timesLandedOn5.Location = new System.Drawing.Point(232, 155);
            this.timesLandedOn5.Name = "timesLandedOn5";
            this.timesLandedOn5.Size = new System.Drawing.Size(13, 13);
            this.timesLandedOn5.TabIndex = 39;
            this.timesLandedOn5.Text = "0";
            // 
            // timesLandedOn6
            // 
            this.timesLandedOn6.AutoSize = true;
            this.timesLandedOn6.Location = new System.Drawing.Point(232, 168);
            this.timesLandedOn6.Name = "timesLandedOn6";
            this.timesLandedOn6.Size = new System.Drawing.Size(13, 13);
            this.timesLandedOn6.TabIndex = 40;
            this.timesLandedOn6.Text = "0";
            // 
            // timesPlayerGuessed6
            // 
            this.timesPlayerGuessed6.AutoSize = true;
            this.timesPlayerGuessed6.Location = new System.Drawing.Point(373, 168);
            this.timesPlayerGuessed6.Name = "timesPlayerGuessed6";
            this.timesPlayerGuessed6.Size = new System.Drawing.Size(13, 13);
            this.timesPlayerGuessed6.TabIndex = 46;
            this.timesPlayerGuessed6.Text = "0";
            // 
            // timesPlayerGuessed5
            // 
            this.timesPlayerGuessed5.AutoSize = true;
            this.timesPlayerGuessed5.Location = new System.Drawing.Point(373, 155);
            this.timesPlayerGuessed5.Name = "timesPlayerGuessed5";
            this.timesPlayerGuessed5.Size = new System.Drawing.Size(13, 13);
            this.timesPlayerGuessed5.TabIndex = 45;
            this.timesPlayerGuessed5.Text = "0";
            // 
            // timesPlayerGuessed4
            // 
            this.timesPlayerGuessed4.AutoSize = true;
            this.timesPlayerGuessed4.Location = new System.Drawing.Point(373, 142);
            this.timesPlayerGuessed4.Name = "timesPlayerGuessed4";
            this.timesPlayerGuessed4.Size = new System.Drawing.Size(13, 13);
            this.timesPlayerGuessed4.TabIndex = 44;
            this.timesPlayerGuessed4.Text = "0";
            // 
            // timesPlayerGuessed3
            // 
            this.timesPlayerGuessed3.AutoSize = true;
            this.timesPlayerGuessed3.Location = new System.Drawing.Point(373, 129);
            this.timesPlayerGuessed3.Name = "timesPlayerGuessed3";
            this.timesPlayerGuessed3.Size = new System.Drawing.Size(13, 13);
            this.timesPlayerGuessed3.TabIndex = 43;
            this.timesPlayerGuessed3.Text = "0";
            // 
            // timesPlayerGuessed2
            // 
            this.timesPlayerGuessed2.AutoSize = true;
            this.timesPlayerGuessed2.Location = new System.Drawing.Point(373, 116);
            this.timesPlayerGuessed2.Name = "timesPlayerGuessed2";
            this.timesPlayerGuessed2.Size = new System.Drawing.Size(13, 13);
            this.timesPlayerGuessed2.TabIndex = 42;
            this.timesPlayerGuessed2.Text = "0";
            // 
            // timesPlayerGuessed1
            // 
            this.timesPlayerGuessed1.AutoSize = true;
            this.timesPlayerGuessed1.Location = new System.Drawing.Point(373, 103);
            this.timesPlayerGuessed1.Name = "timesPlayerGuessed1";
            this.timesPlayerGuessed1.Size = new System.Drawing.Size(13, 13);
            this.timesPlayerGuessed1.TabIndex = 41;
            this.timesPlayerGuessed1.Text = "0";
            // 
            // Percent6
            // 
            this.Percent6.Location = new System.Drawing.Point(286, 168);
            this.Percent6.Name = "Percent6";
            this.Percent6.Size = new System.Drawing.Size(29, 13);
            this.Percent6.TabIndex = 52;
            this.Percent6.Text = "0";
            this.Percent6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Percent5
            // 
            this.Percent5.Location = new System.Drawing.Point(286, 155);
            this.Percent5.Name = "Percent5";
            this.Percent5.Size = new System.Drawing.Size(29, 13);
            this.Percent5.TabIndex = 51;
            this.Percent5.Text = "0";
            this.Percent5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Percent4
            // 
            this.Percent4.Location = new System.Drawing.Point(286, 142);
            this.Percent4.Name = "Percent4";
            this.Percent4.Size = new System.Drawing.Size(29, 13);
            this.Percent4.TabIndex = 50;
            this.Percent4.Text = "0";
            this.Percent4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Percent3
            // 
            this.Percent3.Location = new System.Drawing.Point(286, 129);
            this.Percent3.Name = "Percent3";
            this.Percent3.Size = new System.Drawing.Size(29, 13);
            this.Percent3.TabIndex = 49;
            this.Percent3.Text = "0";
            this.Percent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Percent2
            // 
            this.Percent2.Location = new System.Drawing.Point(286, 116);
            this.Percent2.Name = "Percent2";
            this.Percent2.Size = new System.Drawing.Size(29, 13);
            this.Percent2.TabIndex = 48;
            this.Percent2.Text = "0";
            this.Percent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Percent1
            // 
            this.Percent1.Location = new System.Drawing.Point(286, 103);
            this.Percent1.Name = "Percent1";
            this.Percent1.Size = new System.Drawing.Size(29, 13);
            this.Percent1.TabIndex = 47;
            this.Percent1.Text = "0";
            this.Percent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(311, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(311, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = "%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(311, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(311, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(311, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(311, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 264);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Percent6);
            this.Controls.Add(this.Percent5);
            this.Controls.Add(this.Percent4);
            this.Controls.Add(this.Percent3);
            this.Controls.Add(this.Percent2);
            this.Controls.Add(this.Percent1);
            this.Controls.Add(this.timesPlayerGuessed6);
            this.Controls.Add(this.timesPlayerGuessed5);
            this.Controls.Add(this.timesPlayerGuessed4);
            this.Controls.Add(this.timesPlayerGuessed3);
            this.Controls.Add(this.timesPlayerGuessed2);
            this.Controls.Add(this.timesPlayerGuessed1);
            this.Controls.Add(this.timesLandedOn6);
            this.Controls.Add(this.timesLandedOn5);
            this.Controls.Add(this.timesLandedOn4);
            this.Controls.Add(this.timesLandedOn3);
            this.Controls.Add(this.timesLandedOn2);
            this.Controls.Add(this.timesLandedOn1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.right);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.played);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.userGuess);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.rollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox userGuess;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label played;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label timesLandedOn1;
        private System.Windows.Forms.Label timesLandedOn2;
        private System.Windows.Forms.Label timesLandedOn3;
        private System.Windows.Forms.Label timesLandedOn4;
        private System.Windows.Forms.Label timesLandedOn5;
        private System.Windows.Forms.Label timesLandedOn6;
        private System.Windows.Forms.Label timesPlayerGuessed6;
        private System.Windows.Forms.Label timesPlayerGuessed5;
        private System.Windows.Forms.Label timesPlayerGuessed4;
        private System.Windows.Forms.Label timesPlayerGuessed3;
        private System.Windows.Forms.Label timesPlayerGuessed2;
        private System.Windows.Forms.Label timesPlayerGuessed1;
        private System.Windows.Forms.Label Percent6;
        private System.Windows.Forms.Label Percent5;
        private System.Windows.Forms.Label Percent4;
        private System.Windows.Forms.Label Percent3;
        private System.Windows.Forms.Label Percent2;
        private System.Windows.Forms.Label Percent1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

