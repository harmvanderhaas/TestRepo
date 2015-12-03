namespace TestRepo
{
    public class FooFoo
    {
        public string Foo()
        {
           return Bar("foo");
        }

        private string Bar(string foo)
        {
            return foo + "bar";
        }
    }
}