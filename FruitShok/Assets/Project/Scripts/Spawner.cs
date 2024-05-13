using Project;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Spawner : MonoBehaviour
{
    [SerializeField] private ItemBase[] _items;
    [SerializeField] private float _q;

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

            int index = Random.Range(0, _items.Length);
           // Instantiate(_items[index]).transform.position= transform.position;
           ItemBase itemCopy = Instantiate(_items[index]);

            Vector3 itemPosition = new Vector3();

            itemCopy.transform.position = Vector3.right * Random.Range(-10, 10);
            //Одинаковые что то, что это
            /*Vector3 itemPosition = new Vector3(); 
            itemPosition.x = Random.Range(-10, 10);
            itemPosition.y = 0;
            itemPosition.z = 0;*/
        }
    }

  
}
