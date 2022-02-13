using System.Runtime.InteropServices;

namespace GRG006NUnitAndMoqAsAHabit
{
    public class Quote
    {
        public Quote(int totalQuotes)
        {
            TotalQuotes = totalQuotes;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public int TotalQuotes { get; set; }
        
    }
}