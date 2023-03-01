using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndPanel : MonoBehaviour
{
    public void TutorialClick()
    {
        GameManager.Instance.LoadScene(0);
    }
    public void PlayAgainClick()
    {
        GameManager.Instance.LoadSceneFromIndex(0);
    }
    public void ExitClick()
    {
        GameManager.Instance.ExitGame();
    }
}


