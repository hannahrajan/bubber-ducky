using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globals : MonoBehaviour
{
    public GameObject currentTrack;
    public GameObject player;
    public static Vector3 playerStartingPosition;
    public static float percentageComplete;
    public static int numBubblesNeeded = 12;
    public static bool introOccurring = true;
    public static bool isRestart = false;

    // Start is called before the first frame update
    void Start()
    {
        playerStartingPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //for now, it's wherever the player starts; we can fix this later
    }

    // Update is called once per frame
    void Update()
    {
        float trackLength = currentTrack.transform.position.z + (currentTrack.GetComponent<MeshRenderer>().bounds.size.z / 2);
        percentageComplete = (player.transform.position.z - playerStartingPosition.z) / (trackLength - playerStartingPosition.z);
    }

    public static void win()
    {
        SceneManager.LoadScene("WinScene");
    }
    public static void lose()
    {
        SceneManager.LoadScene("LoseScene");
    }
}
