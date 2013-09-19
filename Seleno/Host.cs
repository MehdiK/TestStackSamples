using TestStack.Seleno.Configuration;

namespace Seleno
{
    public static class Host
    {
        public static readonly SelenoHost Instance = new SelenoHost();

        static Host()
        {
            Instance.Run("MvcMusicStore", 12345);
        }
    }
}