using Project;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swoard : sound
{
    [SerializeField] private GameObject _swoardPrefab;
    [SerializeField] private float _cutDistance = 100;

    private GameObject _swoard;
    private Vector3 _mouseStartPosition;

    private void Start()
    {
        _swoard = Instantiate(_swoardPrefab);
        //Shop_GameState.ReferenceEquals(this, _swoard);
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
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
            //Если луч на чтото попадет
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Если в обьекте есть компонент ItemBase, то
                ItemBase item = hit.collider.GetComponent<ItemBase>();
                //порезать
                if (Vector3.Distance(_mouseStartPosition, Input.mousePosition) > _cutDistance)
                {
                    item?.OnCatch();
                    PlaySound(sounds[0]);
                }

            }
            _swoard.transform.position = new Vector3(ray.origin.x, ray.origin.y, 0);
            //PlaySound(sounds[UnityEngine.Random.Range(0, 1)]);
            

        }
    }
}
