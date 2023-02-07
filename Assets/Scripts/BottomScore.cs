using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScore : MonoBehaviour
{

    public static int bottomScore;
    public static int topScore;
    // Start is called before the first frame update
    void Start()
    {
        bottomScore = 0;
        topScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (this.name == "Bottom Trigger")
        {
            topScore++;
            Debug.Log($"Top team scored.");
        }
        else if (this.name == "Top Trigger")
        {
            bottomScore++;
            Debug.Log($"Bottom team scored.");
        }

        Debug.Log($"The new score is Top Team: { topScore}, Bottom Team: { bottomScore}");

        if (topScore == 11)
        {
            Debug.Log("Top Team wins!");
            topScore = 0;
            bottomScore = 0;
        }
        if (bottomScore == 11)
        {
            Debug.Log("Bottom Team wins!");
            topScore = 0;
            bottomScore = 0;
            
        }

    }
}
