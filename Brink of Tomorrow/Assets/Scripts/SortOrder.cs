using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortOrder : MonoBehaviour
{
    public SpriteRenderer sr;
    public int ySort;

    public float lastY;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float currentY = transform.position.y;
        float fYSort = -transform.parent.transform.position.y;
        
        if (currentY > lastY)
        {
            fYSort = Mathf.Floor(fYSort);
        }
        else
        {
            fYSort = Mathf.Ceil(fYSort);
        }

        ySort = (int)fYSort;
        sr.sortingOrder = ySort;

        lastY = transform.position.y;
    }
}
