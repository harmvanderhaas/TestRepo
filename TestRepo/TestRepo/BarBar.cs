namespace TestRepo
{
    public class BarBar
    {
        private readonly FooFoo _fooFoo;

        public BarBar(FooFoo fooFoo)
        {
            _fooFoo = fooFoo;
        }

        public override string ToString()
        {
            return _fooFoo + "bar";
        }
    }
}