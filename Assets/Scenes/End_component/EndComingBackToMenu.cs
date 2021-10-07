using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.End_component
{
    public class EndComingBackToMenu : MonoBehaviour
    {
        public int countdownTime;
        public int levelindex;

        private void Start()
        {
            StartCoroutine(CountdownToStart());
        }

        IEnumerator CountdownToStart()
        {
            while (countdownTime > 0)
            {
                yield return new WaitForSeconds(1f);

                countdownTime--;
            }
            SceneManager.LoadScene(levelindex);
        }
    
    }
}
