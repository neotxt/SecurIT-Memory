using System.Drawing;

namespace SecurIT_Logic
{
    public enum CardState
    {
        FaceDown,
        FaceUp,
        Matched
    }

    public class Card
    {
        public int PairId { get; private set; }
        public Image FrontImage { get; private set; }
        public CardState State { get; set; }

        public Card(int pairId, Image frontImage)
        {
            PairId = pairId;
            FrontImage = frontImage;
            State = CardState.FaceDown;
        }
    }
}