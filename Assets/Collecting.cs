using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{

    public Transform player;
    public Transform coin;
    public Transform[] children;
    
    void Update(){
            coin.transform.Rotate(0, 50 * Time.deltaTime, 0, Space.World);
    }
    void OnTriggerEnter(Collider collider){
        children = player.GetComponentsInChildren<Transform>();
        if (collider.gameObject.tag=="Coin"){
            Destroy(collider.gameObject);
            Transform newCoin = Instantiate(coin);
            newCoin.transform.SetParent(player);
            newCoin.transform.localPosition = new Vector3(0,0,-children.Length );
            newCoin.transform.localScale = new Vector3(1,1,1);
            newCoin.transform.localRotation = new Quaternion(0,0,0,10); 
            print(children.Length);




            
            
        }
        
}}
