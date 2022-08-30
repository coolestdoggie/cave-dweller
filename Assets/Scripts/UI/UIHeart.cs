using UnityEngine;
using UnityEngine.UI;

namespace CaveDweller.UI
{
    public enum HeartStatus
    {
        Empty,
        Half,
        Full
    }
    
    public class UIHeart : MonoBehaviour
    {
        [SerializeField] private Sprite fullHeart;
        [SerializeField] private Sprite halfHeart;
        [SerializeField] private Sprite emptyHeart;
        [SerializeField] private Image image;

        public void SetHeartStatus(HeartStatus status)
        {
            switch (status)
            {
                case HeartStatus.Full:
                    image.sprite = fullHeart;
                    break;
                case HeartStatus.Half:
                    image.sprite = halfHeart;
                    break;
                case HeartStatus.Empty:
                    image.sprite = emptyHeart;
                    break;
            }
        }
    }
}
