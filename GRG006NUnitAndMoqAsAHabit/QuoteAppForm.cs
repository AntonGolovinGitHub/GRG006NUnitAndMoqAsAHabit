using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRG006NUnitAndMoqAsAHabit
{
    public partial class QuoteAppForm : Form
    {

        private QuoteController controller;

        public QuoteAppForm()
        {
            controller = new QuoteController(this);

            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.controller.stop();
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            quoteTextBox.Text = "GRG006NUnitAndMoqAsAHabit Learning App...";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.controller.reset();
            
        }

        private void roundrobinQuote_Click(object sender, EventArgs e)
        {
            controller.roundrobin();
        }

        private void randomQuoteButton_Click(object sender, EventArgs e)
        {
            controller.random();
        }

        public ProgressBar GetProgressBar()
        {
            return this.progressBar;
        }

        public RichTextBox GetRichTextBox()
        {
            return this.quoteTextBox;
        }
    }
}
