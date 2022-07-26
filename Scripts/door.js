var doorclip: AnimationClip;

function OnTriggerEnter (player : Collider){
	if(player.tag=="Player")
	{
	GetComponent.<Animation>().Play("door1");
	GetComponent.<Animation>().Play("door2");
	}
	}