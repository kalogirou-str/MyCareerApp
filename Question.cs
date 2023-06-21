namespace MyCareerApp
{
    internal class Question
    {
        private string v1;
        private List<string> list;
        private string v2;

        public Question(string v1, List<string> list, string v2)
        {
            this.v1 = v1;
            this.list = list;
            this.v2 = v2;
        }

        public object Options { get; internal set; }
    }
}