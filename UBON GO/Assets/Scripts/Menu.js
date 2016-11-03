#pragma strict

function Start () {

}

function Update () {

}

function StartGame(){
    Application.LoadLevel("Main_Episode");
}

function StartEp1(){
    Application.LoadLevel("Main_Episode_1");
}

function BackToEp(){
    Application.LoadLevel("Main_Episode");
}

function BackToMainGame(){
    Application.LoadLevel("Main_Menu");
}

function stage_1_1(){
    Application.LoadLevel("Play_ep1_s1_1");
}

function ExitGame(){
    Application.Quit();
}