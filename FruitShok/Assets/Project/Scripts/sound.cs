using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Project
{
    public class sound : MonoBehaviour
    {
        public AudioClip[] sounds;
        private AudioSource _audioSrc => GetComponent<AudioSource>();


        public void PlaySound(AudioClip clip, float volume = 1f, bool destroyed = false, float p1 = 0.85f, float p2 = 1.2f)
        {
            _audioSrc.pitch = Random.Range(p1, p2);
            _audioSrc.PlayOneShot(clip , volume );
            //это для спавна и удаления звука
            /*if ( destroyed )                        //может понадобиться для стерео звука
                AudioSource.PlayClipAtPoint ( clip, transform.position, volume );    
            else 
                _audioSrc.PlayOneShot ( clip , volume );*/
        
        }
    }
}
