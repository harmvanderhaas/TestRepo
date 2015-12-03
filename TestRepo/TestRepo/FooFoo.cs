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

    public class BarBar
    {
        private readonly FooFoo _fooFoo;

        public BarBar(FooFoo fooFoo)
        {
            _fooFoo = fooFoo;
        }

        public override string ToString()
        {
            return "bar";
        }
    }
}