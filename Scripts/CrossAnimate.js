var UpCurs : GameObject;
var DownCurs : GameObject;
var LeftCurs : GameObject;
var RightCurs : GameObject;

function Update () {
	if (Input.GetButtonDown("Fire1")) {
		(UpCurs.GetComponent("Animator")as Animator).enabled=true;
		(DownCurs.GetComponent("Animator")as Animator).enabled=true;
		(LeftCurs.GetComponent("Animator")as Animator).enabled=true;
		(RightCurs.GetComponent("Animator")as Animator).enabled=true;
		WaitingAnim();
	}
}

function WaitingAnim () {
	yield WaitForSeconds(0.1);
	(UpCurs.GetComponent("Animator")as Animator).enabled=false;
	(DownCurs.GetComponent("Animator")as Animator).enabled=false;
	(LeftCurs.GetComponent("Animator")as Animator).enabled=false;
	(RightCurs.GetComponent("Animator")as Animator).enabled=false;
}
