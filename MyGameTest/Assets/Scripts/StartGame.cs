using UnityEngine;
using Hades.UI.Base;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UIRoot.Create().Init();
        Hades.UI.Scene.TestWidget.Create().PushLayout();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
