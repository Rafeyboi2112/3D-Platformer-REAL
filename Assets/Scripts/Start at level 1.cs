using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startatlevel1 : MonoBehaviour
{
    public void Level1Restart()
    {
        SceneManager.LoadScene(1);
    }
}
