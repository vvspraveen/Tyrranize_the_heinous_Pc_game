
function OnGUI () {
	if (GUI.Button (Rect (Screen.width/8-50, Screen.height/2, 100, 30), "Play Game")) {
		Application.LoadLevel (1);
	}
	if (GUI.Button (Rect (Screen.width/8-50, Screen.height/2+40, 100, 30), "Quit Game")) {
		Application.Quit();
	}
	
}