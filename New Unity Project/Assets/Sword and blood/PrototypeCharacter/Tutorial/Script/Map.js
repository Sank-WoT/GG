var crosshairTexture : Texture2D ;
var position : Rect;
var X ;
var Y ;
var H ;
var W ;
function Start()
{
position = Rect( X,Y, H, W);
}
    
function OnGUI()
{
GUI.DrawTexture( position, crosshairTexture); 
}