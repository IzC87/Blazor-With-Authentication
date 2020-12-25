namespace Server.Models
{
    public class Resources
    {
        public int Id { get; set; }
        
        public int Food { get; set; }

        private int ore;
        public int Ore
        {
            get { return ore; }
            set
            {
                if ((ore + value) > StorageSize)
                    ore = StorageSize;
                else
                    ore = value;
            }
        }
        
        private int wood;
        public int Wood
        {
            get { return wood; }
            set
            {
                if ((wood + value) > StorageSize)
                    wood = StorageSize;
                else
                    wood = value;
            }
        }
        
        public int StorageSize { get; set; }
    }
}