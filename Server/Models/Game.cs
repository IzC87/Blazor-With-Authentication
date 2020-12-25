namespace Server.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public Resources Resources { get; set; }
    }
}