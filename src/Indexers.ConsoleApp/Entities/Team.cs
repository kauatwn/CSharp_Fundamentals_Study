namespace Indexers.ConsoleApp.Entities
{
    internal class Team
    {
        private string[] Players { get; } = new string[11];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < Players.Length)
                {
                    return Players[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice de jogador fora dos limites da equipe.");
                }
            }

            set
            {
                if (i >= 0 && i < Players.Length)
                {
                    Players[i] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice de jogador fora dos limites da equipe.");
                }
            }
        }
    }
}
