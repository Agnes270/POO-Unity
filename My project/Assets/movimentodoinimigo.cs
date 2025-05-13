using UnityEngine;

public class Movimentodoinimigo : MonoBehaviour
{
    
    private GameObject _player;
    private Rigidbody _rigidbody; 
    private float velocidade;
    
    public float raioDevisao = 3;
    private bool naVisao = false;

    private SphereCollider _sphereCollider;
    
    void Start()
    {
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        _player = GameObject.FindWithTag("Player");
        
    }
    
    
    void Update()
    {
        if (Vector3.Distance(_player.transform.position, transform.position) < raioDevisao)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);
        }
        
    }

    void OntriggerStay(Collider colisao)
    {
        if (colisao.gameObject.tag == "Player");
        {
            naVisao = true;

        }
    }
        
}