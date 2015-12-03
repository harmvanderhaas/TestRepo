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

        public void CpuHeater()
        {
            for (int i = 0; i <= int.MaxValue; i++)
            {
                DoSomethingElse();
            }
        }

        public void DoSomethingElse()
        {
        }
    }
}