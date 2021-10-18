using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.End_component
{
    public class LoadingMenuScreen : MonoBehaviour
    {
        public Animator transition;
        public float transitionTime = 1f;
        
        // Update is called once per frame

        public void LoadNextLevel()
        {
            StartCoroutine(LoadLevel(1));
        }

        IEnumerator LoadLevel(int levelindex)
        {
            transition.SetTrigger("Start");

            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(levelindex);
        }
    }
}