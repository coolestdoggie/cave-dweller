using System;
using System.Collections;
using CaveDweller.Common;
using UnityEngine;

namespace CaveDweller.Player
{
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public Health Health { get; private set; }
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Color flashColor;
        [SerializeField] private float flashDurationInSeconds;
        
        
        public void Init()
        {
            Health.Init();

            Health.Damaged += FlashSprite;
            Health.HealthReducedToZero += Die;
        }

        private void OnDestroy()
        {
            Health.Damaged -= FlashSprite;
            Health.HealthReducedToZero -= Die;
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }

        private void FlashSprite()
        {
            StartCoroutine(FlashSpriteCoroutine());
        }

        private IEnumerator FlashSpriteCoroutine()
        {
            Color beginningColor = spriteRenderer.color;
            
            spriteRenderer.color = flashColor;
            yield return new WaitForSeconds(flashDurationInSeconds);
            spriteRenderer.color = beginningColor;
        }
    }
}
