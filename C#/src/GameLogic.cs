
static class GameLogic
{
    public void Main()
    {
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);
        LoadResources();
        SwinGame.PlayMusic(GameMusic("Background"));
        do
        {
            HandleUserInput();
            DrawScreen();
        }
        while (!SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting);
        SwinGame.StopMusic();
        FreeResources();
    }
}
