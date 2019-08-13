using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Navigate : MonoBehaviour 
{
    public static int modeon ;
    public static float time =0;
    public Vector3 spawn1;
    public static int gg ;
    // Use this for initialization
    void Start()
    {
        gg = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            modeon = 0;
        }
        if (time > 0)
        {
            modeon = 1;
        }
    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ( hit.gameObject.tag == "frightenedmode")
		{
            Destroy(hit.gameObject);

            time = 100f;

        }




        if (modeon == 0)
        {
            if (hit.gameObject.tag == "enemy")
            {
                gg = 10;
            }

        }
        if (modeon == 1)
        {
            if (hit.gameObject.tag == "enemy")
            {
                // 取得敵人底下的 NavMeshAgent
                NavMeshAgent nav = hit.gameObject.GetComponent<NavMeshAgent>();

                // 把它關掉 (避免影響到我們調整位置)
                nav.enabled = false;

                // 將敵人移動到出生點
                hit.gameObject.transform.position = spawn1;

                // 重新開啟 NavMeshAgent
                nav.enabled = true;
            }
        }
    }

       
 

    
}
