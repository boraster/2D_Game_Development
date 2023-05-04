using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace _Complete
{
    public class Pickup : MonoBehaviour
    {

        private int coinCount;
        public TextMeshProUGUI coinText;
        public AudioClip coinSound;
        public AudioSource pickupAudioSource;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Coin"))
            {
                // AudioSource.PlayClipAtPoint(coinSound, other.transform.position);
                pickupAudioSource.clip = coinSound;
                pickupAudioSource.Play();
                coinCount++;
                coinText.text = coinCount.ToString();
                Destroy(other.gameObject);

            }
        }
        
        

    }
}
