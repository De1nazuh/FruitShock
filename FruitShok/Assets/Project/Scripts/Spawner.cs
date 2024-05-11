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
            Instantiate(_items[index]).transform.position= transform.position;
        }
    }

  
}
