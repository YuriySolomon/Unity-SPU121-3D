using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
   
    void Start()
    {
        
    }    
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{		
		bool result = EditorUtility.DisplayDialog("Повыдомлення", "Ви пройшли рівень. Перейти на наступний?", "OK", "Cancel");

		// Реагуємо на вибір у діалоговому вікні
		if (result)
		{
			SceneManager.LoadScene("Level-2");
		}
		else
		{			
			EditorApplication.isPlaying = false;
		}
	}
}
