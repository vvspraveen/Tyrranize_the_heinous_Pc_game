 var sky : Material;

 function OnTriggerEnter(other : Collider)
 {
     if (other.tag == "Player")
     {
          RenderSettings.skybox = sky;
          //this.GetComponent("Gamecontrolscript").SetActive(true);
          }
 }
 
 