using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float startSize = 1f;
    public float startSpeed = 5f;
    public float sizemodifier = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name.Contains("Food"))
        {
            Grow();
            Destroy(other.gameObject);
        }
    }
    void Move()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 movement = Vector2.MoveTowards(transform.position, mousePos, startSpeed * Time.deltaTime);
        rigid.MovePosition(movement);
    }
    public void Grow()
    {
        transform.localScale += new Vector3(sizemodifier, sizemodifier, sizemodifier);
        Game.Instance.cam.orthographicSize += sizemodifier * 5f;
    }
    public void Scale(float size)
    {
        transform.localScale = (new Vector3(size, size, size));
    }
}
