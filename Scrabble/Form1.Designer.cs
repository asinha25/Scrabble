namespace Scrabble
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lstWords = new System.Windows.Forms.ListBox();
      this.txtFolderPath = new System.Windows.Forms.TextBox();
      this.cmdWords = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.lblLetters = new System.Windows.Forms.Label();
      this.txtLetters = new System.Windows.Forms.TextBox();
      this.cmdScores = new System.Windows.Forms.Button();
      this.lstScores = new System.Windows.Forms.ListBox();
      this.txtPattern = new System.Windows.Forms.TextBox();
      this.lblPattern = new System.Windows.Forms.Label();
      this.lstWords2 = new System.Windows.Forms.ListBox();
      this.cmdPattern = new System.Windows.Forms.Button();
      this.txtNumWords = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lstWords
      // 
      this.lstWords.FormattingEnabled = true;
      this.lstWords.ItemHeight = 25;
      this.lstWords.Location = new System.Drawing.Point(39, 122);
      this.lstWords.Name = "lstWords";
      this.lstWords.Size = new System.Drawing.Size(212, 379);
      this.lstWords.TabIndex = 0;
      // 
      // txtFolderPath
      // 
      this.txtFolderPath.BackColor = System.Drawing.Color.Aqua;
      this.txtFolderPath.Location = new System.Drawing.Point(301, 517);
      this.txtFolderPath.Name = "txtFolderPath";
      this.txtFolderPath.Size = new System.Drawing.Size(534, 30);
      this.txtFolderPath.TabIndex = 2;
      this.txtFolderPath.Text = "..\\..\\..\\Dictionary";
      // 
      // cmdWords
      // 
      this.cmdWords.BackColor = System.Drawing.Color.Yellow;
      this.cmdWords.Location = new System.Drawing.Point(39, 76);
      this.cmdWords.Name = "cmdWords";
      this.cmdWords.Size = new System.Drawing.Size(212, 35);
      this.cmdWords.TabIndex = 11;
      this.cmdWords.Text = "Possible Words";
      this.cmdWords.UseVisualStyleBackColor = false;
      this.cmdWords.Click += new System.EventHandler(this.cmdWords_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(726, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(132, 122);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 13;
      this.pictureBox1.TabStop = false;
      // 
      // lblLetters
      // 
      this.lblLetters.AutoSize = true;
      this.lblLetters.Location = new System.Drawing.Point(12, 18);
      this.lblLetters.Name = "lblLetters";
      this.lblLetters.Size = new System.Drawing.Size(77, 25);
      this.lblLetters.TabIndex = 14;
      this.lblLetters.Text = "Letters:";
      // 
      // txtLetters
      // 
      this.txtLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLetters.Location = new System.Drawing.Point(91, 12);
      this.txtLetters.Name = "txtLetters";
      this.txtLetters.Size = new System.Drawing.Size(190, 34);
      this.txtLetters.TabIndex = 15;
      this.txtLetters.Text = "tca";
      this.txtLetters.TextChanged += new System.EventHandler(this.txtLetters_TextChanged);
      // 
      // cmdScores
      // 
      this.cmdScores.BackColor = System.Drawing.Color.Yellow;
      this.cmdScores.Location = new System.Drawing.Point(301, 76);
      this.cmdScores.Name = "cmdScores";
      this.cmdScores.Size = new System.Drawing.Size(212, 35);
      this.cmdScores.TabIndex = 16;
      this.cmdScores.Text = "Words + Scores";
      this.cmdScores.UseVisualStyleBackColor = false;
      this.cmdScores.Click += new System.EventHandler(this.cmdScores_Click);
      // 
      // lstScores
      // 
      this.lstScores.FormattingEnabled = true;
      this.lstScores.ItemHeight = 25;
      this.lstScores.Location = new System.Drawing.Point(301, 122);
      this.lstScores.Name = "lstScores";
      this.lstScores.Size = new System.Drawing.Size(212, 379);
      this.lstScores.TabIndex = 17;
      // 
      // txtPattern
      // 
      this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPattern.Location = new System.Drawing.Point(645, 164);
      this.txtPattern.Name = "txtPattern";
      this.txtPattern.Size = new System.Drawing.Size(190, 34);
      this.txtPattern.TabIndex = 19;
      this.txtPattern.Text = "e**h";
      // 
      // lblPattern
      // 
      this.lblPattern.AutoSize = true;
      this.lblPattern.Location = new System.Drawing.Point(562, 170);
      this.lblPattern.Name = "lblPattern";
      this.lblPattern.Size = new System.Drawing.Size(80, 25);
      this.lblPattern.TabIndex = 18;
      this.lblPattern.Text = "Pattern:";
      // 
      // lstWords2
      // 
      this.lstWords2.FormattingEnabled = true;
      this.lstWords2.ItemHeight = 25;
      this.lstWords2.Location = new System.Drawing.Point(567, 272);
      this.lstWords2.Name = "lstWords2";
      this.lstWords2.Size = new System.Drawing.Size(268, 229);
      this.lstWords2.TabIndex = 20;
      // 
      // cmdPattern
      // 
      this.cmdPattern.BackColor = System.Drawing.Color.Yellow;
      this.cmdPattern.Location = new System.Drawing.Point(567, 225);
      this.cmdPattern.Name = "cmdPattern";
      this.cmdPattern.Size = new System.Drawing.Size(268, 35);
      this.cmdPattern.TabIndex = 21;
      this.cmdPattern.Text = "Words that fit Pattern";
      this.cmdPattern.UseVisualStyleBackColor = false;
      this.cmdPattern.Click += new System.EventHandler(this.cmdPattern_Click);
      // 
      // txtNumWords
      // 
      this.txtNumWords.BackColor = System.Drawing.Color.Aqua;
      this.txtNumWords.Location = new System.Drawing.Point(39, 517);
      this.txtNumWords.Name = "txtNumWords";
      this.txtNumWords.Size = new System.Drawing.Size(212, 30);
      this.txtNumWords.TabIndex = 22;
      this.txtNumWords.Text = "0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Aqua;
      this.ClientSize = new System.Drawing.Size(870, 565);
      this.Controls.Add(this.txtNumWords);
      this.Controls.Add(this.cmdPattern);
      this.Controls.Add(this.lstWords2);
      this.Controls.Add(this.txtPattern);
      this.Controls.Add(this.lblPattern);
      this.Controls.Add(this.lstScores);
      this.Controls.Add(this.cmdScores);
      this.Controls.Add(this.txtLetters);
      this.Controls.Add(this.lblLetters);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.cmdWords);
      this.Controls.Add(this.txtFolderPath);
      this.Controls.Add(this.lstWords);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Scrabble";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstWords;
    private System.Windows.Forms.TextBox txtFolderPath;
    private System.Windows.Forms.Button cmdWords;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblLetters;
    private System.Windows.Forms.TextBox txtLetters;
    private System.Windows.Forms.Button cmdScores;
    private System.Windows.Forms.ListBox lstScores;
    private System.Windows.Forms.TextBox txtPattern;
    private System.Windows.Forms.Label lblPattern;
    private System.Windows.Forms.ListBox lstWords2;
    private System.Windows.Forms.Button cmdPattern;
    private System.Windows.Forms.TextBox txtNumWords;
  }
}

