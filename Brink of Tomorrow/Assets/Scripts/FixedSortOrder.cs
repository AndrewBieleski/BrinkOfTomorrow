using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedSortOrder : MonoBehaviour
{
    public SpriteRenderer sr;
    public int ySort;
    
    // Start is called before the first frame update
    void Start()
    {
        ySort = -(int)transform.position.y;
        sr.sortingOrder = ySort;
    }
}
