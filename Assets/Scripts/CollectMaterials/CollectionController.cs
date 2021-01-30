using UnityEngine;
using System;

namespace TerraFirma.Collection
{
    [System.Serializable]
    public class CollectionController
    {
        [SerializeField] public CollectableMaterial currentCollectableMaterial;

        [SerializeField] private int _ice;
        [SerializeField] private int _cream;
        [SerializeField] private int _sugar;

        public CollectionController()
        {

        }

        public void Gather()
        {
            if (currentCollectableMaterial == null) return;

            // Lock Gathering until locktime

            // Gather

            // Resolution
            bool success = ModifyIngredient(currentCollectableMaterial.Ingredient);
            if (success) GameObject.Destroy(currentCollectableMaterial.gameObject);
        }

        public static string GetNameForIngredientType(IngredientType category)
        {
            return Enum.GetName(typeof(IngredientType), category);
        }

        public bool ModifyIngredient(IIngredient ingredient)
        {
            if (ingredient.IngredientCategory == IngredientType.Cream) _cream = ingredient.Richness;
            if (ingredient.IngredientCategory == IngredientType.Ice) _ice = ingredient.Richness;
            if (ingredient.IngredientCategory == IngredientType.Sugar) _sugar = ingredient.Richness;

            return true;
        }
    }
}
