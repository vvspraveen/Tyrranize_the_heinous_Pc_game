function OnGUI () {
	
	if (GUI.Button (Rect (Screen.width/10-50, Screen.height/2, 100, 30), "Play again")) {
		Application.LoadLevel (0);
	}
	if (GUI.Button (Rect (Screen.width/10-50, Screen.height/2+40, 100, 30), "Quit Game")) {
		Application.Quit();
	}
	
}