using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGround : GameBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        ExecuteAfterSeconds(2, () => { player.transform.localScale = Vector3.one * 2; });

        print("Game Started");

        ExecuteAfterFrames(1, () => { print("player one frame later"); });
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
       
            player.GetComponent<Renderer>().material.color = ColorX.GetRandomColour();

        }
    }
}
