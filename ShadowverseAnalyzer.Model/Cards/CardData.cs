namespace ShadowverseAnalyzer.Model.Cards
{
    public class CardData
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CardType Type { get; set; }
        public int Cost { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int EvolutionAttackIncrease { get; set; } = 2;
        public int EvolutionDefenseIncrease { get; set; } = 2;
        public string EffectDescription { get; set; } = string.Empty;
        public string Pack { get; set; } = string.Empty;
        public CardRarity Rarity { get; set; }
        public CardClass Class { get; set; }

    }
}
