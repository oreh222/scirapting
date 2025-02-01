using UnityEngine;

public class NPC : MonoBehaviour
{
    // vectorio3
    Vector3 newPosition;
    //health is health
    public int health = 5;
    //lvl is level
    public int lvl = 1;
    //speed is DEJAVU
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health = health + lvl;
        print("enemus healath:" + health);
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}