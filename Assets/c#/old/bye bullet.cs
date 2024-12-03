using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletbye : MonoBehaviour
{
    public int maxHits = 1;
    private int hitCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            hitCount++;
            if (hitCount >= maxHits)
            {
                gameObject.SetActive(false);
            }
        }
    }

}
