using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string folderPath = this.txtFolderPath.Text;

      MyLibrary.Initialize(folderPath);
    }

    private void cmdWords_Click(object sender, EventArgs e)
    {
      this.lstWords.Items.Clear();
      this.lstWords.Refresh();

      string letters = this.txtLetters.Text;
        
      var words = MyLibrary.possibleWords(letters);

      this.txtNumWords.Text = words.Count().ToString();

      foreach (string word in words)
      {
        this.lstWords.Items.Add(word);
      }
    }

    private void cmdScores_Click(object sender, EventArgs e)
    {
      this.lstScores.Items.Clear();
      this.lstScores.Refresh();

      string letters = this.txtLetters.Text;

      var pairs = MyLibrary.wordsWithScores(letters);

      foreach (var pair in pairs)
      {
        string msg = string.Format("{0}: {1}", pair.Item1, pair.Item2);
        this.lstScores.Items.Add(msg);
      }
    }

    private void cmdPattern_Click(object sender, EventArgs e)
    {
      this.lstWords2.Items.Clear();
      this.lstWords2.Refresh();

      string letters = this.txtLetters.Text;
      string pattern = this.txtPattern.Text;

      var pairs = MyLibrary.wordsThatFitPattern(letters, pattern);

      foreach (var pair in pairs)
      {
        string msg = string.Format("{0}: {1}", pair.Item1, pair.Item2);
        this.lstWords2.Items.Add(msg);
      }
    }

    private void txtLetters_TextChanged(object sender, EventArgs e)
    {
      //
      // clear the UI if the letters change, since results display
      // become invalid:
      //
      this.lstWords.Items.Clear();
      this.lstWords.Refresh();

      this.lstScores.Items.Clear();
      this.lstScores.Refresh();

      this.lstWords2.Items.Clear();
      this.lstWords2.Refresh();

      txtNumWords.Text = "0";

      if (this.txtLetters.Text.Length == 0)
      {
        this.cmdWords.Enabled = false;
        this.cmdScores.Enabled = false;
        this.cmdPattern.Enabled = false;
      }
      else
      {
        this.cmdWords.Enabled = true;
        this.cmdScores.Enabled = true;
        this.cmdPattern.Enabled = true;
      }
    }

  }
}
