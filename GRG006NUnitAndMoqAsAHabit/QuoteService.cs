using System;

namespace GRG006NUnitAndMoqAsAHabit
{
    public class QuoteService
    {
        private QuoteDAO dao;

        public QuoteService()
        {
            dao = new QuoteDAO();
        }

        public Quote roundrobinQuote()
        {
            try
            {
                return dao.roundrobin();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Quote randomQuote()
        {
            try
            {
                return dao.random();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void resetQuotes()
        {
            try
            {
                dao.reset();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void stopQuotes()
        {
            try
            {
                dao.stop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}