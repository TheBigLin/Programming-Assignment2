using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int killLimit;

    public int totalKills;
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            //if (totalKills >= killLimit)
            //{
                SceneManager.LoadScene(+1);
           // }
        }
    }
}
