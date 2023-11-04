
namespace Practice7_1
{
    internal class Vocabulary
    {
        public string Word { get; set; }
        public string Chinese { get; set; }
        public string WordKind { get; set; }

        public Vocabulary(string Word, string Chinese, string WordKind)
        {
            this.Word = Word;
            this.Chinese = Chinese;
            this.WordKind = WordKind;
        }

        public override string ToString()
        {
            return $"{Word} {Chinese} {WordKind}";
        }

    }
}
