import UnityEngine.UI;

var EnemyHealth : int = 10;
var TheZombie : GameObject;

function DeductPoints (DamageAmount : int) {
	EnemyHealth -= DamageAmount;
}

function Update (){
	if (EnemyHealth <= 0) {
		//this.GetComponent("ZombieFollow").enabled=false;
		TheZombie.GetComponent.<Animation>().Play("back_fall");
		EndZombie();
	}
}

function EndZombie () {
	yield WaitForSeconds(1.3);
	GUIScore.score += 10;
	Destroy(gameObject);
}
