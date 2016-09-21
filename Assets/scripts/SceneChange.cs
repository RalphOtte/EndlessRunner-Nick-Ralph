using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

    public void ChangeScene(int sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
