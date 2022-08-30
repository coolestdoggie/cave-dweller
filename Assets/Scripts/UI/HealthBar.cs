using System.Collections.Generic;
using CaveDweller.Common;
using UnityEngine;

namespace CaveDweller.UI
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private GameObject heartPrefab;
        
        private List<UIHeart> uiHearts = new List<UIHeart>();
        private Health playerHealth;

        public void Init(Health playerHealth)
        {
            this.playerHealth = playerHealth;
        }
        
        private void DrawHearts()
        {
            ClearHearts();

            float maxHealthRemainder = playerHealth.MaxHealth % 2;
            int heartsToCreate = (int) (playerHealth.MaxHealth / 2 + maxHealthRemainder);

            for (int i = 0; i < heartsToCreate; i++)
            {
                CreateEmptyHeart();
            }
        }
        
        private void CreateEmptyHeart()
        {
            GameObject newHeart = Instantiate(heartPrefab);
            newHeart.transform.SetParent(transform);
            
            UIHeart uiHeart = newHeart.GetComponent<UIHeart>();
            uiHeart.SetHeartStatus(HeartStatus.Empty);
            uiHearts.Add(uiHeart);
        }
        
        private void ClearHearts()
        {
            foreach (var uiHeart in uiHearts)
            {
                Destroy(uiHeart.gameObject);
            }
            uiHearts.Clear();
        }
    }
}
