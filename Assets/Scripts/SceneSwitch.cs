using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int killLimit;

    public static int totalKills;
    void Update()
    {
         if (totalKills >= killLimit)
         {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         }
        
    }
 }
