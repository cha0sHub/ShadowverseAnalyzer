using ShadowverseAnalyzer.Model.Cards;

namespace ShadowverseAnalyzer.Model.Decks
{
    public class DeckData
    {
        public string DeckName { get; set; } = string.Empty;
        public string DeckOwner { get; set; } = string.Empty;
        public DeckClass Class { get; set; }
        public List<CardData> Cards { get; set; } = new List<CardData>();
    }
}
