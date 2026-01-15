
namespace Models
{
    /**
     * @class Score
     * Representa la puntuación del usuario en el quiz.
     */
    public class Score
    {
        public int? Points { get; set; }
        public string Message {get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
