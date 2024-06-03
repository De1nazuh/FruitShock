using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Project
{
    [RequireComponent (typeof(Rigidbody))]
    public abstract class ItemBase : sound
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _force=700;
        public static float score = 0;

       

        private void Reset()
        {
            _force = 700;
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.AddForce(Vector3.up * _force);//АДДФорс толкает
        }

        private void Update()
        {
            if (transform.position.y < -20)
            {
                Destroy(gameObject);
            }
        }
        public virtual void OnCatch()
        {
            Destroy(gameObject);
            //destroed?.Invoke();


        }
    }

}
