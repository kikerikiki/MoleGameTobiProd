namespace MoleGameTobi.Models
{
    public class MoleGame
    {
        public int Score { get; set; }
        public int Highscore { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsGameOver { get; set; }
    }
}
