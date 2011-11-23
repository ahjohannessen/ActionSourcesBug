namespace Bug.Actions
{
    public class ChuckNorris
    {
        public RoundKick Query()
        {
            return new RoundKick();
        }

        public class RoundKick { }
    }
}