using UnityEngine;

namespace TerraFirma.Collection
{
    [System.Serializable]
    public class CollectableMaterial : MonoBehaviour
    {
        private IIngredient _ingredient;
        [SerializeField] private IngredientType ingredientType;

        [SerializeField] private int minCount;
        [SerializeField] private int maxCount;

        private void Awake()
        {
            CreateIngredient();
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player == null) return;

            //TODO
            player.SetCollectableMaterial(this);
        }

        private void OnTriggerExit(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player == null) return;

            player.SetCollectableMaterial(null);
        }

        private void CreateIngredient()
        {
            int randomCount = Random.Range(minCount, maxCount);
            if (ingredientType == IngredientType.Ice) _ingredient = new Ice(randomCount);
            if (ingredientType == IngredientType.Cream) _ingredient = new Cream(randomCount);
            if (ingredientType == IngredientType.Sugar) _ingredient = new Sugar(randomCount);
        }

        public IIngredient Ingredient { get => _ingredient; }
    }
}
