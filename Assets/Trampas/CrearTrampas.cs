using UnityEngine;
using System.Collections;

public class CrearTrampas : MonoBehaviour {
    private int[][] generadores = new int[16][];
    public GameObject[] trampas;
    public GameObject[] creadores = new GameObject[16];
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 16; i++){
            generadores[i] = new int[2];
        }
        for (int i = 0; i < 16; i++) {
            generadores[i][0] = i;
            generadores[i][1] = 0;
            
        }
        MetodoTrampas();
	}

    void MetodoTrampas() {
        int trampasactivas = 0;
        for (int i = 0; i < 16; i++) {
            int numero = 0;
            numero = Random.Range(0,16);
            if (generadores[numero][1] == 0 && trampasactivas <= 8) {
                int masmenos = 1;
                if (numero >= 8) { 
                    masmenos = -1;
                    
                }else{
                    masmenos = 1;
                }
                if(generadores[numero + (8*masmenos)][1] == 0){
                    trampasactivas++;
                    generadores[numero][1] = 1;
                    Instantiate(trampas[Random.Range(0, 2)], creadores[numero].transform.position, Quaternion.identity);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
