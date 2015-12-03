namespace TestRepo
{
    public class FooFoo
    {
        private BarBar _bar;

        public FooFoo()
        {
            _bar = new BarBar(this);
        }

        public override string ToString()
        {
            return "foo";
        }
    }
}