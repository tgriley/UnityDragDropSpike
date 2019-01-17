using Models;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class ItemController : MonoBehaviour
    {
        public IItem ItemModel;
        private Image _image;

        private void Awake()
        {
            _image = GetComponentInChildren<Image>();
        }

        void Start()
        {
            _image.sprite = ItemModel.Sprite;
        }
    }
}