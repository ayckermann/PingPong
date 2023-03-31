using UnityEngine;
using UnityEngine.SceneManagement;

public class Gas : MonoBehaviour
{

    private void Update(){
        if(Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
    }
}