
namespace Practice7_2
{
    public class Vocabulary
    {
        public string Word { get; set; }
        public string Chinese { get; set; }
        public string WordKind { get; set; }
        public bool Marked { get; set; }

        public Vocabulary(string Word, string Chinese, string WordKind)
        {
            this.Word = Word;
            this.Chinese = Chinese;
            this.WordKind = WordKind;
            Marked = false;
        }

        public override string ToString()
        {
            return $"{Word} {Chinese} {WordKind}";
        }

    }
}
