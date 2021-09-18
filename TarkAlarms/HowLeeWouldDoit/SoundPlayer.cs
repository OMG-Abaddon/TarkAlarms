namespace TarkAlarms.HowLeeWouldDoit
{
    static class SoundPlayer
    {
        private const string DEFAULT_FILENAME = "Sounds/default.wav";

        private static bool _initiated = false;
        private static System.Media.SoundPlayer _player;

        /// <summary>
        /// Plays the wav async. No idea what happens if you try to play multiple at the same time. Maybe it'd be wise to not be static, but wavs are heavy, so this is better
        /// </summary>
        internal static void PlayDefault()
        {
            if (!_initiated) InitPlayer();
            _player.Play();
        }

        private static void InitPlayer()
        {
            _player = new System.Media.SoundPlayer(DEFAULT_FILENAME);
            _player.Load(); //fuck async lol I'm lazy
            _initiated = true;
        }
    }
}
