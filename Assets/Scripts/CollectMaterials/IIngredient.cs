namespace TerraFirma.Collection
{
    public interface IIngredient
    {
        public int Richness { get; set; }
        public IngredientType IngredientCategory { get; }
    }
}
