using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveCycle : MonoBehaviour
{
    [SerializeField] Material[] textures;
    [SerializeField] GameObject[] gloves;
    [SerializeField] GameObject playButton;
    private int index = 0;

    public void ChangeGlove()
    {
        if (!playButton.GetComponent<MeshRenderer>().enabled)
        {
            EnablePlayButton();
        }
        index = (index + 1) % textures.Length;
        gloves[0].GetComponent<Renderer>().material = textures[index];
        gloves[1].GetComponent<Renderer>().material = textures[index];
    }

    public void EnablePlayButton()
    {
        playButton.GetComponent<MeshRenderer>().enabled = true;
        playButton.GetComponent<BoxCollider>().enabled = true;
    }

}
