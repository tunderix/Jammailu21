namespace TerraFirma.Collection
{
    [System.Serializable]
    public class Sugar : IIngredient
    {
        private int _itemCount;

        public Sugar(int itemCount)
        {
            _itemCount = itemCount;
        }

        public int Richness { get => _itemCount; set => _itemCount = value; }
        public IngredientType IngredientCategory { get => IngredientType.Sugar; }
    }
}
