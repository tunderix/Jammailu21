namespace TerraFirma.Collection
{
    [System.Serializable]
    public class Ice : IIngredient
    {
        private int _itemCount;

        public Ice(int itemCount)
        {
            _itemCount = itemCount;
        }

        public int Richness { get => _itemCount; set => _itemCount = value; }
        public IngredientType IngredientCategory { get => IngredientType.Ice; }
    }
}
