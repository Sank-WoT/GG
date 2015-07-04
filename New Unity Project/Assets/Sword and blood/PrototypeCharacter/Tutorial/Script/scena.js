var isNewGameButton = false;
var isOptionsButton = false; 
var isQualityButtonFastest = false;
var isQualityButtonFantastic = false;
var isMainMenuButton = false;
var isQuitButton = false;
var isMultiplay = false;
var isCreatyMultiplay = false;
 public static var isServ : boolean = false;
function OnMouseEnter()
{
GetComponent.<Renderer>().material.color = Color.gray;
} 
function OnMouseExit()
{ 
GetComponent.<Renderer>().material.color = Color.white;
}

function OnMouseUp()
{
if ( isQuitButton )
{
Application.Quit();
}
else if ( isQualityButtonFastest )
{
QualitySettings.currentLevel = QualityLevel.Fastest;
}
else if ( isQualityButtonFantastic )
{
QualitySettings.currentLevel = QualityLevel.Fantastic;
}
else if ( isNewGameButton )
{
Application.LoadLevel (1);
}
else if ( isOptionsButton )
{
Application.LoadLevel (2);
}
else if ( isMainMenuButton )
{
Application.LoadLevel (0);
}
else if ( isMultiplay )
{
Destroy( gameObject, 0 );
Application.LoadLevel (3);
}
else if ( isCreatyMultiplay )
{
 if ( isServ == false )
{
isServ = true;
Application.LoadLevel (1);
}

}
}