namespace TestRepo
{
    using System;

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

        public void something()
        {
            throw new Exception();
        }
    }
}