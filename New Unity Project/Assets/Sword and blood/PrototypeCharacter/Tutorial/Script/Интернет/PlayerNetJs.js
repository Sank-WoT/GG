#pragma strict
var nView :NetworkView;
private var anotherScript : CharacterMotor;
function Start () {

}
function Update () 
{
if(!nView.isMine)
{
GetComponent(CharacterMotor).enabled = false;
GetComponent(FPSInputController).enabled = false;
}
}