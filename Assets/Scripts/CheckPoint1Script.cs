using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint1Script : MonoBehaviour
{
    [SerializeField]
    private Image image;

    private AudioSource collectSound;
    private AudioSource destroySound;

    private float time = 5f;	
	private float leftTime;
	private bool checkDestroy;

	private void Start()
	{
        leftTime = time;
        GameState.isCheckpoint1 = false;
        AudioSource[] sources = this.GetComponents<AudioSource>();
        collectSound = sources[0];
        destroySound = sources[1];
		checkDestroy = false;
	}

	void LateUpdate()
    {
		leftTime -= Time.deltaTime;
        image.fillAmount = leftTime / time;
        if (leftTime < 0 && !checkDestroy)
        {
			checkDestroy = true;		
			StartCoroutine(DestroyAfterSound());
		}
    }

	private void OnTriggerEnter(Collider other)
	{		
		GameState.isCheckpoint1 = true;
		StartCoroutine(CeollectAfterSound());
	}
	IEnumerator CeollectAfterSound()
	{
		collectSound.Play();
		yield return new WaitForSeconds(collectSound.clip.length);
		GameObject.Destroy(gameObject);
	}
	IEnumerator DestroyAfterSound()
	{		
		destroySound.Play();
		yield return new WaitForSeconds(destroySound.clip.length);
		GameObject.Destroy(gameObject);
	}
}
/* Реалізувати відкладене руйнування об'єкту на час програвання звуку
 * 
 */
