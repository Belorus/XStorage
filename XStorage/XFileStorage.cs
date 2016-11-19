namespace XStorage
{
    public static class XFileStorage
    {
        private static IStorage _provider;

        public static void Initialize(IStorage provider)
        {
            _provider = provider;
        }

        public static IStorage Provider
        {
            get { return _provider; }
        }
    }
}
