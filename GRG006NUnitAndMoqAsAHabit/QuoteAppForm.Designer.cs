namespace GRG006NUnitAndMoqAsAHabit
{
    partial class QuoteAppForm
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
            this.randomQuoteButton = new System.Windows.Forms.Button();
            this.roundrobinQuote = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.quoteTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // randomQuoteButton
            // 
            this.randomQuoteButton.Location = new System.Drawing.Point(647, 12);
            this.randomQuoteButton.Name = "randomQuoteButton";
            this.randomQuoteButton.Size = new System.Drawing.Size(141, 38);
            this.randomQuoteButton.TabIndex = 0;
            this.randomQuoteButton.Text = "Show Random Quote";
            this.randomQuoteButton.UseVisualStyleBackColor = true;
            this.randomQuoteButton.Click += new System.EventHandler(this.randomQuoteButton_Click);
            // 
            // roundrobinQuote
            // 
            this.roundrobinQuote.Location = new System.Drawing.Point(647, 56);
            this.roundrobinQuote.Name = "roundrobinQuote";
            this.roundrobinQuote.Size = new System.Drawing.Size(141, 38);
            this.roundrobinQuote.TabIndex = 1;
            this.roundrobinQuote.Text = "Show RoundRobin Quote";
            this.roundrobinQuote.UseVisualStyleBackColor = true;
            this.roundrobinQuote.Click += new System.EventHandler(this.roundrobinQuote_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(647, 100);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(141, 38);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset Quotes";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(647, 309);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(141, 38);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About Button";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(647, 353);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 38);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit App";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 5;
            // 
            // quoteTextBox
            // 
            this.quoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTextBox.Location = new System.Drawing.Point(12, 12);
            this.quoteTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.quoteTextBox.Name = "quoteTextBox";
            this.quoteTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.quoteTextBox.Size = new System.Drawing.Size(629, 379);
            this.quoteTextBox.TabIndex = 6;
            this.quoteTextBox.Text = "Check me out -->";
            // 
            // QuoteAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quoteTextBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.roundrobinQuote);
            this.Controls.Add(this.randomQuoteButton);
            this.Name = "QuoteAppForm";
            this.Text = "GRG006NUnitAndMoqAsAHabit (Not an Afterthought) App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomQuoteButton;
        private System.Windows.Forms.Button roundrobinQuote;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox quoteTextBox;
    }
}

