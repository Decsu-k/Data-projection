namespace Проекция_данных
{
    internal class Person
    {
        private string v1;
        private int v2;

        public Person(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public object Name { get; internal set; }
    }
}