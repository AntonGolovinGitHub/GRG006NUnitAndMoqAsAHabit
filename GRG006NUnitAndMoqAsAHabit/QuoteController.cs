using System;

namespace GRG006NUnitAndMoqAsAHabit
{
    public class QuoteController
    {
        private QuoteService service;
        private QuoteAppForm view;

        public QuoteController(QuoteAppForm view)
        {
            this.service = new QuoteService();
            this.view = view;
        }

        public void roundrobin()
        {
            try
            {
                var q = service.roundrobinQuote();
                view.GetProgressBar().Minimum = 0;
                view.GetProgressBar().Maximum = q.TotalQuotes;
                view.GetProgressBar().Value = q.Id;
                view.GetRichTextBox().Text = q.Text;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void random()
        {
            try
            {
                var q = service.randomQuote();
                view.GetProgressBar().Minimum = 0;
                view.GetProgressBar().Maximum = q.TotalQuotes;
                view.GetProgressBar().Value = q.Id;
                view.GetRichTextBox().Text = q.Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void reset()
        {
            try
            {
                service.resetQuotes();
                view.GetProgressBar().Value = 0;
                view.GetRichTextBox().Text = "Try me again -->";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void stop()
        {
            try
            {
                service.stopQuotes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}