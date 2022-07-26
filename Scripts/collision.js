 function OnCollisionEnter (myCollision : Collision) 
 { 
 
 if(myCollision.gameObject.name == "Floor")
 { 
 Application.LoadLevel(1);
 }
 }