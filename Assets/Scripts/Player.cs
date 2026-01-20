using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private bool _isGrounded;
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private TextMeshProUGUI _pointsText;
    [SerializeField] private Transform Spawner;
    [SerializeField] private GameObject CoinPrefab;
    private int _points;
    private int willSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", 1.0f, 0.3f);

        _pointsText.text = "Points: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
            _isGrounded = false;
        }

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            CoinCaught();
        }
    }

    void SpawnCoin()
    {
        willSpawn = Random.Range(1,4);
        if (willSpawn == 2)
        {
            GameObject NewCoin = Instantiate(CoinPrefab, Spawner.position, Spawner.rotation);
            Destroy(NewCoin, 7f); 
        }
    }
    void CoinCaught()
    {
        _points += 1;
        _pointsText.text = "Points: " + _points.ToString();


    }


}
