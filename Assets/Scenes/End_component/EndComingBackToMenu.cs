using System.Collections;
using UnityEngine;

namespace Scenes.End_component
{
    public class EndComingBackToMenu : MonoBehaviour
    {
        public int countdownTime;

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

        

        }
    
    }
}
