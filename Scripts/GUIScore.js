static var score : int;
private var barLength = 0.0;

function Start()
{
barLength = Screen.width / 8;
}

function OnGUI()
{
//Icons
GUI.Box(new Rect(5, 70, 50, 23), "Score");

//score bars
GUI.Box(new Rect(55, 70, barLength, 23), "Score: " + score);

}
