using UnityEngine;

namespace Project
{
    public class Worker : MonoBehaviour
    {
        [SerializeField] private WorkBase _work;
        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (_work != null) { _work.Work(); }
            }
        }
    }
}