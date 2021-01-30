using UnityEngine;

namespace TerraFirma.Collection
{
    [System.Serializable]
    public class Cream : IIngredient
    {
        private int _itemCount;

        public Cream(int itemCount)
        {
            _itemCount = itemCount;
        }

        public int Richness { get => _itemCount; set => _itemCount = value; }
        public IngredientType IngredientCategory { get => IngredientType.Cream; }
    }
}
