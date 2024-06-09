using Project;
using SO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
namespace Project
{

    public class Spawner : MonoBehaviour
    {
        [SerializeField] private ItemList _itemList;
        [SerializeField] private float _spawnRate;
        
        [SerializeField] private float _q = 1;
        [SerializeField] private TextMeshProUGUI CountText;



        private void Update()
        {
            CountText.text = ItemBase.score.ToString();
        }



        void Start()
        {
            StartCoroutine(Spawn());

        }
        private IEnumerator Spawn()

        {
            while (gameObject.activeSelf)
            {
                //ждать 1 сек
                yield return new WaitForSeconds(_q);

                int index = Random.Range(0, _itemList.items.Length);
                // Instantiate(_items[index]).transform.position= transform.position;
                ItemBase itemCopy = Instantiate(_itemList.items[index]);

                Vector3 itemPosition = new Vector3();

                itemCopy.transform.position = Vector3.right * Random.Range(-10, 10);
                //Одинаковые что то, что это

                /* itemPosition.x = Random.Range(-10, 10);
                 itemPosition.y = 0;
                 itemPosition.z = 0;*/
            }
        }
    }
}
