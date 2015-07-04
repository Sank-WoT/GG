#pragma strict
var nView :NetworkView;
private var anotherScript : CharacterMotor;
function Start () {

}

function Update () {
if (!nView.isMine)
		{
			 anotherScript = GetComponent(CharacterMotor);
			 anotherScript.enabled = false;
		}
}