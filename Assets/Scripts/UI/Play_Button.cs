using UnityEngine;
using UnityEngine.UI;

public class Play_Button : Music_Button
{
    public Image playImage;
    public Sprite playSprite, pauseSprite;

    private void Awake()
    {
        if (pauseSprite != null)
            playImage.sprite = pauseSprite;
    }

    private void OnEnable()
    {
        MusicPlayer.SongPaused += SwitchSprite;
    }
    private void OnDisable()
    {
        MusicPlayer.SongPaused -= SwitchSprite;
    }

    protected override void Update()
    {
        base.Update();
        if (Input.GetButtonDown("Submit"))
        {
            DoButtonClick();
        }
    }

    private void SwitchSprite(bool isPaused)
    {
        if (playImage == null) return;

        if (isPaused)
        {
            if (playSprite != null)
                playImage.sprite = playSprite;
        }
        else
        {
            if (pauseSprite != null)
                playImage.sprite = pauseSprite;
        }
    }
}
