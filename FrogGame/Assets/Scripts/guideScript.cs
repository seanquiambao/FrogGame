using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guideScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void returnMenu(){
        SceneManager.LoadScene(0);
    }
}
