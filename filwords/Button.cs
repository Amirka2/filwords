namespace filwords
{
    public class Button
    {
        public bool isChosen { get; set; }
        public string text { get; set; }
        public int width = 20;
        
        public Button (string text)
        {
            this.text = text;
        }
    }
}