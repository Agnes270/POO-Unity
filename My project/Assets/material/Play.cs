using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
   private Rigidbody _rigidbody;

   public float velocidade = 10;
   
   void Start()
   {
      _rigidbody = gameObject.GetComponent<Rigidbody>();
   }

   void Update()
   {
      Vector3 posicao = transform.position;
      
      
      //esquerda x-
      if (Input.GetKeyDown(KeyCode.A))
      {
          posicao.x = transform.position.x - velocidade * Time.deltaTime;
      }
      
      //Direita x+
      if (Input.GetKeyDown(KeyCode.D))
      {
         posicao.x = transform.position.x + velocidade * Time.deltaTime;
      }   
      
      //Cima Z-
      if (Input.GetKeyDown(KeyCode.W))
      {
         posicao.z = transform.position.z - velocidade * Time.deltaTime;
      }   
      
      //Baixo Z+
      if (Input.GetKeyDown(KeyCode.S))
      {
         posicao.z = transform.position.z + velocidade * Time.deltaTime;
      }      
      
      transform.position = posicao;
      
   }
   
  
}