namespace LegendsHQ.Mappers
{
    public class Mapper
    {
        public AbilityInteractionMapper abilityInteractionMapper { get; set; } = new AbilityInteractionMapper();
        public AbilityMappers abilityMappers { get; set; } = new AbilityMappers();
        public AbilityTipsMapper abilityTipsMapper { get; set; } = new AbilityTipsMapper();
        public LegendClassMapper legendClassMapper { get; set; } = new LegendClassMapper();
        public LegendFinishersMapper finishersMapper { get; set; } = new LegendFinishersMapper();
        public LegendImagesMapper legendImagesMapper { get; set; } = new LegendImagesMapper();
        public LegendMapper legendMapper { get; set; } = new LegendMapper();
        public LegendVideoMapper legendVideoMapper { get; set; } = new LegendVideoMapper();
        public SkinMapper skinMapper  { get; set; } = new SkinMapper();
    }
}
