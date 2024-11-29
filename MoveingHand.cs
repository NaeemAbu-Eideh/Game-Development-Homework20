using UnityEngine;

public class HandMover : MonoBehaviour
{
    public Transform target; 
    public Transform leftColumn; 
    public Transform rightColumn; 

    
    

    void Start()
    {
        if (target == null) target = GameObject.Find("Hand1").transform;
        if (leftColumn == null) leftColumn = GameObject.Find("LeftColumn").transform;
        if (rightColumn == null) rightColumn = GameObject.Find("RightColumn").transform;
    }

    void Update()
    {
        if (target != null && leftColumn != null && rightColumn != null)
        {
            if (Input.GetKey(KeyCode.A))
            {
                if (target.position.x > leftColumn.position.x)
                {
                    target.position += Vector3.left  * Time.deltaTime;
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (target.position.x < rightColumn.position.x)
                {
                    target.position += Vector3.right  * Time.deltaTime;
                }
            }
        }
    }
}
