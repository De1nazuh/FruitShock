using Project;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    [SerializeField] private GameObject _bladePrefab;
    [SerializeField] private float _cutDistance = 100;

    private GameObject _blade;
    private Vector3 _mouseStartPosition;

    private void Start()
    {
        _blade = Instantiate(_bladePrefab);
    }




    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mouseStartPosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            //создание луча
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Покажи Луч
            Debug.DrawRay(ray.origin, ray.direction*10, Color.red);
            //Если луч на чтото попадет
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Если в обьекте есть компонент ItemBase, то
                ItemBase item = hit.collider.GetComponent<ItemBase>();
                //порезать
                if(Vector3.Distance(_mouseStartPosition, Input.mousePosition) >_cutDistance)
                {
                    item?.OnCatch();
                }
                   
            }
            _blade.transform.position = new Vector3(ray.origin.x, ray.origin.y, 0);
        }
    }
}
