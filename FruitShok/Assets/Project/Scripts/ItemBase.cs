using UnityEngine;

namespace Project
{
    public abstract class ItemBase : MonoBehaviour
    {
        private void Update()
        {
            if (transform.position.y < -20)
            {
                Destroy(gameObject);
            }
        }

        private void OnMouseUp()
        {
            OnCatch();
        }

        public virtual void OnCatch()
        {
            Destroy(gameObject);
        }

    }

}
